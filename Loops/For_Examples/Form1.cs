using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExamples1_Click(object sender, EventArgs e)
        {
                   
            for (int i = 0; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnExample2_Click(object sender, EventArgs e)
        {
          
            int toplam = 0;

            for (int i = 0; i <= 100; i++)
            {
                toplam += i;   
            }
            listBox1.Items.Add(toplam);
        }

        private void btnExample3_Click(object sender, EventArgs e)
        {
            int cifttoplam = 0;
            int tektoplam = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i%2==0)
                {
                    listBox1.Items.Add(i);
                    cifttoplam +=i;                    
                }
                else
                {
                    listBox2.Items.Add(i);
                    tektoplam +=i;                   
                }
            }
            listBox1.Items.Add(cifttoplam);
            listBox2.Items.Add(tektoplam); 
        }

        private void btnExample4_Click(object sender, EventArgs e)
        {
            for (int i = 1989; i < DateTime.Now.Year; i++)
            {
                if (i == 1990 || i == 1994 )
                {
                    continue;
                }
                else if (i == 1996)
                {
                    break;                    
                }
                listBox1.Items.Add(i);
            }
        }

        private void btnExample5_Click(object sender, EventArgs e)
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnExample6_Click(object sender, EventArgs e)
        {
            string[] takimlar = { "Galatasaray", "Fenerbahçe", "Beşiktaş", "Trabzonspor" };

            for (int i = 0; i < takimlar.Length; i++)
            {
                listBox1.Items.Add(takimlar[i]);
            }     
        }

        private void btnExample7_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya" };
            string result = string.Empty;
            bool condition = false;

            for (int i = 0; i < sehirler.Length; i++)
            {
                if(txtSehirSec.Text == sehirler[i].ToLower())
                {
                    result = sehirler[i];
                    condition = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (condition == false)
            {
                MessageBox.Show("bulamadım");
            }
            else
            {
                MessageBox.Show($"buldum={result}");
            }
        }

        private void btnExample8_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();

            int[] sayilar = new int[10];

            int enBuyukSayi = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rastgele.Next(1, 100);
                listBox1.Items.Add(sayilar[i]);
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (enBuyukSayi < sayilar[i])
                {
                    enBuyukSayi = sayilar[i];
                }
            }
            MessageBox.Show($"En büyük sayı:{enBuyukSayi}");
        }

        private void btnExample9_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int[] list1 = new int[10];
            int[] list2 = new int[10];

            for (int i = 0; i < list1.Length; i++)
            {
                list1[i] = rastgele.Next(1,100);
                list2[i] = rastgele.Next(1,100);
                listBox1.Items.Add($"{list1[i]}+{list2[i]}={list1[i] + list2[i]}");
            }
        }

        private void btnExample10_Click(object sender, EventArgs e)
        {
            string metin = txtKullaniciGirisi.Text;
            string tersten = string.Empty;
            for (int i = metin.Length - 1; i >= 0; i--)
            {
                tersten += metin[i];
            }
            MessageBox.Show($"tersten yazım:{tersten}");
        }

        private void btnExample11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].Width = 100;
                    this.Controls[i].BackColor = Color.DarkBlue;
                }
                else if (this.Controls[i] is ListBox)
                {
                    this.Controls[i].BackColor = Color.LightBlue;
                    listBox1.Font = new Font("Tahoma", 13);
                }
                else if (this.Controls[i] is TextBox)
                {
                    continue;
                }
            }
        }
    }
}
