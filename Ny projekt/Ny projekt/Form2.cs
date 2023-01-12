using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ny_projekt
{

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.Red;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "") {
                Form1 form1 = new Form1(textBox1.Text,textBox2.Text);
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
