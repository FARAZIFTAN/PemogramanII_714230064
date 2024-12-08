namespace P6_1_714230064
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
            this.label2 = new System.Windows.Forms.Label();
            this.vbButton1 = new System.Windows.Forms.Button();
            this.csButton2 = new System.Windows.Forms.Button();
            this.Closebutton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Whisch do you think is better, Visual Basic or C#?";
            // 
            // vbButton1
            // 
            this.vbButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.vbButton1.Location = new System.Drawing.Point(82, 151);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(139, 39);
            this.vbButton1.TabIndex = 1;
            this.vbButton1.Text = "Visual Basic";
            this.vbButton1.UseVisualStyleBackColor = true;
            this.vbButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vbButton1_MouseMove);
            // 
            // csButton2
            // 
            this.csButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csButton2.ForeColor = System.Drawing.Color.ForestGreen;
            this.csButton2.Location = new System.Drawing.Point(378, 154);
            this.csButton2.Name = "csButton2";
            this.csButton2.Size = new System.Drawing.Size(93, 36);
            this.csButton2.TabIndex = 2;
            this.csButton2.Text = "C#";
            this.csButton2.UseVisualStyleBackColor = true;
            this.csButton2.Click += new System.EventHandler(this.csButton2_Click);
            // 
            // Closebutton3
            // 
            this.Closebutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebutton3.ForeColor = System.Drawing.Color.Crimson;
            this.Closebutton3.Location = new System.Drawing.Point(82, 271);
            this.Closebutton3.Name = "Closebutton3";
            this.Closebutton3.Size = new System.Drawing.Size(114, 41);
            this.Closebutton3.TabIndex = 3;
            this.Closebutton3.Text = "Close";
            this.Closebutton3.UseVisualStyleBackColor = true;
            this.Closebutton3.Click += new System.EventHandler(this.Closebutton3_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(564, 427);
            this.Controls.Add(this.Closebutton3);
            this.Controls.Add(this.csButton2);
            this.Controls.Add(this.vbButton1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vbButton;
        private System.Windows.Forms.Button csButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button vbButton1;
        private System.Windows.Forms.Button csButton2;
        private System.Windows.Forms.Button Closebutton3;
    }
}

