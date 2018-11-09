using sly.parser.generator;

namespace netSchematron
{
    public class Test
    {
        public Test()
        {

        }

        [Production("Expr: ExprSingle (COMMA [d] ExprSingle)*")]
        public int Expr()
        {
            return 5;
        }

        [Production("ExprSingle: ForExpr")]
        [Production("ExprSingle: LetExpr")]
        [Production("ExprSingle: QuantifiedExpr")]
        [Production("ExprSingle: IfExpr")]
        [Production("ExprSingle: OrExp")]
        public int ExprSingle()
        {
            return 5;
        }

        [Production("ForExpr: SimpleForClause RETURN [d] ExprSingle")]
        public int ForExpr()
        {
            return 5;
        }

        [Production("SimpleForClause: SimpleForBinding (COMMA [d] SimpleForBinding)*")]
        public int SimpleForClause()
        {
            return 5;
        }

        [Production("SimpleForBinding: DOLAR [d] VarName IN [d] ExprSingle")]
        public int SimpleForBinding()
        {
            return 5;
        }

        [Production("LetExpr: SimpleLetClause RETURN [d] ExprSingle")]
        public int LetExpr()
        {
            return 5;
        }

        [Production("SimpleLetClause: LET [d] SimpleLetBinding (COMMA [d] SimpleLetBinding)*")]
        public int SimpleLetClause()
        {
            return 5;
        }

        [Production("SimpleLetBinding: DOLAR [d] VarName ASSIGN [d] ExprSingle")]
        public int SimpleLetBinding()
        {
            return 5;
        }

        [Production("QuantifiedExpr: SOMEEVERY [d] DOLAR [d] VarName IN [d] ExprSingle (COMMA [d] DOLAR [d] VarName IN [d] ExprSingle)* SATISFIES [d] ExprSingle")]
        public int QuantifiedExpr()
        {
            return 5;
        }

        [Production("IfExpr: IF [d] LPARENTHESIS [d] Expr RPARENTHESIS [d] THEN [d] ExprSingle ELSE [d] ExprSingle")]
        public int IfExpr()
        {
            return 5;
        }

        [Production("OrExpr: AndExpr (OR [d] AndExpr)*")]
        public int OrExpr()
        {
            return 5;
        }

        [Production("AndExpr: ComparisonExpr (AND [d] ComparsionExpr)*")]
        public int AndExpr()
        {
            return 5;
        }

        [Production("ComparsionExpr: StringConcatExpr ValueComp StringConcatExpr)?")]
        [Production("ComparsionExpr: StringConcatExpr GeneralComp StringConcatExpr)?")]
        [Production("ComparsionExpr: StringConcatExpr NodeComp StringConcatExpr)?")]
        public int ComparsionExpr()
        {
            return 5;
        }

        [Production("StringConcatExpr: RangeExpr (CONCAT [d] RangeExpr)*")]
        public int StringConcatExpr()
        {
            return 5;
        }

        [Production("RangeExpr: AddiveExpr (TO [d] AdditiveExpr)?")]
        public int RangeExpr()
        {
            return 5;
        }

        [Production("AdditiveExpr: MultiplicativeExpr (BMINUSPLUS MultiplicativeExpr)*")]
        public int AdditiveExpr()
        {
            return 5;
        }

        [Production("MultiplicativeExpr: UnionExpr (MULTIPLICATIVE UnionExpr)*")]
        public int MultiplicativeExpr()
        {
            return 5;
        }

        [Production("UnionExpr: IntersectExceptExpr (UNION [d] IntersectExceptExpr)*")]
        public int UnionExpr()
        {
            return 5;
        }

        [Production("IntersectExceptExpr: InstanceofExpr INTERSECTEXCEPT InstanceofExpr)*")]
        public int IntersectExceptExpr()
        {
            return 5;
        }

        [Production("InstanceofExpr: TreatExpr (INSTANCE [d] OF [d] SequenceType)?")]
        public int InstanceofExpr()
        {
            return 5;
        }

