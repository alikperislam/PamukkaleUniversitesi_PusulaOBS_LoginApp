using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace öğrenci_bilgi_sistemi_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        public string kayitKullanici, kayitParola;
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr22 = new Form2();

            string kul, par;
            string kullan = kayitKullanici;
            string sifre = kayitParola;
            kul = txtKullanici.Text;
            par = txtParola.Text;

           if (kul == "" || par == "")
                {
                    lblUyarı.Text = "Kullanıcı adı veya parola boş bırakılamaz !!!";
                    lblUyarı.ForeColor = Color.Red;
                    txtKullanici.Clear();
                    txtParola.Clear();
            }
                else
                {                  
                    if (kul == kullan && par == sifre)
                    {
                    pusulaa psa = new pusulaa();
                    lblUyarı.Text = "Giriş başarılı...";
                        lblUyarı.ForeColor = Color.Green;

                    psa.Show();

                    }
                    else if (kul != kullan && par == sifre)
                    {
                        lblUyarı.Text = "Kullanıcı adınızı yanlış girdiniz !!!";
                        lblUyarı.ForeColor = Color.Red;
                        txtKullanici.Clear();
                        txtParola.Clear();
                        
                    }
                    else if (kul == kullan && par != sifre)
                    {
                        lblUyarı.Text = "Parolanızı yanlış girdiniz !!!";
                        lblUyarı.ForeColor = Color.Red;
                        txtKullanici.Clear();
                        txtParola.Clear();

                }
                    else
                    {
                        lblUyarı.Text = "Kullanıcı adı ve parola yanlış lütfen tekrar deneyiniz !!!";
                        lblUyarı.ForeColor = Color.Red;
                        txtKullanici.Clear();
                        txtParola.Clear();

                }
                }

                

           
            

            
            




            

            







        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            

        }
    }
}
