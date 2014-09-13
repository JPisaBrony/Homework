using System;
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
    public partial class Form2 : Form
    {
        // form2 constructor
        // it accepts an int which is the index of the item clicked in the listbox in form1
        public Form2(int index)
        {
            // startup everything
            InitializeComponent();
            // gets the person object that is in the list at the index clicked
            PersonEntry person = PersonEntryList.getPersonEntityList().ElementAt(index);
            // sets the text in the label to the name from the person object clicked
            label1.Text = person.Name;
            // sets the text in the label to the email from the person object clicked
            label2.Text = person.Email;
            // sets the text in the label to the phonenumber from the person object clicked
            label3.Text = person.PhoneNumber;
        }
    }
}