        [Production("TreatExpr: CastableExpr (TREAT [d] AS [d] SequenceType)?")]
        public int TreatExpr()
        {
            return 5;
        }

        [Production("CastableExpr: CastExpr (CASTABLE [d] AS [d] SingleType)?")]
        public int CastableExpr()
        {
            return 5;
        }

        [Production("CastExpr: ArrowExpr (CAST [d] AS [d] SingleType)?")]
        public int CastExpr()
        {
            return 5;
        }

        [Production("ArrowExpr: UnaryExpr (ARROW [d] ArrowFunctionSpecifier ArgumentList)*")]
        public int ArrowExpr()
        {
            return 5;
        }

        [Production("UnaryExpr: UMINUSPLUS* ValueExpr")]
        public int UnaryExpr()
        {
            return 5;
        }

        [Production("ValueExpr: SimpleMapExpr")]
        public int ValueExpr()
        {
            return 5;
        }

        [Production("GeneralComp: GENERALCOMPARATOR")]
        public int GeneralComp()
        {
            return 5;
        }

        [Production("ValueComp: VALUECOMPARATOR")]
        public int ValueComp()
        {
            return 5;
        }

        [Production("NodeComp: NODECOMPARATOR")]
        public int NodeComp()
        {
            return 5;
        }

        [Production("SimpleMapExpr: PathExpr (MAP [d] PathExpr)*")]
        public int SimpleMapExpr()
        {
            return 5;
        }

        [Production("PathExpr: PATH RelativePathExpr?")]
        [Production("PathExpr: ALLPATH RelativePathExpr")]
        [Production("PathExpr: RelativePathExpr")]
        public int PathExpr()
        {
            return 5;
        }

        [Production("RelativePathExpr: StepExpr (PATH StepExpr)* RelativePathExpr?")]
        [Production("RelativePathExpr: StepExpr (ALLPATH StepExpr)* RelativePathExpr?")]
        public int RelativePathExpr()
        {
            return 5;
        }

        [Production("StepExpr: PostfixExpr")]
        [Production("StepExpr: AxisStep")]
        public int StepExpr()
        {
            return 5;
        }

        [Production("AxisStep: ReverseStep PredicateList")]
        [Production("AxisStep: ForwardStep PredicateList")]
        public int AxisStep()
        {
            return 5;
        }

        [Production("ForwardStep: ForwardAxis NodeTest")]
        [Production("ForwardStep: AbbrevForwardStep")]
        public int ForwardStep()
        {
            return 5;
        }

        [Production("ForwardAxis: FWDAXIS DUALCOLON [d]")]
        public int ForwardAxis()
        {
            return 5;
        }

        // [Production("AbbrevForwardStep: [d] NodeTest")]
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

        // [Production("ReverseAxis: RVEAXIS [d]")]
        // public int ReverseAxis()
        // {
        //     return 5;
        // }

        // [Production("AbbrevReverseStep: [d]")]
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

        // [Production("Wildcard: [d]")]
        // [Production("Wildcard: NCName [d]")]
        // [Production("Wildcard: [d] NCName")]
        // [Production("Wildcard: BracedURILiteral [d]")]
        // public int Wildcard()
        // {
        //     return 5;
        // }

        // [Production("PostfixExpr: PrimaryExpr Predicate")]
        // [Production("PostfixExpr: PrimaryExpr ArgumentList")]
        // [Production("PostfixExpr: PrimaryExpr Lookup")]
        // public int PostfixExpr()
        // {
        //     return 5;
        // }

        // [Production("ArgumentList: [d] (Argument (COMMA Argument)*)? [d]")]
        // public int ArgumentList()
        // {
        //     return 5;
        // }

        // [Production("PredicateList: Predicate*")]
        // public int PredicateList()
        // {
        //     return 5;
        // }

        // [Production("Predicate: PREDICATE Expr PREDICATE")]
        // public int Predicate()
        // {
        //     return 5;
        // }

