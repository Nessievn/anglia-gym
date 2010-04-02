  /*  string result3 = myMessageBox.ShowBox(Utils.MB_YESNO, "Do you want to exit?", "");
    string result4 = myMessageBox.ShowBox(Utils.MB_OK, "Do you want to exit?", "Exit");
    string result5 = myMessageBox.ShowBox(Utils.MB_CUST1, "Do you want to exit?", "Exit", "hello");
    string result6 = myMessageBox.ShowBox(Utils.MB_CUST2, "Do you want to exit?", "Exit", "hello", "bello");
    string result7 = myMessageBox.ShowBox(Utils.MB_CUST3, "Do you want to exit?", "Exit", "en", "te", "o");
*/
//reference http://www.codeguru.com/csharp/.net/net_general/eventsanddelegates/article.php/c13193__2/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gym_administration
{
    public partial class MyMessageBox : Form
    {

        MyMessageBox newMessageBox;
        string Button_id;

        public MyMessageBox()
        {
            InitializeComponent();
        }

        public class MBButton
        {
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
            public const UInt32 MB_HELP = 0x00004000;
        }

        private void SetButtonLayout(UInt32 Type, string Button1, string Button2, string Button3)

        {
            
            switch (Type)
            {
                case MBButton.MB_OK:
                    {
                        button_1.Hide();
                        button_2.Hide();
                        button_3.Show();
                        button_3.Text = "Ok";
                        break;
                    }
                case MBButton.MB_OKCANCEL:
                    {
                        //MessageBox.Show(this);
                        button_1.Hide();
                        button_2.Show();
                        button_2.Text = "Cancel";
                        button_3.Show();
                        button_3.Text = "Ok";
                        break;
                    }
                case MBButton.MB_ABORTRETRYIGNORE:
                    {
                        button_1.Show();
                        button_1.Text = "Abort";
                        button_2.Show();
                        button_2.Text = "Retry";
                        button_3.Show();
                        button_3.Text = "Ignore";
                        break;
                    }
                case MBButton.MB_YESNOCANCEL:
                    {
                        //MessageBox.Show(MBButton.MB_OK.ToString());
                        this.button_1.Show();
                        button_1.Text = "Yes";
                        button_2.Show();
                        button_2.Text = "No";
                        button_3.Show();
                        button_3.Text = "Cancel";
                        break;
                    }
                case MBButton.MB_YESNO:
                    {
                        //MessageBox.Show(MBButton.MB_OK.ToString());
                        this.button_1.Hide();
                        button_2.Show();
                        button_2.Text = "Yes";
                        button_3.Show();
                        button_3.Text = "No";
                        break;
                    }
                case MBButton.MB_RETRYCANCEL:
                    {
                        button_1.Hide();
                        button_2.Show();
                        button_2.Text = "Retry";
                        button_3.Show();
                        button_3.Text = "Cancel";
                        break;
                    }
                case MBButton.MB_CANCELTRYCONTINUE:
                    {
                        button_1.Show();
                        button_1.Text = "Cancel";
                        button_2.Show();
                        button_2.Text = "Try";
                        button_3.Show();
                        button_3.Text = "Continue";
                        break;
                    }
                case MBButton.MB_HELP:
                    {
                        button_1.Hide();
                        button_2.Hide();
                        button_3.Show();
                        button_3.Text = "Help";
                        break;
                    }
                case MBButton.MB_CUST1:
                    {
                        button_1.Hide();
                        button_2.Hide();
                        button_3.Show();
                        button_3.Text = Button1;
                        break;
                    }
                case MBButton.MB_CUST2:
                    {
                        button_1.Hide();
                        button_2.Show();
                        button_2.Text = Button1;
                        button_3.Show();
                        button_3.Text = Button2;
                        break;
                    }
                case MBButton.MB_CUST3:
                    {
                        button_1.Show();
                        button_1.Text = Button1;
                        button_2.Show();
                        button_2.Text = Button2;
                        button_3.Show();
                        button_3.Text = Button3;
                        break;
                    }


            }
        }
  /*      
        public string ShowBox(UInt32 Type, string txtMessage)
        {

            newMessageBox = new MyMessageBox();
            newMessageBox.SetButtonLayout(Type, "", "", "");
            newMessageBox.label_Message.Text = txtMessage;
            newMessageBox.ShowDialog();

            return Button_id;
        }
        public string ShowBox(UInt32 Type, string txtMessage, string Button1)
        {

            newMessageBox = new MyMessageBox();
            newMessageBox.SetButtonLayout(Type, Button1, "", "");
            newMessageBox.label_Message.Text = txtMessage;
            newMessageBox.ShowDialog();

            return Button_id;
        }
        public string ShowBox(UInt32 Type, string txtMessage, string Button1, string Button2)
        {

            newMessageBox = new MyMessageBox();
            newMessageBox.SetButtonLayout(Type, Button1, Button2, "");
            newMessageBox.label_Message.Text = txtMessage;
            newMessageBox.ShowDialog();

            return Button_id;
        }
        public string ShowBox(UInt32 Type, string txtMessage, string Button1, string Button2, string Button3)
        {

            newMessageBox = new MyMessageBox();
            newMessageBox.SetButtonLayout(Type, Button1, Button2, Button3);
            newMessageBox.label_Message.Text = txtMessage;
            newMessageBox.ShowDialog();

            return Button_id;
        }*/

        public string ShowBox(UInt32 Type, string txtMessage, string txtTitle)
        {

            newMessageBox = new MyMessageBox();
            newMessageBox.SetButtonLayout(Type, "", "", "");
            if (txtTitle == "") newMessageBox.Text = "Message";
            else newMessageBox.Text = txtTitle;
            newMessageBox.label_Message.Text = txtMessage;
            newMessageBox.ShowDialog();

            return Button_id;
        }
        public string ShowBox(UInt32 Type, string txtMessage, string txtTitle, string Button1)
        {

            newMessageBox = new MyMessageBox();
            newMessageBox.SetButtonLayout(Type, Button1, "", "");
            if (txtTitle == "") newMessageBox.Text = "Message";
            else newMessageBox.Text = txtTitle;
            newMessageBox.label_Message.Text = txtMessage;
            newMessageBox.ShowDialog();

            return Button_id;
        }
        public string ShowBox(UInt32 Type, string txtMessage, string txtTitle, string Button1, string Button2)
        {

            newMessageBox = new MyMessageBox();
            newMessageBox.SetButtonLayout(Type, Button1, Button2, "");
            if (txtTitle == "") newMessageBox.Text = "Message";
            else newMessageBox.Text = txtTitle;
            newMessageBox.label_Message.Text = txtMessage;
            newMessageBox.ShowDialog();

            return Button_id;
        }
        public string ShowBox(UInt32 Type, string txtMessage, string txtTitle, string Button1, string Button2, string Button3)
        {

            newMessageBox = new MyMessageBox();
            newMessageBox.SetButtonLayout(Type, Button1, Button2, Button3);
            if (txtTitle == "") newMessageBox.Text = "Message";
            else newMessageBox.Text = txtTitle;
            newMessageBox.label_Message.Text = txtMessage;
            newMessageBox.ShowDialog();

            return Button_id;
        }





        private void MyMessageBox_Load(object sender, EventArgs e)
        {

        }



        private void button_1_Click(object sender, EventArgs e)
        {

            Button_id = "1";
            newMessageBox.Dispose(); 
        } 

        private void button_2_Click(object sender, EventArgs e)
        {

            Button_id = "2";
            newMessageBox.Dispose(); 
        }

        private void button_3_Click(object sender, EventArgs e)
        {

            Button_id = "3"; 
            newMessageBox.Dispose();
        }



 
    }


}