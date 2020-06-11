using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.AbstractClass;
//using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Kendaraan kendaraan;
            kendaraan = new Drone();
            kendaraan.Bergerak();

            Console.WriteLine();
            kendaraan = new Motor();
            kendaraan.Bergerak();

            Console.WriteLine();
            kendaraan = new Kapal();
            kendaraan.Bergerak();


            /*Kendaraan kendaraan;
            kendaraan = new Drone();
            kendaraan.Bergerak();

            Console.WriteLine();
            kendaraan = new Motor();
            kendaraan.Bergerak();

            Console.WriteLine();
            kendaraan = new Kapal();
            kendaraan.Bergerak()*/

            Console.ReadKey();
        }
    }
}
