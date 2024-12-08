using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714230064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan angka pertama : ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan angka kedua : ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{input1} + {input2} = {input1 + input2}");
            Console.WriteLine($"{input1} - {input2} = {input1 - input2}");
            Console.WriteLine($"{input1} * {input2} = {input1 * input2}");
            Console.WriteLine($"{input1} / {input2} = {input1 / input2}");

        }
    }
}