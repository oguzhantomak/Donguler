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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 100)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int i = 0;
            while (i < this.Controls.Count)
            {
                if (Controls[i] is Button)
                {
                    Controls[i].BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
                i++;
            }
        }
    }
}
