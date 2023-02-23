using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int kactaBitsin;
        Random ras=new Random();
        int rastgele;
        int ilkOyuncu=0, ikinciOyuncu=0;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            kactaBitsin = Convert.ToInt32(textBox1.Text);
            if(kactaBitsin>100 || kactaBitsin<=-1)
            {
                MessageBox.Show("Oyun 1-100 Arasında Bitmeli", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            textBox1.Text = "";
            label8.Text = "";

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label6.Text = "";
            label5.Text = "";
            ilkOyuncu = 0;
            ikinciOyuncu = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            
            rastgele = ras.Next(1, 7);
            
            pictureBox1.Image = Image.FromFile(rastgele + ".jpeg");
            ilkOyuncu += rastgele;
            button2.Enabled = false;
            button3.Enabled = true;

            if (ikinciOyuncu>=kactaBitsin)
            {
                label8.Text = "İKİNCİ OYUNCU KAZANDI";
                button4.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else if (ilkOyuncu >= kactaBitsin)
            {
                label8.Text = "İLK OYUNCU KAZANDI";
                button4.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                
                label5.Text = ilkOyuncu.ToString();
                
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        int i,k=0;
        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            rastgele = ras.Next(1, 7);
            
            pictureBox2.Image = Image.FromFile(rastgele + ".jpeg");
            ikinciOyuncu += rastgele;

            button3.Enabled = false;
            button2.Enabled = true;
            
            if (ilkOyuncu >= kactaBitsin)
            {
                label8.Text = "İLK OYUNCU KAZANDI";
                button4.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else if (ikinciOyuncu>=kactaBitsin)
            {
                label8.Text = "İKİNCİ OYUNCU KAZANDI";
                button4.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                
            }
            
            else
            {
               
                
                label6.Text = ikinciOyuncu.ToString();
                
            }
            
        }
    }
}
