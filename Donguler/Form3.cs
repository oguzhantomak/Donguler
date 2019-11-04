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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] liste = { "istanbul", "bursa", "sakarya", "kocaeli", "edirne", "tekirdağ", "kırklareli" };
            string[] liste2 = { "ankara", "konya", "kayseri", "eskişehir", "sivas", "kırıkkale", "aksaray" };
            lst1.Items.AddRange(liste);
            lst2.Items.AddRange(liste2);
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            foreach (string item in lst1.SelectedItems)
            {
                lst2.Items.Add(item);
            }


            while (lst1.SelectedItems.Count != 0)
            {
                lst1.Items.Remove(lst1.SelectedItems[0]);
            }
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            foreach (string item in lst2.SelectedItems)
            {
                lst1.Items.Add(item);
            }
            while (lst2.SelectedItems.Count != 0)
            {
                lst2.Items.Remove(lst2.SelectedItems[0]);
            }
        }
    }
}
