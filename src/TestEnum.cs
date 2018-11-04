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
        [Lexeme(GenericToken.KeyWord, "every")]
        [Lexeme(GenericToken.KeyWord, "some")]
        SOMEEVERY = 2,
        [Lexeme(GenericToken.KeyWord, "if")]
        IF = 2,
        [Lexeme(GenericToken.KeyWord, "or")]
        OR = 3,
        [Lexeme(GenericToken.KeyWord, "and")]
        AND = 4,
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
        [Lexeme("[^{}]*")]
        BRACEDURILITERAL,
        [Lexeme(".*")]
        NCNAME,
        EOF,

        // [Lexeme(GenericToken.SugarToken, ",")]
        // COMMA,
        // [Lexeme(GenericToken.SugarToken, "$")]
        // DOLAR,
        // [Lexeme(GenericToken.KeyWord, "for")]
        // FOR,
        // [Lexeme(GenericToken.KeyWord, "let")]
        // LET,
        // [Lexeme(GenericToken.KeyWord, "some")]
        // SOME,
        // [Lexeme(GenericToken.KeyWord, "every")]
        // EVERY,
        // [Lexeme(GenericToken.KeyWord, "return")]
        // RETURN,
        // [Lexeme(GenericToken.KeyWord, "satisfies")]
        // SATISFIES,
        // [Lexeme(GenericToken.KeyWord, "if")]
        // IF,
        // [Lexeme(GenericToken.KeyWord, "else")]
        // ELSE,
        // [Lexeme(GenericToken.KeyWord, "THEN")]
        // THEN,
        // [Lexeme(GenericToken.KeyWord, "or")]
        // OR,
        // [Lexeme(GenericToken.KeyWord, "and")]
        // AND,
        // [Lexeme(GenericToken.SugarToken, "=")]
        // [Lexeme(GenericToken.KeyWord, "eq")]
        // EQUAL,
        // [Lexeme(GenericToken.SugarToken, "!=")]
        // [Lexeme(GenericToken.KeyWord, "ne")]
        // NOTEQUAL,
        // [Lexeme(GenericToken.SugarToken, "<")]
        // [Lexeme(GenericToken.KeyWord, "lt")]
        // LESSTHAN,
        // [Lexeme(GenericToken.SugarToken, "<=")]
        // [Lexeme(GenericToken.KeyWord, "le")]
        // LESSTHANOREQUAL,
        // [Lexeme(GenericToken.SugarToken, ">")]
        // [Lexeme(GenericToken.KeyWord, "gt")]
        // GREATERTHAN,
        // [Lexeme(GenericToken.SugarToken, ">=")]
        // [Lexeme(GenericToken.KeyWord, "ge")]
        // GREATERTHANOREQUAL,
        // [Lexeme(GenericToken.KeyWord, "is")]
        // IS,
        // [Lexeme(GenericToken.KeyWord, "in")]
        // IN,
        // [Lexeme(GenericToken.SugarToken, ":=")]
        // ASSIGN,
        // [Lexeme(GenericToken.SugarToken, "<<")]
        // LEFTSHIFT,
        // [Lexeme(GenericToken.SugarToken, ">>")]
        // RIGHTSHFIT,
        // [Lexeme(GenericToken.SugarToken, "||")]
        // CONCAT,
        // [Lexeme(GenericToken.KeyWord, "to")]
        // TO,
        // [Lexeme(GenericToken.SugarToken, "+")]
        // BPLUS,
        // [Lexeme(GenericToken.SugarToken, "-")]
        // BMINUS,
        // [Lexeme(GenericToken.SugarToken, "*")]
        // TIMES,
        // [Lexeme(GenericToken.KeyWord, "div")]
        // DIVIDE,
        // [Lexeme(GenericToken.KeyWord, "idiv")]
        // IDIVIDE,
        // [Lexeme(GenericToken.KeyWord, "mod")]
        // MOD,
        // [Lexeme(GenericToken.SugarToken, "|")]
        // [Lexeme(GenericToken.KeyWord, "union")]
        // UNION,
        // [Lexeme(GenericToken.KeyWord, "intersect")]
        // INTERSECT,
        // [Lexeme(GenericToken.KeyWord, "except")]
        // EXCEPT,
        // [Lexeme(GenericToken.KeyWord, "instance of")] // ayırmak gerekebilir
        // INSTANCEOF,
        // [Lexeme(GenericToken.KeyWord, "treat")] // ayırmak gerekebilir
        // TREAT,
        // [Lexeme(GenericToken.KeyWord, "castable")] // ayırmak gerekebilir
        // CASTABLE,
        // [Lexeme(GenericToken.KeyWord, "cast")] // ayırmak gerekebilir
        // CAST,
        // [Lexeme(GenericToken.KeyWord, "as")] // ayırmak gerekebilir
        // AS,
        // [Lexeme(GenericToken.SugarToken, "=>")]
        // ARROW,
        // [Lexeme(GenericToken.SugarToken, ":")]
        // COLON,
        // [Lexeme(GenericToken.SugarToken, ";")]
        // SEMICOLON,
        // [Lexeme(GenericToken.SugarToken, "+")]
        // UPLUS,
        // [Lexeme(GenericToken.SugarToken, "-")]
        // UMINUS,
        // [Lexeme(GenericToken.SugarToken, "!")]
        // MAP,
        // [Lexeme(GenericToken.SugarToken, "/")]
        // DASH,
        // [Lexeme(GenericToken.SugarToken, "//")]
        // DOUBLEDASH,
        // [Lexeme(GenericToken.SugarToken, "[")]
        // LPREDICATE,
        // [Lexeme(GenericToken.SugarToken, "]")]
        // RPREDICATE,
        // [Lexeme(GenericToken.SugarToken, "?")]
        // PLOOKUP,
        // [Lexeme(GenericToken.SugarToken, "?")]
        // ULOOKUP,
        // [Lexeme(GenericToken.SugarToken, "(")]
        // LPARANTHESIS,
        // [Lexeme(GenericToken.SugarToken, ")")]
        // RPARANTHESIS,
        // [Lexeme(GenericToken.SugarToken, "{")]
        // LCURLY,
        // [Lexeme(GenericToken.SugarToken, "}")]
        // RCURLY,
        // [Lexeme(GenericToken.SugarToken, "\"")]
        // DOUBLEQUOTE,
        // [Lexeme(GenericToken.SugarToken, "'")]
        // SINGLEQUOTE
    }
}