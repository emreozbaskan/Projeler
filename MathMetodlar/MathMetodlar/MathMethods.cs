using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathMetodlar
{
    public partial class MathMethods : Form
    {
        public MathMethods()
        {
            InitializeComponent();
        }

        /*
        * MATH CLASSI
        * Hazır olarak onlarca matematiksel fonksiyonu bize sunan temel sınıftır. Yuvarlama islemleri, PI bilgisi, karekök, kuvvet vs...
        */

        private void MathMethods_Load(object sender, EventArgs e)
        {

        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            //pi Sayısını bize virgülden sonra 14 hane olarak verir.
            double deger = Math.PI;
            MessageBox.Show(deger.ToString().Substring(0, 4));
            MessageBox.Show(Math.PI.ToString());
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            //Sayının mutlak değerini döner
            int mutlakDeger = Math.Abs(-45);
            MessageBox.Show(mutlakDeger.ToString());
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            //Floor => Verilen ondalikli degeri, bir alt tam degere tamamlar...
            double deger = Math.Floor(12.987);
            MessageBox.Show(deger.ToString());
        }

        private void btnCeiling_Click(object sender, EventArgs e)
        {
            //Ceiling => Verilen ondalikli degeri, bir ust tam degere tamamlar...
            double deger = Math.Ceiling(12.123);
            MessageBox.Show(deger.ToString());
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            //Round => Sayinin yarisindan fazlasini bir uste, yarisindan azini ise bir alttaki tam sayiya yuvarlar...
            //NOT : .'dan önceki sayı çift ise bir alt değere, tek ise bir üst değere tamamlar. (NOT: .'dan sonraki değer 50 ise)

            double deger = Math.Round(12.50); //12
            double deger1 = Math.Round(13.50); //14

            MessageBox.Show(deger.ToString());

        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            //Truncate => Sayının ondalikli kismina bakmaz, yalnizca tam kismini size teslim eder...
            decimal deger = Math.Truncate(12.558465m);
            MessageBox.Show(deger.ToString());
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            //Max=> verilen iki sayının max değerini döner
            //Min=> verilen iki sayının min değerini döner
            int maxDeger = Math.Max(12, 45);
            int minDeger = Math.Min(12, 45);
            MessageBox.Show(maxDeger.ToString());
            MessageBox.Show(minDeger.ToString());
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            //Pow => Kuvvet alma islemlerini gerceklestirir. Ilk parametrede hangi sayinin kuvveti alinacak, ikinci parametrede ise o sayinin kacinci kuvveti alinacak diye sorar...

            double deger = Math.Pow(3, 4);
            MessageBox.Show(deger.ToString());
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            //Sayının karekökünü almak için kullanılır
            double deger = Math.Sqrt(16);
            MessageBox.Show(deger.ToString());
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            //Sayının negatig mi veya posizitf mi olduğu ile ilgilenir.
            //sayı negatif ise -1
            //Posizif ise +1
            //Eğer sayı 0 ise 0 döner

            int deger1 = Math.Sign(-45); //-1
            int deger2 = Math.Sign(45); //1 
            int deger3 = Math.Sign(0); //0

            MessageBox.Show(deger1.ToString());
            MessageBox.Show(deger2.ToString());
            MessageBox.Show(deger3.ToString());
        }

        private void btnExample_Click(object sender, EventArgs e)
        {
            //Disaridan girilen 3 sayidan en kucugunu tek satirda gosteriniz...

            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int sayi3 = Convert.ToInt32(txtSayi3.Text);

            MessageBox.Show(Math.Min(Math.Min(sayi1, sayi2), sayi3).ToString());
        }
    }
}
