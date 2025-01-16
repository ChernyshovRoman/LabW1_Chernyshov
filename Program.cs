using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW1_Chernyshov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box crate = new Box();
            crate.width = 2;
            crate.height = 3;
            crate.length = 5;
            crate.Show();
            Console.WriteLine($"Объём коробки равен {crate.Volume()} см^2");
            Console.ReadLine();
        }
    }
}
