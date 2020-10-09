using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


/*namespace VDBuoi4._3
{
    class Shape
    {
        protected int chieu_rong;
        protected int chieu_cao;
        public void setChieuRong(int w)
        {
            chieu_rong = w;
        }
        public void sẻtChieuCao(int h)
        {
            chieu_cao = h;
        }
    }
}
class Rectangle:Shape
{
    public int tinhDientich ()
    {
        return (chieu_cao * chieu_rong);

    }
}
class TestCsharp
{
    public static void Main(string [] args)
    {
        Console.WriteLine("Tinh ke thuc trong C#");
        Rectangle hcn = new Rectangle();
        hcn.setChieuRong(5);
        hcn.sẻtChieuCao(7);
        Console.WriteLine("Dien tich hinh chu nhat la :{0}", hcn.tinhDientich());
        Console.ReadKey();
    }
}
*/


/*class Hinhchunhat {
    protected double chieu_dai;
    protected double chieu_rong;
     public Hinhchunhat(double l,double w)
    {
        chieu_dai = l;
        chieu_rong = w;

    }
      public double tinhDientich()
    {
        return chieu_dai * chieu_rong;
    }
    public void Display()
    {
        Console.WriteLine("Chieu dai:{0}", chieu_dai);
        Console.WriteLine("Chieu rong:{0}", chieu_rong);
        Console.WriteLine("Dien tich:{0}", tinhDientich());

    }
}
class Chiphixaydung : Hinhchunhat
{
    private double cost;
    public Chiphixaydung(double l,double w): base(l,w) { }
    public double tinhChiPhi()
    {
        double chi_phi;
        chi_phi = tinhDientich() * 70;
        return chi_phi;


    }
    public void hienThiThongTin()
    {
        base.Display();
        Console.WriteLine("Chi phi:{0}", tinhChiPhi());

    }


}
public class TestCsharp
{
    public static void Main(string[]args)
    {
        Console.WriteLine("tinh ke thua trong C#");
        Console.WriteLine("Khoi tao lop co so");

        Chiphixaydung t = new Chiphixaydung(4.5, 5.7);
        t.hienThiThongTin();
        Console.ReadLine();
        Console.ReadKey();

    }
}*/



/*class Shape {
    protected int chieu_rong;
    protected int chieu_cao;
    public void setChieuRong(int w)
    {
        chieu_rong = w;
    }
    public void sẻtChieuCao(int h)
    {
        chieu_cao = h;
    }
}
public interface ChiPhiSon
{
    int tinnhChiPhi(int dien_tich);
}
class HinhChuNhat : Shape, ChiPhiSon
{
    private int dien_tich;

    public int tinhDienTich()
    {
        return (chieu_cao * chieu_rong);

    }
    public int tinhChiPhi(int dien_tich)
    {
        return dien_tich * 70;
    }

    public int tinnhChiPhi(int dien_tich)
    {
        throw new NotImplementedException();
    }

    internal void setChieuCao(int v)
    {
        throw new NotImplementedException();
    }
}
public class TestCsharp
{
    public static void Main(string[] arsg)
    {
        Console.WriteLine("Tinh ke thua trong C#");
        Console.WriteLine("Vi du minh hoa");

        HinhChuNhat hcn = new HinhChuNhat();
        int dien_tich;
        hcn.setChieuRong(5);
        hcn.setChieuCao(7);
        dien_tich = hcn.tinhDienTich();
        Console.WriteLine("Tong dien tic:{0}", hcn.tinhDienTich());
        Console.WriteLine("Tong chi phi son:{0}", hcn.tinhChiPhi(dien_tich));

    }
}
*/




/*public class TestCSharp
{
    void prinf(int i)
    {
        Console.WriteLine("In so nguyen:{0}", i);

    }
    void prinf(double f)
    {
        Console.WriteLine("In so thuc:{0}", f);

    }
    void prinf(string s)
    {
        Console.WriteLine("In  chuoi:{0}", s);

    }

    static void Main(string[] args)
    {
        Console.WriteLine("Tinh da hinh trong C#");

        TestCSharp p = new TestCSharp();

        p.prinf(5);
        p.prinf(500.263);
        p.prinf("Hoc C# co ban va nang cao");
        Console.ReadKey();

    }
}*/







abstract class Shape
{
    public abstract int tinhDientich();
}
class HinhChuNhat: Shape
{
    private int chieu_dai;
    private int chieu_rong;
    public HinhChuNhat(int a =0, int b = 0)
    {
        chieu_dai = a;
        chieu_rong = b;

    }

    public override int tinhDientich()
    {
        Console.WriteLine("Dien tich hinh chu nhat:");
        return (chieu_rong * chieu_dai);


    }
}
public class TestCsharp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tinh da hinh trong C#");
        Console.WriteLine("Vi du minh hoa Da hinh dong C#");

        HinhChuNhat r = new HinhChuNhat(10, 7);
        double a = r.tinDientich();
        Console.WriteLine("Dien tich:{0}", a);
        Console.ReadKey();

    }
}







