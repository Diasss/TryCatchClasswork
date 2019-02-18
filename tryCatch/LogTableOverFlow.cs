using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    public class LogTableOverFlow : Exception
    {
        const string overflowMessage = "The log table has overflowed";
        public LogTableOverFlow(string auxMessage, Exception inner) : base(string.Format("{0} - {1}", overflowMessage, auxMessage), inner)
        {
            this.HelpLink = "http://google.com";
            this.Source = "Exception_Class_Samples";
        }

    }
    public class LogTable
    {
        protected string[] logArea;
        protected int elemntUse;
        public LogTable(int numElements)
        {
            logArea = new string[numElements];
            elemntUse = 0;
        }
        public int Addrecord(string newRecord)
        {
            try
            {
                logArea[elemntUse] = newRecord;
                return elemntUse++;
            }
            catch (Exception e)
            {
                throw new LogTableOverFlow(string.Format("Record \"{0}\"was not logged", newRecord), e);
            }
            finally
            {
                //ОТРАБОТАЕТ ВСЕГДА!
            }
        }
    }
}
 
