using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> sehirler = new List<string>(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            sehirler.Add("İstanbul");
            sehirler.Add("Ankara");
            sehirler.Add("İzmir");
            sehirler.Add("Bursa");
            sehirler.Add("Eskişehir");
        }

        private void btnExample1_Click(object sender, EventArgs e)
        {
            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }

        private void btnExample2_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtsehir.Text);

            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }

        }

        private void btnExample3_Click(object sender, EventArgs e)
        {
            bool condition = false;
            foreach (string sehir in sehirler)
            {
                if (sehir.ToLower() == txtsehir.Text.ToLower())
                {
                    MessageBox.Show("buldum");
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
                MessageBox.Show("bulamadım.");
            }
        }
    }
}
