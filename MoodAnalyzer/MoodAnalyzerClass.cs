using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyzerClass : Exception
    {
        private string message;
        
        public MoodAnalyzerClass()
        {
            this.message = null;
        }
        public MoodAnalyzerClass(string message)
        {
            this.message = message;
        }

        public string AnalyzerMethod()
        {
            try
            {
                if (this.message is null || this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException("Exception caught : Null encountered");
                }
                else if (this.message.ToUpper().Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (MoodAnalyserCustomException exception)
            {
                return exception.message;
            }
        }
    }
}