        // [Production("Lookup: PLOOKUP KeySpecifier")]
        // public int Lookup()
        // {
        //     return 5;
        // }

        // [Production("KeySpecifier: NCName")]
        // [Production("KeySpecifier: IntegerLiteral")]
        // [Production("KeySpecifier: ParenthesizedExpr")]
        // [Production("KeySpecifier: [d]")]
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

        // [Production("VarRef: [d] VarName")]
        // public int VarRef()
        // {
        //     return 5;
        // }

        // [Production("VarName: EQName")]
        // public int VarName()
        // {
        //     return 5;
        // }

        // [Production("ParenthesizedExpr: [d] Expr? [d]")]
        // public int ParenthesizedExpr()
        // {
        //     return 5;
        // }

        // [Production("ContextItemExpr: [d]")]
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

        // [Production("ArgumentPlaceholder: [d]")]
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

        // [Production("NamedFunctionRef: EQName [d] IntegerLiteral")]
        // public int NamedFunctionRef()
        // {
        //     return 5;
        // }

        // [Production("InlineFunctionExpr: [d] [d] ParamList? [d] ([d] SequenceType)? FunctionBody")]
        // public int InlineFunctionExpr()
        // {
        //     return 5;
        // }

        // [Production("MapConstructor: [d] [d] MapConstructorEntry (COMMA MapConstructorEntry)*)? [d]")]
        // public int MapConstructor()
        // {
        //     return 5;
        // }

        // [Production("MapConstructorEntry: MapKeyExpr [d] MapValueExpr")]
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

        // [Production("SquareArrayConstructor: PREDICATE (ExprSingle (COMMA ExprSingle)*)? PREDICATE")]
        // public int SquareArrayConstructor()
        // {
        //     return 5;
        // }

        // [Production("CurlyArrayConstructor: [d] EnclosedExpr")]
        // public int CurlyArrayConstructor()
        // {
        //     return 5;
        // }

        // [Production("UnaryLookup: [d] KeySpecifier")]
        // public int UnaryLookup()
        // {
        //     return 5;
        // }

        // [Production("SingleType: SimpleTypeName [d]")]
        // public int SingleType()
        // {
        //     return 5;
        // }

        // [Production("TypeDeclaration: [d] SequenceType")]
        // public int TypeDeclaration()
        // {
        //     return 5;
        // }

        // [Production("SequenceType: [d]")]
        // [Production("SequenceType: ItemType OccurrenceIndicator?")]
        // public int SequenceType()
        // {
        //     return 5;
        // }

        // [Production("OccurrenceIndicator: OCCURRENCEINDICATOR")]
        // public int OccurrenceIndicator()
        // {
        //     return 5;
        // }

        // [Production("ItemType: KindTest")]
        // [Production("ItemType: [d]")]
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

        // [Production("AnyKindTest: [d]")]
        // public int AnyKindTest()
        // {
        //     return 5;
        // }

        // [Production("DocumentTest: [d] ElementTest? [d]")]
        // [Production("DocumentTest: [d] SchemaElementTest? [d]")]
        // public int DocumentTest()
        // {
        //     return 5;
        // }

        // [Production("TextTest: [d]")]
        // public int TextTest()
        // {
        //     return 5;
        // }

        // [Production("CommentTest: [d]")]
        // public int CommentTest()
        // {
        //     return 5;
        // }

        // [Production("NamespaceNodeTest: [d]")]
        // public int NamespaceNodeTest()
        // {
        //     return 5;
        // }

        // [Production("PITest: [d] NCName? [d]")]
        // [Production("PITest: [d] StringLiteral? [d]")]
        // public int PITest()
        // {
        //     return 5;
        // }

        // [Production("AttributeTest: [d] (AttributeOrWildcard (COMMA TypeName)?)? [d]")]
        // public int AttributeTest()
        // {
        //     return 5;
        // }

