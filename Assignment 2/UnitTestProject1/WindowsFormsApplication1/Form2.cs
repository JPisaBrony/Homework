using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Invoice Application written by
// Josh Pohl and Matt Leet

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2(LineItem ln, Address a)
        {
            InitializeComponent();
            // create an invoice object from the parameters passed
            Invoice inv = new Invoice(ln, a);
            // iterate through each product in the list
            foreach (Product p in inv.getLineItem())
            {
                // add the description to the first list box
                listBox1.Items.Add(p.Description);
                // add the amount to the second list box
                listBox2.Items.Add(p.Amount);
                // add the quantity to the third list box
                listBox3.Items.Add(p.Quantity);
                // add the total to the fourth list box
                listBox4.Items.Add(p.Quantity * p.Amount);
            }
            // add the address to the first text box
            textBox1.AppendText(inv.getAddress());
            // add the grand total to the second text box
            textBox2.Text = inv.grandTotal().ToString();
        }

    }
}
