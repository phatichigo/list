using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rectangle
    {
        //khaibao bien;
        double len, wid;


        //Phuongthuc
        public void Acc()
        {
            len = 10.5;
            wid = 15.5;
        }
        //Phuong thuc  get
        public double GetArea()
        {
            return len * wid;
        }
        //Phuong thuc in ra man hinh
        public void Display()
        {
            Console.WriteLine("ChieuDai:{0}", len);
            Console.WriteLine("chieurong:{0}", wid);
            Console.WriteLine("Dientich:{0}", GetArea());


        }
    }
}
