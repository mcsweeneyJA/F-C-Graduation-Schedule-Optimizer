using System;
using System.Collections.Generic;
using System.IO;

namespace QUT
{
    using UnitCode = String;

    public enum Token { LeftParen, RightParen, Unit, CP, And, Or, EOF };

    public class Scanner
    {
        private char next = default;
        private StringReader input;
        public int creditPoints;
        public string unitCode;
        public bool EOF;

        public Scanner(string str)
        {
            EOF = false;
            input = new StringReader(str);
            readNext();
        }

        private void readNext()
        {
            if (input.Peek() == -1)
                EOF = true;
            else
                next = (char) input.Read();
        }

        private void matchString(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != next)
                    throw new Exception("unexpected character, found " + next + ", expected " + str);
                readNext();
            }
        }

        private int matchNumber()
        {
            int number = 0;
            while (char.IsDigit(next))
            {
                number = number * 10 + (next - '0');
                readNext();
            }
            return number;
        }

        public Token getNextToken()
        {
            if (EOF)
                return Token.EOF;

            while (char.IsWhiteSpace(next))
                readNext();

            if (next == '(')
            {
                var token = Token.LeftParen;
                readNext();
                return token;
            }

            if (next == ')')
            {
                var token = Token.RightParen;
                readNext();
                return token;
            }

            if (next == 'a')
            {
                matchString("and");
                return Token.And;
            }
            
            if (next == 'o')
            {
                matchString("or");
                return Token.Or;
            }
            
            if (char.IsDigit(next))
            {
                creditPoints = matchNumber();
                matchString("cp");
                return Token.CP;
            }
            
            if (char.IsUpper(next))
            {
                unitCode = "";
                while (char.IsUpper(next))
                {
                    unitCode = unitCode + next;
                    readNext();
                }
                while (!EOF && char.IsDigit(next))
                {
                    unitCode = unitCode + next;
                    readNext();
                }
                if (!EOF && next == '-')
                {
                    unitCode = unitCode + next;
                    readNext();
                }
                if (!EOF && char.IsDigit(next))
                {
                    unitCode = unitCode + next;
                    readNext();
                }
                return Token.Unit;
            }
            else
                throw new Exception("unexpected character " + next);
        }
    }

    public class Parser
    {
        public Prereq And(Prereq a, Prereq b)
        {
            return Prereq.NewAnd(new List<Prereq> { a, b });
        }
        
   
        public Prereq Or(Prereq a, Prereq b)
        {
            return Prereq.NewOr(new List<Prereq> { a, b });
        }
        public Prereq CP(int count)
        {
            return Prereq.NewCreditPoints(count);
        }
        public Prereq Unit(UnitCode code)
        {
            return Prereq.NewUnit(code);
        }
        public Prereq Nil()
        {
            return Prereq.Nil;
        }

        private Token next;
        private Scanner scanner;

        public Parser(string input)
        {
            scanner = new Scanner(input);
            next = scanner.getNextToken();
        }

        private void match(Token expected)
        {
            if (next == expected)
                next = scanner.getNextToken();
            else
                throw new Exception("Unexpected token, found " + next + ", expected " + expected);
        }

        private Prereq parseTerm()
        {
            if (next == Token.LeftParen)
            {
                match(Token.LeftParen);
                var prereq = parsePrereq();
                match(Token.RightParen);
                return prereq;
            }
            else if (next == Token.Unit)
            {
                match(Token.Unit);
                return Unit(scanner.unitCode);
            }
            else if (next == Token.CP)
            {
                match(Token.CP);
                return CP(scanner.creditPoints);
            }
            else
                throw new Exception("Unexpected token" + next);
        }

        private Prereq parsePrereq()
        {
            if (next == Token.EOF)
                return Nil();

            var prereq = parseTerm();
            while (next == Token.And)
            {
                match(Token.And);
                var right = parseTerm();
                prereq = And(prereq, right);
            }
            while (next == Token.Or)
            {
                match(Token.Or);
                var right = parseTerm();
                prereq = Or(prereq, right);
            }
            return prereq;
        }

        public static Prereq parsePrereq(string str)
        {
            var parser = new Parser(str);
            return parser.parsePrereq();
        }
    }
}
