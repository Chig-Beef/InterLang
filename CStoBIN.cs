using System;
using System.CodeDom.Compiler;
using Microsoft.CSharp;

/*
 * 
 * VERSION: 0.0.001
 * 
 */

namespace InterLang
{
    internal class CStoBIN
    {
        // Check if the last compilation resulted in an error
        bool successful = false;

        // Compiler
        public string compile(string program, string filename)
        {
            // Declare
            CSharpCodeProvider codeProvider;
            CompilerParameters parameters;
            string Output;

            // Init
            codeProvider = new CSharpCodeProvider();
            parameters = new CompilerParameters();
            Output = filename + ".exe";

            //Make sure we generate an EXE, not a DLL
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;
            CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, program);

            // Check for errors
            if (results.Errors.Count > 0)
            {
                foreach (CompilerError CompErr in results.Errors)
                {
                    Console.WriteLine("Line number " + CompErr.Line +
                                ", Error Number: " + CompErr.ErrorNumber +
                                ", '" + CompErr.ErrorText + ";");
                }
                setSuccess(false);
            }
            else
            {
                //Successful Compile
                Console.WriteLine("Compile Succesful.");
                setSuccess(true);
            }
            return Output;
        }

        // Accessor
        public bool getSuccess()
        {
            return successful;
        }

        // Mutator
        private void setSuccess(bool value)
        {
            successful = value;
        }
    }
}
