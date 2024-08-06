using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamaLengkap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama;
            Console.WriteLine("Masukan nama panggilan : ");
            nama = Console.ReadLine();
            if (nama == "Kenjiro")
            {
                Console.WriteLine("Kenjiro Keiji Putra Hermawan");
                Console.WriteLine("Umur 15");
                Console.WriteLine("Jogja");
            }
            else if (nama == "Abdillah")
            {
                Console.WriteLine("Abdillah");
                Console.WriteLine("Umur 15");
                Console.WriteLine("Cilacap");
            }
            else if (nama == "")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Kamu siapa");
            }
        }
            
            
    }
}
