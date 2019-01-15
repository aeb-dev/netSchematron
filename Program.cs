using System;
using System.Xml;
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
            var xpathParser = new XPathParser(new XmlDocument());
            var builder = new ParserBuilder<XPathToken, object>();
            BuildResult<Parser<XPathToken, object>> buildResult = builder.BuildParser(xpathParser, ParserType.EBNF_LL_RECURSIVE_DESCENT, "XPath");

            Parser<XPathToken, object> parser = buildResult.Result;
            ParseResult<XPathToken, object> parseResult = parser.Parse("---1-2 div 5---(2*--(3--2)idiv 3 ++(-4+3) * 5) div 5", "XPath");
        }
    }
}
