using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;

// Writen by Josh Pohl and Matt Leet

namespace Online.Chapter_Exams
{
    public partial class Exam2 : System.Web.UI.Page
    {
        // making a new sql connection for running SQL commands
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        UsersEntities dbcontext = new UsersEntities();
        
        // answers to the exam
        int[] answers = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        // users answers to the exam
        int[] userAnswers = new int[10];
        // statitics of the exam
        int[] userStatistics = new int[10];

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i, count = 0;
            // save the user answers to the userAnswers Array
            userAnswers[0] = Convert.ToInt32(RadioButtonList1.SelectedValue);
            userAnswers[1] = Convert.ToInt32(RadioButtonList2.SelectedValue);
            userAnswers[2] = Convert.ToInt32(RadioButtonList3.SelectedValue);
            userAnswers[3] = Convert.ToInt32(RadioButtonList4.SelectedValue);
            userAnswers[4] = Convert.ToInt32(RadioButtonList5.SelectedValue);
            userAnswers[5] = Convert.ToInt32(RadioButtonList6.SelectedValue);
            userAnswers[6] = Convert.ToInt32(RadioButtonList7.SelectedValue);
            userAnswers[7] = Convert.ToInt32(RadioButtonList8.SelectedValue);
            userAnswers[8] = Convert.ToInt32(RadioButtonList9.SelectedValue);
            userAnswers[9] = Convert.ToInt32(RadioButtonList10.SelectedValue);

            // itterate through each element
            for (i = 0; i < 10; i++)
            {
                // check if the answers are correct
                if (answers[i] == userAnswers[i])
                {
                    // set the userStatitcs to the proper value
                    userStatistics[i] = 1;
                    // used to calculate the number correct
                    count++;
                }
                else
                    // set the userStatitcs to the proper value
                    userStatistics[i] = 0;
            }

            // open the connection for commands
            con.Open();
            // exectue command for selecting the examID of the current user
            SqlCommand c = new SqlCommand("SELECT ExamID FROM Users WHERE Username='" + User.Identity.Name.ToString() + "';", con);
            // updating the current exam to the user answers
            SqlCommand cmd = new SqlCommand("UPDATE Exam2 SET Q1='" + userStatistics[0] +
                                            "', Q2='" + userStatistics[1] +
                                            "', Q3='" + userStatistics[2] +
                                            "', Q4='" + userStatistics[3] +
                                            "', Q5='" + userStatistics[4] +
                                            "', Q6='" + userStatistics[5] +
                                            "', Q7='" + userStatistics[6] +
                                            "', Q8='" + userStatistics[7] +
                                            "', Q9='" + userStatistics[8] +
                                            "', Q10='" + userStatistics[9] +
                                            "', Grade='" + count / 10.0 + "' " +
                                            "WHERE Id='" + c.ExecuteScalar() + "';", con);
            // execute the current command
            cmd.ExecuteNonQuery();
            // close connection
            con.Close();
            // calculate the current users totalGrade
            ExamCalc.calcuate(con, User.Identity.Name.ToString());
            // send the email to instructor
            ExamCalc.sendEmail(userStatistics, User.Identity.Name.ToString(), 2);
            // redirect to the Exams page
            Response.Redirect("~/Exams");
        }
    }
}