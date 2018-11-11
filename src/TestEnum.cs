using sly.lexer;

namespace netSchematron
{
    public enum TokenEnum
    {
        [Lexeme(GenericToken.SugarToken, ",")]
        COMMA = 1,
        [Lexeme(GenericToken.KeyWord, "for")]
        FOR = 2,
        [Lexeme(GenericToken.KeyWord, "let")]
        LET = 2,
        [Lexeme(GenericToken.KeyWord, "some")]
        [Lexeme(GenericToken.KeyWord, "every")]
        SOMEEVERY = 2,
        [Lexeme(GenericToken.KeyWord, "if")]
        IF = 2,
        [Lexeme(GenericToken.KeyWord, "or")]
        OR = 3,
        [Lexeme(GenericToken.KeyWord, "and")]
        AND = 4,
        [Lexeme(GenericToken.KeyWord, "eq")]
        [Lexeme(GenericToken.KeyWord, "ne")]
        [Lexeme(GenericToken.KeyWord, "lt")]
        [Lexeme(GenericToken.KeyWord, "le")]
        [Lexeme(GenericToken.KeyWord, "gt")]
        [Lexeme(GenericToken.KeyWord, "ge")]
        VALUECOMPARATOR = 5,
        [Lexeme(GenericToken.SugarToken, "=")]
        [Lexeme(GenericToken.SugarToken, "!=")]
        [Lexeme(GenericToken.SugarToken, "<")]
        [Lexeme(GenericToken.SugarToken, "<=")]
        [Lexeme(GenericToken.SugarToken, ">")]
        [Lexeme(GenericToken.SugarToken, ">=")]
        GENERALCOMPARATOR = 5,
        [Lexeme(GenericToken.KeyWord, "is")]
        [Lexeme(GenericToken.SugarToken, "<<")]
        [Lexeme(GenericToken.SugarToken, ">>")]
        NODECOMPARATOR = 5,
        [Lexeme(GenericToken.SugarToken, "||")]
        CONCAT = 6,
        [Lexeme(GenericToken.KeyWord, "to")]
        TO = 7,
        [Lexeme(GenericToken.SugarToken, "+")]
        [Lexeme(GenericToken.SugarToken, "-")]
        BMINUSPLUS = 8,
        [Lexeme(GenericToken.SugarToken, "*")]
        [Lexeme(GenericToken.KeyWord, "div")]
        [Lexeme(GenericToken.KeyWord, "idiv")]
        [Lexeme(GenericToken.KeyWord, "mod")]
        MULTIPLICATIVE = 9,
        [Lexeme(GenericToken.SugarToken, "|")]
        [Lexeme(GenericToken.KeyWord, "union")]
        UNION = 10,
        [Lexeme(GenericToken.KeyWord, "intersect")]
        [Lexeme(GenericToken.KeyWord, "except")]
        INTERSECTEXCEPT = 11,
        [Lexeme(GenericToken.KeyWord, "instance")]
        INSTANCE = 12,
        [Lexeme(GenericToken.KeyWord, "treat")]
        TREAT = 13,
        [Lexeme(GenericToken.KeyWord, "castable")]
        CASTABLE = 14,
        [Lexeme(GenericToken.KeyWord, "cast")]
        CAST = 15,
        [Lexeme(GenericToken.SugarToken, "=>")]
        ARROW = 16,
        [Lexeme(GenericToken.SugarToken, "+")]
        [Lexeme(GenericToken.SugarToken, "-")]
        UMINUSPLUS = 17,
        [Lexeme(GenericToken.SugarToken, "!")]
        EXCLAMATION = 18,
        [Lexeme(GenericToken.SugarToken, "/")]
        PATH = 19,
        [Lexeme(GenericToken.SugarToken, "//")]
        ALLPATH = 19,
        [Lexeme(GenericToken.SugarToken, "[")]
        LSQRBRACKET = 20,
        [Lexeme(GenericToken.SugarToken, "]")]
        RSQRBRACKET = 20,
        [Lexeme(GenericToken.SugarToken, "?")]
        PLOOKUP = 20,
        [Lexeme(GenericToken.SugarToken, "?")]
        ULOOKUP = 21,
        [Lexeme(GenericToken.KeyWord, "return")]
        RETURN,
        [Lexeme(GenericToken.SugarToken, "$")]
        DOLAR,
        [Lexeme(GenericToken.KeyWord, "in")]
        IN,
        [Lexeme(GenericToken.SugarToken, ":=")]
        ASSIGN,
        [Lexeme(GenericToken.KeyWord, "satisfies")]
        SATISFIES,
        [Lexeme(GenericToken.SugarToken, "(")]
        LPARENTHESIS,
        [Lexeme(GenericToken.SugarToken, ")")]
        RPARENTHESIS,
        [Lexeme(GenericToken.KeyWord, "then")]
        THEN,
        [Lexeme(GenericToken.KeyWord, "else")]
        ELSE,
        [Lexeme(GenericToken.KeyWord, "of")]
        OF,
        [Lexeme(GenericToken.KeyWord, "as")]
        AS,
        [Lexeme(GenericToken.KeyWord, "child")]
        [Lexeme(GenericToken.KeyWord, "descendant")]
        [Lexeme(GenericToken.KeyWord, "attribute")]
        [Lexeme(GenericToken.KeyWord, "self")]
        [Lexeme(GenericToken.KeyWord, "descendant-or-self")]
        [Lexeme(GenericToken.KeyWord, "following-sibling")]
        [Lexeme(GenericToken.KeyWord, "following")]
        [Lexeme(GenericToken.KeyWord, "namespace")]
        FWDAXIS,
        [Lexeme(GenericToken.KeyWord, "parent")]
        [Lexeme(GenericToken.KeyWord, "ancestor")]
        [Lexeme(GenericToken.KeyWord, "preceding-sibling")]
        [Lexeme(GenericToken.KeyWord, "preceding")]
        [Lexeme(GenericToken.KeyWord, "ancestor-or-self")]
        RVEAXIS,
        [Lexeme(GenericToken.SugarToken, ":")]
        COLON,
        [Lexeme(GenericToken.SugarToken, "::")]
        DOUBLECOLON,
        [Lexeme(GenericToken.SugarToken, "@")]
        AT,
        [Lexeme(GenericToken.SugarToken, ".")]
        DOT,
        [Lexeme(GenericToken.SugarToken, "..")]
        DOUBLEDOT,
        [Lexeme(GenericToken.SugarToken, "*")]
        WILDCARD,
        [Lexeme(GenericToken.SugarToken, ":*")]
        COLONWILDCARD,
        [Lexeme(GenericToken.SugarToken, "*:")]
        WILDCARDCOLON,
        [Lexeme(GenericToken.SugarToken, ".")]
        CURRENTCONTEXT,
        [Lexeme(GenericToken.SugarToken, "?")]
        ARGUMENTPLACEHOLDER,
        [Lexeme(GenericToken.SugarToken, "#")]
        SQUARE,
        [Lexeme(GenericToken.KeyWord, "function")]
        FUNCTION,
        [Lexeme(GenericToken.KeyWord, "map")]
        MAP,
        [Lexeme(GenericToken.SugarToken, "{")]
        LCURLYBRACKET,
        [Lexeme(GenericToken.SugarToken, "}")]
        RCURLYBRACKET,
        [Lexeme(GenericToken.KeyWord, "array")]
        ARRAY,
        [Lexeme(GenericToken.KeyWord, "empty-sequence")]
        EMPTYSEQUENCE,
        [Lexeme(GenericToken.SugarToken, "?")]
        ZEROORONE,
        [Lexeme(GenericToken.SugarToken, "*")]
        ZEROORMORE,
        [Lexeme(GenericToken.SugarToken, "+")]
        ONERORMORE,
        [Lexeme(GenericToken.KeyWord, "Q")]
        Q,
        [Lexeme(GenericToken.KeyWord, "item")]
        ITEM,
        [Lexeme(GenericToken.KeyWord, "node")]
        NODE,
        [Lexeme(GenericToken.KeyWord, "document-node")]
        DOCUMENTNODE,
        [Lexeme(GenericToken.KeyWord, "text")]
        TEXT,
        [Lexeme(GenericToken.KeyWord, "comment")]
        COMMENT,
        [Lexeme(GenericToken.KeyWord, "namespace-node")]
        NAMESPACENODE,
        [Lexeme(GenericToken.KeyWord, "processing-instruction")]
        PROCESSINGINSTRUCTION,
        [Lexeme(GenericToken.KeyWord, "attribute")]
        ATTRIBUTE,
        [Lexeme(GenericToken.KeyWord, "schema-attribute")]
        SCHEMAATTRIBUTE,
        [Lexeme(GenericToken.KeyWord, "element")]
        ELEMENT,
        [Lexeme(GenericToken.KeyWord, "schema-element")]
        SCHEMAELEMENT,
        [Lexeme(GenericToken.String)]
        STRING,
        [Lexeme(GenericToken.Int)]
        INTEGER,
        [Lexeme(GenericToken.Double)]
        DOUBLE,
        // [Lexeme("[^{}]*")]
        // BRACEDURILITERAL,
        [Lexeme(GenericToken.SugarToken, "(:")]
        LCOMMENT,
        [Lexeme(GenericToken.SugarToken, ":)")]
        RCOMMENT,
        // [Lexeme(GenericToken.Default)]
        // EOF
    }
}