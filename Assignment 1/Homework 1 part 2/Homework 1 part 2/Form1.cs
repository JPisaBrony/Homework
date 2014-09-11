using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1_part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string desc = textBox1.Text;
                int unit = Convert.ToInt32(textBox2.Text);
                int price = Convert.ToInt32(textBox3.Text);

                RetailItem myItem = new RetailItem(desc, unit, price);
                RetailItemStore.AddItem(myItem);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (FormatException exep)
            {
                MessageBox.Show("You did not input valid data for one or more feilds.");
            }
            catch (OverflowException overflow)
            {
                MessageBox.Show("You input a number that is too large.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }


    }
}
