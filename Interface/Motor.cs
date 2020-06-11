using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Motor : IKendaraan
    {
        public void Bergerak()
        {
            Console.WriteLine("Motor bergerak di atas roda");
            Console.WriteLine("Dengan bantuan mesin motor");
        }
    }
}
