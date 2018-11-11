using System;
using System.Collections.Generic;
using System.Text;
using sly.lexer;
using sly.parser.generator;
using sly.parser.parser;

namespace netSchematron
{
    public class Test
    {
        public Test()
        {

        }

        [Production("XPath: Expr")]
        public string XPath(string expr)
        {
            return expr;
        }

        // [Production("ParamList: Param (COMMA [d] Param)*")]
        // public int ParamList()
        // {
        //     return 5;
        // }

        // [Production("Param: DOLAR [d] EQName TypeDeclaration?")]
        // public int Param()
        // {
        //     return 5;
        // }

        // [Production("FunctionBody: EnclosedExpr")]
        // public int FunctionBody()
        // {
        //     return 5;
        // }

        // [Production("EnclosedExpr: LCURLYBRACKET [d] Expr? RCURLYBRACKET [d]")]
        // public int EnclosedExpr()
        // {
        //     return 5;
        // }

        [Production("Expr: ExprSingle (COMMA [d] ExprSingle)*")]
        public string Expr(string exprSingle, List<Group<TokenEnum, string>> groupList)
        {
            StringBuilder result = new StringBuilder(exprSingle);

            foreach (Group<TokenEnum, string> group in groupList)
            {
                foreach (GroupItem<TokenEnum, string> item in group.Items)
                {
                    result.Append(",");
                    result.Append(item.Token.Value);
                }
            }

            return result.ToString();
        }

        // [Production("ExprSingle: ForExpr")]
        // [Production("ExprSingle: LetExpr")]
        // [Production("ExprSingle: QuantifiedExpr")]
        // [Production("ExprSingle: IfExpr")]
        [Production("ExprSingle: OrExpr")]
        public string ExprSingle(string expr)
        {
            return expr;
        }

        // [Production("ForExpr: SimpleForClause RETURN [d] ExprSingle")]
        // public int ForExpr()
        // {
        //     return 5;
        // }

        // [Production("SimpleForClause: SimpleForBinding (COMMA [d] SimpleForBinding)*")]
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
        public string OrExpr(string andExpr, List<Group<TokenEnum, string>> groupList)
        {
            StringBuilder result = new StringBuilder(andExpr);

            foreach (Group<TokenEnum, string> group in groupList)
            {
                foreach (GroupItem<TokenEnum, string> item in group.Items)
                {
                    result.Append("or");
                    result.Append(item.Value);
                }
            }

            return result.ToString();
        }

        [Production("AndExpr: ComparisonExpr (AND [d] ComparisonExpr)*")]
        public string AndExpr(string comparisonExpr, List<Group<TokenEnum, string>> groupList)
        {
            StringBuilder result = new StringBuilder(comparisonExpr);

            foreach (Group<TokenEnum, string> group in groupList)
            {
                foreach (GroupItem<TokenEnum, string> item in group.Items)
                {
                    result.Append("and");
                    result.Append(item.Value);
                }
            }

            return result.ToString();
        }

        // [Production("ComparisonExpr: StringConcatExpr (ValueComp StringConcatExpr)?")]
        [Production("ComparisonExpr: StringConcatExpr (GeneralComp StringConcatExpr)?")]
        // [Production("ComparisonExpr: StringConcatExpr (NodeComp StringConcatExpr)?")]
        public string ComparisonExpr(string stringConcatExpr, ValueOption<Group<TokenEnum, string>> option)
        {
            return "5";
        }

        [Production("StringConcatExpr: STRING")]
        public string StringConcatExpr(Token<TokenEnum> value)
        {
            return value.Value;
        }

        // [Production("RangeExpr: AdditiveExpr (TO [d] AdditiveExpr)?")]
        // public int RangeExpr()
        // {
        //     return 5;
        // }

        // [Production("AdditiveExpr: MultiplicativeExpr (BMINUSPLUS MultiplicativeExpr)*")]
        // public int AdditiveExpr()
        // {
        //     return 5;
        // }

        // [Production("MultiplicativeExpr: UnionExpr (MULTIPLICATIVE UnionExpr)*")]
        // public int MultiplicativeExpr()
        // {
        //     return 5;
        // }

