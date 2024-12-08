using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace P6_3_714230064
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetErrorMessages(TextBox textBox, string warningMessage = "", string wrongMessage = "", string correctMessage = "")
        {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }

        private void ClearErrorMessages(TextBox textBox)
        {
            SetErrorMessages(textBox);
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHuruf.Text))
            {
                SetErrorMessages(txtHuruf, "Textbox Huruf tidak boleh kosong!");
            }
            else if (txtHuruf.Text.All(Char.IsLetter))
            {
                SetErrorMessages(txtHuruf, correctMessage: "Betul!");
            }
            else
            {
                SetErrorMessages(txtHuruf, wrongMessage: "Inputan hanya boleh huruf!");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAngka.Text))
            {
                SetErrorMessages(txtAngka, "Textbox angka tidak boleh kosong!");
            }
            else if (txtAngka.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka, correctMessage: "Betul!");
            }
            else
            {
                SetErrorMessages(txtAngka, wrongMessage: "Inputan hanya boleh angka!");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                SetErrorMessages(txtEmail, "Textbox Email tidak boleh kosong!");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                SetErrorMessages(txtEmail, correctMessage: "Betul!");
            }
            else
            {
                SetErrorMessages(txtEmail, wrongMessage: "Format email salah!\n Contoh: a@b.c");
            }
        }

        private void txtAngka1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAngka1.Text))
            {
                SetErrorMessages(txtAngka1, "Textbox angka1 tidak boleh kosong!");
            }
            else if (txtAngka1.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka1, correctMessage: "Betul!");
            }
            else
            {
                SetErrorMessages(txtAngka1, wrongMessage: "Inputan hanya boleh angka!");
            }
        }

        private void txtAngka2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAngka2.Text))
            {
                SetErrorMessages(txtAngka2, "Textbox angka2 tidak boleh kosong!");
            }
            else if (txtAngka2.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka2, correctMessage: "Betul!");
            }
            else
            {
                SetErrorMessages(txtAngka2, wrongMessage: "Inputan hanya boleh angka!");
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAngka1.Text))
            {
                SetErrorMessages(txtAngka1, warningMessage: "Textbox Angka1 tidak boleh kosong!");
            }
            else if (!int.TryParse(txtAngka1.Text, out int angka1))
            {
                SetErrorMessages(txtAngka1, wrongMessage: "Masukkan angka yang valid untuk Angka1!");
            }
            else if (!string.IsNullOrWhiteSpace(txtAngka2.Text) && int.TryParse(txtAngka2.Text, out int angka2))
            {
                if (angka1 <= angka2)
                {
                    SetErrorMessages(txtAngka1, wrongMessage: "Angka1 harus lebih besar dari Angka2!");
                }
                else
                {
                    SetErrorMessages(txtAngka1, correctMessage: "Betul!");
                }
            }
            else
            {
                SetErrorMessages(txtAngka1, correctMessage: "Betul!");
            }
        }


        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAngka2.Text))
            {
                SetErrorMessages(txtAngka2, warningMessage: "Textbox Angka2 tidak boleh kosong!");
            }
            else if (!int.TryParse(txtAngka2.Text, out int angka2))
            {
                SetErrorMessages(txtAngka2, wrongMessage: "Masukkan angka yang valid untuk Angka2!");
            }
            else if (!string.IsNullOrWhiteSpace(txtAngka1.Text) && int.TryParse(txtAngka1.Text, out int angka1))
            {
                if (angka1 <= angka2)
                {
                    SetErrorMessages(txtAngka2, wrongMessage: "Angka1 harus lebih besar dari Angka2!");
                    SetErrorMessages(txtAngka1, wrongMessage: "Angka1 harus lebih besar dari Angka2!");
                }
                else
                {
                    SetErrorMessages(txtAngka2, correctMessage: "Betul!");
                    SetErrorMessages(txtAngka1, correctMessage: "Betul!");
                }
            }
            else
            {
                SetErrorMessages(txtAngka2, correctMessage: "Betul!");
            }
        }

    }
}
