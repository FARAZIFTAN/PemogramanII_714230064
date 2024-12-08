using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_3_714230064
{
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat objek Masjid dan Mushola menggunakan polymorphism
            TempatIbadah MasjidAlfalah = new Masjid("Masjid Al-Falah", 300);
            TempatIbadah MusholaAlamin = new Mushola("Mushola Al-Amin", 100);

            //Memanggil metode Ibadah dari masing-masing objek

            MasjidAlfalah.Ibadah();
            MusholaAlamin.Ibadah();
        }
    }
}
