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
    public partial class Form2 : Form
    {
        // form2 consturctor
        public Form2()
        {
            // initilize everything so that you can see something
            InitializeComponent();
        }

        // fires when the show item is hit
        private void button1_Click(object sender, EventArgs e)
        {
            // itterates through each RetailItem object that is in the RetailItemStore list
            foreach (RetailItem item in RetailItemStore.getItems())
            {
                // inputs the objects into the listbox
                listBox1.Items.Add(item.ToString());
            }
        }
    }
}
