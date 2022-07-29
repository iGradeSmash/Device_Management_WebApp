using Device_Management_Web.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Device_Management_Web
{
    public partial class Dashboard : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection(UtilityManager.Constants.DATABASE_CONNECTION);
        SqlDataReader sqlDataReader = null;
        SqlCommand sqlCommand = null;
        string query = "";
        protected void Page_Load(object sender, EventArgs e)
        {
          
            LoadTable();
        }
        protected void LoadTable()
        {
            query = "SELECT * FROM [DEVICES] WHERE ([IsAvailable] = 1 AND [Status]=1)";
            sqlConnection.Open();
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

            StringBuilder table = new StringBuilder();
            table.Append("<table class='table table-condensed table-bord'>");
            table.Append("<thead>");
            table.Append("<tr>");
            table.Append("<th>#</th>");
            table.Append("<th>Description</th>");
            table.Append("<th>Type</th>");
            table.Append("<th>Brand</th>");
            table.Append("<th>Model</th>");
            table.Append("<th>Barcode</th>");
            table.Append("</tr>");
            table.Append("</thead>");

            while (sqlDataReader.Read())
            {
                table.Append("<tbody>");
                table.Append("<tr>");
                table.Append($"<th>{sqlDataReader.GetInt32(0).ToString()}</th>");
                table.Append($"<td>{sqlDataReader.GetString(1).ToString()}</td>");
                table.Append($"<td>{sqlDataReader.GetString(2).ToString()}</td>");
                table.Append($"<td>{sqlDataReader.GetString(3).ToString()}</td>");
                table.Append($"<td>{sqlDataReader.GetString(4).ToString()}</td>");
                table.Append($"<td>{sqlDataReader.GetString(5).ToString()}</td>");
                table.Append("</tr>");

            }
            table.Append("</table>");
            sqlConnection.Close(); 
            MainTable.Controls.Add(new Literal{Text = table.ToString() });
        }
    }
}