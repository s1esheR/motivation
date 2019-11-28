using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //delegate int Point(int x, int y);
        class Vector
        {
            //Point first;
            //Point second;
            double x1;
            double x2;
            double y1;
            double y2;
            public Vector()
            {
                
            }
            public Vector(double x1, double x2, double y1, double y2)
            {
                this.x1 = x1;
                this.x2 = x2;
                this.y1 = y1;
                this.y2 = y2;
            }

            public void MidOfVector()
            {
                double x = (x1 + x2) / 2;
                double y = (y1 + y2) / 2;
                Console.WriteLine("x:" + x);
                Console.WriteLine("y:" + y);
            }
            
            public void Equal45()
            {
                double vec = x2 - x1;
                double angle = Math.Pow(Math.Tan(vec),2);
                double degree = angle * (180 / Math.PI);
                if(degree == 45)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

            ~Vector()
            {
                Console.WriteLine("object is denied");
            }
        }
        static void Main(string[] args)
        {
            Vector A = new Vector(2,4,4,2);
            A.Equal45();
            A.MidOfVector();
            Console.Read();
            
        }
    }
}
