using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_3_714230064
{
    public class Mushola : TempatIbadah
    {
        public Mushola(string nama, int kapasitas): base(nama, kapasitas) { }

        public override void Ibadah()
        {
            Console.WriteLine($"{Nama} adalah mushola dengan kapasitas {Kapasitas} orang, tempat untuk ibadah harian.");
        }
    }
}
