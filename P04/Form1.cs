using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Mocnina(int x, int ep)
        {
            int mocnina = 1;
            for (int i = 0; i < ep; i++)
            {
                mocnina *= x;
            }
            return mocnina;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int ep = Convert.ToInt32(comboBox1.Text);
            foreach  (Control con in panel1.Controls)
            {
                if (con is TextBox)
                {
                    int x = Convert.ToInt32((con as TextBox).Text);
                    (con as TextBox).Text = Mocnina(x, ep).ToString();
                }
                if (con is Label) (con as Label).Text = ep.ToString();
            }

        }
    }
}
