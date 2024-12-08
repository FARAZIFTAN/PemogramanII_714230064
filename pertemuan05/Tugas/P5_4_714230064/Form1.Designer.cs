namespace P5_4_714230064
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.JenisKelamin = new System.Windows.Forms.Label();
            this.TanggalLahir = new System.Windows.Forms.Label();
            this.FormPendaftaran = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.PilihanKelasBox = new System.Windows.Forms.GroupBox();
            this.PanahanCheck = new System.Windows.Forms.CheckBox();
            this.VoliCheck = new System.Windows.Forms.CheckBox();
            this.BuluTangkisCheck = new System.Windows.Forms.CheckBox();
            this.BasketCheck = new System.Windows.Forms.CheckBox();
            this.YogaCheck = new System.Windows.Forms.CheckBox();
            this.TenisCheck = new System.Windows.Forms.CheckBox();
            this.RenangCheck = new System.Windows.Forms.CheckBox();
            this.SepakBolaCheck = new System.Windows.Forms.CheckBox();
            this.PilihanJadwalBox = new System.Windows.Forms.GroupBox();
            this.MingguButton = new System.Windows.Forms.RadioButton();
            this.SabtuMingguButton = new System.Windows.Forms.RadioButton();
            this.SelasaKamisButton = new System.Windows.Forms.RadioButton();
            this.SeninMingguButton = new System.Windows.Forms.RadioButton();
            this.TampilkanButton = new System.Windows.Forms.Button();
            this.SelesaiButton = new System.Windows.Forms.Button();
            this.PilihanKelasBox.SuspendLayout();
            this.PilihanJadwalBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(219, 110);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Nama";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.AutoSize = true;
            this.JenisKelamin.Location = new System.Drawing.Point(219, 160);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(106, 20);
            this.JenisKelamin.TabIndex = 1;
            this.JenisKelamin.Text = "Jenis Kelamin";
            // 
            // TanggalLahir
            // 
            this.TanggalLahir.AutoSize = true;
            this.TanggalLahir.Location = new System.Drawing.Point(219, 222);
            this.TanggalLahir.Name = "TanggalLahir";
            this.TanggalLahir.Size = new System.Drawing.Size(105, 20);
            this.TanggalLahir.TabIndex = 2;
            this.TanggalLahir.Text = "Tanggal Lahir";
            // 
            // FormPendaftaran
            // 
            this.FormPendaftaran.AutoSize = true;
            this.FormPendaftaran.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormPendaftaran.ForeColor = System.Drawing.Color.Black;
            this.FormPendaftaran.Location = new System.Drawing.Point(324, 21);
            this.FormPendaftaran.Name = "FormPendaftaran";
            this.FormPendaftaran.Size = new System.Drawing.Size(285, 29);
            this.FormPendaftaran.TabIndex = 3;
            this.FormPendaftaran.Text = "FORM PENDAFTARAN";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(348, 104);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(327, 26);
            this.NameBox.TabIndex = 4;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.GenderBox.Location = new System.Drawing.Point(348, 160);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(327, 28);
            this.GenderBox.TabIndex = 5;
            this.GenderBox.SelectedIndexChanged += new System.EventHandler(this.GenderBox_SelectedIndexChanged);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(348, 215);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(327, 26);
            this.Date.TabIndex = 6;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // PilihanKelasBox
            // 
            this.PilihanKelasBox.Controls.Add(this.PanahanCheck);
            this.PilihanKelasBox.Controls.Add(this.VoliCheck);
            this.PilihanKelasBox.Controls.Add(this.BuluTangkisCheck);
            this.PilihanKelasBox.Controls.Add(this.BasketCheck);
            this.PilihanKelasBox.Controls.Add(this.YogaCheck);
            this.PilihanKelasBox.Controls.Add(this.TenisCheck);
            this.PilihanKelasBox.Controls.Add(this.RenangCheck);
            this.PilihanKelasBox.Controls.Add(this.SepakBolaCheck);
            this.PilihanKelasBox.Location = new System.Drawing.Point(70, 310);
            this.PilihanKelasBox.Name = "PilihanKelasBox";
            this.PilihanKelasBox.Size = new System.Drawing.Size(313, 209);
            this.PilihanKelasBox.TabIndex = 7;
            this.PilihanKelasBox.TabStop = false;
            this.PilihanKelasBox.Text = "Pilihan Kelas";
            this.PilihanKelasBox.Enter += new System.EventHandler(this.PilihanKelasBox_Enter);
            // 
            // PanahanCheck
            // 
            this.PanahanCheck.AutoSize = true;
            this.PanahanCheck.Location = new System.Drawing.Point(146, 168);
            this.PanahanCheck.Name = "PanahanCheck";
            this.PanahanCheck.Size = new System.Drawing.Size(99, 24);
            this.PanahanCheck.TabIndex = 7;
            this.PanahanCheck.Text = "Panahan";
            this.PanahanCheck.UseVisualStyleBackColor = true;
            this.PanahanCheck.CheckedChanged += new System.EventHandler(this.PanahanCheck_CheckedChanged);
            // 
            // VoliCheck
            // 
            this.VoliCheck.AutoSize = true;
            this.VoliCheck.Location = new System.Drawing.Point(146, 127);
            this.VoliCheck.Name = "VoliCheck";
            this.VoliCheck.Size = new System.Drawing.Size(61, 24);
            this.VoliCheck.TabIndex = 6;
            this.VoliCheck.Text = "Voli";
            this.VoliCheck.UseVisualStyleBackColor = true;
            this.VoliCheck.CheckedChanged += new System.EventHandler(this.VoliCheck_CheckedChanged);
            // 
            // BuluTangkisCheck
            // 
            this.BuluTangkisCheck.AutoSize = true;
            this.BuluTangkisCheck.Location = new System.Drawing.Point(146, 83);
            this.BuluTangkisCheck.Name = "BuluTangkisCheck";
            this.BuluTangkisCheck.Size = new System.Drawing.Size(126, 24);
            this.BuluTangkisCheck.TabIndex = 5;
            this.BuluTangkisCheck.Text = "Bulu Tangkis";
            this.BuluTangkisCheck.UseVisualStyleBackColor = true;
            this.BuluTangkisCheck.CheckedChanged += new System.EventHandler(this.BuluTangkisCheck_CheckedChanged);
            // 
            // BasketCheck
            // 
            this.BasketCheck.AutoSize = true;
            this.BasketCheck.Location = new System.Drawing.Point(146, 40);
            this.BasketCheck.Name = "BasketCheck";
            this.BasketCheck.Size = new System.Drawing.Size(85, 24);
            this.BasketCheck.TabIndex = 4;
            this.BasketCheck.Text = "Basket";
            this.BasketCheck.UseVisualStyleBackColor = true;
            this.BasketCheck.CheckedChanged += new System.EventHandler(this.BasketCheck_CheckedChanged);
            // 
            // YogaCheck
            // 
            this.YogaCheck.AutoSize = true;
            this.YogaCheck.Location = new System.Drawing.Point(6, 168);
            this.YogaCheck.Name = "YogaCheck";
            this.YogaCheck.Size = new System.Drawing.Size(73, 24);
            this.YogaCheck.TabIndex = 3;
            this.YogaCheck.Text = "Yoga";
            this.YogaCheck.UseVisualStyleBackColor = true;
            this.YogaCheck.CheckedChanged += new System.EventHandler(this.YogaCheck_CheckedChanged);
            // 
            // TenisCheck
            // 
            this.TenisCheck.AutoSize = true;
            this.TenisCheck.Location = new System.Drawing.Point(6, 127);
            this.TenisCheck.Name = "TenisCheck";
            this.TenisCheck.Size = new System.Drawing.Size(73, 24);
            this.TenisCheck.TabIndex = 2;
            this.TenisCheck.Text = "Tenis";
            this.TenisCheck.UseVisualStyleBackColor = true;
            this.TenisCheck.CheckedChanged += new System.EventHandler(this.TenisCheck_CheckedChanged);
            // 
            // RenangCheck
            // 
            this.RenangCheck.AutoSize = true;
            this.RenangCheck.Location = new System.Drawing.Point(6, 83);
            this.RenangCheck.Name = "RenangCheck";
            this.RenangCheck.Size = new System.Drawing.Size(92, 24);
            this.RenangCheck.TabIndex = 1;
            this.RenangCheck.Text = "Renang";
            this.RenangCheck.UseVisualStyleBackColor = true;
            this.RenangCheck.CheckedChanged += new System.EventHandler(this.RenangCheck_CheckedChanged);
            // 
            // SepakBolaCheck
            // 
            this.SepakBolaCheck.AutoSize = true;
            this.SepakBolaCheck.Location = new System.Drawing.Point(6, 40);
            this.SepakBolaCheck.Name = "SepakBolaCheck";
            this.SepakBolaCheck.Size = new System.Drawing.Size(117, 24);
            this.SepakBolaCheck.TabIndex = 0;
            this.SepakBolaCheck.Text = "Sepak Bola";
            this.SepakBolaCheck.UseVisualStyleBackColor = true;
            this.SepakBolaCheck.CheckedChanged += new System.EventHandler(this.SepakBolaCheck_CheckedChanged);
            // 
            // PilihanJadwalBox
            // 
            this.PilihanJadwalBox.Controls.Add(this.MingguButton);
            this.PilihanJadwalBox.Controls.Add(this.SabtuMingguButton);
            this.PilihanJadwalBox.Controls.Add(this.SelasaKamisButton);
            this.PilihanJadwalBox.Controls.Add(this.SeninMingguButton);
            this.PilihanJadwalBox.Location = new System.Drawing.Point(443, 320);
            this.PilihanJadwalBox.Name = "PilihanJadwalBox";
            this.PilihanJadwalBox.Size = new System.Drawing.Size(316, 199);
            this.PilihanJadwalBox.TabIndex = 8;
            this.PilihanJadwalBox.TabStop = false;
            this.PilihanJadwalBox.Text = "Pilihan Jadwal";
            this.PilihanJadwalBox.Enter += new System.EventHandler(this.PilihanJadwalBox_Enter);
            // 
            // MingguButton
            // 
            this.MingguButton.AutoSize = true;
            this.MingguButton.Location = new System.Drawing.Point(7, 157);
            this.MingguButton.Name = "MingguButton";
            this.MingguButton.Size = new System.Drawing.Size(179, 24);
            this.MingguButton.TabIndex = 3;
            this.MingguButton.TabStop = true;
            this.MingguButton.Text = "Minggu, 13.00-20.00";
            this.MingguButton.UseVisualStyleBackColor = true;
            this.MingguButton.CheckedChanged += new System.EventHandler(this.MingguButton_CheckedChanged);
            // 
            // SabtuMingguButton
            // 
            this.SabtuMingguButton.AutoSize = true;
            this.SabtuMingguButton.Location = new System.Drawing.Point(7, 116);
            this.SabtuMingguButton.Name = "SabtuMingguButton";
            this.SabtuMingguButton.Size = new System.Drawing.Size(251, 24);
            this.SabtuMingguButton.TabIndex = 2;
            this.SabtuMingguButton.TabStop = true;
            this.SabtuMingguButton.Text = "Sabtu s/d Minggu, 09.00-11.00";
            this.SabtuMingguButton.UseVisualStyleBackColor = true;
            this.SabtuMingguButton.CheckedChanged += new System.EventHandler(this.SabtuMingguButton_CheckedChanged);
            // 
            // SelasaKamisButton
            // 
            this.SelasaKamisButton.AutoSize = true;
            this.SelasaKamisButton.Location = new System.Drawing.Point(7, 72);
            this.SelasaKamisButton.Name = "SelasaKamisButton";
            this.SelasaKamisButton.Size = new System.Drawing.Size(248, 24);
            this.SelasaKamisButton.TabIndex = 1;
            this.SelasaKamisButton.TabStop = true;
            this.SelasaKamisButton.Text = "Selasa s/d Kamis, 14.00-16.00";
            this.SelasaKamisButton.UseVisualStyleBackColor = true;
            this.SelasaKamisButton.CheckedChanged += new System.EventHandler(this.SelasaKamisButton_CheckedChanged);
            // 
            // SeninMingguButton
            // 
            this.SeninMingguButton.AutoSize = true;
            this.SeninMingguButton.Location = new System.Drawing.Point(7, 30);
            this.SeninMingguButton.Name = "SeninMingguButton";
            this.SeninMingguButton.Size = new System.Drawing.Size(240, 24);
            this.SeninMingguButton.TabIndex = 0;
            this.SeninMingguButton.TabStop = true;
            this.SeninMingguButton.Text = "Senin s/d Rabu, 14.00 -16.00";
            this.SeninMingguButton.UseVisualStyleBackColor = true;
            this.SeninMingguButton.CheckedChanged += new System.EventHandler(this.SeninMingguButton_CheckedChanged);
            // 
            // TampilkanButton
            // 
            this.TampilkanButton.Location = new System.Drawing.Point(225, 547);
            this.TampilkanButton.Name = "TampilkanButton";
            this.TampilkanButton.Size = new System.Drawing.Size(117, 38);
            this.TampilkanButton.TabIndex = 9;
            this.TampilkanButton.Text = "Tampilkan";
            this.TampilkanButton.UseVisualStyleBackColor = true;
            this.TampilkanButton.Click += new System.EventHandler(this.TampilkanButton_Click);
            // 
            // SelesaiButton
            // 
            this.SelesaiButton.Location = new System.Drawing.Point(450, 546);
            this.SelesaiButton.Name = "SelesaiButton";
            this.SelesaiButton.Size = new System.Drawing.Size(126, 39);
            this.SelesaiButton.TabIndex = 10;
            this.SelesaiButton.Text = "Selesai";
            this.SelesaiButton.UseVisualStyleBackColor = true;
            this.SelesaiButton.Click += new System.EventHandler(this.SelesaiButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(873, 610);
            this.Controls.Add(this.SelesaiButton);
            this.Controls.Add(this.TampilkanButton);
            this.Controls.Add(this.PilihanJadwalBox);
            this.Controls.Add(this.PilihanKelasBox);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.FormPendaftaran);
            this.Controls.Add(this.TanggalLahir);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "LABEL";
            this.PilihanKelasBox.ResumeLayout(false);
            this.PilihanKelasBox.PerformLayout();
            this.PilihanJadwalBox.ResumeLayout(false);
            this.PilihanJadwalBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label JenisKelamin;
        private System.Windows.Forms.Label TanggalLahir;
        private System.Windows.Forms.Label FormPendaftaran;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.GroupBox PilihanKelasBox;
        private System.Windows.Forms.GroupBox PilihanJadwalBox;
        private System.Windows.Forms.CheckBox PanahanCheck;
        private System.Windows.Forms.CheckBox VoliCheck;
        private System.Windows.Forms.CheckBox BuluTangkisCheck;
        private System.Windows.Forms.CheckBox BasketCheck;
        private System.Windows.Forms.CheckBox YogaCheck;
        private System.Windows.Forms.CheckBox TenisCheck;
        private System.Windows.Forms.CheckBox RenangCheck;
        private System.Windows.Forms.CheckBox SepakBolaCheck;
        private System.Windows.Forms.RadioButton SeninMingguButton;
        private System.Windows.Forms.RadioButton MingguButton;
        private System.Windows.Forms.RadioButton SabtuMingguButton;
        private System.Windows.Forms.RadioButton SelasaKamisButton;
        private System.Windows.Forms.Button TampilkanButton;
        private System.Windows.Forms.Button SelesaiButton;
    }
}

