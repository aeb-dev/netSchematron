using sly.parser.generator;

namespace netSchematron
{
    public class Test
    {
        public Test()
        {

        }

        [Production("Expr: ExprSingle (COMMA ExprSingle)*")]
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

        [Production("ForExpr: SimpleForClause [d] ExprSingle")]
        public int ForExpr()
        {
            return 5;
        }

        [Production("LetExpr: SimpleLetClause [d] ExprSingle")]
        public int LetExpr()
        {
            return 5;
        }

        [Production("QuantifiedExpr: SOMEEVERY [d] VarName [d] ExprSingle (COMMA [d] VarName [d] ExprSingle)* [d] ExprSingle")]
        public int QuantifiedExpr()
        {
            return 5;
        }

        [Production("IfExpr: IF [d] Expr [d] [d] ExprSingle [d] ExpreSingle")]
        public int IfExpr()
        {
            return 5;
        }

        [Production("OrExpr: AndExpr (OR AndExpr)*")]
        public int OrExpr()
        {
            return 5;
        }

        [Production("SimpleForClause: FOR SimpleForBinding (COMMA SimpleForBinding)*")]
        public int SimpleForClause()
        {
            return 5;
        }

        [Production("SimpleLetClause: LET SimpleLetBinding (COMMA SimpleLetBinding)*")]
        public int SimpleLetClause()
        {
            return 5;
        }

        [Production("AndExpr: ComparisonExpr (AND ComparsionExpr)*")]
        public int AndExpr()
        {
            return 5;
        }

        [Production("SimpleForBinding: [d] VarName [d] ExprSingle")]
        public int SimpleForBinding()
        {
            return 5;
        }

        [Production("SimpleLetBinding: [d] VarName [d] ExprSingle")]
        public int SimpleLetBinding()
        {
            return 5;
        }

        [Production("ComparsionExpr: StringConcatExpr (ValueComp) StringConcatExpr)?")]
        [Production("ComparsionExpr: StringConcatExpr (GeneralComp) StringConcatExpr)?")]
        [Production("ComparsionExpr: StringConcatExpr (NodeComp) StringConcatExpr)?")]
        public int ComparsionExpr()
        {
            return 5;
        }

        [Production("VarName: EQName")]
        public int VarName()
        {
            return 5;
        }

        [Production("StringConcatExpr: RangeExpr (CONCAT RangeExpr)*")]
        public int StringConcatExpr()
        {
            return 5;
        }

        [Production("EQName: QName")]
        [Production("EQName: URIQualifiedName")]
        public int EQName()
        {
            return 5;
        }

        [Production("RangeExpr: AddiveExpr (TO AdditiveExpr)?")]
        public int RangeExpr()
        {
            return 5;
        }

        [Production("QName: PrefixedName")]
        [Production("QName: UnprefixedName")]
        public int QName()
        {
            return 5;
        }

        [Production("URIQualifiedName: BracedURILiteral NCNAME")]
        public int URIQualifiedName()
        {
            return 5;
        }

        [Production("AdditiveExpr: MultiplicativeExpr (BMINUSPLUS MultiplicativeExpr)*")]
        public int AdditiveExpr()
        {
            return 5;
        }

        [Production("PrefixedName: Prefix [d] LocalPart")]
        public int PrefixedName()
        {
            return 5;
        }

        [Production("UnprefixedName: LocalPart")]
        public int UnprefixedName()
        {
            return 5;
        }

        [Production("MultiplicativeExpr: UnionExpr ((TIMES | DIV | IDIV | MOD) UnionExpr)*")]
        public int MultiplicativeExpr()
        {
            return 5;
        }

        [Production("BracedURILiteral: [d] [d] BRACEDURILITERAL [d]")]
        public int BracedURILiteral()
        {
            return 5;
        }

        [Production("Prefix: NCNAME")]
        public string Prefix()
        {
            return 5;
        }

        [Production("UnionExpr: IntersectExceptExpr (UNION IntersectExceptExpr)*")]
        public int UnionExpr()
        {
            return 5;
        }

        [Production("LocalPart: NCNAME")]
        public string LocalPart(string )
        {
            return 5;
        }

        // [Production("IntersectExceptExpr: InstanceofExpr (INTERSECT | EXCEPT) InstanceofExpr)*")]
        // public int IntersectExceptExpr()
        // {
        //     return 5;
        // }

