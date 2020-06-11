using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Kapal : Kendaraan
    {
        public override void Bergerak()
        {
            Console.WriteLine("Kapal bergerak dengan angin");
            Console.WriteLine("Dengan cara bantuan mesin diesel");
        }
    }
}
