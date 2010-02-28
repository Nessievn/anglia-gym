using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Gym_administration
{
    static class Utils
    {

        static public string CreateMD5Hash(string input)
        {
            // Use input string to calculate MD5 hash
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
                // To force the hex string to lower-case letters instead of
                // upper-case, use he following line instead:
                // sb.Append(hashBytes[i].ToString("x2")); 
            }
            return sb.ToString().ToLower();
        }
        static public string sGetMysqlDate(string date)
        {
            try
            {
                // fetch the en-GB culture
                CultureInfo ukCulture = new CultureInfo("en-GB");
                // pass the DateTimeFormat information to DateTime.Parse
                DateTime dateTime = DateTime.Parse(date, ukCulture.DateTimeFormat);
                string sMysqlDate = String.Format("{0:yyyy-M-d}", dateTime);
                return sMysqlDate;
            }
            catch (FormatException fe)
            {
                MessageBox.Show("The date is in incorrect format! Please type it again");
                return "0000-00-00";
            }
          
        }
    }
}
