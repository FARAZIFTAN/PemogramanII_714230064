using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_1_714230064
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void vbButton1_MouseMove(object sender, MouseEventArgs e)
        {

            vbButton1.Top += e.Y / 2;  
            vbButton1.Left += e.X / 2;

            if (vbButton1.Top < -16 || vbButton1.Top > 160)
                vbButton1.Top = 73; 
            if (vbButton1.Left < -64 || vbButton1.Left > 384)
                vbButton1.Left = 160; 
        }

        private void csButton2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Correct!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Closebutton3_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }
    }
}
