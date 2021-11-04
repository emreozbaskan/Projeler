using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Sahip oldugunuz metinsel degerlerin ozelliklerini degistirmek icin kullanilan metotlardir. Ornegin, kelimeleri parcalamak, eklemek, harflerin yerlerini degistirmek, bosluk temizlemek vs...
         */

        private void btnContains_Click(object sender, EventArgs e)
        {
            //Contains => Verilen string ifadeyi çağırılan metin içerisinde arar
            string metin = textBox1.Text;
            bool result = metin.Contains("çok"); //ekrandan girilen metin içerisinde çok ifadesi geçiyor mu?
            if (result == true)
            {
                MessageBox.Show("çok ifadesi metin içerisinde geçiyor");
            }
            else
            {
                MessageBox.Show("ifade metin içerisinde geçmiyor");
            }
        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            //StartsWith => Kelimenizin parametrede gonderdiginiz degerle baslayip baslamadigini size "bool" olarak dondurur...
            //start with default olarak camel case yani büyük küçük duyarlılığı vardır.
            string metin = textBox1.Text;
            bool result = metin.StartsWith("bil");
            MessageBox.Show(result == true ? "ifade bil ile başlıyor" : "ifade bil ile başlamıyor");

        }

        private void btnCompareTo_Click(object sender, EventArgs e)
        {
            //Metodu kullandiginiz string degerle metoda verdiginiz parametredeki string degeri sozluk mantigiyla karsilastirir... Eger sozlukte ayni lokasyonlardasa 0, parametredeki deger, ana degerimizden sozlukte onceyse - 1; sonraysa 1 degerini dondurur...


            string metin = textBox1.Text;
            int sonuc = metin.CompareTo("bilgeadam");
            string mesaj = "";
            switch (sonuc)
            {
                case -1:
                    {
                        mesaj = "Kelime diğer kelime ile eşleşmektedir.";
                        break;
                    }
                case 0:
                    {
                        mesaj = "Kelime diğer kelime ile eşleşmektedir";
                        break;
                    }
                case 1:
                    {
                        mesaj = "Kelime diğer kelime ile eşleşmemektedir.";
                        break;
                    }
            }

            MessageBox.Show(mesaj);

            //int result1 = "5".CompareTo("6");
            //int result2 = "6".CompareTo("5");
            //int result3 = "5".CompareTo("5");


        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            //EndsWith => Kelimenizin parametrede gonderdiginiz degerle bitip bitmedigini size "bool" olarak dondurur...

            string metin = textBox1.Text;
            bool result = metin.EndsWith("dam");
            MessageBox.Show(result == true ? "metin dam ile bitiyor" : "kelimenin sonu dam ile bitmiyor");

        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            //IndexOf => Dizilerde gordugumuz metodun ayni prensibleriyle calisir. Eger harf varsa harfin indexini, yoksa -1 degerini, harf birden fazla var ise ilk harfin indexini dondurur...
            //string metin = textBox1.Text;
            //int index = metin.IndexOf("çok");


            //MessageBox.Show(index.ToString());

            //metin içerisinde birden fazla geçiyor ise
            string metin = textBox1.Text;
            int kackere = 0;
            int startIndex = 0;
            while (true)
            {
                startIndex = metin.IndexOf("çok", startIndex);
                if (startIndex == -1)
                {
                    break;
                }
                else
                {
                    kackere++;
                    startIndex++;
                }
            }

            MessageBox.Show(kackere.ToString());
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            //LastIndexOf => Dizilerde gordugumuz metodun ayni prensibiyle calisir. Eger harf varsa harfin indexini, yoksa - 1 degerini, harf birden fazla varsa son harfin indexini dondurur... arama işlemine son indexden başlayarak döner
            string metin = textBox1.Text;
            int sonuc = metin.LastIndexOf("çok");
            MessageBox.Show(sonuc.ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //string içerisinden belli bir kısmı silmek için kullanılır.
            //metni değiştirmez yeni bir kopyasını döner
            string metin = textBox1.Text;
            string metinKopya = metin.Remove(5);
            MessageBox.Show(metin);
            MessageBox.Show(metinKopya);

            //2. Kullanım
            //kaç index başla kaç eleman sil
            string metinKopya2 = metin.Remove(5, 3);
            MessageBox.Show(metinKopya2);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            // Replace => Metniniz icerisindeki bir karakteri ya da bir bolumu yeni bir karakter - bolum - ile degistirmenize olanak saglar..
            //hangi metin veya string ifde üstünden çağırıldığında içerisinde birden fazla da geçse hepsini dönüştürür.
            string metin = textBox1.Text;
            //string metinKopya = metin.Replace("adam", "kadın");
            //MessageBox.Show(metinKopya);

            string[] musteriler = { "Emre", "Yalın", "Havva" };
            decimal[] faturalar = { 157.65m, 199.89m, 385.85m };
            for (int i = 0; i < musteriler.Length; i++)
            {
                string metinKopya1 = metin.Replace("[Adi]", musteriler[i]);
                metinKopya1 = metinKopya1.Replace("[Tutar]", faturalar[i].ToString());
                MessageBox.Show(metinKopya1);
            }

        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            //Split => Metninizi ozel bir karakterden birden fazla parcaya ayirmaniza olanak saglayan metottur. Ayni anda birden fazla ozel karakter de verebilirsiniz...
            string metin = textBox1.Text;
            //string[] metinDizisi = metin.Split(' ');
            string[] metinDizisi = metin.Split(' ', ';', ',');

            for (int i = 0; i < metinDizisi.Length; i++)
            {
                MessageBox.Show(metinDizisi[i]);
            }


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Insert => Bir metinsel degerin herhangi bir pozisyonuna (index) yeni bir degeri ilistirmek istiyorsaniz bu metodu kullanabilirsiniz. İlk parameterde kacinci indexten sonra ekleyecegini, ikinci parametrede ise hangi metni ekleyecegini sorar...
            string metin = textBox1.Text;
            string metinKopya = metin.Insert(3, "güzel");


            MessageBox.Show(metinKopya);
        }

        private void btnSubString_Click(object sender, EventArgs e)
        {
            //Substring (1.Kullanım) => Metninizden, parametrede gonderdiginiz indexten baslayarak, geri kalan kismi cekip almaniza olanak saglar...
            //Substring (2.Kullanım) => Metninizden, ilk parametrede verdiginiz indexten baslayip, ikinci parametrede verdiginiz deger kadarlik kismi cekip almaniza olanak saglar..

            string metin = textBox1.Text;
            string metinKopya = metin.Substring(5);
            string metinKopya2 = metin.Substring(7, 4);
            MessageBox.Show(metinKopya);
            MessageBox.Show(metinKopya2);
        }

        private void btnToCharArray_Click(object sender, EventArgs e)
        {
            //ToCharArray => Stringinizi charlarina ayirarak size char[] olarak teslim eder...
            string metin = textBox1.Text;
            char[] charDizi = metin.ToCharArray();
            for (int i = 0; i < charDizi.Length; i++)
            {
                MessageBox.Show(charDizi[i].ToString());
            }
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            //Trim => Metninizin saginda ya da solundaki tum bosluklari temizlemenize olanak saglayan metottur...
            //metin içerisindeki boşluklara dokunmaz
            string metin = textBox1.Text;
            MessageBox.Show(metin.Trim());
        }

        //Ödev
        //kendi extension şeklinde insert metodunuzu yazınız
    }
}

//public static class CustomExtension
//{
//    public static string CustomInsert(this string s, int startIndex, string caracters)
//    {

//    }
//}