        // [Production("Name: NameStartChar (NameChar)*")]
        // public int Name()
        // {
        //     return 5;
        // }

        // [Production("Char: #x9 | #xA | #xD | [#x20-#xD7FF] | [#xE000-#xFFFD] | [#x10000-#x10FFFF]")]
        // public int Char()
        // {
        //     return 5;
        // }

        // [Production("InstanceofExpr: TreatExpr ('instance' 'of' SequenceType)?")]
        // public int InstanceofExpr()
        // {
        //     return 5;
        // }

        // [Production("NameStartChar: ':' | [A-Z] | '_' | [a-z] | [#xC0-#xD6] | [#xD8-#xF6] | [#xF8-#x2FF] | [#x370-#x37D] | [#x37F-#x1FFF] | [#x200C-#x200D] | [#x2070-#x218F] | [#x2C00-#x2FEF] | [#x3001-#xD7FF] | [#xF900-#xFDCF] | [#xFDF0-#xFFFD] | [#x10000-#xEFFFF]")]
        // public int NameStartChar()
        // {
        //     return 5;
        // }

        // [Production("NameChar: NameStartChar | '-' | '.' | [0-9] | #xB7 | [#x0300-#x036F] | [#x203F-#x2040]")]
        // public int NameChar()
        // {
        //     return 5;
        // }

        // [Production("TreatExpr: CastableExpr ('treat' 'of' SequenceType)?")]
        // public int TreatExpr()
        // {
        //     return 5;
        // }

        // [Production("SequenceType: ('empty-sequence' LPARANTHESIS RPARANTHESIS) | (ItemType OccurenceIndicator?)")]
        // public int SequenceType()
        // {
        //     return 5;
        // }

        // [Production("CastableExpr: CastExpr (CASTABLE AS SingleType)?")]
        // public int CastableExpr()
        // {
        //     return 5;
        // }

        // [Production("ItemType: KindTest | ('item' LPARANTHESIS RPARANTHESIS) | FunctionTest | MapTest | ArrayTest | AtomicOrUnionType | ParenthesizedItemType")]
        // public int ItemType()
        // {
        //     return 5;
        // }

        // [Production("OccurenceIndicator: '?' '*' '+'")]
        // public int OccurenceIndicator()
        // {
        //     return 5;
        // }

        // [Production("CastExpr: ArrowExpr (CAST AS SingleType)?")]
        // public int CastExpr()
        // {
        //     return 5;
        // }

        // [Production("KindTest: DocumentTest | ElementTest | AttributeTest | SchemaElementTest | SchemaAttributeTest | PITest | CommentTest | TextTest | NamespaceNodeTest | AnyKindTest")]
        // public int KindTest()
        // {
        //     return 5;
        // }

        // [Production("FunctionTest: AnyFunctionTest | TypedFunctionTest")]
        // public int FunctionTest()
        // {
        //     return 5;
        // }

        // [Production("MapTest: AnyMapTest | TypedMaptest")]
        // public int MapTest()
        // {
        //     return 5;
        // }

        // [Production("ArrayTest: AnyArrayTest | TypedArrayTest")]
        // public int ArrayTest()
        // {
        //     return 5;
        // }

        // [Production("AtomicOrUnionType: EQName")]
        // public int AtomicOrUnionType()
        // {
        //     return 5;
        // }

        // [Production("ParenthesizedItemType: LPARANTHESIS ItemType RPARATHESIS")]
        // public int ParenthesizedItemType()
        // {
        //     return 5;
        // }

        // [Production("ArrowExpr: UnaryExpr (ARROW ArrowFunctionSpecifier ArgumentList)*")]
        // public int ArrowExpr()
        // {
        //     return 5;
        // }

        // [Production("DocumentTest: 'document-node' LPARANTHESIS (ElementTest | SchemaElementTest)? RPARANTHESIS")]
        // public int DocumentTest()
        // {
        //     return 5;
        // }

        // [Production("ElementTest: 'element' LPARANTHESIS (ElementNameOrWildCard (COMMA TypeName '?'?)?)? RPARANTHESIS")]
        // public int ElementTest()
        // {
        //     return 5;
        // }

