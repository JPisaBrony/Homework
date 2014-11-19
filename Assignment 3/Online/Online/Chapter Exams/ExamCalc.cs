using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Net;

// Writen by Josh Pohl and Matt Leet

namespace Online.Chapter_Exams
{
    public class ExamCalc
    {
        public static void calcuate(SqlConnection con, string user) {
            double total = 0;
            int examCount = 0;
            // open connection
            con.Open();
            // set command to get the ExamID from the table with the current user
            SqlCommand c = new SqlCommand("SELECT ExamID FROM Users WHERE Username='" + user + "';", con);
            // execute the command and save it to s variable
            string s = c.ExecuteScalar().ToString();
            // gets grade from each exam
            SqlCommand exam1 = new SqlCommand("SELECT Grade FROM Exam1 WHERE Id='" + s + "';", con);
            SqlCommand exam2 = new SqlCommand("SELECT Grade FROM Exam2 WHERE Id='" + s + "';", con);
            SqlCommand exam3 = new SqlCommand("SELECT Grade FROM Exam3 WHERE Id='" + s + "';", con);

            // saves each variable
            string e1 = exam1.ExecuteScalar().ToString();
            string e2 = exam2.ExecuteScalar().ToString();
            string e3 = exam3.ExecuteScalar().ToString();

            // check if the exam was taken
            if(!e1.Equals("-1.00"))
            {
                // add the exam to the total
                total += Convert.ToDouble(e1);
                // increment the exam count
                examCount++;
            }

            // check if the exam was taken
            if (!e2.Equals("-1.00"))
            {
                // add the exam to the total
                total += Convert.ToDouble(e2);
                // increment the exam count
                examCount++;
            }

            // check if the exam was taken
            if (!e3.Equals("-1.00"))
            {
                // add the exam to the total
                total += Convert.ToDouble(e3);
                // increment the exam count
                examCount++;
            }

            // updates the total grade for the current user 
            c.CommandText = "UPDATE Users SET TotalGrade='" + total / examCount + "' WHERE Username='" + user + "';";
            // execute command
            c.ExecuteNonQuery();
            // close the connection
            con.Close();
        }

        public static void sendEmail(int[] userStatistics, string user, int examNumber)
        {
            int i;
            var mailObj = new MailMessage("gateolson@gmail.com", "Oksana.Myronovych@ndsu.edu");
            mailObj.Subject = "subject";
            mailObj.Body = "Exam" + examNumber + "<br/>" + user + " Anwers:<br/>";
            for (i = 0; i < 10; i++)
            {
                mailObj.Body += "Question " + (i + 1) + ": " + Convert.ToBoolean(userStatistics[i]) + "<br/>";
            }
            mailObj.IsBodyHtml = true;
            var smtpServer = new SmtpClient("smtp.gmail.com", 587);

            smtpServer.UseDefaultCredentials = true;
            smtpServer.EnableSsl = true;
            smtpServer.Credentials = new NetworkCredential("gateolson@gmail.com", "Sonyclie");
            smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpServer.Send(mailObj);
        }
    }
}