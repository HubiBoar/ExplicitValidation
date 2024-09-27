using Microsoft.CodeAnalysis;

namespace Definit.Utils.SourceGenerator;

public static class Method
{
    private const string TaskType = "System.Threading.Tasks.Task";
    private const string ValueTaskType = "System.Threading.Tasks.ValueTask";

    public interface IReturnType;
    public interface IReturnInfo : IReturnType
    {
        public ITypeSymbol Symbol { get; }
        public string Name { get; }
        public bool CanBeNull { get; }
    }

    public static class Return
    {
        public readonly struct Void : IReturnType;

        public readonly struct Type : IReturnInfo
        {
            public string Name { get; }
            public bool CanBeNull { get; }
            public ITypeSymbol Symbol { get; }

            public Type(ITypeSymbol symbol) : this()
            {
                Symbol = symbol;
                Name = symbol.ToDisplayString();
                CanBeNull = symbol.CanBeNull();
            }
        }

        public readonly struct Task : IReturnType
        {
            public readonly struct Type : IReturnInfo
            {
                public string Name { get; }
                public bool CanBeNull { get; }
                public ITypeSymbol Symbol { get; }

                public Type(ITypeSymbol symbol) : this() 
                {
                    Symbol = symbol;
                    Name = symbol.ToDisplayString();
                    CanBeNull = symbol.CanBeNull();
                }
            }
        }
        
        public readonly struct ValueTask : IReturnType
        {
            public readonly struct Type : IReturnInfo
            {
                public string Name { get; }
                public bool CanBeNull { get; }
                public ITypeSymbol Symbol { get; }

                public Type(ITypeSymbol symbol) : this()
                {
                    Symbol = symbol;
                    Name = symbol.ToDisplayString();
                    CanBeNull = symbol.CanBeNull();
                }
            }
        }
    }

    public static bool CanBeNull(this ITypeSymbol symbol)
    {
        if (symbol is ITypeParameterSymbol type)
        {
            var argument = type.GetGenericArgument();

            if(argument.HasNullAnnotation)
            {
                return true;
            }

            return argument.Constraint switch
            {
                Generic.Constraint.Empty            => true,
                Generic.Constraint.New              => true,
                Generic.Constraint.ClassNullable    => true,
                Generic.Constraint.ClassNullableNew => true,
                _                                   => false
            };
        }
        return symbol.NullableAnnotation is NullableAnnotation.Annotated;
    }

    public static IReturnType GetReturnType(this IMethodSymbol method)
    {
        if(method.ReturnsVoid)
        {
            return new Return.Void();
        }

        if (method.ReturnType is INamedTypeSymbol typeSymbol == false)
        {
            return new Return.Type(method.ReturnType);
        }

        var returnName = typeSymbol.ToDisplayString();
        var isTask = returnName.StartsWith(TaskType);
        var isValueTask = returnName.StartsWith(ValueTaskType);

        if(isTask)
        {
            if(typeSymbol.IsGenericType)
            {
                var taskSymbol = typeSymbol.TypeArguments.Single();

                return new Return.Task.Type(taskSymbol);
            }

            return new Return.Task();
        }

        if(isValueTask)
        {
            if(typeSymbol.IsGenericType)
            {
                var taskSymbol = typeSymbol.TypeArguments.Single();

                return new Return.ValueTask.Type(taskSymbol);
            }

            return new Return.ValueTask();
        }

        return new Return.Type(typeSymbol);
    }
}
