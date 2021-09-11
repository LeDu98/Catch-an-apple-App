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
    public partial class Form2 : Form
    {
        public static string passingText1;
        public static string passingText2;
        Random R = new Random(); 

        public Form2()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form2_KeyDown); 
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;


            if (e.KeyCode == Keys.Right && x < ClientRectangle.Width - 120) x += 30; 
            else if (e.KeyCode == Keys.Left && x > 20)  x -= 30;
            

            pictureBox1.Location = new Point(x, y);
        }
      
        
        private bool IsTouching(PictureBox p1, PictureBox p2)
        {
            if (p1.Location.X + p1.Width < p2.Location.X)
                return false;
            if (p2.Location.X + p2.Width < p1.Location.X)
                return false;
            if (p1.Location.Y + p1.Height < p2.Location.Y)
                return false;
            if (p2.Location.Y + p2.Height < p1.Location.Y)
                return false;
            else return true;
        }
        int skor = 0;

        private void Kraj(PictureBox jabuka)
        {
            if (jabuka.Location.Y > ClientRectangle.Height - 10)
            {
                Pokretanje.Stop(); Sat.Stop(); jabukaa.Stop(); Form3 frm = new Form3(); passingText1 = label2.Text; passingText2 = label4.Text;
                frm.Show();
            }
        }
        private void Pogodak(PictureBox PictureBox1, PictureBox apple)
        {
            if (PictureBox1.Location.Y == apple.Location.Y && PictureBox1.Location.X == apple.Location.X)
            {
                
                apple.Visible = false;
                

                skor = skor + 100;
            }

        }
       

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.passingText;
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        
       

        
      

        int min = 0, sec = 0; int broj = 50;
        private void Sat_Tick(object sender, EventArgs e)
        {
      
            if (sec < 10 && min < 10) { label2.Text = Convert.ToString("0" + min + ":" + "0" + sec); }
            else if (min < 10) label2.Text = Convert.ToString("0" + min + ":" + sec);
            else label2.Text = Convert.ToString(min + ":" + sec);

            if (sec == 59)
            {
                sec = 0; min++; label3.Visible = true; label3.Text = "Nivo " + (min + 1); if (broj != 10) broj = broj - 5;

            }
            else { sec ++;  label3.Visible = false; }


            int prom1 = 1; int prom2 = 2; int prom3 = 3; int prom4 = 4;
            int prom5 =5; int prom6 = 6; int prom7 = 7; int prom8 = 8;
            int prom9 = 9; int prom10 = 10; int prom11 =11; int prom12 = 12;
            int prom13 = 13; int prom14=14; int prom15 = 15; int prom16 = 16;
            int prom17 = 17; int prom18 = 18; int prom19 = 19; int prom20 = 20; int rnd = R.Next(0, 40);

            if (prom1 == rnd) pictureBox2.Visible = true;
             if (prom2 == rnd) pictureBox3.Visible = true;
             if (prom3 == rnd) pictureBox4.Visible = true;
             if (prom4 == rnd) pictureBox5.Visible = true;
             if (prom5 == rnd) pictureBox6.Visible = true;
             if (prom6 == rnd) pictureBox7.Visible = true;
             if (prom7 == rnd) pictureBox8.Visible = true;
             if (prom8 == rnd) pictureBox9.Visible = true;
             if (prom9 == rnd) pictureBox10.Visible = true;
             if (prom10 == rnd) pictureBox11.Visible = true;
             if (prom11 == rnd && min>= 1 ) pictureBox12.Visible = true;
             if (prom12 == rnd && min >= 1) pictureBox13.Visible = true;
             if (prom13 == rnd && min >= 1) pictureBox14.Visible = true;
             if (prom14 == rnd && min >= 1) pictureBox15.Visible = true;
             if (prom15 == rnd && min >= 1) pictureBox16.Visible = true;
             if (prom16 == rnd && min >= 1) pictureBox17.Visible = true;
             if (prom17 == rnd && min >= 1) pictureBox18.Visible = true;
             if (prom18 == rnd && min >= 1) pictureBox19.Visible = true;
             if (prom19 == rnd && min >=1) pictureBox20.Visible = true;
             if (prom20 == rnd && min >= 1) pictureBox21.Visible = true;

        }
        
        private void jabuka_Tick(object sender, EventArgs e)
        {
         

            if (IsTouching(pictureBox2, pictureBox1) == true && pictureBox2.Visible == true) { pictureBox2.Visible = false; pictureBox2.Location = new Point(30, 13); skor = skor + 100; } 
            if (IsTouching(pictureBox3, pictureBox1) == true && pictureBox3.Visible == true) { pictureBox3.Visible = false; pictureBox3.Location = new Point(92, 13); skor = skor + 100; }
            if (IsTouching(pictureBox4, pictureBox1) == true && pictureBox4.Visible == true) { pictureBox4.Visible = false; pictureBox4.Location = new Point(158, 13); skor = skor + 100; }
            if (IsTouching(pictureBox5, pictureBox1) == true && pictureBox5.Visible == true) { pictureBox5.Visible = false; pictureBox5.Location = new Point(222, 13); skor = skor + 100; }
            if (IsTouching(pictureBox6, pictureBox1) == true && pictureBox6.Visible == true) { pictureBox6.Visible = false; pictureBox6.Location = new Point(286, 13); skor = skor + 100; }
            if (IsTouching(pictureBox7, pictureBox1) == true && pictureBox7.Visible == true) { pictureBox7.Visible = false; pictureBox7.Location = new Point(359, 13); skor = skor + 100; }
            if (IsTouching(pictureBox8, pictureBox1) == true && pictureBox8.Visible == true) { pictureBox8.Visible = false; pictureBox8.Location = new Point(433, 13); skor = skor + 100; }
            if (IsTouching(pictureBox9, pictureBox1) == true && pictureBox9.Visible == true) { pictureBox9.Visible = false; pictureBox9.Location = new Point(505, 13); skor = skor + 100; }
            if (IsTouching(pictureBox10, pictureBox1) == true && pictureBox10.Visible == true) { pictureBox10.Visible = false; pictureBox10.Location = new Point(580, 13); skor = skor + 100; }
            if (IsTouching(pictureBox11, pictureBox1) == true && pictureBox11.Visible == true) { pictureBox11.Visible = false; pictureBox11.Location = new Point(644, 13); skor = skor + 100; }
            if (IsTouching(pictureBox12, pictureBox1) == true && pictureBox12.Visible == true) { pictureBox12.Visible = false; pictureBox12.Location = new Point(30, 88); skor = skor + 100; }
            if (IsTouching(pictureBox13, pictureBox1) == true && pictureBox13.Visible == true) { pictureBox13.Visible = false; pictureBox13.Location = new Point(92, 88); skor = skor + 100; }
            if (IsTouching(pictureBox14, pictureBox1) == true && pictureBox14.Visible == true) { pictureBox14.Visible = false; pictureBox14.Location = new Point(158, 88); skor = skor + 100; }
            if (IsTouching(pictureBox15, pictureBox1) == true && pictureBox15.Visible == true) { pictureBox15.Visible = false; pictureBox15.Location = new Point(222, 88); skor = skor + 100; }
            if (IsTouching(pictureBox16, pictureBox1) == true && pictureBox16.Visible == true) { pictureBox16.Visible = false; pictureBox16.Location = new Point(286, 88); skor = skor + 100; }
            if (IsTouching(pictureBox17, pictureBox1) == true && pictureBox17.Visible == true) { pictureBox17.Visible = false; pictureBox17.Location = new Point(359, 88); skor = skor + 100; }
            if (IsTouching(pictureBox18, pictureBox1) == true && pictureBox18.Visible == true) { pictureBox18.Visible = false; pictureBox18.Location = new Point(433, 88); skor = skor + 100; }
            if (IsTouching(pictureBox19, pictureBox1) == true && pictureBox19.Visible == true) { pictureBox19.Visible = false; pictureBox19.Location = new Point(505, 88); skor = skor + 100; }
            if (IsTouching(pictureBox20, pictureBox1) == true && pictureBox20.Visible == true) { pictureBox20.Visible = false; pictureBox20.Location = new Point(580, 88); skor = skor + 100; }
            if (IsTouching(pictureBox21, pictureBox1) == true && pictureBox21.Visible == true) { pictureBox21.Visible = false; pictureBox21.Location = new Point(644, 88); skor = skor + 100; }
            label4.Text = Convert.ToString(skor);
        }

        private void Pokretanje_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true) pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 3);
            if (pictureBox3.Visible == true) pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 3);
            if (pictureBox4.Visible == true) pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + 3);
            if (pictureBox5.Visible == true) pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + 3);
            if (pictureBox6.Visible == true) pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 3);
            if (pictureBox7.Visible == true) pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y + 3);
            if (pictureBox8.Visible == true) pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y + 3);
            if (pictureBox9.Visible == true) pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y + 3);
            if (pictureBox10.Visible == true) pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y + 3);
            if (pictureBox11.Visible == true) pictureBox11.Location = new Point(pictureBox11.Location.X, pictureBox11.Location.Y + 3);
            if (pictureBox12.Visible == true) pictureBox12.Location = new Point(pictureBox12.Location.X, pictureBox12.Location.Y + 3);
            if (pictureBox13.Visible == true) pictureBox13.Location = new Point(pictureBox13.Location.X, pictureBox13.Location.Y + 3);
            if (pictureBox14.Visible == true) pictureBox14.Location = new Point(pictureBox14.Location.X, pictureBox14.Location.Y + 3);
            if (pictureBox15.Visible == true) pictureBox15.Location = new Point(pictureBox15.Location.X, pictureBox15.Location.Y + 3);
            if (pictureBox16.Visible == true) pictureBox16.Location = new Point(pictureBox16.Location.X, pictureBox16.Location.Y + 3);
            if (pictureBox17.Visible == true) pictureBox17.Location = new Point(pictureBox17.Location.X, pictureBox17.Location.Y + 3);
            if (pictureBox18.Visible == true) pictureBox18.Location = new Point(pictureBox18.Location.X, pictureBox18.Location.Y + 3);
            if (pictureBox19.Visible == true) pictureBox19.Location = new Point(pictureBox19.Location.X, pictureBox19.Location.Y + 3);
            if (pictureBox20.Visible == true) pictureBox20.Location = new Point(pictureBox20.Location.X, pictureBox20.Location.Y + 3);
            if (pictureBox21.Visible == true) pictureBox21.Location = new Point(pictureBox21.Location.X, pictureBox21.Location.Y + 3);

            Kraj(pictureBox2); Kraj(pictureBox3); Kraj(pictureBox4); Kraj(pictureBox5); Kraj(pictureBox6); Kraj(pictureBox7); Kraj(pictureBox8); Kraj(pictureBox9); Kraj(pictureBox10);
            Kraj(pictureBox11); Kraj(pictureBox12); Kraj(pictureBox13); Kraj(pictureBox14); Kraj(pictureBox15); Kraj(pictureBox16); Kraj(pictureBox17); Kraj(pictureBox18); Kraj(pictureBox19);
            Kraj(pictureBox20); Kraj(pictureBox21);
        }

      
        }

       


     }
