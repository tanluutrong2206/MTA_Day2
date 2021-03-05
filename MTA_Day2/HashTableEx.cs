using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTA_Day2
{
    public sealed class HashTableEx
    {
        private HashTableEx()
        {
        }

        public static void Run()
        {
            Hashtable cart = new Hashtable();

            // lay gia tri trong hashtable
            Console.WriteLine($"Ten cua san pham co id la 1 la: {cart[1]}");

            // check ton tai key, value
            if (cart.ContainsKey(1) || cart.ContainsValue("Demo"))
            {
                Console.WriteLine("Gio hang co ton tai san pham voi id la 1 hoac ten la Demo");
            } else
            {
                Console.WriteLine("Gio hang khong ton tai san pham voi id la 1 hoac ten la Demo");
            }

            // xoa item theo key
            cart.Remove(2);

            // in ra hash table
            foreach (var key in cart.Keys)
            {
                Console.WriteLine($"{key} - {cart[key]}");
            }
        }

        private static Hashtable Input()
        {
            Hashtable cart = new Hashtable();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Nhap id san pham thu " + i);
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ten san pham thu " + i);
                string name = Console.ReadLine();

                cart.Add(id, name);
            }

            return cart;
        }
    }
}
