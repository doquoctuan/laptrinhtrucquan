using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btap
{
    
    class Tailieu
    {
         protected string Matailieu;
         protected string TenNSX;
         protected int Sobanphathanh;
        public void Input()
        {
            Console.Write("\nNhap Ma :");
            Matailieu = Console.ReadLine();
            Console.Write("Nhap Ten nha xuat ban :");
            TenNSX = Console.ReadLine();
            Console.Write("Nhap so phat hanh  :");
            Sobanphathanh = Convert.ToInt32(Console.ReadLine());
            if (Sobanphathanh <= 0)
            {
                Console.Write("Error : So ban phat hanh phai lon hon 0.Nhap lai !\n");
                Console.Write("Nhap lai so phat hanh  :");
                Sobanphathanh = Convert.ToInt32(Console.ReadLine());
            }
            

        }
        public void Output()
        {
            Console.WriteLine("\nMa : {0}",Matailieu);
            Console.WriteLine("Nha xuat Ban : {0}", TenNSX);
            Console.WriteLine("So Phat Hanh : {0}", Sobanphathanh);
        }

    }
}
