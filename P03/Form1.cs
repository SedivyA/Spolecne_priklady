using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = listBox1.Text;
            double prum = 0 ;
            int poc = 0;
            
            foreach(Control ctrl in groupBox1.Controls)
            {
                if(ctrl is Label)
                {
                    (ctrl as Label).Text = text;
                }
                if(ctrl is TextBox)
                {
                    prum = prum + Convert.ToInt32((ctrl as TextBox).Text);
                    poc++;
                }
            }
            if(poc!=0)
            {
                prum = prum / poc;
                MessageBox.Show("Aritmetický průměr je: " + prum);
            }




            
        }
    }
}
