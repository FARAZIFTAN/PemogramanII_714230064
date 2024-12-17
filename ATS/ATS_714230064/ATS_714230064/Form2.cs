using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ATS_714230064
{
    public partial class Form2 : Form
    {
        private ErrorProvider errorProvider;
        public Form2()
        {
            InitializeComponent();
            this.Size = new Size(700, 230);
            this.StartPosition = FormStartPosition.CenterScreen;
            errorProvider = new ErrorProvider();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void PilihMataKuliah_Click(object sender, EventArgs e)
        {
            string npm = NPMtextBox1.Text;
            string nama = NamatextBox2.Text;
            string alamat = AlamattextBox3.Text;
            string tahunAkademik = TahuntextBox4.Text;
            string kelas = KelastextBox5.Text;
            string jenisKelamin = radioButton1.Checked ? "Laki - Laki" : radioButton2.Checked ? "Perempuan" : null;
            if (string.IsNullOrWhiteSpace(npm) || !int.TryParse(npm, out _))
            {
                ShowWarning("NPM harus diisi dan harus berupa angka!");
                return;
            }
            if (string.IsNullOrWhiteSpace(nama) || !Regex.IsMatch(nama, @"^[a-zA-Z\s]+$"))
            {
                ShowWarning("Nama harus diisi dan harus berupa huruf!");
                return;
            }
            if (string.IsNullOrWhiteSpace(jenisKelamin))
            {
                ShowWarning("Jenis Kelamin belum dipilih!");
                return;
            }
            if (string.IsNullOrWhiteSpace(alamat))
            {
                ShowWarning("Alamat belum diisi!");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBox1.SelectedItem?.ToString()))
            {
                ShowWarning("Program Studi belum dipilih!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tahunAkademik) || !Regex.IsMatch(tahunAkademik, @"^\d{4}/\d{4}$"))
            {
                ShowWarning("Format Tahun Akademik Salah!!");
                return;
            }
            if (string.IsNullOrWhiteSpace(kelas))
            {
                ShowWarning("Kelas belum diisi!");
                return;
            }

            MessageBox.Show("Lengkap!", "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Size = new Size(700, 460);
            ShowAdditionalElements();
        }
        private void ShowAdditionalElements()
        {
            groupBox1Semester.Visible = true;
            groupBox2MataKuliah.Visible = true;
        }
        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void NPMtextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(NPMtextBox1.Text, out _))
            {
                errorProvider.SetError(NPMtextBox1, "Inputan NPM hanya boleh angka!");
            }
            else
            {
                errorProvider.SetError(NPMtextBox1, string.Empty);
            }
        }
        private void NamatextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(NamatextBox2.Text, @"^[a-zA-Z\s]+$"))
            {
                errorProvider.SetError(NamatextBox2, "Inputan Nama hanya boleh huruf!");
            }
            else
            {
                errorProvider.SetError(NamatextBox2, string.Empty);
            }
        }
        private void TahuntextBox4_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TahuntextBox4.Text, @"^\d{4}/\d{4}$"))
            {
                errorProvider.SetError(TahuntextBox4, "Format Tahun Akademik harus nnnn/nnnn");
            }
            else
            {
                errorProvider.SetError(TahuntextBox4, string.Empty);
            }
        }
        private void AlamattextBox3_TextChanged(object sender, EventArgs e) { }
        private void KelastextBox5_TextChanged(object sender, EventArgs e) { }
        private void Semester1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Semester1RadioButton.Checked)
            {
                SetCheckboxesEnabled(false);
                LiterasiDataCheckBox.Enabled = true;
                PendidikanPancasilaCheckBox.Enabled = true;
                PemrogramanICheckBox.Enabled = true;
                AlgoritmaStrukturData1CheckBox.Enabled = true;
                MatematikaDiskritCheckBox.Enabled = true;
            }
        }
        private void SetCheckboxesEnabled(bool enabled)
        {
            LiterasiDataCheckBox.Enabled = enabled;
            PendidikanPancasilaCheckBox.Enabled = enabled;
            PemrogramanICheckBox.Enabled = enabled;
            AlgoritmaStrukturData1CheckBox.Enabled = enabled;
            MatematikaDiskritCheckBox.Enabled = enabled;
            AljabarLinierCheckBox.Enabled = enabled;
            BasisDataICheckBox.Enabled = enabled;
            LiterasiTeknologiCheckBox.Enabled = enabled;
            PengantarLogistikCheckBox.Enabled = enabled;
            PemrogramanIICheckBox.Enabled = enabled;
            BasisDataIICheckBox.Enabled = enabled;
            AlgoritmaStrukturData2CheckBox.Enabled = enabled;
        }
        private void Semester2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Semester2RadioButton.Checked)
            {
                SetCheckboxesEnabled(false);
                AljabarLinierCheckBox.Enabled = true;
                BasisDataICheckBox.Enabled = true;
                LiterasiTeknologiCheckBox.Enabled = true;
                PengantarLogistikCheckBox.Enabled = true;
            }
        }
        private void Semester3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Semester3RadioButton.Checked)
            {
                SetCheckboxesEnabled(false);
                PemrogramanIICheckBox.Enabled = true;
                BasisDataIICheckBox.Enabled = true;
                AlgoritmaStrukturData2CheckBox.Enabled = true;
            }
        }
        private void SimpanButton_Click(object sender, EventArgs e)
        {
            string npm = NPMtextBox1.Text;
            string nama = NamatextBox2.Text;
            string alamat = AlamattextBox3.Text;
            string tahunAkademik = TahuntextBox4.Text;
            string kelas = KelastextBox5.Text;
            string jenisKelamin = radioButton1.Checked ? "Laki - Laki" : "Perempuan";
            string semester = Semester1RadioButton.Checked ? "Semester 1" :
                              Semester2RadioButton.Checked ? "Semester 2" : "Semester 3";

            var mataKuliah = new List<string>();
            if (LiterasiDataCheckBox.Checked) mataKuliah.Add("Literasi Data");
            if (PendidikanPancasilaCheckBox.Checked) mataKuliah.Add("Pendidikan Pancasila");
            if (PemrogramanICheckBox.Checked) mataKuliah.Add("Pemrograman I");
            if (PemrogramanIICheckBox.Checked) mataKuliah.Add("Pemrograman II");
            if (MatematikaDiskritCheckBox.Checked) mataKuliah.Add("Matematika Diskrit");
            if (AljabarLinierCheckBox.Checked) mataKuliah.Add("Aljabar Linier");
            if (BasisDataICheckBox.Checked) mataKuliah.Add("Basis Data I");
            if (BasisDataIICheckBox.Checked) mataKuliah.Add("Basis Data II");
            if (LiterasiTeknologiCheckBox.Checked) mataKuliah.Add("Literasi Teknologi");
            if (PengantarLogistikCheckBox.Checked) mataKuliah.Add("Pengantar Logistik dan SCM");
            if (AlgoritmaStrukturData1CheckBox.Checked) mataKuliah.Add("Algoritma dan Struktur Data 1");
            if (AlgoritmaStrukturData2CheckBox.Checked) mataKuliah.Add("Algoritma dan Struktur Data 2");

            string message = $"NIM: {npm}\nNama: {nama}\nJenis Kelamin: {jenisKelamin}\nAlamat: {alamat}\n" +
                             $"Program Studi: {comboBox1.SelectedItem}\nTahun Akademik: {tahunAkademik}\n" +
                             $"Kelas: {kelas}\n{semester}\nMata Kuliah:\n" + string.Join(", ", mataKuliah);

            MessageBox.Show(message, "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BatalButton_Click(object sender, EventArgs e)
        {
            NPMtextBox1.Clear();
            NamatextBox2.Clear();
            AlamattextBox3.Clear();
            TahuntextBox4.Clear();
            KelastextBox5.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.SelectedIndex = -1;
            Semester1RadioButton.Checked = false;
            Semester2RadioButton.Checked = false;
            Semester3RadioButton.Checked = false;
            SetCheckboxesEnabled(false);
            LiterasiDataCheckBox.Checked = false;
            PendidikanPancasilaCheckBox.Checked = false;
            PemrogramanICheckBox.Checked = false;
            PemrogramanIICheckBox.Checked = false;
            MatematikaDiskritCheckBox.Checked = false;
            AljabarLinierCheckBox.Checked = false;
            BasisDataICheckBox.Checked = false;
            BasisDataIICheckBox.Checked = false;
            LiterasiTeknologiCheckBox.Checked = false;
            PengantarLogistikCheckBox.Checked = false;
            AlgoritmaStrukturData1CheckBox.Checked = false;
            AlgoritmaStrukturData2CheckBox.Checked = false;
            this.Size = new Size(700, 230);
        }

    }
}
