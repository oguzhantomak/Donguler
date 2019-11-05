using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        string[] sehirler = {
"Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "İçel (Mersin)", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "K.maraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"};
        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (String item in sehirler)
            {
                listBox1.Items.Add(item);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int[] dizi = { 123, 54, 76, 876, 4532, 23, 77, 734, 83, 45, 190 };

            int ikiyeBolunen;
            int ikiveuc = 0;

            foreach (int item in dizi)
            {
                if (item % 2 == 0)
                {
                    ikiyeBolunen = item;
                    listBox1.Items.Add(ikiyeBolunen);

                    if (item % 3 == 0)
                    {
                        ikiveuc++;
                    }
                }
                else
                {
                    listBox2.Items.Add(item);
                }
            }

            MessageBox.Show(ikiveuc.ToString());
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            foreach (object item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }
            foreach (var item in listBox2.Items)
            {
                listBox1.Items.Remove(item);
            }
        }
        Random rnd = new Random();
        private void Btn4_Click(object sender, EventArgs e)
        {

            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
            }
            
        }
    }
}