        // [Production("UnionExpr: IntersectExceptExpr (UNION [d] IntersectExceptExpr)*")]
        // public int UnionExpr()
        // {
        //     return 5;
        // }

        // [Production("IntersectExceptExpr: InstanceofExpr (INTERSECTEXCEPT InstanceofExpr)*")]
        // public int IntersectExceptExpr()
        // {
        //     return 5;
        // }

        // [Production("InstanceofExpr: TreatExpr (INSTANCE [d] OF [d] SequenceType)?")]
        // public int InstanceofExpr()
        // {
        //     return 5;
        // }

        // [Production("TreatExpr: CastableExpr (TREAT [d] AS [d] SequenceType)?")]
        // public int TreatExpr()
        // {
        //     return 5;
        // }

        // [Production("CastableExpr: CastExpr (CASTABLE [d] AS [d] SingleType)?")]
        // public int CastableExpr()
        // {
        //     return 5;
        // }

        // [Production("CastExpr: ArrowExpr (CAST [d] AS [d] SingleType)?")]
        // public int CastExpr()
        // {
        //     return 5;
        // }

        // [Production("ArrowExpr: UnaryExpr (ARROW [d] ArrowFunctionSpecifier ArgumentList)*")]
        // public int ArrowExpr()
        // {
        //     return 5;
        // }

        // [Production("UnaryExpr: UMINUSPLUS* ValueExpr")]
        // public int UnaryExpr()
        // {
        //     return 5;
        // }

        // [Production("ValueExpr: SimpleMapExpr")]
        // public int ValueExpr()
        // {
        //     return 5;
        // }

        [Production("GeneralComp: GENERALCOMPARATOR")]
        public string GeneralComp(Token<TokenEnum> token)
        {
            // switch (token.Value)
            // {
            //     case "=":
            //     {
            //         break;
            //     }
            //     case "!=":
            //     {
            //         break;
            //     }
            //     case "<":
            //     {
            //         break;
            //     }
            //     case "<=":
            //     {
            //         break;
            //     }
            //     case ">":
            //     {
            //         break;
            //     }
            //     case ">=":
            //     {
            //         break;
            //     }
            //     default:
            //     {
            //         throw new Exception("Unexpected general comparator value");
            //     }
            // }
            return token.Value;
        }

        // [Production("ValueComp: VALUECOMPARATOR")]
        // public int ValueComp()
        // {
        //     return 5;
        // }

        // [Production("NodeComp: NODECOMPARATOR")]
        // public int NodeComp()
        // {
        //     return 5;
        // }

        // [Production("SimpleMapExpr: PathExpr (EXCLAMATION [d] PathExpr)*")]
        // public int SimpleMapExpr()
        // {
        //     return 5;
        // }

        // [Production("PathExpr: PATH RelativePathExpr?")]
        // [Production("PathExpr: ALLPATH RelativePathExpr")]
        // [Production("PathExpr: RelativePathExpr")]
        // public int PathExpr()
        // {
        //     return 5;
        // }

        // [Production("RelativePathExpr: StepExpr (PATH StepExpr)* RelativePathExpr?")]
        // [Production("RelativePathExpr: StepExpr (ALLPATH StepExpr)* RelativePathExpr?")]
        // public int RelativePathExpr()
        // {
        //     return 5;
        // }

        // [Production("StepExpr: PostfixExpr")]
        // [Production("StepExpr: AxisStep")]
        // public int StepExpr()
        // {
        //     return 5;
        // }

        // [Production("AxisStep: ReverseStep PredicateList")]
        // [Production("AxisStep: ForwardStep PredicateList")]
        // public int AxisStep()
        // {
        //     return 5;
        // }

        // [Production("ForwardStep: ForwardAxis NodeTest")]
        // [Production("ForwardStep: AbbrevForwardStep")]
        // public int ForwardStep()
        // {
        //     return 5;
        // }

        // [Production("ForwardAxis: FWDAXIS DOUBLECOLON [d]")]
        // public int ForwardAxis()
        // {
        //     return 5;
        // }

        // [Production("AbbrevForwardStep: AT [d] NodeTest")]
        // public int AbbrevForwardStep()
        // {
        //     return 5;
        // }

