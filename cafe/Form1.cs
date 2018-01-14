using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void verigetir(System.Windows.Forms.Button btn, System.Windows.Forms.Label lbl)
        {
            if(btn.Text=="Kapat")
            {
                if(txtucret.Text!="")
                {
                    TimeSpan d;
                    int p;
                    btn.Text = "Aç";
                    d = DateTime.Now - Convert.ToDateTime(lbl.Text.Substring(25, lbl.Text.Length - 25));
                    if ((d.Hours * 60 + d.Minutes < 60))
                        p = 1;
                    else
                        p = Convert.ToInt32(Math.Round((decimal)((d.Hours * 60 + d.Minutes) / 60)));
                    lbl.Text = "Durum : Boş, Son Oturumdan Alınan" + Convert.ToString((p * double.Parse(txtucret.Text))) + "TL";
                    txtmesaj.Text = btn.Name + ".Masa Kapatıldı, Kapanış Zamanı :" + DateTime.Now.ToString() +
                        "Ödenen Miktar" + Convert.ToString((p * double.Parse(txtucret.Text))) + "TL" + Environment.NewLine + txtmesaj.Text;
                }
                else
                {
                    MessageBox.Show("Lütfen Saat Ücretini Giriniz!!!");
                    txtucret.Focus();
                }
            }
            else
            {
                btn.Text = "Kapat";
                lbl.Text = "Durum: Dolu, Giriş Saati:" + DateTime.Now.ToString();
                txtmesaj.Text = btn.Name + ".Masa Açıldı, Açılış Zamanı:" + DateTime.Now.ToString() +
                    Environment.NewLine + txtmesaj.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnmasa1_Click(object sender, EventArgs e)
        {
            verigetir((Button)sender, lblmasa1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verigetir((Button)sender, label4);
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtucret.Text !="")
                {
                    if (txtucret.Text != "")
                    {
                        lblhesap.Text = txtsure.Text + "Saat Kullanım Ücreti" + Convert.ToString(double.Parse(txtucret.Text) * double.Parse(txtsure.Text));
                        
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Kullanım Süresini Giriniz!!");
                        txtsure.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Saat Ücretini Giriniz!!");
                    txtucret.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
