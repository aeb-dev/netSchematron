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

        [Production("XPath: Expr")]
        public object XPath(object expr)
        {
            return expr;
        }

        // [Production("ParamList: Param (COMMA [d] Param)*")]
        // public int ParamList(string param, List<Group<XPathToken, string>> groupList)
        // {
        //     return 5;
        // }

        // [Production("Param: DOLAR [d] EQName TypeDeclaration?")]
        // public int Param(string eqName, ValueOption<string> optionalExpr)
        // {
        //     return 5;
        // }

        // [Production("FunctionBody: EnclosedExpr")]
        // public int FunctionBody(string enclosedExpr)
        // {
        //     return 5;
        // }

        // [Production("EnclosedExpr: LCURLYBRACKET [d] Expr? RCURLYBRACKET [d]")]
        // public int EnclosedExpr(ValueOption<string> optionalExpr)
        // {
        //     return 5;
        // }

        // [Production("Expr: ExprSingle (COMMA [d] ExprSingle)*")]
        // public object Expr(object exprSingle, List<object> exprList)
        [Production("Expr: ExprSingle")]
        public object Expr(object exprSingle)
        {
            return exprSingle;
        }

        // [Production("ExprSingle: ForExpr")]
        // [Production("ExprSingle: LetExpr")]
        // [Production("ExprSingle: QuantifiedExpr")]
        // [Production("ExprSingle: IfExpr")]
        [Production("ExprSingle: OrExpr")]
        public object ExprSingle(object orExpr)
        {
            return orExpr;
        }

        // [Production("ForExpr: SimpleForClause RETURN [d] ExprSingle")]
        // public int ForExpr()
        // {
        //     return 5;
        // }

        // [Production("SimpleForClause: FOR [d] SimpleForBinding (COMMA [d] SimpleForBinding)*")]
        // public int SimpleForClause()
        // {
        //     return 5;
        // }

        // [Production("SimpleForBinding: DOLAR [d] VarName IN [d] ExprSingle")]
        // public int SimpleForBinding()
        // {
        //     return 5;
        // }

        // [Production("LetExpr: SimpleLetClause RETURN [d] ExprSingle")]
        // public int LetExpr()
        // {
        //     return 5;
        // }

        // [Production("SimpleLetClause: LET [d] SimpleLetBinding (COMMA [d] SimpleLetBinding)*")]
        // public int SimpleLetClause()
        // {
        //     return 5;
        // }

        // [Production("SimpleLetBinding: DOLAR [d] VarName ASSIGN [d] ExprSingle")]
        // public int SimpleLetBinding()
        // {
        //     return 5;
        // }

        // [Production("QuantifiedExpr: SOMEEVERY [d] DOLAR [d] VarName IN [d] ExprSingle (COMMA [d] DOLAR [d] VarName IN [d] ExprSingle)* SATISFIES [d] ExprSingle")]
        // public int QuantifiedExpr()
        // {
        //     return 5;
        // }

        // [Production("IfExpr: IF [d] LPARENTHESIS [d] Expr RPARENTHESIS [d] THEN [d] ExprSingle ELSE [d] ExprSingle")]
        // public int IfExpr()
        // {
        //     return 5;
        // }

        [Production("OrExpr: AndExpr (OR [d] AndExpr)*")]
        public object OrExpr(object andExpr, List<Group<XPathToken, object>> exprList)
        {
            if (exprList.Any())
            {

            }

            return andExpr;
        }

        [Production("AndExpr: ComparisonExpr (AND [d] ComparisonExpr)*")]
        public object AndExpr(object comparisonExpr, List<Group<XPathToken, object>> exprList)
        {
            if (exprList.Any())
            {

            }

            return comparisonExpr;
        }

        // [Production("ComparisonExpr: StringConcatExpr (COMPARATOR StringConcatExpr)?")]
        // public object ComparisonExpr(object stringConcatExpr, ValueOption<Group<XPathToken, object>> optionalGroup)
        [Production("ComparisonExpr: StringConcatExpr (COMPARATOR StringConcatExpr)*")]
        public object ComparisonExpr(object stringConcatExpr, List<Group<XPathToken, object>> exprList)
        {
            if (exprList.Count > 1) throw new Exception("a value option clause is simulated with list, therefore 0 or 1 occurence is permitted");

            if (exprList.Any())
            {

            }

            return stringConcatExpr;
        }

        [Production("StringConcatExpr: RangeExpr (CONCAT [d] RangeExpr)*")]
        public object StringConcatExpr(object rangeExpr, List<Group<XPathToken, object>> exprList)
        {
            if (exprList.Any())
            {

            }

            return rangeExpr;
        }

        // [Production("RangeExpr: AdditiveExpr (TO [d] AdditiveExpr)?")]
        // public object RangeExpr(object additiveExpr, ValueOption<object> optionalExpr)
        [Production("RangeExpr: AdditiveExpr (TO [d] AdditiveExpr)*")]
        public object RangeExpr(object additiveExpr, List<Group<XPathToken, object>> exprList)
        {
            if (exprList.Count > 1) throw new Exception("a value option clause is simulated with list, therefore 0 or 1 occurence is permitted");

            if (exprList.Any())
            {

            }

            return additiveExpr;
        }

        [Production("AdditiveExpr: MultiplicativeExpr (MinusOrPlusExpr MultiplicativeExpr)*")]
        public object AdditiveExpr(object multiplicativeExpr, List<Group<XPathToken, object>> groupList)
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
                            if (multiplicativeExpr is decimal || value is decimal)
                            {
                                multiplicativeExpr = Convert.ToDecimal(multiplicativeExpr) - Convert.ToDecimal(value);
                            }
                            else if (multiplicativeExpr is int || value is int)
                            {
                                multiplicativeExpr = Convert.ToInt32(multiplicativeExpr) - Convert.ToInt32(value);
                            }
                            break;
                        }
                        case XPathToken.PLUS:
                        {
                            if (multiplicativeExpr is decimal || value is decimal)
                            {
                                multiplicativeExpr = Convert.ToDecimal(multiplicativeExpr) + Convert.ToDecimal(value);
                            }
                            else if (multiplicativeExpr is int || value is int)
                            {
                                multiplicativeExpr = Convert.ToInt32(multiplicativeExpr) + Convert.ToInt32(value);
                            }
                            break;
                        }
                    }
                }
            }

            return multiplicativeExpr;
        }

        [Production("MinusOrPlusExpr: MINUS")]
        [Production("MinusOrPlusExpr: PLUS")]
        public XPathToken MinusOrPlusExpr(Token<XPathToken> token)
        {
            return token.TokenID;
        }

        [Production("MultiplicativeExpr: UnionExpr (MultiplicativeOperatorExpr UnionExpr)*")]
        public object MultiplicativeExpr(object unionExpr, List<Group<XPathToken, object>> groupList)
        {
            if (groupList.Any())
            {
                foreach (Group<XPathToken, object> group in groupList)
                {
                    object value = group.Value(1);
                    switch (group.Value(0))
                    {
                        case XPathToken.STAR:
                        {
                            if (unionExpr is decimal || value is decimal)
                            {
                                unionExpr = Convert.ToDecimal(unionExpr) * Convert.ToDecimal(value);
                            }
                            else if (unionExpr is int || value is int)
                            {
                                unionExpr = Convert.ToInt32(unionExpr) * Convert.ToInt32(value);
                            }
                            break;
                        }
                        case XPathToken.DIV:
                        {
                            if (unionExpr is decimal || value is decimal)
                            {
                                unionExpr = Convert.ToDecimal(unionExpr) / Convert.ToDecimal(value);
                            }
                            break;
                        }
                        case XPathToken.IDIV:
                        {
                            if (unionExpr is decimal || value is decimal)
                            {
                                unionExpr = Convert.ToInt32((Convert.ToDecimal(unionExpr) / Convert.ToDecimal(value)));
                            }
                            else if (unionExpr is int || value is int)
                            {
                                unionExpr = Convert.ToInt32((Convert.ToInt32(unionExpr) / Convert.ToInt32(value)));
                            }
                            break;
                        }
                        case XPathToken.MOD:
                        {
                            if (unionExpr is decimal || value is decimal)
                            {
                                unionExpr = Convert.ToDecimal(unionExpr) % Convert.ToDecimal(value);
                            }
                            else if (unionExpr is int || value is int)
                            {
                                unionExpr = Convert.ToInt32(unionExpr) % Convert.ToInt32(value);
                            }
                            break;
                        }
                    }
                }
            }

            return unionExpr;
        }

        [Production("MultiplicativeOperatorExpr: DIV")]
        [Production("MultiplicativeOperatorExpr: MOD")]
        [Production("MultiplicativeOperatorExpr: IDIV")]
        [Production("MultiplicativeOperatorExpr: STAR")]
        public XPathToken MultiplicativeOperatorExpr(Token<XPathToken> token)
        {
            return token.TokenID;
        }

        [Production("UnionExpr: IntersectExceptExpr")]
        public object UnionExpr(object intersectExceptExpr)
        {
            return intersectExceptExpr;
        }

        [Production("IntersectExceptExpr: InstanceofExpr")]
        public object IntersectExceptExpr(object instanceOfExpr)
        {
            return instanceOfExpr;
        }

        [Production("InstanceofExpr: TreatExpr")]
        public object InstanceofExpr(object treatExpr)
        {
            return treatExpr;
        }

        [Production("TreatExpr: CastableExpr")]
        public object TreatExpr(object castableExpr)
        {
            return castableExpr;
        }

        [Production("CastableExpr: CastExpr")]
        public object CastableExpr(object castExpr)
        {
            return castExpr;
        }

        [Production("CastExpr: ArrowExpr")]
        public object CastExpr(object arrowExpr)
        {
            return arrowExpr;
        }

        [Production("ArrowExpr: UnaryExpr")]
        public object ArrowExpr(object unaryExpr)
        {
            return unaryExpr;
        }

        [Production("UnaryExpr: MinusOrPlusExpr* ValueExpr")]
        public object UnaryExpr(List<object> uMinusPlus, object valueExpr)
        {
            bool isNegative = false;
            if (uMinusPlus.Any())
            {
                int minusCount = uMinusPlus.Count(x => (XPathToken)x == XPathToken.MINUS);
                if (minusCount % 2 != 0)
                {
                    isNegative = true;
                }
            }

            if (isNegative)
            {
                if (valueExpr is decimal)
                {
                    valueExpr = -(decimal)valueExpr;
                }
                else if (valueExpr is int)
                {
                    valueExpr = -(int)valueExpr;
                }
            }

            return valueExpr;
        }

        [Production("ValueExpr: SimpleMapExpr")]
        public object ValueExpr(object simpleMapExpr)
        {
            return simpleMapExpr;
        }

        [Production("SimpleMapExpr: PathExpr")]
        public object SimpleMapExpr(object pathExpr)
        {
            return pathExpr;
        }

        // [Production("PathExpr: PATH [d] RelativePathExpr?")]
        // public int PathExpr(ValueOption<string> option)
        // {
        //     return 5;
        // }

        // [Production("PathExpr: ALLPATH [d] RelativePathExpr")]
        [Production("PathExpr: RelativePathExpr")]
        public object PathExpr(object relativePathExpr)
        {
            return relativePathExpr;
        }

        [Production("RelativePathExpr: StepExpr")]
        // [Production("RelativePathExpr: StepExpr (ALLPATH StepExpr)*")]
        public object RelativePathExpr(object stepExpr)
        {
            return stepExpr;
        }

        [Production("StepExpr: PostfixExpr")]
        // [Production("StepExpr: AxisStep")]
        public object StepExpr(object expr)
        {
            return expr;
        }

        // [Production("AxisStep: ReverseStep PredicateList")]
        // [Production("AxisStep: ForwardStep PredicateList")]
        // public int AxisStep(string reverseStep, string predicateList)
        // {
        //     return 5;
        // }

        // [Production("ForwardStep: ForwardAxis NodeTest")]
        // public int ForwardStep(string forwardAxis, string nodeTest)
        // {
        //     return 5;
        // }

        // [Production("ForwardStep: AbbrevForwardStep")]
        // public int ForwardStep(string abbrevForwardStep)
        // {
        //     return 5;
        // }

        // [Production("ForwardAxis: FWDAXIS DOUBLECOLON [d]")]
        // public int ForwardAxis(Token<XPathToken> token)
        // {
        //     return 5;
        // }

        // [Production("AbbrevForwardStep: AT? NodeTest")]
        // public int AbbrevForwardStep(ValueOption<Token<XPathToken>> optionalToken, string nodeTest)
        // {
        //     return 5;
        // }

        // [Production("ReverseStep: ReverseAxis NodeTest")]
        // public int ReverseStep(string reverseAxis, string nodeTest)
        // {
        //     return 5;
        // }

        // [Production("ReverseStep: DOUBLEDOT [d]")]
        // public int ReverseStep()
        // {
        //     return 5;
        // }

        // [Production("ReverseAxis: RVEAXIS DOUBLECOLON [d]")]
        // public int ReverseAxis(Token<XPathToken> token)
        // {
        //     return 5;
        // }

        // [Production("NodeTest: KindTest")]
        // [Production("NodeTest: NameTest")]
        // public int NodeTest(string expr)
        // {
        //     return 5;
        // }

        // [Production("NameTest: EQName")]
        // [Production("NameTest: Wildcard")]
        // public int NameTest(string expr)
        // {
        //     return 5;
        // }

        // [Production("Wildcard: STAR [d]")]
        // public int Wildcard()
        // {
        //     return 5;
        // }

        // [Production("Wildcard: NCName COLONWILDCARD [d]")]
        // [Production("Wildcard: WILDCARDCOLON [d] NCName")]
        // [Production("Wildcard: BracedURILiteral STAR [d]")]
        // public int Wildcard(string expr)
        // {
        //     return 5;
        // }

        [Production("PostfixExpr: PrimaryExpr PredicateOrArgumentListOrLookupExpr*")]
        public object PostfixExpr(object primaryExpr, List<object> exprList)
        {
            if (exprList.Any())
            {

            }

            return primaryExpr;
        }

        [Production("PredicateOrArgumentListOrLookupExpr: Predicate")]
        [Production("PredicateOrArgumentListOrLookupExpr: ArgumentList")]
        // [Production("PredicateOrArgumentListOrLookupExpr: Lookup")]
        public object PredicateOrArgumentListOrLookupExpr(object expr)
        {
            return expr;
        }

        // [Production("ArgumentList: LPARENTHESIS [d] (Argument ExtraArgumentList)? RPARENTHESIS [d]")]
        // public object ArgumentList(ValueOption<Group<XPathToken, object>> optionalGroup)
        [Production("ArgumentList: LPARENTHESIS [d] (Argument ExtraArgumentList)* RPARENTHESIS [d]")]
        public object ArgumentList(List<Group<XPathToken, object>> exprList)
        {
            if (exprList.Count > 1) throw new Exception("a value option clause is simulated with list, therefore 0 or 1 occurence is permitted");

            if (exprList.Any())
            {
                // optionalGroup.Match()
            }

            return 5;
        }

        [Production("ExtraArgumentList: (COMMA [d] Argument)*")]
        public object ExtraArgumentList(List<Group<XPathToken, object>> groupList)
        {
            var argumentList = new List<object>();
            foreach (Group<XPathToken, object> group in groupList)
            {
                argumentList.Add(group.Value(0));
            }

            return argumentList;
        }

        // [Production("PredicateList: Predicate*")]
        // public int PredicateList(List<string> list)
        // {
        //     return 5;
        // }

        [Production("Predicate: LSQRBRACKET [d] Expr RSQRBRACKET [d]")]
        public object Predicate(object expr)
        {
            return expr;
        }

        // [Production("Lookup: QUESTION [d] KeySpecifier")]
        // public int Lookup(string keySpecifier)
        // {
        //     return 5;
        // }

        // [Production("KeySpecifier: NCName")]
        // [Production("KeySpecifier: IntegerLiteral")]
        // [Production("KeySpecifier: ParenthesizedExpr")]

        // public int KeySpecifier(string expr)
        // {
        //     return 5;
        // }

        // [Production("KeySpecifier: STAR [d]")]
        // public int KeySpecifier()
        // {
        //     return 5;
        // }

        // [Production("ArrowFunctionSpecifier: EQName")]
        // [Production("ArrowFunctionSpecifier: VarRef")]
        // [Production("ArrowFunctionSpecifier: ParenthesizedExpr")]
        // public int ArrowFunctionSpecifier(string expr)
        // {
        //     return 5;
        // }

        [Production("PrimaryExpr: Literal")]
        // [Production("PrimaryExpr: VarRef")]
        [Production("PrimaryExpr: ParenthesizedExpr")]
        // [Production("PrimaryExpr: ContextItemExpr")]
        [Production("PrimaryExpr: FunctionCall")]
        // [Production("PrimaryExpr: FunctionItemExpr")]
        // [Production("PrimaryExpr: MapConstructor")]
        // [Production("PrimaryExpr: ArrayConstructor")]
        // [Production("PrimaryExpr: UnaryLookup")]
        public object PrimaryExpr(object expr)
        {
            return expr;
        }

        [Production("Literal: NumericLiteral")]
        [Production("Literal: StringLiteral")]
        public object Literal(object expr)
        {
            return expr;
        }

        [Production("NumericLiteral: IntegerLiteral")]
        [Production("NumericLiteral: DecimalLiteral")]
        [Production("NumericLiteral: DoubleLiteral")]
        public object NumericLiteral(object expr)
        {
            return expr;
        }

        // [Production("VarRef: DOLAR [d] VarName")]
        // public int VarRef(string varName)
        // {
        //     return 5;
        // }

        // [Production("VarName: EQName")]
        // public int VarName(string eqName)
        // {
        //     return 5;
        // }

        [Production("ParenthesizedExpr: LPARENTHESIS [d] Expr? RPARENTHESIS [d]")]
        public object ParenthesizedExpr(ValueOption<object> option)
        {
            object result = null;
            if (option.IsSome)
            {
                result = option.Match((expr) => expr, null);
            }

            return result;
        }

        // [Production("ContextItemExpr: DOT [d]")]
        // public string ContextItemExpr()
        // {
        //     return ".";
        // }

        [Production("FunctionCall: EQName ArgumentList")]
        public object FunctionCall(string eqName, object argumentList)
        {
            return XPathReservedFunction.FunctionList[eqName](argumentList);
        }

        [Production("Argument: ExprSingle")]
        // [Production("Argument: ArgumentPlaceholder")]
        public object Argument(object expr)
        {
            return expr;
        }

        // [Production("ArgumentPlaceholder: QUESTION [d]")]
        // public string ArgumentPlaceholder()
        // {
        //     return "*";
        // }

        // [Production("FunctionItemExpr: NamedFunctionRef")]
        // [Production("FunctionItemExpr: InlineFunctionExpr")]
        // public int FunctionItemExpr(string expr)
        // {
        //     return 5;
        // }

        // [Production("NamedFunctionRef: EQName SQUARE [d] IntegerLiteral")]
        // public int NamedFunctionRef(string eqName, string integerLiteral)
        // {
        //     return 5;
        // }

        // [Production("InlineFunctionExpr: FUNCTION [d] LPARENTHESIS [d] ParamList? RPARENTHESIS [d] (AS [d] SequenceType)? FunctionBody")]
        // public int InlineFunctionExpr(ValueOption<string> option_first, ValueOption<Group<XPathToken, string>> option_second, string functionBody)
        // {
        //     return 5;
        // }

        // [Production("MapConstructor: MAP [d] LCURLYBRACKET [d] (MapConstructorEntry ExtraMapConstructor)? RCURLYBRACKET [d]")]
        // public int MapConstructor(ValueOption<Group<XPathToken, string>> option)
        // {
        //     return 5;
        // }

        // [Production("ExtraMapConstructor: (COMMA [d] MapConstructorEntry)*")]
        // public int ExtraMapConstructor(List<Group<XPathToken, string>> list)
        // {
        //     return 5;
        // }

        // [Production("MapConstructorEntry: MapKeyExpr COLON [d] MapValueExpr")]
        // public int MapConstructorEntry(string mapKeyExpr, string mapValueExpr)
        // {
        //     return 5;
        // }

        // [Production("MapKeyExpr: ExprSingle")]
        // public int MapKeyExpr(string exprSingle)
        // {
        //     return 5;
        // }

        // [Production("MapValueExpr: ExprSingle")]
        // public int MapValueExpr(string exprSingle)
        // {
        //     return 5;
        // }

        // [Production("ArrayConstructor: SquareArrayConstructor")]
        // [Production("ArrayConstructor: CurlyArrayConstructor")]
        // public int ArrayConstructor(string expr)
        // {
        //     return 5;
        // }

        // [Production("SquareArrayConstructor: LSQRBRACKET [d] (ExprSingle ExtraSquareArrayConstructor)? RSQRBRACKET [d]")]
        // public int SquareArrayConstructor(ValueOption<Group<XPathToken, string>> option)
        // {
        //     return 5;
        // }

        // [Production("ExtraSquareArrayConstructor: (COMMA [d] ExprSingle)*")]
        // public int ExtraSquareArrayConstructor(List<Group<XPathToken, string>> list)
        // {
        //     return 5;
        // }

        // [Production("CurlyArrayConstructor: ARRAY [d] EnclosedExpr")]
        // public int CurlyArrayConstructor(string enclosedExpr)
        // {
        //     return 5;
        // }

        // [Production("UnaryLookup: QUESTION [d] KeySpecifier")]
        // public int UnaryLookup(string keySpecifier)
        // {
        //     return 5;
        // }

        // [Production("SingleType: SimpleTypeName QUESTION?")]
        // public int SingleType(string simpleTypeName, ValueOption<Token<XPathToken>> option)
        // {
        //     return 5;
        // }

        // [Production("TypeDeclaration: AS [d] SequenceType")]
        // public int TypeDeclaration(string sequenceType)
        // {
        //     return 5;
        // }

        // [Production("SequenceType: EMPTYSEQUENCE [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int SequenceType()
        // {
        //     return 5;
        // }

        // [Production("SequenceType: ItemType OccurrenceIndicator?")]
        // public int SequenceType(string itemType, ValueOption<string> occurenceIndicator)
        // {
        //     return 5;
        // }

        // [Production("OccurrenceIndicator: QUESTION")]
        // [Production("OccurrenceIndicator: STAR")]
        // [Production("OccurrenceIndicator: PLUS")]
        // public int OccurrenceIndicator(Token<XPathToken> token)
        // {
        //     return 5;
        // }

        // [Production("ItemType: KindTest")]
        // [Production("ItemType: FunctionTest")]
        // [Production("ItemType: MapTest")]
        // [Production("ItemType: ArrayTest")]
        // [Production("ItemType: AtomicOrUnionType")]
        // [Production("ItemType: ParenthesizedItemType")]
        // public int ItemType(string expr)
        // {
        //     return 5;
        // }

        // [Production("ItemType: ITEM [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int ItemType()
        // {
        //     return 5;
        // }

        // [Production("AtomicOrUnionType: EQName")]
        // public int AtomicOrUnionType(string eqName)
        // {
        //     return 5;
        // }

        // [Production("KindTest: DocumentTest")]
        // [Production("KindTest: ElementTest")]
        // [Production("KindTest: AttributeTest")]
        // [Production("KindTest: SchemaElementTest")]
        // [Production("KindTest: SchemaAttributeTest")]
        // [Production("KindTest: PITest")]
        // [Production("KindTest: CommentTest")]
        // [Production("KindTest: TextTest")]
        // [Production("KindTest: NamespaceNodeTest")]
        // [Production("KindTest: AnyKindTest")]
        // public int KindTest(string expr)
        // {
        //     return 5;
        // }

        // [Production("AnyKindTest: NODE [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int AnyKindTest()
        // {
        //     return 5;
        // }

        // [Production("DocumentTest: DOCUMENTNODE [d] LPARENTHESIS [d] ElementTest? RPARENTHESIS [d]")]
        // [Production("DocumentTest: DOCUMENTNODE [d] LPARENTHESIS [d] SchemaElementTest? RPARENTHESIS [d]")]
        // public int DocumentTest(ValueOption<string> option)
        // {
        //     return 5;
        // }

        // [Production("TextTest: TEXT [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int TextTest()
        // {
        //     return 5;
        // }

        // [Production("CommentTest: COMMENT [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int CommentTest()
        // {
        //     return 5;
        // }

        // [Production("NamespaceNodeTest: NAMESPACENODE [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int NamespaceNodeTest()
        // {
        //     return 5;
        // }

        // [Production("PITest: PROCESSINGINSTRUCTION [d] LPARENTHESIS [d] NCName? RPARENTHESIS [d]")]
        // [Production("PITest: PROCESSINGINSTRUCTION [d] LPARENTHESIS [d] StringLiteral? RPARENTHESIS [d]")]
        // public int PITest(ValueOption<string> option)
        // {
        //     return 5;
        // }

        // [Production("AttributeTest: ATTRIBUTE [d] LPARENTHESIS [d] (AttributeNameOrWildcard ExtraAttributeTest)? RPARENTHESIS [d]")]
        // public int AttributeTest(ValueOption<Group<XPathToken, string>> option)
        // {
        //     return 5;
        // }

        // [Production("ExtraAttributeTest: (COMMA [d] TypeName)?")]
        // public int ExtraAttributeTest(ValueOption<Group<XPathToken, string>> option)
        // {
        //     return 5;
        // }

        // [Production("AttributeNameOrWildcard: AttributeName")]
        // public int AttributeNameOrWildcard(string attributeName)
        // {
        //     return 5;
        // }

        // [Production("AttributeNameOrWildcard: STAR [d]")]
        // public int AttributeNameOrWildcard()
        // {
        //     return 5;
        // }

        // [Production("SchemaAttributeTest: SCHEMAATTRIBUTE [d] LPARENTHESIS [d] AttributeDeclaration RPARENTHESIS [d]")]
        // public int SchemaAttributeTest(string attributeDeclaration)
        // {
        //     return 5;
        // }

        // [Production("AttributeDeclaration: AttributeName")]
        // public int AttributeDeclaration(string attributeName)
        // {
        //     return 5;
        // }

        // [Production("ElementTest: ELEMENT [d] LPARENTHESIS [d] (ElementNameOrWildcard ExtraElementTest)? RPARENTHESIS [d]")]
        // public int ElementTest(ValueOption<Group<XPathToken, string>> option)
        // {
        //     return 5;
        // }

        // [Production("ExtraElementTest: (COMMA [d] TypeName ZeroOrOne)?")]
        // public int ExtraElementTest(ValueOption<Group<XPathToken, string>> option)
        // {
        //     return 5;
        // }

        // [Production("ZeroOrOne: QUESTION?")]
        // public int ZeroOrOne(ValueOption<Token<XPathToken>> option)
        // {
        //     return 5;
        // }

        // [Production("ElementNameOrWildcard: ElementName")]
        // public int ElementNameOrWildcard(string elementName)
        // {
        //     return 5;
        // }

        // [Production("ElementNameOrWildcard: STAR [d]")]
        // public int ElementNameOrWildcard()
        // {
        //     return 5;
        // }

        // [Production("SchemaElementTest: SCHEMAELEMENT [d] LPARENTHESIS [d] ElementDeclaration RPARENTHESIS [d]")]
        // public int SchemaElementTest(string elementDeclaration)
        // {
        //     return 5;
        // }

        // [Production("ElementDeclaration: ElementName")]
        // public int ElementDeclaration(string elementName)
        // {
        //     return 5;
        // }

        // [Production("AttributeName: EQName")]
        // public int AttributeName(string eqName)
        // {
        //     return 5;
        // }

        // [Production("ElementName: EQName")]
        // public int ElementName(string eqName)
        // {
        //     return 5;
        // }

        // [Production("SimpleTypeName: TypeName")]
        // public int SimpleTypeName(string typeName)
        // {
        //     return 5;
        // }

        // [Production("TypeName: EQName")]
        // public int TypeName(string eqName)
        // {
        //     return 5;
        // }

        // [Production("FunctionTest: AnyFunctionTest")]
        // [Production("FunctionTest: TypedFunctionTest")]
        // public int FunctionTest(string expr)
        // {
        //     return 5;
        // }

        // [Production("AnyFunctionTest: FUNCTION [d] LPARENTHESIS [d] STAR [d] RPARENTHESIS [d]")]
        // public int AnyFunctionTest()
        // {
        //     return 5;
        // }

        // [Production("TypedFunctionTest: FUNCTION [d] LPARENTHESIS [d] (SequenceType ExtraTypedFunctionTest)? RPARENTHESIS [d] AS [d] SequenceType")]
        // public int TypedFunctionTest(ValueOption<Group<XPathToken, string>> option, string sequenceType)
        // {
        //     return 5;
        // }

        // [Production("ExtraTypedFunctionTest: (COMMA [d] SequenceType)*")]
        // public int ExtraTypedFunctionTest(List<Group<XPathToken, string>> list)
        // {
        //     return 5;
        // }

        // [Production("MapTest: AnyMapTest")]
        // [Production("MapTest: TypedMapTest")]
        // public int MapTest(string expr)
        // {
        //     return 5;
        // }

        // [Production("AnyMapTest: MAP [d] LPARENTHESIS [d] STAR [d] RPARENTHESIS [d]")]
        // public int AnyMapTest()
        // {
        //     return 5;
        // }

        // [Production("TypedMapTest: MAP [d] LPARENTHESIS [d] AtomicOrUnionType COMMA [d] SequenceType RPARENTHESIS [d]")]
        // public int TypedMapTest(string atomicOrUnionType, string sequenceType)
        // {
        //     return 5;
        // }

        // [Production("ArrayTest: AnyArrayTest")]
        // [Production("ArrayTest: TypedArrayTest")]
        // public int ArrayTest(string expr)
        // {
        //     return 5;
        // }

        // [Production("AnyArrayTest: ARRAY [d] LPARENTHESIS [d] STAR RPARENTHESIS [d]")]
        // public int AnyArrayTest(Token<XPathToken> token)
        // {
        //     return 5;
        // }

        // [Production("TypedArrayTest: ARRAY [d] LPARENTHESIS [d] SequenceType RPARENTHESIS [d]")]
        // public int TypedArrayTest(string sequenceType)
        // {
        //     return 5;
        // }

        // [Operand]
        // [Production("ParenthesizedItemType: LPARENTHESIS [d] ItemType RPARENTHESIS [d]")]
        // public string ParenthesizedItemType(string itemType)
        // {
        //     return itemType;
        // }

        [Production("EQName: QName")]
        // [Production("EQName: URIQualifiedName")]
        public string EQName(string expr)
        {
            return expr;
        }

        // [Operand]
        [Production("IntegerLiteral: INTEGER")]
        public int IntegerLiteral(Token<XPathToken> token)
        {
            return token.IntValue;
        }

        [Production("DecimalLiteral: DOT [d] INTEGER")]
        public decimal DecimalLiteral(Token<XPathToken> token)
        {
            return Decimal.Parse($".{token.Value}");
        }

        [Production("DecimalLiteral: INTEGER DOT [d] INTEGER*")] // INETEGER* migth not work here!
        public decimal DecimalLiteral(Token<XPathToken> token, List<Token<XPathToken>> list)
        {
            string afterDot = list.Any() ? list[0].Value : String.Empty;
            return Decimal.Parse($"{token.Value}.{afterDot}");
        }

        [Production("DoubleLiteral: DOUBLE")]
        public decimal DoubleLiteral(Token<XPathToken> token)
        {
            return Decimal.Parse(token.Value);
        }

        [Production("StringLiteral: STRING")]
        public string StringLiteral(Token<XPathToken> token)
        {
            return token.Value;
        }

        // [Production("URIQualifiedName: BracedURILiteral NCName")]
        // public int URIQualifiedName(string bacedUriLiteral, string ncName)
        // {
        //     return 5;
        // }

        // // [Operand]
        // [Production("BracedURILiteral: Q [d] LCURLYBRACKET [d] STRING RCURLYBRACKET [d]")]
        // public string BracedURILiteral(Token<XPathToken> token)
        // {
        //     return token.Value;
        // }

        // [Production("Comment: LCOMMENT [d] CommentContents* RCOMMENT [d]")]
        // [Production("Comment: LCOMMENT [d] Comment* RCOMMENT [d]")]
        // public int Comment()
        // {
        //     return 5;
        // }

        [Production("QName: DEFAULT")]
        public string QName(Token<XPathToken> token)
        {
            return token.Value;
        }

        // [Operand]
        // [Production("NCName: STRING")]
        // public string NCName(Token<XPathToken> token)
        // {
        //     return token.Value;
        // }

        // [Production("Char: STRING")]
        // public int Char()
        // {
        //     return 5;
        // }

        // [Production("CommentContents: STRING")]
        // public int CommentContents()
        // {
        //     return 5;
        // }
    }
}