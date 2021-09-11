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
  public partial class Form1 : Form
    {
        public static string passingText;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pomeranje u levo-Leva strelica" + "\n" + "Pomeranje u Desno-Desna strelica" + "\n" , "Kontrole");

        }

        private void button2_Click(object sender, EventArgs e)
        {
                      passingText = textBox1.Text;
                            Form2 frm = new Form2();
                frm.Show();
                this.Hide();


        }

         }
    }

