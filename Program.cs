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
            var xpathParser = new XPathParser();
            var builder = new ParserBuilder<XPathToken, object>();
            BuildResult<Parser<XPathToken, object>> buildResult = builder.BuildParser(xpathParser, ParserType.EBNF_LL_RECURSIVE_DESCENT, "XPath");

            Parser<XPathToken, object> parser = buildResult.Result;
            ParseResult<XPathToken, object> parseResult = parser.Parse("---1-2----((3--2)++(-4+3))", "XPath");
        }
    }
}
