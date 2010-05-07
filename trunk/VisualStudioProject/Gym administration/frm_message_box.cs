/* References used:
 * Creating a Custom Message Box
 * (Hussain, S., 2007)
 * 
 * 
 * Create Custom Dialog like MessageBox
 * (Drumm, D., 2005)
 * 
 * 
 *  MyMessageBox myMessagebox; //put this before class constructor
 *  myMessageBox = new MyMessageBox(); //put this into frm_"yourclassname"_Load()
//Then use it like this anywhere in class:
//default title "Message" and default buttons yes/no
    string result1 = myMessageBox.ShowBox(Utils.MB_YESNO, "Do you want to exit?", "");

//title "exit" and default button ok
    string result2 = myMessageBox.ShowBox(Utils.MB_OK, "Do you want to exit?", "Exit");
 
//title "exit" and 1 custom button hello
    string result3 = myMessageBox.ShowBox(Utils.MB_CUST1, "Do you want to exit?", "Exit", "hello");

//title "exit" and 2 custom buttons hello and bello
    string result4 = myMessageBox.ShowBox(Utils.MB_CUST2, "Do you want to exit?", "Exit", "hello", "bello");

//title "exit" and 3 custom buttons Bimm, Bamm, Bumm
    string result5 = myMessageBox.ShowBox(Utils.MB_CUST3, "Do you want to exit?", "Exit", "Bimm", "Bamm", "Bumm");
*/

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
    /**
     * @desc 
     * Form Handler for custom dialogs
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    public partial class frm_message_box : Form
    {
        frm_message_box newMessageBox;
        static string Button_id;
        string Button1_Value;
        string Button2_Value;
        string Button3_Value;
        int Counter1_PrevValue;

        /**
         * @desc Constructor.  
         * Initializes the dialog to its default state
         * @params [none] No input parameter.
         * @return [none] No directly returned data.
         */
        public frm_message_box()
        {
            InitializeComponent();
            label_counter1.Hide();
            counter1.Hide();
            label_counter2.Hide();
            label_borrowedcounter.Hide();
            button_1.Hide();
            button_2.Hide();
            button_3.Hide();
        }

        /**
         * @desc Constants for default button values
         * @params [none] No input parameter.
         * @return [none] No directly returned data.
         */
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

        /**
         * @desc Default return values
         * @params [none] No input parameter.
         * @return [none] No directly returned data.
         */
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

        /**
         * @desc It sets up the default and custom dialog layout variations
         * @params [none] No input parameter.
         * @return [none] No directly returned data.
         */
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
                        label_counter1.Show();
                        counter1.Value = 1;
                        Counter1_PrevValue = 1;
                        counter1.Show();
                        counter1.Minimum = 1;
                        counter1.Maximum = int.Parse(Button1);
                        label_counter2.Show();
                        label_borrowedcounter.Show();
                        label_borrowedcounter.Text = (int.Parse(Button1)-1).ToString();
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

        /**
          * @desc Default dialog invoker
          * @params [Uint32] Type: Selector of one of the default dialog layouts
          * @params [string] txtMessage: Dialog message
          * @params [string] txtTitle: Dialog title
          * @return [string] Button_id: Return value of selected button
          */
        public string ShowBox(UInt32 Type, string txtMessage, string txtTitle)
        {
            // Create message box
            newMessageBox = new frm_message_box();
            // Set layout
            newMessageBox.SetButtonLayout(Type, "", "", "");
            // Set title
            if (txtTitle == "") 
                newMessageBox.Text = "Message";
            else 
                newMessageBox.Text = txtTitle;
            // Set message
            newMessageBox.label_Message.Text = txtMessage;
            // Show dialog
            newMessageBox.ShowDialog();
            // Return result
            return Button_id;
        }

        /**
          * @desc Dialog invoker with one custom button
          * @params [Uint32] Type: Selector of one of the custom dialog layouts
          * @params [string] txtMessage: Dialog message
          * @params [string] txtTitle: Dialog title
          * @params [string] Button1: Button text
          * @return [string] Button_id: Return value of selected button
          */
        public string ShowBox(UInt32 Type, string txtMessage, string txtTitle, string Button1)
        {
            newMessageBox = new frm_message_box();
            newMessageBox.SetButtonLayout(Type, Button1, "", "");
            if (txtTitle == "") newMessageBox.Text = "Message";
            else newMessageBox.Text = txtTitle;
            newMessageBox.label_Message.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Button_id;
        }

        /**
          * @desc Dialog invoker with two custom buttons
          * @params [Uint32] Type: Selector of one of the custom dialog layouts
          * @params [string] txtMessage: Dialog message
          * @params [string] txtTitle: Dialog title
          * @params [string] Button1: Button text
          * @params [string] Button2: Button text
          * @return [string] Button_id: Return value of selected button
          */
        public string ShowBox(UInt32 Type, string txtMessage, string txtTitle, string Button1, string Button2)
        {
            newMessageBox = new frm_message_box();
            newMessageBox.SetButtonLayout(Type, Button1, Button2, "");
            if (txtTitle == "") newMessageBox.Text = "Message";
            else newMessageBox.Text = txtTitle;
            newMessageBox.label_Message.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Button_id;
        }

        /**
          * @desc Dialog invoker with three custom buttons
          * @params [Uint32] Type: Selector of one of the custom dialog layouts
          * @params [string] txtMessage: Dialog message
          * @params [string] txtTitle: Dialog title
          * @params [string] Button1: Button text
          * @params [string] Button2: Button text
          * @params [string] Button3: Button text
          * @return [string] Button_id: Return value of selected button
          */
        public string ShowBox(UInt32 Type, string txtMessage, string txtTitle, string Button1, string Button2, string Button3)
        {
            newMessageBox = new frm_message_box();
            newMessageBox.SetButtonLayout(Type, Button1, Button2, Button3);
            if (txtTitle == "") newMessageBox.Text = "Message";
            else newMessageBox.Text = txtTitle;
            newMessageBox.label_Message.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Button_id;
        }

        /** 
          * @desc Executes when button 1 is clicked on
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_1_Click(object sender, EventArgs e)
        {
            // Pass the result to return method
            Button_id = Button1_Value;
            this.Close(); 
        }

        /** 
          * @desc Executes when button 1 is clicked on
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_2_Click(object sender, EventArgs e)
        {
            // If this is an item return dialog, then the result is to be the amount returned
            if (Button2_Value == MBButton.MB_CUST4.ToString())
                Button2_Value = label_borrowedcounter.Text;
            // Pass the result to return method
            Button_id = Button2_Value;
            this.Close(); 
        }

        /** 
          * @desc Executes when button 1 is clicked on
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_3_Click(object sender, EventArgs e)
        {
            // Pass the result to return method
            Button_id = Button3_Value;
            this.Close(); 
        }


        /** 
          * @desc Executes when counter1's value is changed
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void counter1_ValueChanged(object sender, EventArgs e)
        {

            // if counter1's value is decreased (-1)
            // (prevvalue is first 1, counter1 is also 1,
            // so if first change is decrease counter1 will be 0)
            if (Counter1_PrevValue > counter1.Value)
            {
                // if opposite counter is not at max yet
                if (counter1.Value < counter1.Maximum)
                {
                    int iCounter2;
                    // Retrieve current value of opposite counter
                    iCounter2 = int.Parse(label_borrowedcounter.Text);
                    // Increase opposite counter's value
                    iCounter2++;
                    // Set opposite counter to the new value
                    label_borrowedcounter.Text = iCounter2.ToString();
                    // Store current value of counter1 as prevvalue
                    Counter1_PrevValue = int.Parse(counter1.Value.ToString());
                }
            }
            // if counter1's value is increased (+1)
            // (prevvalue is first 1, counter1 is also 1,
            // so if first change is increase counter1 will be 2)
            else if (Counter1_PrevValue < counter1.Value)
            {
                // if opposite counter is not at min yet
                if (counter1.Value > counter1.Minimum)
                {
                    int iCounter2;
                    // Retrieve current value of opposite counter
                    iCounter2 = int.Parse(label_borrowedcounter.Text);
                    // Decrease opposite counter's value
                    iCounter2--;
                    // Set opposite counter to the new value
                    label_borrowedcounter.Text = iCounter2.ToString();
                    // Store current value of counter1 as prevvalue
                    Counter1_PrevValue = int.Parse(counter1.Value.ToString());
                }
            }
        }
    }
}