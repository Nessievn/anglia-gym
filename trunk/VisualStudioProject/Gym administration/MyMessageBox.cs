/*  MyMessageBox myMessagebox; //put this before class constructor
 *  myMessageBox = new MyMessageBox(); //put this into frm_"yourclassname"_Load()
//Then use it like this anywhere in class:
//default title "Message" and default buttons yes/no
    string result1 = myMessageBox.ShowBox(Utils.MB_YESNO, "Do you want to exit?", "");

//title "exit" and default button yes
    string result2 = myMessageBox.ShowBox(Utils.MB_OK, "Do you want to exit?", "Exit");
 
//title "exit" and 1 custom button hello
    string result3 = myMessageBox.ShowBox(Utils.MB_CUST1, "Do you want to exit?", "Exit", "hello");

//title "exit" and 2 custom buttons hello and bello
    string result4 = myMessageBox.ShowBox(Utils.MB_CUST2, "Do you want to exit?", "Exit", "hello", "bello");

//title "exit" and 3 custom buttons Bimm, Bamm and Bumm
    string result5 = myMessageBox.ShowBox(Utils.MB_CUST3, "Do you want to exit?", "Exit", "Bimm", "Bamm", "Bumm");
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
        static string Button_id;
        string Button1_Value;
        string Button2_Value;
        string Button3_Value;

        public MyMessageBox()
        {
            InitializeComponent();
            counter.Hide();
            button_1.Hide();
            button_2.Hide();
            button_3.Hide();
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
            public const UInt32 MB_CUST4 = 0x00000010;
            public const UInt32 MB_HELP = 0x00004000;
        }

        //Not implemented (maybe later?)
        public enum MBReturn
        {
            OK = 1,
            CANCEL = 2,
            ABORT = 3,
            RETRY = 4,
            IGNORE = 5,
            YES = 6,
            NO = 7,
            CLOSE = 8,
            HELP = 9,
            TRYAGAIN = 10,
            CONTINUE = 11,
        }

        private void SetButtonLayout(UInt32 Type, string Button1, string Button2, string Button3)

        {
            
            switch (Type)
            {
                case MBButton.MB_OK:
                    {
                        button_3.Show();
                        button_3.Text = "Ok";
                        Button3_Value = MBReturn.OK.ToString();
                        break;
                    }
                case MBButton.MB_OKCANCEL:
                    {
                        button_2.Show();
                        button_2.Text = "OK";
                        button_3.Show();
                        button_3.Text = "Cancel";
                        Button2_Value = MBReturn.OK.ToString();
                        Button3_Value = MBReturn.CANCEL.ToString(); 
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
                        Button1_Value = MBReturn.ABORT.ToString();
                        Button2_Value = MBReturn.RETRY.ToString();
                        Button3_Value = MBReturn.IGNORE.ToString();

                        break;
                    }
                case MBButton.MB_YESNOCANCEL:
                    {
                        button_1.Show();
                        button_1.Text = "Yes";
                        button_2.Show();
                        button_2.Text = "No";
                        button_3.Show();
                        button_3.Text = "Cancel";
                        Button1_Value = MBReturn.YES.ToString();
                        Button2_Value = MBReturn.NO.ToString();
                        Button3_Value = MBReturn.CANCEL.ToString();

                        break;
                    }
                case MBButton.MB_YESNO:
                    {
                        button_2.Show();
                        button_2.Text = "Yes";
                        button_3.Show();
                        button_3.Text = "No";
                        Button2_Value = MBReturn.YES.ToString();
                        Button3_Value = MBReturn.NO.ToString();
                        break;
                    }
                case MBButton.MB_RETRYCANCEL:
                    {
                        button_2.Show();
                        button_2.Text = "Retry";
                        button_3.Show();
                        button_3.Text = "Cancel";
                        Button2_Value = MBReturn.RETRY.ToString();
                        Button3_Value = MBReturn.CANCEL.ToString();
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
                        Button1_Value = MBReturn.CANCEL.ToString();
                        Button2_Value = MBReturn.TRYAGAIN.ToString();
                        Button3_Value = MBReturn.CONTINUE.ToString();

                        break;
                    }
                case MBButton.MB_HELP:
                    {
                        button_3.Show();
                        button_3.Text = "Help";
                        Button3_Value = MBReturn.HELP.ToString();
                        break;
                    }
                case MBButton.MB_CUST1:
                    {
                        button_3.Show();
                        button_3.Text = Button1;
                        Button3_Value = Button1;
                        break;
                    }
                case MBButton.MB_CUST2:
                    {
                        button_2.Show();
                        button_2.Text = Button1;
                        button_3.Show();
                        button_3.Text = Button2;

                        Button2_Value = Button1;
                        Button3_Value = Button2;
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

                        Button1_Value = Button1;
                        Button2_Value = Button2;
                        Button3_Value = Button3;

                        break;
                    }
                case MBButton.MB_CUST4:
                    {
                        counter.Show();
                        counter.Value = 1;
                        button_2.Show();
                        button_2.Text = "OK";
                        button_3.Show();
                        button_3.Text = "Cancel";
                        Button2_Value = MBButton.MB_CUST4.ToString();
                        Button3_Value = MBReturn.CANCEL.ToString(); 

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
            Button_id = Button1_Value;
            this.Close(); 
        } 

        private void button_2_Click(object sender, EventArgs e)
        {

            if (Button2_Value == MBButton.MB_CUST4.ToString())
                Button2_Value = counter.Value.ToString();

            
            double Num;
            bool isNum = double.TryParse(Button2_Value, out Num);
            if (isNum)
            {
                if (int.Parse(Button2_Value) < 1)
                    MessageBox.Show("You can't choose zero amount, click Cancel instead");
            }
            Button_id = Button2_Value;
            this.Close(); 
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            Button_id = Button3_Value;
            this.Close(); 
            
        }

  


 
    }


}