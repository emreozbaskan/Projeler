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
    public partial class DatetimeMethods : Form
    {
        public DatetimeMethods()
        {
            InitializeComponent();
        }

        private void btnDatetime_Click(object sender, EventArgs e)
        {
            //Uygulamayı kullanan user bilgisinin culture ayarı
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
            MessageBox.Show(DateTime.Now.ToString());

            //o andki tarih ve saat bilgisini döner
            label1.Text = DateTime.Now.ToString();

            //Suanki günün Tarihini alma
            label1.Text = DateTime.Now.ToShortDateString();
            label2.Text = DateTime.Now.ToLongDateString();

            //Parça şeklinde alma
            //Year=> Yıl
            //Month=> ay
            //Day =>Gün
            //Hour=> Saat
            //Minute => Dakika
            //Second => Saniye
            //Milisecond
            label1.Text = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + " T " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + " " + DateTime.Now.Millisecond;

            //Artik Yil
            bool IsLeapYear = DateTime.IsLeapYear(1989);
            MessageBox.Show(IsLeapYear == true ? "Şubat 29 çeker" : "Şubat 28 Çeker");

            //Bulunduğunuz yılın artıl yılmı bilgisini bu şekilde kontrol edebilirsiniz
            //DateTime.IsLeapYear(DateTime.Now.Year);

            //Haftanın gün bilgisi
            DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;
            MessageBox.Show("Haftanın günü=>" + dayOfWeek.ToString());

            //Yılın kaçıncı günü
            int dayOfYear = DateTime.Now.DayOfYear;
            MessageBox.Show("Yılın kaçıncı günü=>" + dayOfYear.ToString());


            label1.Text = DateTime.UtcNow.ToString();
            label2.Text = DateTime.Now.ToString();

        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //kendiniz bir tarih saat nesnesi oluşmak istediğiniz bu şekilde oluşturabilirsiniz
            DateTime date1 = new DateTime(1988, 1, 1);
            DateTime date = new DateTime(1990, 6, 1, 12, 12, 12);
            DateTime bugun = DateTime.Now;

            TimeSpan fark = bugun - date;
            //fark.TotalDays //toplam gün
            //fark.TotalHours //toplam Saat
            //fark.TotalMinutes 
            //fark.TotalSeconds
            //fark.TotalMilliseconds

            
            MessageBox.Show("İki tarih arası toplam gün=>" + fark.Days);



        }
    }
}
