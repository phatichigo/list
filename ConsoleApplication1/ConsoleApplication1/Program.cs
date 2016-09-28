using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.String;

namespace ConsoleApplication1
{
    class BaiDauTien
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MO ta huong doi tuong trong C#");
            Console.WriteLine("--------**--------");
            //tao doi tuong trong C#
            Rectangle r =new Rectangle();

            //goi phuong thuc
            r.Acc();
            r.Display();

            //Tu khoa sizeof trong C#

            Console.WriteLine("Kich co cua kieu du lieu int la:{0}",sizeof(int));
            Console.WriteLine("Kich co cua kieu du lieu double la:{0}", sizeof(double));
            Console.WriteLine("Kich co cua kieu du lieu float la:{0}", sizeof(float));
            Console.WriteLine("Kich co cua kieu du lieu char la:{0}", sizeof(char));
            Console.WriteLine("Kich co cua kieu du lieu bool la:{0}", sizeof(bool));
            Console.WriteLine("Kich co cua kieu du lieu ulong la:{0}", sizeof(ulong));
            Console.WriteLine("Kich co cua kieu du lieu sbyte la:{0}", sizeof(sbyte));







            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
