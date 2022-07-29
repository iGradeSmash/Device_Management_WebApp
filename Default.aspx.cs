using Device_Management_Web.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Device_Management_Web
{
    public partial class _Default : Page
    {
        private readonly ConnectionManager con = new ConnectionManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSubmit.Click += new EventHandler(this.btnSubmit_Click);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            con.GetUserID(txtUsername.Text, UtilityManager.Validation.PasswordEncode(txtPassword.Text));
            if (UtilityManager.Variables.UserID != 0)
            {
                lblResult.ForeColor = Color.FromArgb(0x0010AF00);
                lblResult.Text = "Logged In!";
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                lblResult.ForeColor = Color.FromArgb(0x00AF5000);
                lblResult.Text = $"Credentials Invalid! - User ID : { UtilityManager.Variables.UserID}";
            }
        }
    }
}