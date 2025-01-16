using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW1_Chernyshov
{
    internal class Box
    {
        public float height { get; set; }
        public float width { get; set; }
        public float length { get; set; }
        public Box()
        {
            height = 0;
            width = 0;
            length = 0;
        }
        public Box(float h, float w, float l)
        {
            height = h;
            width = w;
            length = l;
        }
        public void Show()
        {
            Console.WriteLine($"Данная коробка имеет ширину в {width} см, высоту в {height} см и длину в {length} см");
        }
        public float Volume()
        {
            float Vol = height * width * length;
            return Vol;
        }
    }
}
