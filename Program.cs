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
            foreach (TokenEnum enumm in (TokenEnum[]) Enum.GetValues(typeof(TokenEnum)))
            {
                Console.WriteLine((int)enumm);
            }

            var test = new Test();
            var builder = new ParserBuilder<TokenEnum, string>();
            BuildResult<Parser<TokenEnum, string>> buildResult = builder.BuildParser(test, ParserType.EBNF_LL_RECURSIVE_DESCENT, "XPath");

            Parser<TokenEnum, string> parser = buildResult.Result;
            ParseResult<TokenEnum, string> parseResult = parser.Parse("2-2", "XPath");

            // Console.WriteLine("Hello World!");
        }
    }
}
