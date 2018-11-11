using System;
using sly.buildresult;
using sly.lexer;
using sly.parser;
using sly.parser.generator;

namespace netSchematron
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Test();
            var builder = new ParserBuilder<TokenEnum, string>();
            BuildResult<Parser<TokenEnum, string>> buildResult = builder.BuildParser(test, ParserType.EBNF_LL_RECURSIVE_DESCENT, "XPath");

            Parser<TokenEnum, string> parser = buildResult.Result;
            ParseResult<TokenEnum, string> parseResult = parser.Parse("\"2 + 2\" > \"2\"");

            // Console.WriteLine("Hello World!");
        }
    }
}
