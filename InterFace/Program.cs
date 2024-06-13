using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ascı ascı = new Ascı();
            ascı.Maas();
            ascı.Bilgi();
            ascı.EnSevdigiYemek();

            Console.WriteLine("************************");

            Isci ısci = new Isci();
            ısci.Maas();
            ısci.Bilgi();
            ısci.VardiyaSaat();

            Console.ReadLine();
        }
    }
}
