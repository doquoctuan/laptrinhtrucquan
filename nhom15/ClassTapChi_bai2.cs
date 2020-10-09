using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btap
{
    class Tapchi:Tailieu
    {
        private int SoPhatHanh;
        private int ThangPhatHanh;
        public  void Input1()
        {
            Input();
            Console.Write("So Phat Hanh :");
            SoPhatHanh = Convert.ToInt32(Console.ReadLine());
            if (SoPhatHanh <= 0)
            {
                Console.Write("Error : So Phat Hanh phai lon hon 0.Nhap lai !\n");
                Console.Write("So Phat Hanh :");
                SoPhatHanh = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Nhap Ten nha xuat ban :");
            ThangPhatHanh = Convert.ToInt32(Console.ReadLine());
            if (ThangPhatHanh <= 0 || ThangPhatHanh > 12)
            {
                Console.Write("Error : Thang Phat Hanh phai lon hon 0 va nho hon 12.Nhap lai !\n");
                Console.Write("Thang Phat Hanh :");
                ThangPhatHanh = Convert.ToInt32(Console.ReadLine());
            }

        }
        public virtual  void Output1()
        {
            Output();
            Console.WriteLine(" Ma : {0}", SoPhatHanh);
            Console.WriteLine(" Nha xuat Ban : {0}", ThangPhatHanh);
         
        }

    }
}
