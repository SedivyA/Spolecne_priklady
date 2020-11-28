using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random nh = new Random();
            listBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                int x = nh.Next(0, 11);
                listBox1.Items.Add(x);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int soucet = 0;
            foreach (int a in listBox1.SelectedItems)
            {
                soucet += a;
            }
            label1.Text = "Počet: " + listBox1.SelectedItems.Count.ToString();
            label2.Text = "Součet: " + soucet.ToString();
        }
    }
}
