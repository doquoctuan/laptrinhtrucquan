using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btap
{
    class Sach:Tailieu
    {
        private string Name;
        private int SoTrang;
        public void Input1()
        {
            Input();
            Console.Write("Nhap Ten Tac Gia :");
            Name = Console.ReadLine();
            Console.Write("Nhap so trang  :");
            SoTrang = Convert.ToInt32(Console.ReadLine());
            if(SoTrang <= 0)
            {
                Console.Write("Error : So trang khong hop le.Nhap lai !\n");
                Console.Write("Nhap lai so trang  :");
                SoTrang = Convert.ToInt32(Console.ReadLine());
            }

        }
        public void Ouput1()
        {
            Output();
            Console.WriteLine("Ma : {0}", Name);
            Console.WriteLine("Nha xuat Ban : {0}", SoTrang);
         
        }
    }
}
