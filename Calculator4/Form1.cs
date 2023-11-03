using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if(textBox1.Text!=String.Empty)
=======
            if(textBox1.Text!=String.Empty && textBox2.Text!=String.Empty)
>>>>>>> feature-cal
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = a + b;
                textBox3.Text = c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
