using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace P5_4_714230064
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {
        }

        private void SelesaiButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void GenderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
        }

        private void SepakBolaCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RenangCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void TenisCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void YogaCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void BasketCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void BuluTangkisCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void VoliCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void PanahanCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void SeninMingguButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void SelasaKamisButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void SabtuMingguButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void MingguButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void TampilkanButton_Click(object sender, EventArgs e)
        {
            string nama = NameBox.Text;
            string jenisKelamin = GenderBox.SelectedItem?.ToString() ?? "";
            DateTime tanggalLahir = Date.Value;

            // Mengambil pilihan kelas
            List<string> pilihanKelas = new List<string>();
            if (SepakBolaCheck.Checked) pilihanKelas.Add("Sepak Bola");
            if (RenangCheck.Checked) pilihanKelas.Add("Renang");
            if (TenisCheck.Checked) pilihanKelas.Add("Tenis");
            if (YogaCheck.Checked) pilihanKelas.Add("Yoga");
            if (BasketCheck.Checked) pilihanKelas.Add("Basket");
            if (BuluTangkisCheck.Checked) pilihanKelas.Add("Bulu Tangkis");
            if (VoliCheck.Checked) pilihanKelas.Add("Voli");
            if (PanahanCheck.Checked) pilihanKelas.Add("Panahan");

            // Mengambil pilihan jadwal
            string pilihanJadwal = "";
            if (SeninMingguButton.Checked) pilihanJadwal = "Senin s/d Rabu, 14.00 - 16.00";
            else if (SelasaKamisButton.Checked) pilihanJadwal = "Selasa s/d Kamis, 14.00 - 16.00";
            else if (SabtuMingguButton.Checked) pilihanJadwal = "Sabtu s/d Minggu, 09.00 - 11.00";
            else if (MingguButton.Checked) pilihanJadwal = "Minggu, 13.00 - 20.00";

            // Validasi
            if (pilihanKelas.Count == 0)
            {
                MessageBox.Show("Harus memilih salah satu dari kelas", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(pilihanJadwal))
            {
                MessageBox.Show("Harus memilih salah satu jadwal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Menampilkan hasil
            string hasil = $"Nama: {nama}\nJenis Kelamin: {jenisKelamin}\nTanggal Lahir: {tanggalLahir.ToShortDateString()}\n" +
                           $"Pilihan Kelas: {string.Join(", ", pilihanKelas)}\nPilihan Jadwal: {pilihanJadwal}";

            MessageBox.Show(hasil, "Hasil Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PilihanKelasBox_Enter(object sender, EventArgs e)
        {
        }

        private void PilihanJadwalBox_Enter(object sender, EventArgs e)
        {
        }
    }
}