        // [Production("ReverseStep: ReverseAxis NodeTest")]
        // [Production("ReverseStep: AbbrevReverseStep")]
        // public int ReverseStep()
        // {
        //     return 5;
        // }

        // [Production("ReverseAxis: RVEAXIS DOUBLECOLON [d]")]
        // public int ReverseAxis()
        // {
        //     return 5;
        // }

        // [Production("AbbrevReverseStep: DOUBLEDOT [d]")]
        // public int AbbrevReverseStep()
        // {
        //     return 5;
        // }

        // [Production("NodeTest: KindTest")]
        // [Production("NodeTest: NameTest")]
        // public int NodeTest()
        // {
        //     return 5;
        // }

        // [Production("NameTest: EQName")]
        // [Production("NameTest: Wildcard")]
        // public int NameTest()
        // {
        //     return 5;
        // }

        // [Production("Wildcard: WILDCARD [d]")]
        // [Production("Wildcard: NCName COLONWILDCARD [d]")]
        // [Production("Wildcard: WILDCARDCOLON [d] NCName")]
        // [Production("Wildcard: BracedURILiteral WILDCARD [d]")]
        // public int Wildcard()
        // {
        //     return 5;
        // }

        // [Production("PostfixExpr: PrimaryExpr Predicate*")]
        // [Production("PostfixExpr: PrimaryExpr ArgumentList*")]
        // [Production("PostfixExpr: PrimaryExpr Lookup*")]
        // public int PostfixExpr()
        // {
        //     return 5;
        // }

        // [Production("ArgumentList: LPARENTHESIS [d] (Argument ExtraArgumentList)? RPARENTHESIS [d]")]
        // public int ArgumentList()
        // {
        //     return 5;
        // }

        // [Production("ExtraArgumentList: (COMMA Argument)*")]
        // public int ExtraArgumentList()
        // {
        //     return 5;
        // }

        // [Production("PredicateList: Predicate*")]
        // public int PredicateList()
        // {
        //     return 5;
        // }

        // [Production("Predicate: LSQRBRACKET [d] Expr RSQRBRACKET [d]")]
        // public int Predicate()
        // {
        //     return 5;
        // }

        // [Production("Lookup: PLOOKUP [d] KeySpecifier")]
        // public int Lookup()
        // {
        //     return 5;
        // }

        // [Production("KeySpecifier: NCName")]
        // [Production("KeySpecifier: IntegerLiteral")]
        // [Production("KeySpecifier: ParenthesizedExpr")]
        // [Production("KeySpecifier: WILDCARD [d]")]
        // public int KeySpecifier()
        // {
        //     return 5;
        // }

        // [Production("ArrowFunctionSpecifier: EQName")]
        // [Production("ArrowFunctionSpecifier: VarRef")]
        // [Production("ArrowFunctionSpecifier: ParenthesizedExpr")]
        // public int ArrowFunctionSpecifier()
        // {
        //     return 5;
        // }

        // [Production("PrimaryExpr: Literal")]
        // [Production("PrimaryExpr: VarRef")]
        // [Production("PrimaryExpr: ParenthesizedExpr")]
        // [Production("PrimaryExpr: ContextItemExpr")]
        // [Production("PrimaryExpr: FunctionCall")]
        // [Production("PrimaryExpr: FunctionItemExpr")]
        // [Production("PrimaryExpr: MapConstructor")]
        // [Production("PrimaryExpr: ArrayConstructor")]
        // [Production("PrimaryExpr: UnaryLookup")]
        // public int PrimaryExpr()
        // {
        //     return 5;
        // }

        // [Production("Literal: NumbericLiteral")]
        // [Production("Literal: StringLiteral")]
        // public int Literal()
        // {
        //     return 5;
        // }

        // [Production("NumbericLiteral: IntegerLiteral")]
        // [Production("NumbericLiteral: DecimalLiteral")]
        // [Production("NumbericLiteral: DoubleLiteral")]
        // public int NumbericLiteral()
        // {
        //     return 5;
        // }

        // [Production("VarRef: DOLAR [d] VarName")]
        // public int VarRef()
        // {
        //     return 5;
        // }

        // [Production("VarName: EQName")]
        // public int VarName()
        // {
        //     return 5;
        // }

