using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3365
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan(20113365, "surhes", 7000000);
            Karyawan karyawan2 = new Karyawan(20113999, "sasuke ", 6000000);
            Karyawan karyawan3 = new Karyawan(20113888, "naruto", 5000000);


            Console.WriteLine("No.\t NIK \t   \t Nama \t   \t\t  Gaji      ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1.   {0} \t   \t {1} \t   \t {2}     ", karyawan1.nim, karyawan1.nama, karyawan1.gaji);
            Console.WriteLine("2.   {0} \t   \t {1} \t   \t {2}     ", karyawan2.nim, karyawan2.nama, karyawan2.gaji);
            Console.WriteLine("3.   {0} \t   \t {1} \t   \t {2}     ", karyawan3.nim, karyawan3.nama, karyawan3.gaji);


            Console.WriteLine("\n Alhamdulillah naek gaji 10 % \n");


            Console.WriteLine("No. \t NIK \t   \t Nama \t   \t\t  Gaji      ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1.   {0} \t   \t {1} \t   \t {2}     ", karyawan1.nim, karyawan1.nama, karyawan1.naikGaji);
            Console.WriteLine("2.   {0} \t   \t {1} \t   \t {2}     ", karyawan2.nim, karyawan2.nama, karyawan2.naikGaji);
            Console.WriteLine("3.   {0} \t   \t {1} \t   \t {2}     ", karyawan3.nim, karyawan3.nama, karyawan3.naikGaji);


            Console.ReadKey();
        }

    }
}
    
