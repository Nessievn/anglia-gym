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
    public partial class frm_class_instance_arrange : Form
    {
        ClassInstance ciClassInstance;
        frm_class_instance_list frmClArrList;

        public frm_class_instance_arrange()
        {
            InitializeComponent();
            ciClassInstance = new ClassInstance();
            button_enrollmembers.Enabled = false;
        }
        public frm_class_instance_arrange(int iIdClassBooked, frm_class_instance_list frmClArrList)
        {
            InitializeComponent();
            this.frmClArrList = frmClArrList;
            ciClassInstance = new ClassInstance(iIdClassBooked);
            if (ciClassInstance.Id_class_instance == -1)
                MessageBox.Show("The class instance could not be found");
            else
            {
                txt_endtime.Text = ciClassInstance.SEndTime;
                txt_startdate.Text = ciClassInstance.SDateStart;
                txt_starttime.Text = ciClassInstance.SStartTime;
                button_enrollmembers.Enabled = true;
            }
        }
        private void frm_class_instance_arrange_Load(object sender, EventArgs e)
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
            
            // HERE we select the options with the class instance
            if (this.ciClassInstance.Id_class_instance != -1)
            {
                cmb_classes.SelectedIndex = cmb_classes.FindString(ciClassInstance.SClass.SName);
                //cmb_instructors.SelectedIndex = cmb_instructors.FindString(ciClassInstance..SName+' ');
                cmb_rooms.SelectedIndex = cmb_rooms.FindString(ciClassInstance.RRoom.SName);
                cmb_repeats.SelectedIndex = cmb_repeats.FindString(ciClassInstance.SFrequency);
                sQuery = "SELECT COUNT(*) q FROM gym.class_bookings WHERE id_class_instance = '" + this.ciClassInstance.Id_class_instance + "'";
                List<Hashtable> lhRes = conn.lhSqlQuery(sQuery);
                lbl_currentmembers_amount.Text = lhRes[0]["q"].ToString();
                sQuery = "SELECT r.size FROM gym.class_instance ci, gym.rooms r WHERE ci.id_room = r.id_room AND ci.id_class_instance = '" + this.ciClassInstance.Id_class_instance + "'";
                lhRes = conn.lhSqlQuery(sQuery);
                label_maxmembers_amount.Text = lhRes[0]["size"].ToString();
            }
            else
                button_remove.Enabled = false;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Check data
            string sDate = Utils.sGetMysqlDate(txt_startdate.Text);
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
            }else if(Utils.bValidateTime(txt_starttime.Text) == false || Utils.bValidateTime(txt_starttime.Text) == false)
            {
                MessageBox.Show("Check the time format!");
                return;
            }
            
            // Check if we found the user
            if (this.ciClassInstance.bCheckOverlap(sDate, sIdRoom, sIdStaff, txt_starttime.Text, txt_endtime.Text))
                MessageBox.Show("The class is overlapping with another class, please specify another date, room or instructor.");
            else
            {
                this.ciClassInstance.Id_staff = int.Parse(sIdStaff);
                this.ciClassInstance.RRoom = new Room(int.Parse(sIdRoom));
                this.ciClassInstance.SClass = new Class(int.Parse(sIdClass));
                this.ciClassInstance.SDateStart = sDate;
                this.ciClassInstance.SEndTime = txt_endtime.Text;
                this.ciClassInstance.SFrequency = cmb_repeats.Text;
                this.ciClassInstance.SStartTime = txt_starttime.Text;
                if (this.ciClassInstance.bSave())
                {
                    button_enrollmembers.Enabled = true;
                }
            }

            // Check Equipment availability

        }

        private void button_enrollmembers_Click(object sender, EventArgs e)
        {
            frm_member_list frmMemberList = new frm_member_list(ciClassInstance,false);
            frmMemberList.Show();
        }

        private void button_viewattendants_Click(object sender, EventArgs e)
        {
            frm_member_list frmMemberList = new frm_member_list(ciClassInstance, true);
            frmMemberList.Show();
        }

        private void cmb_rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            DictionaryEntry de = (DictionaryEntry)cmb_rooms.SelectedItem;
            string sIdRoom = de.Key.ToString();
            string sQuery = "SELECT size FROM gym.rooms WHERE id_room = '" + sIdRoom + "'";
            List<Hashtable> lhRes = conn.lhSqlQuery(sQuery);
            label_maxmembers_amount.Text = lhRes[0]["size"].ToString();
        }

        private void button_remove_Click(object sender, EventArgs e)        {
            DialogResult res = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (this.ciClassInstance.bRemove() == false)
                {
                    MessageBox.Show("Please make sure that there aren't any class instances for this class.");
                }
                frmClArrList.vLoadDgClassList();
                this.Close();
            }
        }




    }
}
