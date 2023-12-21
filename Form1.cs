using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click_1(object sender, EventArgs e)
        {
            string metin = txtMetin.Text;

            int harfSayisi = metin.HarfSayisi();
            int kelimeSayisi = metin.KelimeSayisi();
            int cumleSayisi = metin.CumleSayisi();

            rtbSonuclar.Text = "Harf Sayısı: " + harfSayisi.ToString() + "\nKelime Sayısı: " + kelimeSayisi.ToString() + "\nCümle Sayısı: " + cumleSayisi.ToString();

        }

        private void Btnbuyuk_Click(object sender, EventArgs e)
        {
            string metin = txtMetin.Text;
            string[] cumleler = metin.Split('.');

            for (int i = 0; i < cumleler.Length; i++)
            {
                //boşluk karakterini kaldırma
                string cumle = cumleler[i].Trim();
                if (cumle.Length > 0)
                {
                    cumleler[i] = char.ToUpper(cumle[0]) + cumle.Substring(1);
                }
            }

            string yeniMetin = string.Join(". ", cumleler);//cumleler dizisindeki cümleleri nokta ve boşluk karakteri kullanılarak birleştirir.


            rtbSonuclar.Text = yeniMetin;
        }

       
    }

    public static class StringExtensions
    {
        public static int HarfSayisi(this string metin)
        {
            return metin.Replace(" ", "").Replace(".", "").Length;
        }

        public static int KelimeSayisi(this string metin)
        {
            string[] kelimeler = metin.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return kelimeler.Length;
        }

        public static int CumleSayisi(this string metin)
        {
            return metin.Split('.').Length - 1;
        }
    }

}