        // [Production("ParenthesizedExpr: LPARENTHESIS [d] Expr? RPARENTHESIS [d]")]
        // public int ParenthesizedExpr()
        // {
        //     return 5;
        // }

        // [Production("ContextItemExpr: CURRENTCONTEXT [d]")]
        // public int ContextItemExpr()
        // {
        //     return 5;
        // }

        // [Production("FunctionCall: EQName ArgumentList")]
        // public int FunctionCall()
        // {
        //     return 5;
        // }

        // [Production("Argument: ExprSingle")]
        // [Production("Argument: ArgumentPlaceholder")]
        // public int Argument()
        // {
        //     return 5;
        // }

        // [Production("ArgumentPlaceholder: ARGUMENTPLACEHOLDER [d]")]
        // public int ArgumentPlaceholder()
        // {
        //     return 5;
        // }

        // [Production("FunctionItemExpr: NamedFunctionRef")]
        // [Production("FunctionItemExpr: InlineFunctionExpr")]
        // public int FunctionItemExpr()
        // {
        //     return 5;
        // }

        // [Production("NamedFunctionRef: EQName SQUARE [d] IntegerLiteral")]
        // public int NamedFunctionRef()
        // {
        //     return 5;
        // }

        // [Production("InlineFunctionExpr: FUNCTION [d] LPARENTHESIS [d] ParamList? RPARENTHESIS [d] (AS [d] SequenceType)? FunctionBody")]
        // public int InlineFunctionExpr()
        // {
        //     return 5;
        // }

        // [Production("MapConstructor: MAP [d] LCURLYBRACKET [d] (MapConstructorEntry ExtraMapConstructor)? RCURLYBRACKET [d]")]
        // public int MapConstructor()
        // {
        //     return 5;
        // }

        // [Production("ExtraMapConstructor: (COMMA [d] MapConstructorEntry)*")]
        // public int ExtraMapConstructor()
        // {
        //     return 5;
        // }

        // [Production("MapConstructorEntry: MapKeyExpr COLON [d] MapValueExpr")]
        // public int MapConstructorEntry()
        // {
        //     return 5;
        // }

        // [Production("MapKeyExpr: ExprSingle")]
        // public int MapKeyExpr()
        // {
        //     return 5;
        // }

        // [Production("MapValueExpr: ExprSingle")]
        // public int MapValueExpr()
        // {
        //     return 5;
        // }

        // [Production("ArrayConstructor: SquareArrayConstructor")]
        // [Production("ArrayConstructor: CurlyArrayConstructor")]
        // public int ArrayConstructor()
        // {
        //     return 5;
        // }

        // [Production("SquareArrayConstructor: LSQRBRACKET [d] (ExprSingle ExtraSquareArrayConstructor)? RSQRBRACKET [d]")]
        // public int SquareArrayConstructor()
        // {
        //     return 5;
        // }

        // [Production("ExtraSquareArrayConstructor: (COMMA [d] ExprSingle)*")]
        // public int ExtraSquareArrayConstructor()
        // {
        //     return 5;
        // }

        // [Production("CurlyArrayConstructor: ARRAY [d] EnclosedExpr")]
        // public int CurlyArrayConstructor()
        // {
        //     return 5;
        // }

        // [Production("UnaryLookup: ULOOKUP [d] KeySpecifier")]
        // public int UnaryLookup()
        // {
        //     return 5;
        // }

        // [Production("SingleType: SimpleTypeName ZEROORONE? [d]")]
        // public int SingleType()
        // {
        //     return 5;
        // }

        // [Production("TypeDeclaration: AS [d] SequenceType")]
        // public int TypeDeclaration()
        // {
        //     return 5;
        // }

        // [Production("SequenceType: EMPTYSEQUENCE [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // [Production("SequenceType: ItemType OccurrenceIndicator?")]
        // public int SequenceType()
        // {
        //     return 5;
        // }

        // [Production("OccurrenceIndicator: ZEROORONE")]
        // [Production("OccurrenceIndicator: ZEROORMORE")]
        // [Production("OccurrenceIndicator: ONERORMORE")]
        // public int OccurrenceIndicator()
        // {
        //     return 5;
        // }

