using sly.lexer;

namespace netSchematron
{
    public enum Token
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
        MAP = 18,
        [Lexeme(GenericToken.SugarToken, "/")]
        PATH = 19,
        [Lexeme(GenericToken.SugarToken, "//")]
        ALLPATH = 19,
        [Lexeme(GenericToken.SugarToken, "[")]
        LPREDICATE = 20,
        [Lexeme(GenericToken.SugarToken, "]")]
        RPREDICATE = 20,
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
        [Lexeme(GenericToken.SugarToken, "::")]
        DOUBLECOLON,
        // [Lexeme(GenericToken.String)]
        // STRING,
        [Lexeme(GenericToken.SugarToken, "*")]
        [Lexeme(GenericToken.SugarToken, "+")]
        [Lexeme(GenericToken.SugarToken, "?")]
        OCCURRENCEINDICATOR,
        EOF
    }
}