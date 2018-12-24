using sly.lexer;

namespace netSchematron
{
    public enum XPathToken
    {
        [Lexeme(GenericToken.SugarToken, ",")]
        COMMA = 1,
        [Lexeme(GenericToken.KeyWord, "for")]
        FOR,
        [Lexeme(GenericToken.KeyWord, "let")]
        LET,
        [Lexeme(GenericToken.KeyWord, "some")]
        [Lexeme(GenericToken.KeyWord, "every")]
        SOMEEVERY,
        [Lexeme(GenericToken.KeyWord, "if")]
        IF,
        [Lexeme(GenericToken.KeyWord, "or")]
        OR,
        [Lexeme(GenericToken.KeyWord, "and")]
        AND,
        [Lexeme(GenericToken.KeyWord, "eq")]
        [Lexeme(GenericToken.KeyWord, "ne")]
        [Lexeme(GenericToken.KeyWord, "lt")]
        [Lexeme(GenericToken.KeyWord, "le")]
        [Lexeme(GenericToken.KeyWord, "gt")]
        [Lexeme(GenericToken.KeyWord, "ge")]
        [Lexeme(GenericToken.SugarToken, "=")]
        [Lexeme(GenericToken.SugarToken, "!=")]
        [Lexeme(GenericToken.SugarToken, "<")]
        [Lexeme(GenericToken.SugarToken, "<=")]
        [Lexeme(GenericToken.SugarToken, ">")]
        [Lexeme(GenericToken.SugarToken, ">=")]
        [Lexeme(GenericToken.KeyWord, "is")]
        [Lexeme(GenericToken.SugarToken, "<<")]
        [Lexeme(GenericToken.SugarToken, ">>")]
        COMPARATOR,
        [Lexeme(GenericToken.SugarToken, "||")]
        CONCAT,
        [Lexeme(GenericToken.KeyWord, "to")]
        TO,
        [Lexeme(GenericToken.SugarToken, "-")]
        MINUS,
        [Lexeme(GenericToken.SugarToken, "+")]
        PLUS,
        [Lexeme(GenericToken.SugarToken, "*")]
        STAR,
        // [Lexeme(GenericToken.SugarToken, "*")]
        [Lexeme(GenericToken.KeyWord, "div")]
        [Lexeme(GenericToken.KeyWord, "idiv")]
        [Lexeme(GenericToken.KeyWord, "mod")]
        MULTIPLICATIVE,
        [Lexeme(GenericToken.SugarToken, "|")]
        [Lexeme(GenericToken.KeyWord, "union")]
        UNION,
        [Lexeme(GenericToken.KeyWord, "intersect")]
        [Lexeme(GenericToken.KeyWord, "except")]
        INTERSECTEXCEPT,
        [Lexeme(GenericToken.KeyWord, "instance")]
        INSTANCE,
        [Lexeme(GenericToken.KeyWord, "treat")]
        TREAT,
        [Lexeme(GenericToken.KeyWord, "castable")]
        CASTABLE,
        [Lexeme(GenericToken.KeyWord, "cast")]
        CAST,
        [Lexeme(GenericToken.SugarToken, "=>")]
        ARROW,
        // [Lexeme(GenericToken.SugarToken, "+")]
        // [Lexeme(GenericToken.SugarToken, "-")]
        // UMINUSPLUS,
        [Lexeme(GenericToken.SugarToken, "!")]
        EXCLAMATION,
        [Lexeme(GenericToken.SugarToken, "/")]
        PATH,
        [Lexeme(GenericToken.SugarToken, "//")]
        ALLPATH,
        [Lexeme(GenericToken.SugarToken, "[")]
        LSQRBRACKET,
        [Lexeme(GenericToken.SugarToken, "]")]
        RSQRBRACKET,
        [Lexeme(GenericToken.SugarToken, "?")]
        QUESTION,
        // [Lexeme(GenericToken.SugarToken, "?")]
        // PLOOKUP,
        // [Lexeme(GenericToken.SugarToken, "?")]
        // ULOOKUP,
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
        // [Lexeme(GenericToken.SugarToken, "*")]
        // WILDCARD,
        [Lexeme(GenericToken.SugarToken, ":*")]
        COLONWILDCARD,
        [Lexeme(GenericToken.SugarToken, "*:")]
        WILDCARDCOLON,
        // [Lexeme(GenericToken.SugarToken, "?")]
        // ARGUMENTPLACEHOLDER,
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
        // [Lexeme(GenericToken.SugarToken, "?")]
        // ZEROORONE,
        // [Lexeme(GenericToken.SugarToken, "*")]
        // ZEROORMORE,
        // [Lexeme(GenericToken.SugarToken, "+")]
        // ONERORMORE,
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
        [Lexeme(GenericToken.Default)]
        DEFAULT,
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