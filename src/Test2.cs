using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sly.lexer;
using sly.parser.generator;
using sly.parser.parser;

namespace netSchematron
{
    public class Test2
    {
        public Test2()
        {

        }

        [Production("XPath: Expr")]
        public string XPath(string expr)
        {
            return expr;
        }

        [Production("Expr: ExprSingle")]
        public string Expr(string exprSingle)
        {
            return exprSingle;
        }

        [Production("ExprSingle: OrExpr")]
        public string ExprSingle(string orExpr)
        {
            return orExpr;
        }

        [Production("OrExpr: AndExpr")]
        public string OrExpr(string andExpr)
        {
            return andExpr;
        }

        [Production("AndExpr: ComparisonExpr")]
        public string AndExpr(string comparisonExpr)
        {
            return comparisonExpr;
        }

        [Production("ComparisonExpr: StringConcatExpr")]
        public string ComparisonExpr(string stringConcatExpr)
        {
            return stringConcatExpr;
        }

        [Production("StringConcatExpr: RangeExpr")]
        public string StringConcatExpr(string rangeExpr)
        {
            return rangeExpr;
        }

        [Production("RangeExpr: AdditiveExpr")]
        public string RangeExpr(string additiveExpr)
        {
            return additiveExpr;
        }

        [Production("AdditiveExpr: MultiplicativeExpr (MinusOrPlusExpr MultiplicativeExpr)*")]
        public string AdditiveExpr(string multiplicativeExpr, List<Group<TokenEnum, string>> groupList)
        {
            string result = multiplicativeExpr;
            foreach (Group<TokenEnum, string> group in groupList)
            {
                result += group.Value(0);
                result += group.Value(1);
            }
            return result;
        }

        [Production("MinusOrPlusExpr: MINUS")]
        [Production("MinusOrPlusExpr: PLUS")]
        public string MinusOrPlusExpr(Token<TokenEnum> token)
        {
            return token.Value;
        }

        [Production("MultiplicativeExpr: UnionExpr")]
        public string MultiplicativeExpr(string unionExpr)
        {
            return unionExpr;
        }

        [Production("UnionExpr: IntersectExceptExpr")]
        public string UnionExpr(string intersectExceptExpr)
        {
            return intersectExceptExpr;
        }

        [Production("IntersectExceptExpr: InstanceofExpr")]
        public string IntersectExceptExpr(string instanceOfExpr)
        {
            return instanceOfExpr;
        }

        [Production("InstanceofExpr: TreatExpr")]
        public string InstanceofExpr(string treatExpr)
        {
            return treatExpr;
        }

        [Production("TreatExpr: CastableExpr")]
        public string TreatExpr(string castableExpr)
        {
            return castableExpr;
        }

        [Production("CastableExpr: CastExpr")]
        public string CastableExpr(string castExpr)
        {
            return castExpr;
        }

        [Production("CastExpr: ArrowExpr")]
        public string CastExpr(string arrowExpr)
        {
            return arrowExpr;
        }

// works if true
#if false
        [Production("ArrowExpr: ValueExpr")]
        public string ArrowExpr(string unaryExpr)
        {
            return unaryExpr;
        }
#else
        [Production("ArrowExpr: UnaryExpr")]
        public string ArrowExpr(string unaryExpr)
        {
            return unaryExpr;
        }

        [Production("UnaryExpr: MinusOrPlusExpr* ValueExpr")]
        public string UnaryExpr(List<string> uMinusPlus, string valueExpr)
        {
            string result = String.Empty;
            int minusCount = uMinusPlus.Count(x => x == "-");
            if (minusCount % 2 == 0)
            {
                result += $"+{valueExpr}";
            }
            else
            {
                result += $"-{valueExpr}";
            }

            return result;
        }
#endif

        [Production("ValueExpr: SimpleMapExpr")]
        public string ValueExpr(string simpleMapExpr)
        {
            return simpleMapExpr;
        }

        [Production("SimpleMapExpr: PathExpr")]
        public string SimpleMapExpr(string pathExpr)
        {
            return pathExpr;
        }
        [Production("PathExpr: RelativePathExpr")]
        public string PathExpr(string relativePathExpr)
        {
            return relativePathExpr;
        }

        [Production("RelativePathExpr: StepExpr")]
        public string RelativePathExpr(string stepExpr)
        {
            return stepExpr;
        }

        [Production("StepExpr: PostfixExpr")]
        public string StepExpr(string expr)
        {
            return expr;
        }

        [Production("PostfixExpr: PrimaryExpr")]
        public string PostfixExpr(string primaryExpr)
        {
            return primaryExpr;
        }

        [Production("PrimaryExpr: Literal")]
        [Production("PrimaryExpr: ParenthesizedExpr")]
        public string PrimaryExpr(string expr)
        {
            return expr;
        }

        [Production("Literal: NumericLiteral")]
        public string Literal(string expr)
        {
            return expr;
        }

        [Production("NumericLiteral: IntegerLiteral")]
        public string NumericLiteral(string expr)
        {
            return expr;
        }

        [Production("ParenthesizedExpr: LPARENTHESIS [d] Expr? RPARENTHESIS [d]")]
        public string ParenthesizedExpr(ValueOption<string> option)
        {
            var gg = option.Match((expr) => $"({expr})", () => "()");
            return gg;
        }

        [Production("IntegerLiteral: INTEGER")]
        public string IntegerLiteral(Token<TokenEnum> token)
        {
            return token.Value;
        }
    }
}