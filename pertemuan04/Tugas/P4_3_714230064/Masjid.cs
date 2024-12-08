    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_3_714230064
{
    //Intheritance: Masjid mewarisi kelas TempatIbadah
    public class Masjid : TempatIbadah
    {
        //Contructor untuk kelas Masjid 
        public Masjid(string nama, int kapasitas) : base(nama, kapasitas) { }

        //Polymorphsim: Override metode Ibadah dengan implementasi kHusus untuk Masjid

        public override void Ibadah()
        {
            Console.WriteLine($"{Nama} adalah masjid dengan kapasitas {Kapasitas} orang, tempat untuk shalat berjamaah.");
        }
    }
}
