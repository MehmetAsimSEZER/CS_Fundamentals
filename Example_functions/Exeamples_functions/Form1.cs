using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exeamples_functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int index = 0;
        string[] personeller;
        int[] maaslar;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            personeller = new string[] { "asım", "ibrahim", "sefer", "sefa", "mehmet" };
            maaslar = new int[] { 3900, 3800, 4500, 5000, 5500 };
            for (int i = 0; i < personeller.Length; i++)
            {
                listBox1.Items.Add(personeller[i] + "\t" + maaslar[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            bool bulundu = false;
            for (int i = 0; i < personeller.Length; i++)
            {
                if (aranan == personeller[i])
                {
                    bulundu = true;
                    listBox1.SelectedIndex = i;
                    break;
                }
            }
            if (bulundu)
            {
                MessageBox.Show("personel bulundu");
            }
            else
            {
                MessageBox.Show("personel bulunamadı");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show (string.Format("toplam personel sayısı: {0}",personeller.Length));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dusukMaas = maaslar[0];
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (dusukMaas > maaslar[i])
                {
                    dusukMaas = maaslar[i];   
                }
            }
            MessageBox.Show($"En Düşük Maaş:{dusukMaas}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int yuksekMaas = maaslar[0];
            int yuksekIndex = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (yuksekMaas < maaslar[i])
                {
                    yuksekMaas = maaslar[i];
                    yuksekIndex = i;
                }
            }
            MessageBox.Show($"En Yüksek Maaş Alan personel:{personeller[yuksekIndex]}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (maaslar[i] < 4000)
                {
                    MessageBox.Show($"personel: {personeller[i]}\nmaaş: {maaslar[i]}");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (maaslar[i] >= 5000 && maaslar[i] <= 7000)
                {
                    sayac++;
                }
            }
            MessageBox.Show($"Maaşı 5000 ile 7000 arası olan personel sayısı: {sayac}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int toplamMaas = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                toplamMaas += maaslar[i];
            }
            MessageBox.Show($"Toplam ödenen maaş: {toplamMaas}");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            maaslar[2] += 500;
            for (int i = 0; i < personeller.Length; i++)
            {
                
            }
            MessageBox.Show($"personel:{personeller[2]}\t maas:{maaslar[2]}");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"en son personel: {personeller[personeller.Length-1]}");
        }

        double sayi;
        int skor;
        private void button12_Click(object sender, EventArgs e)
        {
            skor = 10;
            lblSkor.Text = $"Skor :" + skor.ToString();
            btnTahminEt.Enabled = true;
            Random rastgele = new Random();
            sayi = rastgele.Next(101);
            MessageBox.Show("Aklımdan bir sayı tuttum.");
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(txtTahmin.Text);
            if (tahmin < sayi)
            {
                MessageBox.Show("Yukarı");
                skor = skor - 1;
            }
            else if(tahmin > sayi)
            {
                MessageBox.Show("Aşağı");
                skor = skor - 1;
            }
            else
            {
                MessageBox.Show("Tebrikler");
            }
            if (skor ==0)
            {
                MessageBox.Show("game over");
                btnTahminEt.Enabled = false;
            }
            lblSkor.Text = $"Skor :" + skor.ToString();
            txtTahmin.Clear();
        }

        //Arka plan düzenleme

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] button = new Button[9, 16];
            int top = 0;
            int left = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 70;
                    button[i, j].Height = 70;
                    button[i, j].Left = left;
                    button[i, j].Top = top;
                    this.Controls.Add(button[i, j]);
                    left += 70;
                    if ((i+j) % 2 == 0) 
                    {
                        button[i, j].BackColor = Color.DarkGray;
                    }
                    else
                    {
                        button[i, j].BackColor = Color.White;
                    }
                }
                top += 70;
                left = 0;
            }
            
        }

        //Kalan süreyi geri sayım sayacında saydırma

        private void btnSureHesapla_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string girisZamani = DateTime.Now.ToLongTimeString();
            string cikisZamani = txtSure.Text;
            TimeSpan girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
            string calismaSuresi = girisCikisFarki.ToString();
            lblKalanSure.Text = calismaSuresi.ToString();
        }
    }
}
