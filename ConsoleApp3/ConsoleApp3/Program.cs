using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        class Room
        {
            double length;
            double weight;
            double hight;

            public Room()
            {
                
            }

            public Room(double length, double weight, double hight)
            {
                this.length = length;
                this.weight = weight;
                this.hight = hight;
            }

            public void VolumeWithWindows()
            {
                double v = weight * length * hight;
                Console.WriteLine("Volume With Windows: " + v);
            }

            public void VolumeWithOutWindows()
            {
                double window = 2 * 15;
                double door = 2 * 8;
                double v = (weight * length * hight) - window - door;
                Console.WriteLine("Volume With Out Window: " + v);
            }

            ~Room()
            {
                Console.WriteLine("object is denied");
            }
        }
        static void Main(string[] args)
        {
            Room A = new Room(10, 5, 3);
            A.VolumeWithOutWindows();
            A.VolumeWithWindows();
            Console.Read();
        }
    }
}
