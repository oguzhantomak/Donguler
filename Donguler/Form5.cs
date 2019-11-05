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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            int i = 100;
            while (i < 100)
            {
                lstb1.Items.Add(i);
                i++;
            }
        }

        private void BtnDoWhile_Click(object sender, EventArgs e)
        {
            int i = 100;
            do
            {
                lstb1.Items.Add(i);
                i++;
            } while (i < 100);
        }
    }
}