        // [Production("ItemType: KindTest")]
        // [Production("ItemType: ITEM [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // [Production("ItemType: FunctionTest")]
        // [Production("ItemType: MapTest")]
        // [Production("ItemType: ArrayTest")]
        // [Production("ItemType: AtomicOrUnionType")]
        // [Production("ItemType: ParenthesizedItemType")]
        // public int ItemType()
        // {
        //     return 5;
        // }

        // [Production("AtomicOrUnionType: EQName")]
        // public int AtomicOrUnionType()
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
        // public int KindTest()
        // {
        //     return 5;
        // }

        // [Production("AnyKindTest: NODE [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int AnyKindTest()
        // {
        //     return 5;
        // }

        // [Production("DocumentTest: DOCUMENTNODE LPARENTHESIS [d] ElementTest? RPARENTHESIS [d]")]
        // [Production("DocumentTest: DOCUMENTNODE LPARENTHESIS [d] SchemaElementTest? RPARENTHESIS [d]")]
        // public int DocumentTest()
        // {
        //     return 5;
        // }

        // [Production("TextTest: TEXT [d] LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int TextTest()
        // {
        //     return 5;
        // }

        // [Production("CommentTest: COMMENT LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int CommentTest()
        // {
        //     return 5;
        // }

        // [Production("NamespaceNodeTest: NAMESPACENODE LPARENTHESIS [d] RPARENTHESIS [d]")]
        // public int NamespaceNodeTest()
        // {
        //     return 5;
        // }

        // [Production("PITest: PROCESSINGINSTRUCTION [d] LPARENTHESIS [d] NCName? RPARENTHESIS [d]")]
        // [Production("PITest: PROCESSINGINSTRUCTION [d] LPARENTHESIS [d] StringLiteral? RPARENTHESIS [d]")]
        // public int PITest()
        // {
        //     return 5;
        // }

        // [Production("AttributeTest: ATTRIBUTE [d] LPARENTHESIS [d] (AttributeNameOrWildcard ExtraAttributeTest)? RPARENTHESIS [d]")]
        // public int AttributeTest()
        // {
        //     return 5;
        // }

        // [Production("ExtraAttributeTest: (COMMA [d] TypeName)?")]
        // public int ExtraAttributeTest()
        // {
        //     return 5;
        // }

        // [Production("AttributeNameOrWildcard: AttributeName")]
        // [Production("AttributeNameOrWildcard: WILDCARD [d]")]
        // public int AttributeNameOrWildcard()
        // {
        //     return 5;
        // }

        // [Production("SchemaAttributeTest: LPARENTHESIS [d] AttributeDeclaration RPARENTHESIS [d]")]
        // public int SchemaAttributeTest()
        // {
        //     return 5;
        // }

        // [Production("AttributeDeclaration: AttributeName")]
        // public int AttributeDeclaration()
        // {
        //     return 5;
        // }

        // [Production("ElementTest: ELEMENT [d] LPARENTHESIS [d] (ElementNameOrWildcard ExtraElementTest)? RPARENTHESIS [d]")]
        // public int ElementTest()
        // {
        //     return 5;
        // }

        // [Production("ExtraElementTest: (COMMA [d] TypeName X [d])?")]
        // public int ExtraElementTest()
        // {
        //     return 5;
        // }

        // [Production("X: ZEROORONE?")]
        // public int X()
        // {
        //     return 5;
        // }

        // [Production("ElementNameOrWildcard: ElementName")]
        // [Production("ElementNameOrWildcard: WILDCARD [d]")]
        // public int ElementNameOrWildcard()
        // {
        //     return 5;
        // }

        // [Production("SchemaElementTest: SCHEMAELEMENT [d] LPARENTHESIS [d] ElementDeclaration RPARENTHESIS [d]")]
        // public int SchemaElementTest()
        // {
        //     return 5;
        // }

        // [Production("ElementDeclaration: ElementName")]
        // public int ElementDeclaration()
        // {
        //     return 5;
        // }

        // [Production("AttributeName: EQName")]
        // public int AttributeName()
        // {
        //     return 5;
        // }

        // [Production("ElementName: EQName")]
        // public int ElementName()
        // {
        //     return 5;
        // }

