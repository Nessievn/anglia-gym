using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gym_administration
{
    public partial class frm_class_arrange : Form
    {
        public frm_class_arrange()
        {
            InitializeComponent();
        }

        private void frm_class_arrange_Load(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            
            // Loading Available Classes
            string sQuery = "SELECT id_class, name FROM classes ORDER BY id_class";
            ArrayList myItems = conn.alGetComboFromDb(sQuery, "id_class","name");
            cmb_classes.DisplayMember = "Value";
            cmb_classes.DataSource = myItems;

            // Loading Available Rooms
            sQuery = "SELECT id_room, name FROM rooms ORDER BY id_room";
            myItems = conn.alGetComboFromDb(sQuery, "id_room", "name");
            cmb_rooms.DisplayMember = "Value";
            cmb_rooms.DataSource = myItems;

            // Loading Available Instructor
            //TODO: Inform Katie about the Position -> Instructor field
            sQuery = "SELECT id_staff, CONCAT(firstName,' ', lastName) name FROM staff WHERE position = 'Instructor' ORDER BY id_staff";
            myItems = conn.alGetComboFromDb(sQuery, "id_staff", "name");
            cmb_instructors.DisplayMember = "Value";
            cmb_instructors.DataSource = myItems;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Check data
            string sDate = Utils.sGetMysqlDate(txt_start.Text);
            DictionaryEntry de = (DictionaryEntry)cmb_classes.SelectedItem;
            string sIdClass = de.Key.ToString();
            de = (DictionaryEntry)cmb_instructors.SelectedItem;
            string sIdStaff = de.Key.ToString();
            de = (DictionaryEntry)cmb_rooms.SelectedItem;
            string sIdRoom = de.Key.ToString();

            if(sDate == "0000-00-00")
            {
                MessageBox.Show("Check the date format!");
                return;
            }else if(Utils.bValidateTime(txt_start_time.Text) == false || Utils.bValidateTime(txt_start_time.Text) == false)
            {
                MessageBox.Show("Check the time format!");
                return;
            }

            
            // Check class overlapping
            ClassBooked cbClassBooked = new ClassBooked();
            
            // Check if we found the user
            if (cbClassBooked.bCheckOverlap(sDate, sIdRoom, sIdStaff, txt_start_time.Text, txt_end_time.Text))
                MessageBox.Show("The class is overlapping with another class, please specify another date, room or instructor.");
            else
            {
                cbClassBooked.Id_staff = int.Parse(sIdStaff);
                cbClassBooked.RRoom = new Room(int.Parse(sIdRoom));
                cbClassBooked.SClass = new Class(int.Parse(sIdClass));
                cbClassBooked.SDateStart = sDate;
                cbClassBooked.SEndTime = txt_end_time.Text;
                cbClassBooked.SFrequency = cmb_repeats.Text;
                cbClassBooked.SStartTime = txt_start_time.Text;
                if (cbClassBooked.bSave())
                    MessageBox.Show("The class instance has been created!");
            }

            // Check Equipment availability

        }
    }
}
