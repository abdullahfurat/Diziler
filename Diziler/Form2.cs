using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] sehirler = {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K.maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce" };
        private void btnSonElemaniGoster_Click(object sender, EventArgs e)
        {
            // Dizinin son elemanını MB içerisinde kullanıcıya gösteriniz!
        }

        private void btnRastgeleEleman_Click(object sender, EventArgs e)
        {
            // Butona her tıkladığımızda, dizinin içerisinde yer alan bir elemanı rastgele Formun Text özelliğinde gösteriniz!.
        }


        int[] sayilar = { 10, 20, 30, 40, 50 };
        private void btnElemanlariListboxaEkle_Click(object sender, EventArgs e)
        {
            // Kullanıcı butona her tıkladığında sırayla dizinin ilk elemanından başlayarak, listbox'a ekleyecek
            // Ve her ekelem işleminde, kullanıcının eklediği değeri bir havuz içerisinde toplayarak, Formun Text özelliğinde toplam değeri yazdırınız.





            listBox1.Items.Add(10);
            listBox1.Items.Add(20);
            listBox1.Items.Add(30);
            listBox1.Items.Add(40);
            listBox1.Items.Add(50);
            Text = "150";

            // Kullanıcı eğer son elemanı eklemiş ise, butona tıklandığında uyarı verdiriniz.!!!

            listBox1.Items.Add(1); 
            listBox1.Items.Add(1.0);
            listBox1.Items.Add("1");
            listBox1.Items.Add('1');



            listBox1.Items.Add("object alır, ne istiyosanız direk olarak ekleyebilirsiniz");
        }
    }
}
