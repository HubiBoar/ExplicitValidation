using System.Collections.Immutable;
using System.Text;
using Definit.Validation.Generator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Results.Generator;

[Generator]
public class MethodGenerator : IIncrementalGenerator
{
    private const string ResultType = "Definit.Results.NewApproach.IResult";
    private const string TaskType = "System.Threading.Tasks.Task<";

    private record struct TypeInfo
    (
        TypeDeclarationSyntax Parent,
        ImmutableArray<MethodInfo> Methods
    );

    private record struct MethodInfo
    (
        string Keyword,
        MethodDeclarationSyntax Syntax,
        IMethodSymbol Symbol
    );

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider
            .CreateSyntaxProvider(
                predicate: static (s, _) => ShouldTransform(s), 
                transform: static (ctx, _) => Transform(ctx)) 
            .Where(static m => m is not null)
            .Select(static (x, _) => x!.Value);

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<(TypeDeclarationSyntax Type, MethodInfo Method)> typeList
    )
    {
        var types = typeList
            .GroupBy(x => x.Type)
            .Select(x => new TypeInfo(x.Key, x.Select(v => v.Method).ToImmutableArray()))
            .ToArray();

        foreach(var type in types.Select(x => GetType(x)))
        {
            var name = type.ClassName.Replace("<", "_").Replace(">", "").Replace(", ", "_").Replace(" ", "_").Replace(",", "_");
            context.AddSource($"{name}.g.cs", type.Code);
        }
    }

    private static (string Code, string ClassName) GetType(TypeInfo type)
    {
        var (code, typeInfo) = type.Parent.BuildTypeHierarchy
        (
            name => name,
            "Definit.Results",
            "Definit.Validation",
            "System.Diagnostics.CodeAnalysis"
        );

        var builder = new StringBuilder();

        foreach(var method in type.Methods)
        {
            var returnType = GetResultType(method.Symbol)!.Value;
            var returnError = returnType.Type.TypeArguments.Last();
            var isAsync = returnType.IsTask;
            var returnValue = $"{returnType.Type.ToDisplayString()}.Value";

            var decStatic = method.Symbol.IsStatic ? " static": "";
            var decAsync = isAsync ? " async" : ""; 
            var decReturn = isAsync ? $"{TaskType}{returnValue}>" : returnValue;
            var decName = method.Symbol.Name.Remove(0, 1);
            var decParameters = string.Join(", ", method.Symbol.Parameters.Select(x => x.ToDisplayString()));
            var declaration = $"{method.Keyword}{decStatic}{decAsync} {decReturn} {decName}({decParameters})";

            var awaitCall = isAsync ? "await " : "";
            var methodCall = $"{awaitCall}{method.Symbol.Name}({string.Join(", ", method.Symbol.Parameters.Select(x => x.Name))})";
            var errorCall = returnError.ToDisplayString();

            builder.AppendLine().AppendLine($$"""
            {{declaration}}
            {
                try
                {
                    return new {{returnValue}}({{methodCall}});
                }
                catch(Exception exception)
                {
                    return new {{returnValue}}({{errorCall}}.Create(exception)); 
                }
            }
            """);
        }

        code.AddBlock(builder.ToString());

        return (code.ToString(), typeInfo.FullName);
    }

    private static readonly (string Attribute, string Keyword)[] Attributes = 
    [
        ("Definit.Results.NewApproach.GenerateMethod.PublicAttribute", "public"),
        ("Definit.Results.NewApproach.GenerateMethod.PrivateAttribute", "private"),
        ("Definit.Results.NewApproach.GenerateMethod.Public.OverrideAttribute", "public override"),
        ("Definit.Results.NewApproach.GenerateMethod.Private.OverrideAttribute", "private override"),
        ("Definit.Results.NewApproach.GenerateMethod.Public.VirtualAttribute", "public virual"),
        ("Definit.Results.NewApproach.GenerateMethod.Private.VirtualAttribute", "private virual")
    ];

    private static bool ShouldTransform(SyntaxNode node)
    {
        return node is MethodDeclarationSyntax method
            && method.AttributeLists.Count > 0 
            && node.Parent is not null
            && node.Parent is TypeDeclarationSyntax type
            && type is not null
            && type.Modifiers.Any(x => x.IsKind(SyntaxKind.PartialKeyword));
    }

    private static (TypeDeclarationSyntax Type, MethodInfo Method)? Transform
    (
        GeneratorSyntaxContext context
    )
    {
        var typeSyntax = (TypeDeclarationSyntax)context.Node.Parent!; 

        var methodSyntax = (MethodDeclarationSyntax)context.Node;

        foreach (AttributeSyntax attributeSyntax in methodSyntax.AttributeLists.SelectMany(x => x.Attributes))
        {
            var attributeSymbol = (context.SemanticModel.GetSymbolInfo(attributeSyntax).Symbol as IMethodSymbol)!;

            string fullName = attributeSymbol.ContainingType.ToDisplayString();
           
            var attributes = Attributes.Where(x => x.Attribute == fullName).ToArray();
            if (attributes.Length == 1)
            {
                var attribute = attributes[0];

                var methodSymbol = (context.SemanticModel.GetDeclaredSymbol(methodSyntax) as IMethodSymbol)!;
            
                if(methodSymbol.Name.StartsWith("_") == false)
                {
                    return null;
                }

                if(GetResultType(methodSymbol) is null)
                {
                   return null;
                }

                return (typeSyntax, new MethodInfo(attribute.Keyword, methodSyntax, methodSymbol));
            }
        }


        return null;
    }  

    private static (INamedTypeSymbol Type, bool IsTask)? GetResultType(IMethodSymbol symbol)
    {
        if(symbol.ReturnType is INamedTypeSymbol returnType is false)
        {
            return null;
        }

        if(IsResult(returnType))
        {
            return (returnType, false);
        }
        
        if(returnType.ToDisplayString().StartsWith(TaskType) is false)
        {
            return null;
        }

        if(returnType.TypeArguments.First() is INamedTypeSymbol genericReturn is false)
        {
            return null;
        }

        if(IsResult(genericReturn))
        {
            return (genericReturn, true);
        }

        return null;

        static bool IsResult(ITypeSymbol type)
        {
            return type.AllInterfaces.Any(x => x.ToDisplayString().StartsWith(ResultType));
        }
    }
}

