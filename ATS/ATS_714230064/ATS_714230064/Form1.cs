using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS_714230064
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newChild = new Form2();

           
            newChild.MdiParent = this;

            newChild.Size = new System.Drawing.Size(700, 230); 


            newChild.StartPosition = FormStartPosition.CenterScreen; 

            
            newChild.FormBorderStyle = FormBorderStyle.FixedSingle; 
            newChild.MaximizeBox = false; 
            newChild.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
