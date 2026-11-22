using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical9
{
    public partial class Companies : System.Web.UI.Page
    {
        private static readonly string ConnectionString =
            ConfigurationManager.ConnectionStrings["PlacementDb"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCompanies();
                LoadPlacements();
            }
        }

        private void LoadCompanies()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = "SELECT PlacementId, StudentId, CompanyName, JobRole, PackageLPA FROM Students";

                DataTable dt = new DataTable();

                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    da.Fill(dt);
                }

                rptCompanies.DataSource = dt;
                rptCompanies.DataBind();
            }
        }

        private void LoadPlacements()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = "SELECT PlacementId, StudentId, CompanyName, JobRole, PackageLPA FROM Students";

                DataTable dt = new DataTable();

                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    da.Fill(dt);
                }

                dlPlacements.DataSource = dt;
                dlPlacements.DataBind();
            }
        }
    }
}