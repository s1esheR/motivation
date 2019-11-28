using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        class Parallelepiped
        {
            int a;
            int b;
            int c;

            public Parallelepiped()
            {
                
            }

            public Parallelepiped(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public void Square()
            {
                double s = Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2);
                Console.WriteLine("s: " + s);
            }

            public void SumOfRebers()
            {
                int sum = 4 * a + 4 * b + 4 * c;
                Console.WriteLine("sum: " + sum);
            }

            ~Parallelepiped()
            {
                Console.WriteLine("object is denied");
            }
        }
        static void Main(string[] args)
        {
            Parallelepiped A = new Parallelepiped(1, 2, 3);
            A.Square();
            A.SumOfRebers();
            Console.Read();
        }
    }
}
