using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    internal class Isci : IKisi
    {
        public void Bilgi()
        {
            Console.WriteLine("Ben bir İşciyim inşa ederim");
        }

        public void BordoCikar()
        {
            throw new NotImplementedException();
        }

        public void Maas()
        {
            Console.WriteLine(17002);
        }
        public void VardiyaSaat()
        {
            Console.WriteLine("sabah 9 akşam 6 ya kadar");
        }
    }
}