/*class Shape
{
    protected int chieu_rong, chieu_cao;
    public Shape(int a=0,int b = 0)
    {
        chieu_rong = a;
        chieu_cao = b;
    }
    public virtual int tinhDientich()
    {
        Console.WriteLine("Dien tich cua class cha:");
        return 0;
    }
}
class HinhChuNhat : Shape
{
    public HinhChuNhat(int a = 0, int b= 0) : base(a, b)
    {

    }
    public override int tinhDientich()
    {
        Console.WriteLine("Dien tich cua class HinhChuNhat:");
        return (chieu_rong * chieu_dai);
    }
}

class TamGiac : Shape
{
    public TamGiac(int a = 0, int b = 0) : base(a, b)
    {

    }
    public override int tinhDientich()
    {
        Console.WriteLine("Dien tich cua class TamGiac:");
        return (chieu_cao * chieu_rong / 2);
    }
}
class HienThiDuLieu
{
    public void hienthiDientich(Shape sh)
    {
        int a;
        a = sh.tinhDientich();
        Console.WriteLine("Dien tich:{0}", a);
    }
}

public class TestCsharp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tinh da hinh trong C#");
        Console.WriteLine("Vi du minh hoa da hinh dong");
        Console.WriteLine("...........................");

        HienThiDuLieu c = new HienThiDuLieu();
        HinhChuNhat r = new HinhChuNhat(10,7);
        TamGiac t = new TamGiac(10, 7);
        c.hienthiDientich(r);
        c.hienthiDientich(t);
        Console.ReadKey();
    }
}

*/







/*class Box
{
    private double chieu_dai;
    private double chieu_rong;
    private double chieu_cao;

    public double tinhThetich()
    {
        return chieu_dai * chieu_cao * chieu_rong;
    }
    public void setChieuDai(double len)
    {
        chieu_dai = len;
    }
    public void setChieuRong(double bre)
    {
        chieu_rong = bre;
    }
    public void setChieuCao(double hei)
    {
        chieu_cao = hei;
    }
    public static Box operator +(Box b, Box c)
    {
        Box box = new Box();
        box.chieu_dai = b.chieu_dai + c.chieu_dai;
        box.chieu_rong = b.chieu_rong + c.chieu_rong;
        box.chieu_cao = b.chieu_cao + c.chieu_cao;
        return box;
    }
}
public class TestCharp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nap chong toan tu trong C#");
        Console.WriteLine("vi du minh hoan nap chong toan tu");
        Console.WriteLine("......................");

        Box Box1 = new Box();
        Box Box2 = new Box();
        Box Box3 = new Box();
        double the_tich = 0.0;


        Box1.setChieuDai(6.0);
        Box1.setChieuRong(7.0);
        Box1.setChieuCao(5.0);

        Box2.setChieuDai(12.0);
        Box2.setChieuRong(13.0);
        Box2.setChieuCao(10.0);

        the_tich = Box1.tinhThetich();
        Console.WriteLine("The tich cua Box 1 la :{0}", the_tich);
        Console.ReadKey();
        the_tich = Box2.tinhThetich();
        Console.WriteLine("The tic cua Box 2 la :{0}", the_tich);
    }
}*/










/*public interface ITransactions
{
    void hienThiThongTinGiaoDich();
    double laySoLuong();

}
public interface GiaoDich
{
    void hienThiThongTinGiaoDich();
    double laySoLuong();
}
 class GiaoDichHangHoa : GiaoDich
{
    private string ma_hang_hoa;
    private string ngay;
    private double so_luong;
    public GiaoDichHangHoa()
    {
        ma_hang_hoa = " ";
        ngay = " ";
        so_luong = 0.0;
    }
    public GiaoDichHangHoa(string c,string d, double a)
    {
        ma_hang_hoa = c;
        ngay = d;
        so_luong = a;
    }
    public double laySoLuong()
    {
        return so_luong;
    }
    public void hienThiThongTinGiaoDich()
    {
        Console.WriteLine("Ma hang hoa :{0}", ma_hang_hoa);
        Console.WriteLine("Ngay giao dich:{0}", ngay);
        Console.WriteLine("So Luong:{0}", laySoLuong());
    }
}
public class TestCsharp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Interface trong C#");
        Console.WriteLine("Vi du minh hoa");

        GiaoDichHangHoa t1 = new GiaoDichHangHoa("001", "8/10/2020", 123000.00);
        GiaoDichHangHoa t2 = new GiaoDichHangHoa("002", "9/10/2020", 321000.00);
        t1.hienThiThongTinGiaoDich();
        t2.hienThiThongTinGiaoDich();
        Console.ReadKey();
    }
}*/