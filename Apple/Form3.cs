using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apple
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2.ActiveForm.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label4.Text = Form1.passingText;
            label5.Text = Form2.passingText1;
            label6.Text = Form2.passingText2;
        }

        
    }
}