        // [Production("AttributeOrWildcard: AttributeName")]
        // [Production("AttributeOrWildcard: [d]")]
        // public int AttributeOrWildcard()
        // {
        //     return 5;
        // }

        // [Production("SchemaAttributeTest: [d] AttributeDeclaration [d]")]
        // public int SchemaAttributeTest()
        // {
        //     return 5;
        // }

        // [Production("AttributeDeclaration: AttributeName")]
        // public int AttributeDeclaration()
        // {
        //     return 5;
        // }

        // [Production("ElementTest: [d] (ElementNameOrWildcard (COMMA TypeName [d]?)?)? [d]")]
        // public int ElementTest()
        // {
        //     return 5;
        // }

        // [Production("ElementNameOrWildcard: ElementName")]
        // [Production("ElementNameOrWildcard: [d]")]
        // public int ElementNameOrWildcard()
        // {
        //     return 5;
        // }

        // [Production("SchemaElementTest: [d] ElementDeclaration [d]")]
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

        // [Production("AnyFunctionTest: [d]")]
        // public int AnyFunctionTest()
        // {
        //     return 5;
        // }

        // [Production("TypedFunctionTest: [d] (SequenceType (COMMA SequenceType)*)? [d] SequenceType")]
        // public int TypedFunctionTest()
        // {
        //     return 5;
        // }

        // [Production("MapTest: AnyMapTest")]
        // [Production("MapTest: TypedMapTest")]
        // public int MapTest()
        // {
        //     return 5;
        // }

        // [Production("AnyMapTest: [d]")]
        // public int AnyMapTest()
        // {
        //     return 5;
        // }

        // [Production("TypedMapTest: [d] AtomicOrUnionType COMMA SequenceType [d]")]
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

        // [Production("AnyArrayTest: [d]")]
        // public int AnyArrayTest()
        // {
        //     return 5;
        // }

        // [Production("TypedArrayTest: [d] SequenceType [d]")]
        // public int TypedArrayTest()
        // {
        //     return 5;
        // }

        // [Production("ParenthesizedItemType: [d] ItemType [d]")]
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

        // [Production("IntegerLiteral: Digits")]
        // public int IntegerLiteral()
        // {
        //     return 5;
        // }

        // [Production("DecimalLiteral: [d] Digits")]
        // [Production("DecimalLiteral: Digits [d]")]
        // public int DecimalLiteral()
        // {
        //     return 5;
        // }

        // [Production("DoubleLiteral: . Digits")]
        // [Production("DoubleLiteral: [d] Digits")]
        // public int DoubleLiteral()
        // {
        //     return 5;
        // }

        // [Production("StringLiteral: Digits [d]")]
        // public int StringLiteral()
        // {
        //     return 5;
        // }

        // [Production("URIQualifiedName: BracedURILiteral NCName")]
        // public int URIQualifiedName()
        // {
        //     return 5;
        // }

        // [Production("BracedURILiteral: [d]")]
        // public int BracedURILiteral()
        // {
        //     return 5;
        // }

        // [Production("EscapeQuot: [d]")]
        // public int EscapeQuot()
        // {
        //     return 5;
        // }

        // [Production("EscapeApos: [d]")]
        // public int EscapeApos()
        // {
        //     return 5;
        // }

        // [Production("Comment: [d] CommentContents* [d]")]
        // [Production("Comment: [d] Comment* [d]")]
        // public int Comment()
        // {
        //     return 5;
        // }

        // [Production("QName: [d]")]
        // public int QName()
        // {
        //     return 5;
        // }

        // [Production("NCName: [d]")]
        // public int NCName()
        // {
        //     return 5;
        // }

        // [Production("Char: [d]")]
        // public int Char()
        // {
        //     return 5;
        // }

        // [Production("Digits: [d]")]
        // public int Digits()
        // {
        //     return 5;
        // }

        // [Production("CommentContents: [d]")]
        // public int CommentContents()
        // {
        //     return 5;
        // }















































    }
}