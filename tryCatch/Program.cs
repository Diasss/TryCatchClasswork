using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    class Program
    {

        static int[] num = { 2, 4, 5, 6, 7 };

        public static int GetNum(int index)
        {
            if (index < 0 || index >= num.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return num[index];
        }
        static void Main(string[] args)
        {
            try
            {
                GetNum(66);
            }
            catch (Exception e)
            {

                throw;
            }


            int x = 1;
            int y = 0;
            try
            {
                int result = x / y;
            }
            catch (Exception ex)
            when(y==0)
            {

                Console.WriteLine("y не должен быть равен нулю");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            LogTable log = new LogTable(4);
            Console.WriteLine("---");
            try
            {
                for (int count = 1; ; count++)
                {
                    log.Addrecord(string.Format("log record number {0}", count));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nMessage----n{0}", ex.Message);
                Console.WriteLine("\nHelp link---\n{0}", ex.HelpLink);
                Console.WriteLine("\nSource ---\n{0}", ex.Source);
                Console.WriteLine("\nStackTrace---\n{0}", ex.StackTrace);
                Console.WriteLine("\nTargerSite---\n{0}", ex.TargetSite);
            }
        }
    }
}
