using System.Text;

namespace Definit.Utils.SourceGenerator;

public sealed class SourceBuilder
{
    private readonly StringBuilder _code;
    private int _indentation = 0;

    public SourceBuilder(string[] usings, string? nameSpace = null)
    {
        _code = new();

        _code.AppendLine($"#nullable enable");
        _code.AppendLine();
        foreach(var u in usings)
        {
            _code.AppendLine($"using {u};");
        }

        if(string.IsNullOrEmpty(nameSpace) == false)
        {
            _code.AppendLine().Append($"namespace {nameSpace};");
        }
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

    public SourceBuilder AddBlockDontIndent(string value)
    {
        _code.AppendLine().Append($$"""{{AddTabs(_indentation)}}""");

        AddBlock(_code, value, _indentation);

        return this;
    }

    public SourceBuilder AddBlock(string value)
    {
        _code.AppendLine().Append($$"""{{AddTabs(_indentation)}}{""");

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
