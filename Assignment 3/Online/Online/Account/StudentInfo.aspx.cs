using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

// Writen by Josh Pohl and Matt Leet

namespace Online.Account
{
    public partial class StudentInfo : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            // check if the current user has already create user data
            // opens connection
            con.Open();
            // get the Id from the current logged in user
            SqlCommand c = new SqlCommand("SELECT Id FROM Users WHERE Username='" + User.Identity.Name.ToString() + "';", con);
            try {
                // execute the command
                c.ExecuteScalar().ToString();
                // close the connection
                con.Close();
                // redirect to exams
                Response.Redirect("~/Exams");
            }
            catch (NullReferenceException)
            {
                // catches if the user has not created an account
                // close the connection
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // open the connection
            con.Open();
            // creates the new user with the information provided
            SqlCommand cmd = new SqlCommand("INSERT INTO Users (Id, StudentName, Course, ClassNumber, TotalGrade, ChapterName, Username) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + "0.00" + "','" + "First Chapter" + "','" + User.Identity.Name.ToString() + "')", con);
            // execute command
            cmd.ExecuteNonQuery();
            // gets the current exam from the user logged in
            SqlCommand c = new SqlCommand("SELECT ExamID FROM Users WHERE Username='" + User.Identity.Name.ToString() + "';", con);
            // store the examID into a variable
            string id = c.ExecuteScalar().ToString();
            // create the users Exams rows from the examID
            cmd.CommandText = "INSERT INTO Exam1 VALUES('" + id + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + -1 + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO Exam2 VALUES('" + id + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + -1 + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO Exam3 VALUES('" + id + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + -1 + "')";
            // execute
            cmd.ExecuteNonQuery();
            // close
            con.Close();
            // redirect
            Response.Redirect("~/Exams");
        }
    }
}