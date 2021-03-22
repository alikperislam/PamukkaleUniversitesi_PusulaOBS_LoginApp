using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace öğrenci_bilgi_sistemi_uygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
        }

        
        
        
        private void button2_Click(object sender, EventArgs e)
        {
           
             string kul, kul2, par, par2;
             kul =txtkul1.Text ;
             kul2 =txtkul2.Text ;
             par =txtparola1.Text ;
             par2 =txtparola2.Text ;
            
            if (kul=="" || kul2=="" || par=="" || par2=="")
            {
                lblUyar.Text ="Hiçbir kutucuk boş bırakılamaz !!!";
                lblUyar.ForeColor = Color.Red;

            }
            else
            {
                if (kul==kul2 && par== par2)
                {
                    Form1 fr11 = new Form1();
                    fr11.kayitKullanici = kul;
                    fr11.kayitParola = par;
                    fr11.Show();

                }
                else
                {
                    lblUyar.Text = "Kullanıcı adı ve parolanızı tekrarları ile aynı giriniz lütfen...";
                    lblUyar.ForeColor = Color.Red;
                }
            }
        }
    }
}
