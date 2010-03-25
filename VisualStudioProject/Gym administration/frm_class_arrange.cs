﻿using System;
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
        ClassBooked clbClassBooked;

        public frm_class_arrange()
        {
            InitializeComponent();
            clbClassBooked = new ClassBooked();
            btn_attendants.Enabled = false;
        }
        public frm_class_arrange(int iIdClassBooked)
        {
            InitializeComponent();

            clbClassBooked = new ClassBooked(iIdClassBooked);
            if (clbClassBooked.Id_class_instance == -1)
                MessageBox.Show("The class instance could not be found");
            else
            {
                txt_end_time.Text = clbClassBooked.SEndTime;
                txt_start.Text = clbClassBooked.SDateStart;
                txt_start_time.Text = clbClassBooked.SStartTime;
                btn_attendants.Enabled = true;
            }
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
            
            // HERE we select the options with the class instance
            if (this.clbClassBooked.Id_class_instance != -1)
            {
                cmb_classes.SelectedIndex = cmb_classes.FindString(clbClassBooked.SClass.SName);
                //cmb_instructors.SelectedIndex = cmb_instructors.FindString(clbClassBooked..SName+' ');
                cmb_rooms.SelectedIndex = cmb_rooms.FindString(clbClassBooked.RRoom.SName);
                cmb_repeats.SelectedIndex = cmb_repeats.FindString(clbClassBooked.SFrequency);

            }
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
                {
                    MessageBox.Show("The class instance has been created!");
                    this.clbClassBooked = cbClassBooked;
                    btn_attendants.Enabled = true;
                }
            }

            // Check Equipment availability

        }

        private void btn_attendants_Click(object sender, EventArgs e)
        {
            frm_member_list frmMemberList = new frm_member_list(clbClassBooked);
            frmMemberList.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


    }
}