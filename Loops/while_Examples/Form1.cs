using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            int toplam = 0;

            while (i <= 100)
            {
                toplam += i;
                listBox1.Items.Add(i);
                i++;
                
            }
            MessageBox.Show(string.Format("1'den 100'e kadar olan sayıların toplamı:{0}",toplam));
        }

        private void btnTarihleriGetir_Click(object sender, EventArgs e)
        {
            int tarih = 1989;
            while (tarih < DateTime.Now.Year)
            {
                if (tarih == 1991 || tarih == 1994)
                {
                    tarih++;
                    continue;
                }
                else if (tarih == 1998)
                {                 
                    break;
                }
                listBox1.Items.Add(tarih);
                tarih++;
            }
        }

        private void btnExample_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < this.Controls.Count)
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].Width = 100;
                    this.Controls[i].Height = 50;
                }
                i++;
            }
        }
    }
}
