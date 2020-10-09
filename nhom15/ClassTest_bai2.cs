using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btap
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Sach> ListSach = new List<Sach>();
            List<Tapchi> ListTapchi = new List<Tapchi>();
            List<Bao> ListBao = new List<Bao>();
            int Chose = default;
            int Chose1 = default;
            int n = default;
            do
            {
                Menu();
                Chose = Convert.ToInt32(Console.ReadLine());
                switch (Chose)
                {
                    case 1:
                        do
                        {
                            Menu1();
                            Chose1 = Convert.ToInt32(Console.ReadLine());
                            switch (Chose1)
                            {
                                case 1:
                                    Console.Write("\n-Nhap So Luong Sach : ");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < n; i++)
                                    {
                                        Console.WriteLine("\n\tNhap Sach Thu {0} : ", i + 1);
                                        Sach sach = new Sach();
                                        sach.Input1();
                                        ListSach.Add(sach);
                                    }
                                    break;
                                case 2:
                                    Console.Write("\n--Nhap So Luong Bao : ");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < n; i++)
                                    {
                                        Console.WriteLine("\n\tNhap Bao Thu {0} : ", i + 1);
                                        Bao bao = new Bao();
                                        bao.Input1();
                                        ListBao.Add(bao);
                                    }
                                    break;
                                case 3:
                                    Console.Write("\n--Nhap So Luong Tap Chi : ");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < n; i++)
                                    {
                                        Console.WriteLine("\n\tNhap Tap Chi Thu {0} : ", i + 1);
                                        Tapchi tapchi = new Tapchi();
                                        tapchi.Input1();
                                        ListTapchi.Add(tapchi);
                                    }
                                    break;
                                case 4:
                                    break;
                                default:
                                    break;
                            }
                        } while (Chose1 != 4);
                        break;
                    case 2:
                        if (ListSach.Count > 0)
                        {
                            Console.WriteLine("\n==========Thong Tin Sach==========");
                            foreach (Sach item in ListSach)
                            {
                                item.Ouput1();
                            }
                        }
                        if (ListBao.Count > 0)
                        {
                            Console.WriteLine("\n==========Thong Tin Bao==========");

                            foreach (Bao item in ListBao)
                            {
                                item.Output1();
                            }
                        }
                        if (ListTapchi.Count > 0)
                        {
                            Console.WriteLine("\n==========Thong Tin Tap Chi========");
                            foreach (Tapchi item in ListTapchi)
                            {
                                item.Output1();
                            }
                        }
                        break;
                    case 3:
                        do
                        {
                            Menu1();
                            Chose1 = Convert.ToInt32(Console.ReadLine());
                            switch (Chose1)
                            {
                                case 1:
                                    if (ListSach.Count > 0)
                                    {
                                        Console.WriteLine("\n=========Thong Tin Sach==========");
                                        foreach (Sach item in ListSach)
                                        {
                                            item.Ouput1();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nKhong Co Sach !");
                                    }
                                    break;
                                case 2:
                                    if (ListBao.Count > 0)
                                    {
                                        Console.WriteLine("\n==========Thong Tin Bao==========");
                                        foreach (Bao item in ListBao)
                                        {
                                            item.Output1();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nKhong co Bao !");
                                    }
                                    break;
                                case 3:
                                    if (ListTapchi.Count > 0)
                                    {
                                        Console.WriteLine("\n==========Thong Tin Tap Chi==========");
                                        foreach (Tapchi item in ListTapchi)
                                        {
                                            item.Output1();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nKhong co Tap chi !");
                                    }
                                    break;
                                case 4:
                                    break;
                                default:
                                    break;
                            }
                        } while (Chose1 != 4);
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            } while (Chose != 4);
            Console.ReadKey();
        }
        static void Menu()
        {
            Console.WriteLine("\n\n-------------Menu-----------");
            Console.WriteLine("1.Nhap thong tin cac tai lieu");
            Console.WriteLine("2.Xuat thong ve cac tai lieu");
            Console.WriteLine("3.Tim kiem tai lieu theo loai");
            Console.WriteLine("4.Thoat chuong trinh");
            Console.WriteLine("============================");
            Console.Write("Moi chon : ");

        }
        static void Menu1()
        {
            Console.WriteLine("\n\n-------------Menu-----------");
            Console.WriteLine("1.Sach");
            Console.WriteLine("2.Bao");
            Console.WriteLine("3.Tap chi");
            Console.WriteLine("4.Thoat");
            Console.WriteLine("============================");
            Console.Write("Moi chon : ");
        }

    }
}

