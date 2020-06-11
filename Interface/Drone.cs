using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Drone : IKendaraan
    {
        public void Bergerak()
        {
            Console.WriteLine("Drone bergerak dengan cara terbang");
            Console.WriteLine("Dengan bantuan mesin drone");
        }
    }
}
