using System.Collections.Generic;
using sly.lexer;
using sly.parser.generator;
using sly.parser.parser;
using System.Linq;
using System;

namespace netSchematron
{
    public class XPathParser
    {
        public XPathParser()
        {

        }

        [Production("XPath: AndExpr (COMPARATOR AndExpr)?")]
        public object XPath(object andExpr, ValueOption<Group<XPathToken, object>> exprList)
        {
            return andExpr;
        }

        [Production("AndExpr: PrimaryExpr (MinusOrPlusExpr PrimaryExpr)*")]
        public object AdditiveExpr(object primaryExpr, List<Group<XPathToken, object>> groupList)
        {
            if (groupList.Any())
            {
                foreach (Group<XPathToken, object> group in groupList)
                {
                    object value = group.Value(1);
                    switch (group.Value(0))
                    {
                        case XPathToken.MINUS:
                        {
                            if (primaryExpr is decimal || value is decimal)
                            {
                                primaryExpr = Convert.ToDecimal(primaryExpr) - Convert.ToDecimal(value);
                            }
                            else if (primaryExpr is int || value is int)
                            {
                                primaryExpr = Convert.ToInt32(primaryExpr) - Convert.ToInt32(value);
                            }
                            break;
                        }
                        case XPathToken.PLUS:
                        {
                            if (primaryExpr is decimal || value is decimal)
                            {
                                primaryExpr = Convert.ToDecimal(primaryExpr) + Convert.ToDecimal(value);
                            }
                            else if (primaryExpr is int || value is int)
                            {
                                primaryExpr = Convert.ToInt32(primaryExpr) + Convert.ToInt32(value);
                            }
                            break;
                        }
                    }
                }
            }

            return primaryExpr;
        }

        [Production("MinusOrPlusExpr: MINUS")]
        [Production("MinusOrPlusExpr: PLUS")]
        public XPathToken MinusOrPlusExpr(Token<XPathToken> token)
        {
            return token.TokenID;
        }

        [Production("PrimaryExpr: NumericLiteral")]
        [Production("PrimaryExpr: ParenthesizedExpr")]
        public object PrimaryExpr(object expr)
        {
            return expr;
        }

        [Production("NumericLiteral: INTEGER")]
        public int NumericLiteral(Token<XPathToken> token)
        {
            return token.IntValue;
        }

        [Production("ParenthesizedExpr: LPARENTHESIS [d] XPath? RPARENTHESIS [d]")]
        public object ParenthesizedExpr(ValueOption<object> option)
        {
            object result = null;
            if (option.IsSome)
            {
                result = option.Match((expr) => expr, null);
            }

            return result;
        }
    }
}