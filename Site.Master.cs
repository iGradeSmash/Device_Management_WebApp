using Device_Management_Web.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Device_Management_Web
{
    public partial class SiteMaster : MasterPage
    {
            string AppName = "Device Manager";
        string Role = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = AppName;
            brand.InnerText = AppName;
            if (UtilityManager.Variables.RoleId == 1)
            {
                Role = "Administrator";

            }else if(UtilityManager.Variables.RoleId == 2)
            {
                Role = "Technician";
            }
            else
            {
      
                Role = "Teacher";
            }
            lblLogin.Text = $"{UtilityManager.Variables.UserName}, {Role}";

        }
    }
}