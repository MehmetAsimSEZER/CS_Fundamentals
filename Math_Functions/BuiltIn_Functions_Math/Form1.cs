using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuiltIn_Functions_Math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            //Pi sayısı 
            MessageBox.Show($"Pi Sayısı: {Math.PI}");
        }

        private void btnABS_Click(object sender, EventArgs e)
        {
            //Mutlak Değer hesaplar
            MessageBox.Show($"Abs:{Math.Abs(double.Parse(txtVeriGirisi_1.Text))}");
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            //Verilen ondalıklı değeri, bir alt değer yuvarlar. Örneğin 12.3 gelirse 12'ye yuvarlar
            MessageBox.Show($"Floor: {Math.Floor(Double.Parse(txtVeriGirisi_1.Text))}");
        }

        private void btnCelling_Click(object sender, EventArgs e)
        {
            //Ceilling: Verilen ondalıklı değeri bir üst tam sayıya tamamlar
            MessageBox.Show($"Ceiling: {Math.Ceiling(Decimal.Parse(txtVeriGirisi_1.Text))}");
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            //Round: Verilen sayının ondalıklı kısmı 50'nin altında ise aşağıya , üstünde ise bir üst tam sayıya yuvarlanır.

            MessageBox.Show($"Round: {Math.Round(Double.Parse(txtVeriGirisi_1.Text))}");
        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            //Ondalıklı kısma bakmaksızın tam kısmı size teslim eder.
            MessageBox.Show($"Truncate: {Math.Truncate(decimal.Parse(txtVeriGirisi_1.Text))}");
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            //Girilen sayının kuvvetini alma
            MessageBox.Show($"Pow: {Math.Pow(double.Parse(txtVeriGirisi_1.Text),double.Parse(txtVeriGirisi_2.Text))}");
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            //Karekök dışına çıkarma
            MessageBox.Show($"SQRT: {Math.Sqrt(double.Parse(txtVeriGirisi_1.Text))}");
        }

        private void btnCosinus_Click(object sender, EventArgs e)
        {
            //Cosinüs değerini hesaplama
            MessageBox.Show($"Cos: {Math.Cos(double.Parse(txtVeriGirisi_1.Text))}");
        }

        private void btnBuyukSayiBulma_Click(object sender, EventArgs e)
        {
            //İki sayı arasında büyük olanı bulma
            MessageBox.Show($"Büyük sayı : {Math.Max(double.Parse(txtVeriGirisi_1.Text),double.Parse(txtVeriGirisi_2.Text))}");
        }

    }
}
