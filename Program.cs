using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * 
 * INTERLANG
 * VERSION: 0.0.001
 * 
 */

namespace InterLang
{
    internal class Program
    {
        /*
         * 1. Readability - Easy to learn and understand
         * 2. Interoperability - Every language
         * 3. Error Handling - Errors that show the user how to fix the issue
         * 4. Security - Protection against basic errors (with warnings) and good security practices (such as encapsulation)
         */

        static void Main(string[] args)
        {
            // Declare
            string fileName, comp, target;
            string[] program, tokens;
            Lexer lexer;

            // Get the file
            Console.Write("Enter the file you would like to compile: ");
            fileName = Console.ReadLine();
            program = File.ReadAllLines(fileName);

            Console.WriteLine("Lexing file.");
            lexer = new Lexer();
            tokens = lexer.lex(program);
            Console.WriteLine("Lex completed.");

            // Convert to correct format
            Console.Write("What is your target language? (JS, PY, C#): ");
            target = Console.ReadLine();
            if (target == "C#")
            {
                // Declare
                ILtoCS ilcsCompiler = new ILtoCS();

                // Convert to C#
                comp = ilcsCompiler.compile(tokens);

                // Show code
                Console.Write("View code? (Y/N): ");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    Console.WriteLine(comp);
                }

                // Save code
                Console.Write("Save code? (Y/N): ");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    Console.WriteLine(comp);
                }

                // Convert to BIN
                Console.Write("Convert to BIN? (Y/N): ");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    CStoBIN csCompiler = new CStoBIN();

                    // Run
                }
            }
            else if (target == "JS")
            {
                // Declare
                ILtoJS iljsCompiler = new ILtoJS();

                // Convert to JavaScript
                comp = iljsCompiler.compile(tokens);

                // Show code
                Console.Write("View code? (Y/N): ");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    Console.WriteLine(comp);
                }

            }
            else if (target == "PY")
            {
                // Declare
                ILtoPY ilpyCompiler = new ILtoPY();

                // Convert to Python
                comp = ilpyCompiler.compile(tokens);

                // Show code
                Console.Write("View code? (Y/N): ");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    Console.WriteLine(comp);
                }

            }

            // End
            Console.WriteLine("Program Finished");
            Console.ReadLine();
        }
    }
}
