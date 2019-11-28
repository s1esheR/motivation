using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        class Book
        {
            string name;
            int papers;
            int c;

            public Book()
            {
                
            }

            public Book(string name, int papers, int c)
            {
                this.name = name;
                this.papers = papers;
                this.c = c;
            }

            public void CoastOfOnePaper()
            {
                double coast = c / papers;
                Console.WriteLine("Coast Of One Paper: " + coast);
            }

            public void AntiSell()
            {
                int NewPrice = 0;
                string HighPrice = "Программирование";
                if(name == HighPrice)
                {
                    NewPrice = c * 2;
                    Console.WriteLine("New Price: " + NewPrice);
                }
                else
                {
                    Console.WriteLine("New price is not change");
                }
            }

            ~Book()
            {
                Console.WriteLine("object is denied");
            }
        }
        static void Main(string[] args)
        {
            Book A = new Book("Программирование", 20, 40);
            A.AntiSell();
            A.CoastOfOnePaper();
            Console.Read();
        }
    }
}
