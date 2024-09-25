using Microsoft.CodeAnalysis;

namespace Definit.Utils.SourceGenerator;

public static class Method
{
    private const string TaskType = "System.Threading.Tasks.Task";
    private const string ValueTaskType = "System.Threading.Tasks.ValueTask";

    public interface IReturnType;

    public static class Return
    {
        public readonly struct Void : IReturnType;

        public readonly struct Type : IReturnType
        {
            public INamedTypeSymbol Parameter { get; }

            public Type(INamedTypeSymbol parameter) => Parameter = parameter;

            public readonly struct Generic : IReturnType
            {
                public ITypeParameterSymbol Parameter { get; }

                public Generic(ITypeParameterSymbol parameter) => Parameter = parameter;
            }
        }

        public readonly struct Task : IReturnType
        {
            public readonly struct Type : IReturnType
            {
                public INamedTypeSymbol Parameter { get; }

                public Type(INamedTypeSymbol parameter) => Parameter = parameter;

                public readonly struct Generic : IReturnType
                {
                    public ITypeParameterSymbol Parameter { get; }

                    public Generic(ITypeParameterSymbol parameter) => Parameter = parameter;
                }
            }
        }
        
        public readonly struct ValueTask : IReturnType
        {
            public readonly struct Type : IReturnType
            {
                public INamedTypeSymbol Parameter { get; }

                public Type(INamedTypeSymbol parameter) => Parameter = parameter;

                public readonly struct Generic : IReturnType
                {
                    public ITypeParameterSymbol Parameter { get; }

                    public Generic(ITypeParameterSymbol parameter) => Parameter = parameter;
                }
            }
        }
    }

    public static bool CanBeNull(this ITypeParameterSymbol symbol)
    {
        var argument = symbol.GetGenericArgument();

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

    public static bool CanBeNull(this ITypeSymbol symbol)
    {
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
            return new Return.Type.Generic((method.ReturnType as ITypeParameterSymbol)!);
        }

        var returnName = typeSymbol.ToDisplayString();
        var isTask = returnName.StartsWith(TaskType);
        var isValueTask = returnName.StartsWith(ValueTaskType);

        if(isTask)
        {
            if(typeSymbol.IsGenericType)
            {
                var taskSymbol = typeSymbol.TypeArguments.Single();

                if (taskSymbol is INamedTypeSymbol taskNamedSymbol == false)
                {
                    return new Return.Task.Type.Generic((taskSymbol as ITypeParameterSymbol)!);
                }

                return new Return.Task.Type(taskNamedSymbol);
            }

            return new Return.Task();
        }

        if(isValueTask)
        {
            if(typeSymbol.IsGenericType)
            {
                var taskSymbol = typeSymbol.TypeArguments.Single();

                if (taskSymbol is INamedTypeSymbol taskNamedSymbol == false)
                {
                    return new Return.ValueTask.Type.Generic((taskSymbol as ITypeParameterSymbol)!);
                }

                return new Return.ValueTask.Type(taskNamedSymbol);
            }

            return new Return.ValueTask();
        }

        return new Return.Type(typeSymbol);
    }
}
