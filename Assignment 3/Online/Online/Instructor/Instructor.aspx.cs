using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace Online.Instructor
{
    public partial class Instructor : System.Web.UI.Page
    {
        UsersDataEntities dbcontext = new UsersDataEntities();
        UsersDataEntities dbcontext2 = new UsersDataEntities();
        UsersDataEntities dbcontext3 = new UsersDataEntities();
        UsersDataEntities dbcontext4 = new UsersDataEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dbcontext.Users.Load();
            dbcontext2.Exam1.Load();
            dbcontext3.Exam2.Load();
            dbcontext4.Exam3.Load();

            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    var exam1 = from item in dbcontext2.Exam1.Local
                                 where item.Grade >= Convert.ToDecimal(0.6)
                                 select item;

                    var examID = from item in dbcontext2.Exam1.Local
                                where item.Grade >= Convert.ToDecimal(0.6)
                                select item.Id;

                    var user = from item in dbcontext.Users.Local.Where(x => examID.Contains(x.ExamID))
                               select item;

                    GridView1.DataSource = user;
                    GridView1.DataBind();
                    GridView2.DataSource = exam1;
                    GridView2.DataBind();
                    break;
                case 1:
                    var exam2 = from item in dbcontext3.Exam2.Local
                                 where item.Grade >= Convert.ToDecimal(0.6)
                                 select item;

                    var examID2 = from item in dbcontext3.Exam2.Local
                                where item.Grade >= Convert.ToDecimal(0.6)
                                select item.Id;

                    var user2 = from item in dbcontext.Users.Local.Where(x => examID2.Contains(x.ExamID))
                               select item;

                    GridView1.DataSource = user2;
                    GridView1.DataBind();
                    GridView2.DataSource = exam2;
                    GridView2.DataBind();
                    break;
                case 2:
                    var exam3 = from item in dbcontext4.Exam3.Local
                                 where item.Grade >= Convert.ToDecimal(0.6)
                                 select item;

                    var examID3 = from item in dbcontext4.Exam3.Local
                                where item.Grade >= Convert.ToDecimal(0.6)
                                select item.Id;

                    var user3 = from item in dbcontext.Users.Local.Where(x => examID3.Contains(x.ExamID))
                               select item;

                    GridView1.DataSource = user3;
                    GridView1.DataBind();
                    GridView2.DataSource = exam3;
                    GridView2.DataBind();
                    break;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dbcontext.Users.Load();
            dbcontext2.Exam1.Load();
            dbcontext3.Exam2.Load();
            dbcontext4.Exam3.Load();

            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    var exam1 = from item in dbcontext2.Exam1.Local
                                where item.Grade < Convert.ToDecimal(0.6)
                                select item;

                    var examID = from item in dbcontext2.Exam1.Local
                                 where item.Grade < Convert.ToDecimal(0.6)
                                 select item.Id;

                    var user = from item in dbcontext.Users.Local.Where(x => examID.Contains(x.ExamID))
                               select item;

                    GridView1.DataSource = user;
                    GridView1.DataBind();
                    GridView2.DataSource = exam1;
                    GridView2.DataBind();
                    break;
                case 1:
                    var exam2 = from item in dbcontext3.Exam2.Local
                                where item.Grade < Convert.ToDecimal(0.6)
                                select item;

                    var examID2 = from item in dbcontext3.Exam2.Local
                                  where item.Grade < Convert.ToDecimal(0.6)
                                  select item.Id;

                    var user2 = from item in dbcontext.Users.Local.Where(x => examID2.Contains(x.ExamID))
                                select item;

                    GridView1.DataSource = user2;
                    GridView1.DataBind();
                    GridView2.DataSource = exam2;
                    GridView2.DataBind();
                    break;
                case 2:
                    var exam3 = from item in dbcontext4.Exam3.Local
                                where item.Grade < Convert.ToDecimal(0.6)
                                select item;

                    var examID3 = from item in dbcontext4.Exam3.Local
                                  where item.Grade < Convert.ToDecimal(0.6)
                                  select item.Id;

                    var user3 = from item in dbcontext.Users.Local.Where(x => examID3.Contains(x.ExamID))
                                select item;

                    GridView1.DataSource = user3;
                    GridView1.DataBind();
                    GridView2.DataSource = exam3;
                    GridView2.DataBind();
                    break;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            dbcontext.Users.Load();
            dbcontext2.Exam1.Load();
            dbcontext3.Exam2.Load();
            dbcontext4.Exam3.Load();

            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    var exam1 = from item in dbcontext2.Exam1.Local
                                where item.Grade >= Convert.ToDecimal(0.9)
                                select item;

                    var examID = from item in dbcontext2.Exam1.Local
                                 where item.Grade >= Convert.ToDecimal(0.9)
                                 select item.Id;

                    var user = from item in dbcontext.Users.Local.Where(x => examID.Contains(x.ExamID))
                               select item;

                    GridView1.DataSource = user;
                    GridView1.DataBind();
                    GridView2.DataSource = exam1;
                    GridView2.DataBind();
                    break;
                case 1:
                    var exam2 = from item in dbcontext3.Exam2.Local
                                where item.Grade >= Convert.ToDecimal(0.9)
                                select item;

                    var examID2 = from item in dbcontext3.Exam2.Local
                                  where item.Grade >= Convert.ToDecimal(0.9)
                                  select item.Id;

                    var user2 = from item in dbcontext.Users.Local.Where(x => examID2.Contains(x.ExamID))
                                select item;

                    GridView1.DataSource = user2;
                    GridView1.DataBind();
                    GridView2.DataSource = exam2;
                    GridView2.DataBind();
                    break;
                case 2:
                    var exam3 = from item in dbcontext4.Exam3.Local
                                where item.Grade >= Convert.ToDecimal(0.9)
                                select item;

                    var examID3 = from item in dbcontext4.Exam3.Local
                                  where item.Grade >= Convert.ToDecimal(0.9)
                                  select item.Id;

                    var user3 = from item in dbcontext.Users.Local.Where(x => examID3.Contains(x.ExamID))
                                select item;

                    GridView1.DataSource = user3;
                    GridView1.DataBind();
                    GridView2.DataSource = exam3;
                    GridView2.DataBind();
                    break;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            dbcontext.Users.Load();
            dbcontext2.Exam1.Load();
            dbcontext3.Exam2.Load();
            dbcontext4.Exam3.Load();
            double total = 0;
            int count = 0;
            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    var grade = from item in dbcontext2.Exam1.Local
                                select item.Grade;
                    foreach (var x in grade)
                    {
                        total += Convert.ToDouble(x.ToString());
                        count++;
                    }
                    break;
                case 1:
                    var grade2 = from item in dbcontext3.Exam2.Local
                                 select item.Grade;
                    foreach (var x in grade2)
                    {
                        total += Convert.ToDouble(x.ToString());
                        count++;
                    }
                    break;
                case 2:
                    var grade3 = from item in dbcontext4.Exam3.Local
                                 select item.Grade;
                    foreach (var x in grade3)
                    {
                        total += Convert.ToDouble(x.ToString());
                        count++;
                    }
                    break;
            }

            total /= count;
            Label1.Text = total.ToString();
        }
    }
}