        // [Production("SimpleTypeName: TypeName")]
        // public int SimpleTypeName()
        // {
        //     return 5;
        // }

        // [Production("TypeName: EQName")]
        // public int TypeName()
        // {
        //     return 5;
        // }

        // [Production("FunctionTest: AnyFunctionTest")]
        // [Production("FunctionTest: TypedFunctionTest")]
        // public int FunctionTest()
        // {
        //     return 5;
        // }

        // [Production("AnyFunctionTest: FUNCTION [d] LPARENTHESIS [d] ZEROORMORE RPARENTHESIS [d]")]
        // public int AnyFunctionTest()
        // {
        //     return 5;
        // }

        // [Production("TypedFunctionTest: FUNCTION [d] LPARENTHESIS [d] (SequenceType ExtraTypedFunctionTest)? RPARENTHESIS [d] AS [d] SequenceType")]
        // public int TypedFunctionTest()
        // {
        //     return 5;
        // }

        // [Production("ExtraTypedFunctionTest: (COMMA [d] SequenceType)*")]
        // public int ExtraTypedFunctionTest()
        // {
        //     return 5;
        // }

        // [Production("MapTest: AnyMapTest")]
        // [Production("MapTest: TypedMapTest")]
        // public int MapTest()
        // {
        //     return 5;
        // }

        // [Production("AnyMapTest: MAP [d] LPARENTHESIS [d] ZEROORMORE RPARENTHESIS [d]")]
        // public int AnyMapTest()
        // {
        //     return 5;
        // }

        // [Production("TypedMapTest: MAP [d] LPARENTHESIS [d] AtomicOrUnionType COMMA [d] SequenceType RPARENTHESIS [d]")]
        // public int TypedMapTest()
        // {
        //     return 5;
        // }

        // [Production("ArrayTest: AnyArrayTest")]
        // [Production("ArrayTest: TypedArrayTest")]
        // public int ArrayTest()
        // {
        //     return 5;
        // }

        // [Production("AnyArrayTest: ARRAY [d] LPARENTHESIS [d] ZEROORMORE RPARENTHESIS [d]")]
        // public int AnyArrayTest()
        // {
        //     return 5;
        // }

        // [Production("TypedArrayTest: ARRAY [d] LPARENTHESIS [d] SequenceType RPARENTHESIS [d]")]
        // public int TypedArrayTest()
        // {
        //     return 5;
        // }

        // [Production("ParenthesizedItemType: LPARENTHESIS [d] ItemType RPARENTHESIS [d]")]
        // public int ParenthesizedItemType()
        // {
        //     return 5;
        // }

        // [Production("EQName: QName")]
        // [Production("EQName: URIQualifiedName")]
        // public int EQName()
        // {
        //     return 5;
        // }

        // [Production("IntegerLiteral: INTEGER")]
        // public int IntegerLiteral()
        // {
        //     return 5;
        // }

        // [Production("DecimalLiteral: DOT [d] INTEGER")]
        // [Production("DecimalLiteral: INTEGER DOT [d] INTEGER*")] // INETEGER* migth not work here!
        // public int DecimalLiteral()
        // {
        //     return 5;
        // }

        // [Production("DoubleLiteral: DOUBLE")]
        // public int DoubleLiteral()
        // {
        //     return 5;
        // }

        // [Production("StringLiteral: STRING")]
        // public int StringLiteral()
        // {
        //     return 5;
        // }

        // [Production("URIQualifiedName: BracedURILiteral NCName")]
        // public int URIQualifiedName()
        // {
        //     return 5;
        // }

        // [Production("BracedURILiteral: Q [d] LCURLYBRACKET [d] STRING RCURLYBRACKET [d]")]
        // public int BracedURILiteral()
        // {
        //     return 5;
        // }

        // [Production("Comment: LCOMMENT [d] CommentContents* RCOMMENT [d]")]
        // [Production("Comment: LCOMMENT [d] Comment* RCOMMENT [d]")]
        // public int Comment()
        // {
        //     return 5;
        // }

        // [Production("QName: STRING")]
        // public int QName()
        // {
        //     return 5;
        // }

        // [Production("NCName: STRING")]
        // public int NCName()
        // {
        //     return 5;
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