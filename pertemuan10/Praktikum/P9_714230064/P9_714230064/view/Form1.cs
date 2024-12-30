using P9_714230064.controller;
using P9_714230064.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714230064
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();
        public Form1()
        {
            InitializeComponent();


        }

        public void Tampil()
        {
            string query = "SELECT * FROM t_mahasiswa";
            DataMahasiswa.DataSource = koneksi.ShowData(query);
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxNPM.Text == "" || textBoxNama.Text == "" || comboBoxAngkatan.SelectedIndex == -1 || textBoxAlamat.Text == "" || textBoxEmail.Text == "" || textBoxNohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                M_mahasiswa mhs = new M_mahasiswa
                {
                    Npm = textBoxNPM.Text,
                    Nama = textBoxNama.Text,
                    Angkatan = comboBoxAngkatan.Text,
                    Alamat = textBoxAlamat.Text,
                    Email = textBoxEmail.Text,
                    Nohp = textBoxNohp.Text
                };

              
                Mahasiswa mahasiswaController = new Mahasiswa();
                mahasiswaController.Insert(mhs);

                ResetForm();
                Tampil();
            }
        }


        private void ResetForm()
        {
            textBoxNPM.Text = "";
            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
            textBoxEmail.Text = "";
            textBoxNohp.Text = "";
            comboBoxAngkatan.SelectedIndex = -1;
        }
        private void textBoxNPM_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAngkatan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNohp_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNPM.Text = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxAngkatan.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxAlamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxEmail.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxNohp.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {

            if (textBoxNPM.Text == "" || textBoxNama.Text == "" || comboBoxAngkatan.SelectedIndex == -1 || textBoxAlamat.Text == "" || textBoxEmail.Text == "" || textBoxNohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                M_mahasiswa mhs = new M_mahasiswa
                {
                    Npm = textBoxNPM.Text,
                    Nama = textBoxNama.Text,
                    Angkatan = comboBoxAngkatan.Text,
                    Alamat = textBoxAlamat.Text,
                    Email = textBoxEmail.Text,
                    Nohp = textBoxNohp.Text
                };

                Mahasiswa mahasiswaController = new Mahasiswa();
                mahasiswaController.Update(mhs, textBoxNPM.Text);  
                ResetForm();
                Tampil();
            }
            }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Tampil();
            ResetForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                 "Apakah yakin akan menghapus data ini?",
                 "Perhatian",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(textBoxNPM.Text);
                ResetForm();
                Tampil();
            }
        }
    }
}
