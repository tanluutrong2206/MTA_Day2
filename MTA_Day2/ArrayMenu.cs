using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTA_Day2
{
    public sealed class ArrayMenu
    {
        private ArrayMenu()
        {

        }

        public static void ExArray()
        {
            int[] array = InputArray();

            // hien thi thong tin mang vua nhap
            Console.WriteLine("Mang vua nhap la: ");
            Console.Write(string.Join(", ", array));

            Console.WriteLine();
            Console.WriteLine("Mang theo thu tu giam dan: ");
            Array.Sort(array);
            Console.Write(string.Join(", ", array));

            Console.WriteLine();
            Console.WriteLine("Nhung phan tu co gia tri lon nhat la: ");
            Console.Write(string.Join(", ", array.Where(x => x == array[^1])));

            Console.WriteLine();
            Console.WriteLine("Phan tu trong mang co gia tri nho nhat la: ");
            Console.Write(string.Join(", ", array.Where(x => x == array[0])));

            Console.WriteLine();
            var sumEvenNumber = array.Where(x => x % 2 == 0).Sum();
            Console.WriteLine($"Cac chu so chan trong mang co tong la: " +
                $"{sumEvenNumber} va trung binh cong la: ${(double)sumEvenNumber / array.Count(x => x % 2 == 0)}");

            Console.WriteLine();
            Console.WriteLine("So luong cac phan tu trong mang co gia tri lon nhat la: " + array.Count(x => x == array[^1]));
        }

        public static void ExArray2()
        {
            var array = InputArray();

            Console.WriteLine("Mang vua nhap la: ");
            Console.Write(string.Join(", ", array));

            Console.WriteLine();
            Console.WriteLine($"Gia tri trung binh cua cac phan tu trong mang la: " + (double)array.Sum()/array.Count());

            Console.WriteLine("Gia tri cua phan tu lon nhat trong mang la: " + array.Max(x => x));

            Console.WriteLine("So luong cac phan tu trong mang co gia tri bang 5 la: " + array.Count(x => x == 5));

            if (CheckArraySymmetry(array))
            {
                Console.WriteLine("Mang doi xung");
            } else
            {
                Console.WriteLine("Mang bat doi xung");
            }
        }
        private static int[] InputArray()
        {
            Console.WriteLine("Nhap so luong phan tu cua mang: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Nhap thong tin cac phan tu cua mang");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Nhap thong tin gia tri phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        private static bool CheckArraySymmetry(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[^(i + 1)])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