        // [Production("AttributeTest: 'attribute' LPARANTHESIS (AttribNameOrWildcard (COMMA TypeName)?)? RPARANTHESIS")]
        // public int AttributeTest()
        // {
        //     return 5;
        // }

        // [Production("SchemaElementTest: 'schema-element' LPARANTHESIS ElementDeclaration RPARANTHESIS")]
        // public int SchemaElementTest()
        // {
        //     return 5;
        // }

        // [Production("SchemaAttributeTest: 'schema-attribute' LPARANTHESIS AttributeDeclaration RPARANTHESIS")]
        // public int SchemaAttributeTest()
        // {
        //     return 5;
        // }

        // [Production("PITest: 'process-instruction' LPARANTHESIS (NCName | StringLiteral)? RPARANTHESIS")]
        // public int PITest()
        // {
        //     return 5;
        // }

        // [Production("CommentTest: 'comment' LPARANTHESIS RPARANTHESIS")]
        // public int CommentTest()
        // {
        //     return 5;
        // }

        // [Production("TextTest: 'text' LPARANTHESIS RPARANTHESIS")]
        // public int TextTest()
        // {
        //     return 5;
        // }

        // [Production("NamespaceNodeTest: 'namespace-node' LPARANTHESIS RPARANTHESIS")]
        // public int NamespaceNodeTest()
        // {
        //     return 5;
        // }

        // [Production("AnyKindTest: 'node' LPARANTHESIS RPARANTHESIS")]
        // public int AnyKindTest()
        // {
        //     return 5;
        // }

        // [Production("AnyFunctionTest: 'function' LPARANTHESIS '*' RPARANTHESIS")]
        // public int AnyFunctionTest()
        // {
        //     return 5;
        // }

        // [Production("TypedFunctionTest: 'function' LPARANTHESIS (SequenceType (COMMA SequenceType)*)? RPARANTHESIS 'as' SequenceType")]
        // public int TypedFunctionTest()
        // {
        //     return 5;
        // }

        // [Production("AnyMapTest: 'map' LPARANTHESIS '*' RPARANTHESIS")]
        // public int AnyMapTest()
        // {
        //     return 5;
        // }

        // [Production("TypedMaptest: 'map' LPARANTHESIS AtomicOrUnionType COMMA SequenceType RPARANTHESIS")]
        // public int TypedMaptest()
        // {
        //     return 5;
        // }

        // [Production("AnyArrayTest: 'array' LPARANTHESIS '*' RPARANTHESIS")]
        // public int AnyArrayTest()
        // {
        //     return 5;
        // }

        // [Production("TypedArrayTest: 'array' LPARANTHESIS SequenceType RPARANTHESIS")]
        // public int TypedArrayTest()
        // {
        //     return 5;
        // }

        // [Production("UnaryExpr: (UMINUS | UPLUS)- ValueExpr")]
        // public int UnaryExpr()
        // {
        //     return 5;
        // }

        // [Production("ArrowFunctionSpecifier: EQName | VarRef | ParenthesizedExpr")]
        // public int ArrowFunctionSpecifier()
        // {
        //     return 5;
        // }

        // [Production("ArgumentList: LPARANTHESIS (Argument (COMMA Argument)*)? RPARANTHESIS")]
        // public int ArgumentList()
        // {
        //     return 5;
        // }

        // [Production("ElementNameOrWildCard: ElementName | '*'")]
        // public int ElementNameOrWildCard()
        // {
        //     return 5;
        // }

        // [Production("TypeName: EQName")]
        // public int TypeName()
        // {
        //     return 5;
        // }

        // [Production("AttribNameOrWildcard: AttributeName | '*'")]
        // public int AttribNameOrWildcard()
        // {
        //     return 5;
        // }

        // [Production("ElementDeclaration: ElementName")]
        // public int ElementDeclaration()
        // {
        //     return 5;
        // }

        // [Production("AttributeDeclaration: AttributeName")]
        // public int AttributeDeclaration()
        // {
        //     return 5;
        // }

        // [Production("StringLiteral: (DOUBLEQUOTE (EscapeQuot | [^\"])* DOUBLEQUOTE) | (SINGLEQUOTE (EscapeApos | [^'])* DOUBLEQUOTE)")]
        // public int StringLiteral()
        // {
        //     return 5;
        // }
    }
}