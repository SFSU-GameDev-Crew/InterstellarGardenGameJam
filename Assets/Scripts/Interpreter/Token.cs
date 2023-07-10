namespace Interpreter
{
    public class Token
    {
        TokenType type;
        string lexeme;
        object literal;
        int line;

        public Token(TokenType type, string lexeme, object literal, int line)
        {
            this.type = type;
            this.lexeme = lexeme;
            this.literal = literal;
            this.line = line;
        }
        public override string ToString()
        {
            string result = string.Format("{0} {1} {2}", type, lexeme, literal);
            return result;
        }
    }
}