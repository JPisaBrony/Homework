using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1_part_3
{
    public partial class Form1 : Form
    {
        // form1 constructor
        public Form1()
        {
            // startup everything
            InitializeComponent();

            // this string is used for holding the information at each line in the text document
            string line;
            // this string array is used for spliting up the string into each part
            string[] data;

            // try block
            // this makes sure that the there is a text file avaliable for reading
            try
            {
                // stream reader for reading the information from the text file
                StreamReader input = new StreamReader("list.txt");
                // iterate through the file until the last line
                while ((line = input.ReadLine()) != null)
                {
                    // split up the data into each part
                    data = line.Split(',');
                    // create a person object from the split up data
                    PersonEntry person = new PersonEntry(data[0], data[1], data[2]);
                    // adds the object to the PersonEntryList list
                    PersonEntryList.addPerson(person);
                    // adds the object to the listbox
                    listBox1.Items.Add(person);
                }
            }
            // catches any exceptions thrown
            catch (Exception e)
            {
                // shows a message box with the reason that the exeception was thrown
                MessageBox.Show(e.Message);
            }
        }

        // fires when the user clicks on one of the items in the listbox selection area
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // creates a new form2 object
            Form2 form2 = new Form2(listBox1.SelectedIndex);
            // shows form2
            form2.ShowDialog();
        }

    }
}
