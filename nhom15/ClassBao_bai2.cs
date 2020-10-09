using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btap
{
    class Bao:Tailieu
    {
       
        private int NgayPhatHanh;
        public void Input1()
        {
            Input();
            Console.WriteLine("Ngay Phat Hanh :");
            NgayPhatHanh = Convert.ToInt32(Console.ReadLine());
            if (NgayPhatHanh <= 0 || NgayPhatHanh > 31)
            {
                Console.Write("Error : Ngay Phat Hanh phai lon hon 0 va nho hon 30.Nhap lai !\n");
                Console.Write("Ngay Phat Hanh :");
                NgayPhatHanh = Convert.ToInt32(Console.ReadLine());
            }


        }
        public void Output1()
        {
            Output();
            Console.WriteLine("Ngay Phat Hanh : {0}",NgayPhatHanh);
        }

    }
}
