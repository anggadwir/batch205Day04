using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay04
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka = 3;
            bool status = true;
            Console.Write("Selamat Datang {0} {1} \n", angka, status);
            Console.Write("Selamat Datang " + angka + " " + status);

            Console.ReadLine();
        }
    }
}
