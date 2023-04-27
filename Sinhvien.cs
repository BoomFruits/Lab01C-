using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Sinhvien
    {
        private string msv;
        private string hoten;
        private double diemToan;
        private double diemLy;
        private double diemHoa;
        public string Msv
        {
            get { return msv; }
            set { msv = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public double DiemToan
        {
            get { return diemToan; }
            set { diemToan = value; }
        }
        public double DiemLy
        {
            get { return diemLy; }
            set { diemLy = value; }
        }
        public double DiemHoa
        {
            get { return diemHoa; }
            set { diemHoa = value; }
        }
        public void show()
        {
            Console.WriteLine("MSSV:{0}",msv);
            Console.WriteLine("Ten SV:{0}",hoten);
            Console.WriteLine("Diem Toan:{0}", diemToan);
            Console.WriteLine("Diem Ly:{0}", diemLy);
            Console.WriteLine("Diem Hoa:{0}", diemHoa);
        }
    }
}
