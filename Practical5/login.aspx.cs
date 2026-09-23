using System;

namespace Pratical5
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = "Please select a date.";
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            // Get selected date
            DateTime selectedDate = Calendar1.SelectedDate;

            // Show selected date
            Label1.Text = "Selected Date: " +
                          selectedDate.ToString("dd-MM-yyyy");

            // Store date in Session
            Session["LeaveDate"] = selectedDate;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate == DateTime.MinValue)
            {
                Label1.Text = "Please select a date first.";
                return;
            }

            Response.Redirect("LeaveApplication.aspx");
        }
    }
}