using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         

        //Dört işlem uygulama methodu


        int toplama(int s1, int s2)
        {
            int topla = s1 + s2;
            return topla;
        }

        double cikarma(int s1, int s2)
        {
            double cikar = s1 - s2;
            return cikar;
        }

        int carpma(int s1, int s2)
        {
            int carp = s1 * s2;
            return carp;
        }

        double bolme(int s1, int s2)
        {
            int bol = s1 / s2;
            return bol;
        }

        private void btnDortIslem_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_verigirisi1.Text);
            int sayi2 = Convert.ToInt32(txt_verigirisi2.Text);
            MessageBox.Show($"toplama:{toplama(sayi1, sayi2)}\ncikarma:{cikarma(sayi1, sayi2)}\ncarpma:{carpma(sayi1, sayi2)}\nbolme:{bolme(sayi1, sayi2)}");
        }

        

         

        //Çift ve tek sayıların ayrı ayrı toplamlarını bolan method

        string Tek_CiftlerinToplami()
        {
 
            int ciftlerinToplami = 0;
            int teklerinToplami = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    ciftlerinToplami += i;
                }
                else
                {
                    teklerinToplami += i;
                }
            }
            return $"Çiftlerin Toplami: {ciftlerinToplami}\nTeklerin Toplami: {teklerinToplami}";
        }
        

        private void Btn_example2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Tek_CiftlerinToplami());
            
        }
        

         

        string mailadresiolusturma()
        {
            string fullname = txt_verigirisi1.Text;
            return $"mail adresi: {fullname.ToLower().Replace(" ", ".")}@hotmail.com";
        }
        

        private void Btn_example3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mailadresiolusturma());
        }
        

         

        //Kullanıcıdan istediği aralıkta ve sayıda random sayılar üretelim, bunların içerisinden kaç tane çift kaç tanesi tek bulalım.

        string kac_tek_kac_cift(int baslangic, int bitis, int adet)
        {

            Random rand = new Random();
            int[] sayilar = new int[adet];
            int ciftler = 0;
            int tekler = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rand.Next(baslangic, bitis);
                listBox1.Items.Add(sayilar[i]);
                if (sayilar[i] % 2 == 0)
                {
                    ciftler += 1;
                }
                else
                {
                    tekler += 1;
                }
            }
            return $"Toplam Çift Sayısı: {ciftler}\nToplam Tekler Sayısı: {tekler}";
            
        }

        private void Btn_example4_Click(object sender, EventArgs e)
        {
            int param_1 = int.Parse(txt_verigirisi1.Text);
            int param_2 = int.Parse(txt_verigirisi2.Text);
            int param_3 = int.Parse(txt_verigirisi3.Text);
            string result = kac_tek_kac_cift(param_1, param_2, param_3);
            MessageBox.Show(result);

        }
        

         

        //Kullanıcıdan alınan söz öbeğinde sesli harfleri listbox1'e yazdıran fonksiyon

        void sesliharfbulucu(string parametre)
        {
            char[] karakterler = parametre.ToLower().ToCharArray();
            for (int i = 0; i < karakterler.Length; i++)
            {
                if (karakterler[i] == 'a' || karakterler[i] == 'e' || karakterler[i] == 'ı' || karakterler[i] == 'i' || karakterler[i] == 'o' || karakterler[i] == 'ö' || karakterler[i] == 'u' || karakterler[i] == 'ü')
                {
                    listBox1.Items.Add(karakterler[i].ToString());    
                }
            }
            return;

        }

        private void Btn_example5_Click(object sender, EventArgs e)
        {           
            sesliharfbulucu(txt_verigirisi1.Text);
        }

        

         

        //kullanıcının combobox'tan seçtiği rengi butonlara uygulayan fonksiyonu yazın.

        object renkuygula(ComboBox comboBox)
        {
            return comboBox.SelectedItem;
        }


        private void Btn_example6_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button && item.Text == "Example 6")
                {
                    item.BackColor = ColorTranslator.FromHtml(renkuygula(cmb_renkler).ToString());
                }
            }
        }

        

        //Sisteme kontrol ekranından giriş yapılmasını ve hesaptan para çekme işlemini sağlayan basic method 

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        bool SignIn (string UserName,string Password)
        {
            if (UserName == "" || Password == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            bool account = SignIn(txtUserName.Text, txtPassword.Text);
            {
                if (account==true)
                {
                    groupBox2.Visible = true;
                    groupBox1.Visible = false;
                }
                else
                {
                    MessageBox.Show("lütfen bilgilerinizi kontrol ediniz","hatalı bilgi", MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation);                   
                }
            }
        }
        string accountBalance(int amount)
        {
            int balance = 5000;
            if (balance >= amount)
            {
                listBox1.Items.Add($"kalan bakiye:{balance - amount}");
                MessageBox.Show("işlem başarı ile gerçekleştirildi.","bakiyeniz yeterli",MessageBoxButtons.OK,MessageBoxIcon.Information);
                groupBox2.Visible = false;
            }
            else
            {
                MessageBox.Show("işlem başarısız","bakiyeniz yetersiz",MessageBoxButtons.OK, MessageBoxIcon.Warning);              
            }
            return listBox1.Items.ToString();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            accountBalance(Convert.ToInt32(txtTutarGir.Text));          
        }


        //For döngüsü ile asal sayı bulan method

        bool asalSayiBul(int sayi)
        {
            int kontrol = 0;
            bool durum = false;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % 2 == 0)
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
            {
                durum = false;   
            }
            else
            {
                durum = true;   
            }
            return durum;
        }

        private void btnAsalSayi_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            int sayi = Convert.ToInt32(txt_verigirisi1.Text);
            if (asalSayiBul(sayi))
            {
                MessageBox.Show(string.Format("{0} sayısı asaldır", sayi));
            }
            else
            {
                MessageBox.Show(string.Format("{0} sayısı asal değil", sayi));
            }
            //Eğer bulunan asal sayının devamında istenilen kadar daha asal sayıyı getiren fonksiyon
            //while (true)
            //{
            //    sayi++;
            //    if (asalSayiBul(sayi)==true)
            //    {
            //        MessageBox.Show(string.Format("{0} sayısı asal", sayi));
            //        sayac++;
            //        if (sayac==5)
            //        {
            //            break;
            //        }
            //    }
            //}
        }




        int EnBuyukCiftSayi(int kacAdet)
        {
            int buyukSayi = 0;
            Random randint = new Random(); 
            int[] sayilar = new int[kacAdet];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = randint.Next(1, 101);
                listBox1.Items.Add(sayilar[i]);
                if (buyukSayi < sayilar[i] && sayilar[i]% 2 == 0)
                {
                    buyukSayi = sayilar[i];                   
                }                
            }
            if (buyukSayi == 0)
            {
                MessageBox.Show("Dizide çift sayı bulunmamaktadır.");
            }
            MessageBox.Show($"En büyük çift sayi:{buyukSayi}");
            return buyukSayi;
        }

        private void btnEnBuyukCiftSayi_Click(object sender, EventArgs e)
        {
            EnBuyukCiftSayi(Convert.ToInt32(txt_verigirisi1.Text));
        }


        //Random olarak oluşturulan dizi içerisindeki sayıların toplamı ve ortalamasını bulan method


        int topla(int[] dizi)
        {
            int toplam = 0;
            for (int i = 0;i < dizi.Length;i++)
            {
                toplam += dizi[i];
            }
            return toplam;
        }
        double ortalama (int[]dizi)
        {
            int toplam = 0;
            double ortalama = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                toplam += dizi[i];
            }
            ortalama = (double)toplam/dizi.Length;
            return ortalama;
        }

        private void btnToplaOrtala_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] sayilar = new int [10];
            for (int i = 0; i < sayilar.Length ; i++)
            {
                sayilar[i] = rnd.Next(1, 100);
                listBox1.Items.Add (sayilar[i]);
            }
            MessageBox.Show("Sayıların toplamı:" + topla(sayilar));
            MessageBox.Show("sayıların ortalaması" + ortalama(sayilar));
        }


        //Random olarak oluşturulan dizi içerisinde En küçük en büyük sayıyı bulan method

        int Maximum(int[]sayilar)
        {
            int buyuk = sayilar[0];
            for (int i = 0;i < sayilar.Length;i++)
            {
                if (buyuk < sayilar[i])
                {
                    buyuk = sayilar[i];
                }
            }
            return buyuk;
        }

        int Minimum(int[]sayilar)
        {
            int kucuk = sayilar[0];
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (kucuk > sayilar[i])
                {
                    kucuk = sayilar[i];
                }
            }
            return kucuk;
        }

        private void btnEnBuyukEnKucuk_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rastgele.Next(1, 101);
                listBox1.Items.Add(sayilar[i]);
            }
            MessageBox.Show($"En Büyük sayı:{Maximum(sayilar)}\nEn Küçük sayi:{Minimum(sayilar)}");
        }

        //Faktöriyel hesaplama methodu

        int faktoriyelHesapla(int sayi)
        {
            int s = 1;
            for (int i = 1; i < sayi; i++)
            {
                s *= i;
            }
            return s;
        }

        private void btnFaktoriyelHesapla_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Sayının faktöriyeli:{faktoriyelHesapla(Convert.ToInt32(txt_verigirisi1.Text))}");
        }

        //Girilen notların ortalamasını ve "geçti" "kaldı" durumunu gösteren method


        string notOrtalaması(double not1,double not2)
        {
            string s;
            if ((not1 + not2)/2 >=50)
            {
                s = "geçti";
            }
            else
            {
                s = "Kaldı";
            }
            return s;
        }

        private void btnNotSonucu_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"sonuç:{notOrtalaması((Convert.ToDouble(txt_verigirisi1.Text)),(Convert.ToDouble(txt_verigirisi2.Text)))}");
        }
    }
}
