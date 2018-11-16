using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void total1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(price.Text);
            int y = Convert.ToInt32(items.Text);
            int z = x * y;
            total.Text = Convert.ToString(z);

            int b = Convert.ToInt32(total.Text);
            double c = b * 0.07;
            cgst.Text = Convert.ToString(c);

             b = Convert.ToInt32(total.Text);
            double l = b * 0.08;
            sgst.Text = Convert.ToString(l);


        }

        private void cgst_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cgst1_Click(object sender, EventArgs e)
        {
          
           
        }

        private void sgst1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p= Convert.ToInt32(total.Text);
            double q= Convert.ToInt32(cgst.Text);
            int r= Convert.ToInt32(sgst.Text);
            double s = p + q + r;
            final.Text = Convert.ToString(s);
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "shampoo")
            {
                price.Text = "100";
            }
            if (comboBox1.Text == "maida")
            {
                price.Text = "50";
            }
            if (comboBox1.Text == "deterjent")
            {
                price.Text = "75";
            }
            if (comboBox1.Text == "soap")
            {
                price.Text = "45";
            }
            if (comboBox1.Text == "hair wax")
            {
                price.Text = "170";
            }
            if (comboBox1.Text == "biscuit")
            {
                price.Text = "20";
            }
            if (comboBox1.Text == "odonil")
            {
                price.Text = "60";
            }
            if (comboBox1.Text == "shampoo")
            {
                price.Text = "100";
            }
            if (comboBox1.Text == "noodles")
            {
                price.Text = "65";
            }
            if (comboBox1.Text == "harpic")
            {
                price.Text = "80";
            }
            if (comboBox1.Text == "perfume")
            {
                price.Text = "200";
            }
        }

        private void log_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleVioletRed;
        }

        private void items_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Form f2 = new Form2();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form f3 = new Form3();
            f3.Show();
        }
    }
}
