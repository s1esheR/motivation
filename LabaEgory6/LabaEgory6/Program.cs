using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaEgory6
{
    class Program
    {
        
        static void Main(string[] args)
        {
        /// DataType
            for(; ; )
            {
                DateTime old = new DateTime(2000, 1, 1, 0, 0, 0);
                Console.WriteLine(DateTime.Now.Subtract(old));
            }
            Console.Read();

            ///String Format
            /*int money = 200;
            double clean_money = money * 1 / 1.25;
            string result = String.Format("{0:C2}", clean_money);
            Console.WriteLine(result);
            Console.Read();*/
        }
    }
}
