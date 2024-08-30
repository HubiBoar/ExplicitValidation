using System.Text;

namespace Definit.Validation.Generator;

public sealed class SourceBuilder
{
    private readonly StringBuilder _code;
    private int _indentation = 0;

    public SourceBuilder(string[] usings, string? nameSpace = null)
    {
        _code = new();
    }

    public override string ToString()
    {
        var code = new StringBuilder(_code.ToString());
        for(int i = _indentation - 1; i >= 0; i--)
        {
            var tabs = AddTabs(i);
            code.AppendLine()
                .Append(tabs)
                .Append("}");
        }

        return code.ToString();
    }

    public SourceBuilder AddBlock(string value)
    {
        _code.AppendLine()
            .AppendLine("{");

        _indentation += 1;

        AddBlock(_code, value, _indentation);

        return this;
    }

    private static string AddTabs(int count)
    {
        return string.Join("", Enumerable.Range(0, count).Select(x => "\t"));
    }

    private static StringBuilder AddBlock(StringBuilder code, string value, int indentation)
    {
        var tabs = AddTabs(indentation);
        var lines = string.Join("\n", value.Split('\n').Select(x => $"{tabs}{x}"));
        return code.AppendLine().Append(lines);
    }
}
