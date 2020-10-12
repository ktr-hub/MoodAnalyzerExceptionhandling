using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyzerClass
    {
        private string message;

        public MoodAnalyzerClass(string message)
        {
            this.message = message;
        }

        public string AnalyzerMethod() 
        {
            try
            {
                if (this.message.ToUpper().Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return null;
            }
        }

    }
}
