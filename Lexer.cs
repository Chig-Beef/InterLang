using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * VERSION: 0.0.001
 * 
 */

namespace InterLang
{
    internal class Lexer
    {
        private string[] tokens;
        private int nTokens;
        private string[] validTokens = new string[14]
        {
                "cls",
                "int",
                "fun",
                "new",
                "0",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9"
        };
        private char[] validCharTokens = new char[12]
        {
                ',',
                '\n',
                '\t',
                '(',
                ')',
                '=',
                '.',
                '+',
                '-',
                '*',
                '/',
                ':'
        };

        public string[] lex(string[] program)
        {
            // Declare
            string token;
            bool done, in_string;

            // Init
            tokens = new string[program.Length * 10];
            done = false;
            in_string = false;

            nTokens = 0;
            for (int i = 0; i < program.Length; i++)
            {
                token = "";
                for (int j = 0; j < program[i].Length; j++)
                {
                    // Strings don't get tokenized
                    if (in_string)
                    {
                        if (program[i][j] == '"')
                        {
                            in_string = false;
                        }
                        token += program[i][j];
                        continue;
                    }

                    // Start of a string
                    if (program[i][j] == '"')
                    {
                        token += program[i][j];
                        in_string = true;
                        continue;
                    }

                    // End of word, usually means token was a variable/number
                    if (program[i][j] == ' ')
                    {
                        if (token != "")
                        {
                            addToken(ref token);
                            done = true;
                        }
                        continue;
                    }

                    // Check if the next character is a token
                    if (isValidCharToken(program[i][j]))
                    {
                        if (token != "")
                        {
                            addToken(ref token);
                        }
                        tokens[nTokens] = program[i][j].ToString();
                        nTokens++;
                        continue;
                    }

                    token += program[i][j];

                    if (isValidToken(token))
                    {
                        addToken(ref token);
                    }
                }
                if (token != "")
                {
                    addToken(ref token);
                }
                tokens[nTokens] = "\n";
                nTokens++;
            }

            tokens = ridNulls(tokens);

            return tokens;
        }

        private bool isValidToken(string token)
        {
            if (token[0] == '"' && token[token.Length - 1] == '"')
            {
                return true;
            }

            for (int i = 0; i < validTokens.Length; i++)
            {
                if (token == validTokens[i])
                {
                    return true;
                }
            }
            return false;
        }

        private bool isValidCharToken(char token)
        {
            for (int k = 0; k < validCharTokens.Length; k++)
            {
                if (token == validCharTokens[k])
                {
                    return true;
                }
            }
            return false;
        }

        private void addToken(ref string token)
        {
            tokens[nTokens] = token;
            nTokens++;
            token = "";
        }

        private string[] ridNulls(string[] tokens)
        {
            string[] newTokens = new string[nTokens];
            for (int i = 0; i < nTokens; i++)
            {
                newTokens[i] = tokens[i];
            }
            return newTokens;
        }
    }
}
