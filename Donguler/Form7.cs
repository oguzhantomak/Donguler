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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string deger = "X";
            for (int i = 1; i < 5; i++)
            {
                deger = deger + "X";
                label1.Text = deger;
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            string deger = "";
            for (int i = 0; i <= 5; i++)
            {
                //deger = deger+"\n";
                //for (int y = 5; y >=5-i ; y++)
                //{
                //    deger = "*";
                //}
                //deger = deger+"*";

                for (int y = 5; y <= i; y++)
                {
                    deger = deger + "*";
                    label1.Text = deger + "\n";

                }
                label1.Text = deger + "\n";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string deger = "";
            for (int i = 0; i < 7; i++)
            {
                deger = "";
                for (int y = 5; y >= 5 - i; y--)
                {
                    deger += "*";
                }
                label1.Text = label1.Text + deger + "\n";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    // 1. yazım şekli
                    // int sonuc = x * y;
                    // lstCarpimTablosu.Items.Add(x + "x" + y + "=" + sonuc);

                    // 2. Yazım Şekli
                    // lstCarpimTablosu.Items.Add(x + "x" + y + "=" + x * y);

                    // 3. Yazım Şekli
                    // lstCarpimTablosu.Items.Add(string.Format("{0}x{1}={2}", x, y, x * y));

                    // 4. Yazım Şekli
                    listBox1.Items.Add($"{x}x{y}={x * y}");

                }
                listBox1.Items.Add("*******************");
            }
        }


    }
}
