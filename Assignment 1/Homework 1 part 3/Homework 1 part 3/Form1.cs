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

        public Form1()
        {
            InitializeComponent();
            try
            {
                string line, part1 = "", part2 = "", part3 = "";;
                int counter = 0;
                StreamReader input = new StreamReader("list.txt");
                while ((line = input.ReadLine()) != null)
                {
                    counter++;
                    switch (counter)
                    {
                        case 1:
                            part1 = line;
                            break;
                        case 2:
                            part2 = line;
                            break;
                        case 3:
                            part3 = line;
                            break;
                        default:
                            PersonEntry person = new PersonEntry(part1, part2, part3);
                            PersonEntryList.addPerson(person);
                            listBox1.Items.Add(person);
                            counter = 0;
                            break;
                    }
                    /*
                    string[] part1, part2, part3;
                    part1 = line.Split(' ');
                    part2 = line.Split(' ');
                    part3 = line.Split(' ');
                    PersonEntry person = new PersonEntry(part1.ToString, part2.ToString, part3.ToString);
                    listBox1.Items.Add(person);
                    */
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(listBox1.SelectedIndex);
            form2.ShowDialog();
        }

    }
}
