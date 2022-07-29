using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Device_Management_Web.Utilities
{
    public class UtilityManager
    {
        public static class Constants
        {
            public const string DATABASE_CONNECTION = @"Data Source=(localdb)\ProjectModels; Database=Device_Management_db";
            public const string TABLE_NAME_DEVICES = "[Devices]";
            public const string TABLE_NAME_USERS = "[Users]";
            public const string TABLE_NAME_DEVICE_MANAGER = "[Device_Manager]";
            public const string APPLICATION_CLOSE_WARNING_MESSAGE_CONFIRM_EXIT = "EXIT APPLICATION?";
            public const string APPLICATION_CLOSE_WARNING_MESSAGE_CONFIRM_EXIT_TITLE = "Device Management System";
            public const string ERROR_MESSAGE_IS_EMAIL_VALID = "Invalid Email Address!";

        }
        public static class Variables
        {
            public static int UserID = 0;
            public static int RoleId = 0;
            public static int PasswordChangeId = 0;
            public static string UserName = "";
            public static string Department = "";
            public static string Description = "";
        }
        public static class Validation
        {
            public static string PasswordEncode(string plainText)
            {
                var plainBytes = Encoding.UTF8.GetBytes(plainText);

                return Convert.ToBase64String(plainBytes);
            }
            public static string PasswordDecode(string encodedData)
            {
                var encodedBytes = Convert.FromBase64String(encodedData);
                return Encoding.UTF8.GetString(encodedBytes);
            }

            public static bool IsValidEmail(string email)
            {

                bool isEmail = Regex.IsMatch(email.Trim(), @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

                return isEmail;

            }
        }
        //public static class SystemMessages
        //{
        //    public static void WarningMessage(string title, string body)
        //    {
        //        DialogResult dialogResult = MessageBox.Show(body, title, MessageBoxButtons.YesNo);

        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            Application.Exit();
        //        }
        //        else
        //        {
        //            return;
        //        }
        //    }
        //}
    }
}