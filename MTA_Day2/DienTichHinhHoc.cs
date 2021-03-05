using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTA_Day2
{
    public class DienTichHinhHoc
    {
        private DienTichHinhHoc()
        {

        }

        public static void TinhDienTich()
        {
            var option = 0;
            do
            {
                DisplayMenu();
                option = int.Parse(Console.ReadLine());
                TinhDienTich(option);
                if (option != 5)
                {
                    Console.WriteLine("Press any key to back to menu.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (option != 5);
        }

        private static void DisplayMenu()
        {
            Console.WriteLine(@"
1. Tính chu vi và diện tích hình thang
2. Tính chu vi và diện tích hình bình hành
3. Tính chu vi và diện tích hình thoi
4. Tính chu vi và diện tích xung quanh hình trụ
5. Kết thúc
");
        }

        private static void TinhDienTich(int option)
        {
            double s;
            switch (option)
            {
                case 1:
                    s = ChuViDienTichThang();
                    Console.WriteLine($"Dien tich hinh vuong la: {s}");
                    break;
                case 2:
                    s = ChuViDienTichBinhHanh();
                    Console.WriteLine($"Dien tich hinh chu nhat la: {s}");
                    break;
                case 3:
                    s = ChuViDienTichThoi();
                    Console.WriteLine($"Dien tich hinh tam giac la: {s}");
                    break;
                case 4:
                    s = ChuViDienTichTru();
                    Console.WriteLine($"Dien tich hinh tron la: {s}");
                    break;
                default:
                    break;
            }
        }

        private static double ChuViDienTichThang()
        {
            Console.WriteLine("Nhap do dai day lon cua hinh thang: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap do dai day nho cua hinh thang: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap do dai chieu cao cua hinh thang: ");
            double h = double.Parse(Console.ReadLine());

            return .5 * h * (a + b);
        }

        private static double ChuViDienTichThoi()
        {
            Console.WriteLine("Nhap do dai duong cheo thu nhat cua hinh thoi: ");
            double d1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap do dai duong cheo thu hai cua hinh thoi: ");
            double d2 = double.Parse(Console.ReadLine());

            return d1 * d2 / 2;
        }

        private static double ChuViDienTichBinhHanh()
        {
            Console.WriteLine("Nhap do dai chieu cao cua hinh binh hanh: ");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap do dai canh day ung voi chieu cao cua hinh binh hanh: ");
            double a = double.Parse(Console.ReadLine());
            return a * h;
        }

        private static double ChuViDienTichTru()
        {
            Console.WriteLine("Nhap ban kinh day cua hinh tru: ");
            double r = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Nhap chieu cao cua hinh tru: ");
            double h = double.Parse(Console.ReadLine());


            return 2 * Math.PI * r * h;
        }
    }
}
