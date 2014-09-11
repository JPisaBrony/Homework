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
        public Form2(int index)
        {
            InitializeComponent();
            //List<PersonEntry> pList = PersonEntryList.getPersonEntityList();
            PersonEntry person = PersonEntryList.getPersonEntityList().ElementAt(index);
            label1.Text = person.Name;
            label2.Text = person.Email;
            label3.Text = person.PhoneNumber;
        }
    }
}
