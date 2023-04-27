using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so sinh vien: ");
            n = Convert.ToInt32(Console.ReadLine());
            Sinhvien[] sv = new Sinhvien[n];
            for(int i = 0; i < n; i++)
            {
                sv[i] = new Sinhvien();
                Console.WriteLine("Nhap thong tin sinh vien thu " + i + 1);
                Console.Write("Nhap msv: ");
                sv[i].Msv = Console.ReadLine();
                Console.Write("Nhap ho ten: ");
                sv[i].Hoten = Console.ReadLine();
                Console.Write("Nhap diem toan: ");
                sv[i].DiemToan = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap diem ly: ");
                sv[i].DiemLy = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap diem hoa: ");
                sv[i].DiemHoa = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Sinhvien s in sv)
                s.show();
            Console.ReadLine();
        }
    }
}
