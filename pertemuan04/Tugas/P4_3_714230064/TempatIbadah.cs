using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P4_3_714230064
{
    public abstract class TempatIbadah //Abstraction: Mendefinisikan kelas abstrak 
    {
        //Encapsulation: Private field yang hanya dapat di akses melalui properti
        private string _nama;
        private int _kapasitas;
   

    // Property Nama untuk mengakses dan mengubah nilai _nama dengan enkapsulasi
    public string Nama
    {
        get { return _nama; }
        set { _nama = value; }
    }

    // Property Kapasitas untuk mengakses dan mengubah nilai _kapasitas dengan enkapsulasi
    public int Kapasitas
    {
        get { return _kapasitas; }
        set { _kapasitas = value; }
    }

    public TempatIbadah(string nama, int kapasitas)
    {
        Nama = nama;
        Kapasitas = kapasitas;
    }
    // Abstraction: Metode abstrak Ibadah yang akan diimplementasikan di kelas turunan
    public abstract void Ibadah();
    }
}
