using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    internal class Ascı : IKisi
    {
        public void Bilgi()
        {
            Console.WriteLine("ben aşçıyım yemke yaparım");
        }

        public void BordoCikar()
        {
            throw new NotImplementedException();
        }

        public void Maas()
        {
            Console.WriteLine(25099);
        }
        public void EnSevdigiYemek()
        {
            Console.WriteLine("Salata");
        }
    }
}
