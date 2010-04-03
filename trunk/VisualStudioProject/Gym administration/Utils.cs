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



        /**
        * @desc Returns true when the email received is valid 
        * @params [string] sEmail
        * @return [bool] True when the e-mail is a valid e-mail address
        * otherwise it will return false
        */
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

        /**
        * @desc It creates and md5hash useful to generate hashes for the password
        * to be stored in the database
        * @params [string] input
        * @return [string] The md5 string hash
        */
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
        /**
        * @desc It generates the a new random member number
        * @return [string] The new member number
        */
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


        /**
        * @desc It returns a valid formated date [YYYY-MM-DD] to be stored in the 
        * database from a U.K format [DD/MM/YYYY]
        * @params [string] date in [DD/MM/YYYY] format
        * @return [string] date in [YYYY-MM-DD] format
        */
        static public string sGetMysqlDate(string date)
        {
            try
            {
                // fetch the en-GB culture
                CultureInfo ukCulture = new CultureInfo("en-GB");
                // pass the DateTimeFormat information to DateTime.Parse
                DateTime dateTime = DateTime.Parse(date, ukCulture.DateTimeFormat);
                return String.Format("{0:yyyy-MM-dd}", dateTime);
            }
            catch (FormatException)
            {
                return "0000-00-00";
            }
          
        }

        /**
        * @desc It validates a string to see if it's in a time format
        * @params [string] time in [HH:MM] format
        * @return [bool] only true if the time is correct
        * */
        static public bool bValidateTime(string sTime)
        {
            try
            {
                // fetch the en-GB culture
                CultureInfo ukCulture = new CultureInfo("en-GB");
                // pass the DateTimeFormat information to DateTime.Parse
                DateTime dateTime = DateTime.Parse(sTime, ukCulture.DateTimeFormat);

                string sFormat =  String.Format("{0:HH:mm}", dateTime);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /**
        * @desc It returns a valid formated date [DD/MM/YYYY] to be used in the c sharp forms
        * from a mysql formated date [YYYY-MM-DD]
        * @params [string] date in [YYYY-MM-DD] format
        * @return [string] date in [DD/MM/YYYY] format
        */
        static public string sGetCsharpDateFromMysqlDate(string date)
        {
            try
            {
                // fetch the en-US culture
                CultureInfo usCulture = new CultureInfo("en-US");
                // pass the DateTimeFormat information to DateTime.Parse
                DateTime dateTime = DateTime.Parse(date, usCulture.DateTimeFormat);
                return String.Format("{0:dd/MM/yyyy}", dateTime);
            }
            catch (FormatException)
            {
                return "00/00/0000";
            }
        }

        /**
         * @desc It checks if the form is already opened, it it is, it shows it on top
         * @params [Form] The form to check
         * @return [bool] True if it is opened
         */
        static public bool bIsAlreadyOpened(Form frmMyForm)
        {
            foreach (Form frmOpenForm in Application.OpenForms)
            {
                if (frmOpenForm.GetType() == frmMyForm.GetType())
                {
                    frmOpenForm.TopMost = true;
                    frmOpenForm.Visible = true;
                    frmOpenForm.Activate();
                    return true;
                }
            }
            return false;
        }

   //     static public class MBButton
     //   {
            public const UInt32 MB_OK = 0x00000000;
            public const UInt32 MB_OKCANCEL = 0x00000001;
            public const UInt32 MB_ABORTRETRYIGNORE = 0x00000002;
            public const UInt32 MB_YESNOCANCEL = 0x00000003;
            public const UInt32 MB_YESNO = 0x00000004;
            public const UInt32 MB_RETRYCANCEL = 0x00000005;
            public const UInt32 MB_CANCELTRYCONTINUE = 0x00000006;
            public const UInt32 MB_CUST1 = 0x00000007;
            public const UInt32 MB_CUST2 = 0x00000008;
            public const UInt32 MB_CUST3 = 0x00000009;
            public const UInt32 MB_CUST4 = 0x00000010;
            public const UInt32 MB_HELP = 0x00004000;
    //    }
 

    }
}
