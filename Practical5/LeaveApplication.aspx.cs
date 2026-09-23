using System;

namespace Pratical5
{
    public partial class LeaveApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (Session["LeaveDate"] != null)
                {
                    DateTime selectedDate =
                        Convert.ToDateTime(Session["LeaveDate"]);

                   
                    TextBox2.Text =
                        selectedDate.ToString("dd-MM-yyyy");
                }

                
                if (Request.Cookies["EmployeeName"] != null)
                {
                    TextBox1.Text =
                        Request.Cookies["EmployeeName"].Value;
                }

                Label1.Text = "";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Label1.Text = "Please enter employee name.";
                return;
            }

            if (TextBox2.Text == "")
            {
                Label1.Text = "Please select leave date.";
                return;
            }

            if (DropDownList1.SelectedIndex == 0)
            {
                Label1.Text = "Please select leave type.";
                return;
            }

            if (TextBox4.Text == "")
            {
                Label1.Text = "Please enter reason.";
                return;
            }

            
            if (CheckBox1.Checked)
            {
                Response.Cookies["EmployeeName"].Value =
                    TextBox1.Text;

                Response.Cookies["EmployeeName"].Expires =
                    DateTime.Now.AddDays(7);
            }

            Label1.Text =
                "Leave Application Submitted Successfully!<br/>" ;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        protected void DropDownList1_SelectedIndexChanged(
            object sender, EventArgs e)
        {
        }

        protected void CheckBox1_CheckedChanged(
            object sender, EventArgs e)
        {
        }
    }
}