using System;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            // 1. Tanımlama yöntemi

            // veriTipi(int,string,Form,MessageBox, vs..)[] diziAdi = new veriTipi[eleman sayısı]; 

            // 0 = ?
            // 1 = ?
            // 2 = ?
            // 3 = ?
            // 4 = ?

            int[] sayilar = new int[5];
            sayilar[4] = 40;
            sayilar[1] = 10;
            sayilar[0] = 50;
            sayilar[3] = 30;
            sayilar[2] = 20;
            //sayilar[5] = 60;  'Index was outside the bounds of the array.' => eğer bu hatayı görüyorsanız, nesnenin alabileceğinden fazla değer atamaya çalıştınız anlamına gelir.

            int gelenSayi = sayilar[3];
            MessageBox.Show(gelenSayi.ToString());
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            string[] sehirler = new string[5] { "Ankara", "Edirne", "İstanbul", "Eskişehir", "Bursa" };
            sehirler[4] = "Konya";
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            char[] karakterler = {Convert.ToChar(65), 'B', 'C', 'D', 'E' };
        }
    }
}


// dizinin elemanları       =>  A, B, C, D, E, F, 1, 2, 3, 4,  5,  6
// eleman sayı numarası     =>  1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
// elamaının index numarası =>  0, 1, 2, 3, 4, 5, 6, 7, 8, 9,  10, 11
// Not :  bir dizinin maximum index değeri, o dizinin eleman sayısının -1 bir değeridir.
// bir diz 10 elemanlı ise, maximum index değeri 9'dur