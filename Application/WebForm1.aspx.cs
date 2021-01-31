using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Application
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection appconection = new SqlConnection("Server=tcp:serwerdatabase.database.windows.net,1433;Initial Catalog=database;Persist Security Info=False;User ID=julia;Password=Tuptus11;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            {
                SqlCommand insert = new SqlCommand("EXEC dbo.InsertFullName @FullName", appconection);
                insert.Parameters.AddWithValue("@FullName", TextBox1.Text);

                appconection.Open();
                insert.ExecuteNonQuery();
                appconection.Close();

                if(IsPostBack)
                {
                    TextBox1.Text = "";
                }

            }
        }
    }
}