using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaEgory5
{
    class Program
    {
        ///String
        static void Main(string[] args)
        {
            Console.Write("Введите строку S1: ");
            String s1 = Console.ReadLine();
            Console.Write("Введите строку S2: ");
            String s2 = Console.ReadLine();
            Console.Write("Введите символ для поиска: ");
            String c = Console.ReadLine();
            int count = s1.Length;
            int pos;

            while ((pos = s1.LastIndexOf(c, count, count)) != -1)
            {
                s1 = s1.Insert(pos + 1, s2);
                count = pos - 1;
            }

            Console.WriteLine("Полученная строка: " + s1);
            Console.ReadLine();

            ///StringBilder
            /*Console.WriteLine("Введите первую строку:");
            StringBuilder s1 = new StringBuilder(Console.ReadLine());

            Console.WriteLine("Введите вторую строку:");
            StringBuilder s2 = new StringBuilder(Console.ReadLine());

            Console.WriteLine("Введите символ для поиска:");
            Char c = Char.Parse(Console.ReadLine());

            int count = s1.Length;

            for (int i = 0; i < count; i++)
            {
                if (s1[i] == c)
                {
                    s1.Insert(i, s2);
                    s1.Insert((s2.Length + i + 1), s2); 
                    i += s2.Length; 
                    count += 2 * s2.Length; 
                }
            }
            Console.WriteLine("Полученная строка: {0}", s1);
            Console.ReadLine();*/
        }
    }
}
