using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Net.Mail;
namespace Gym_administration
{
    static class Utils
    {
        static public bool bValidateEmail(string sEmail)
        {
            try
            {
                MailAddress temp = new System.Net.Mail.MailAddress(sEmail);
            }
            catch (FormatException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }
        
            return true;
        }
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
        static public string sGenerateNewMemberNumber()
        {
            // TODO: Check for existing number
            //Create a new Random class
            Random RandomClass = new Random();

            string sRandomNumber1 = RandomClass.Next(100, 999).ToString();
            string sRandomNumber2 = RandomClass.Next(100, 999).ToString();
            string sRandomNumber3 = RandomClass.Next(100, 999).ToString();
            return sRandomNumber1 + " " + sRandomNumber2 + " " + sRandomNumber3;
        }

        static public string sGetMysqlDate(string date)
        {
            try
            {
                // fetch the en-GB culture
                CultureInfo ukCulture = new CultureInfo("en-GB");
                // pass the DateTimeFormat information to DateTime.Parse
                DateTime dateTime = DateTime.Parse(date, ukCulture.DateTimeFormat);
                return String.Format("{0:yyyy-M-d}", dateTime);
            }
            catch (FormatException)
            {
                return "0000-00-00";
            }
          
        }

        static public string sGetCsharpDateFromMysqlDate(string date)
        {
            try
            {
                // fetch the en-US culture
                CultureInfo usCulture = new CultureInfo("en-US");
                // pass the DateTimeFormat information to DateTime.Parse
                DateTime dateTime = DateTime.Parse(date, usCulture.DateTimeFormat);
                return String.Format("{0:d/M/yyyy}", dateTime);
            }
            catch (FormatException)
            {
                return "00/00/0000";
            }

        }
    }
}
