using System;
using sly.parser.generator;

namespace netSchematron
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Test();
            var builder = new ParserBuilder<Token, string>();
            var parser = builder.BuildParser(test, ParserType.EBNF_LL_RECURSIVE_DESCENT, "Expr");

            Console.WriteLine("Hello World!");
        }
    }
}
