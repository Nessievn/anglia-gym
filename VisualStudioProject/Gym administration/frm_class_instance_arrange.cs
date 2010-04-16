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
        ClassInstance clClassInstance;
        frm_class_instance_list frmClassInstanceList;
        EquipmentBooked clEquipmentBooked;

        public frm_class_instance_arrange()
        {
            InitializeComponent();
            clClassInstance = new ClassInstance();
            button_enrollmembers.Enabled = false;
        }

        public frm_class_instance_arrange(int id_class_booked, frm_class_instance_list frmClInstList)
        {
            InitializeComponent();
            this.frmClassInstanceList = frmClInstList;
            clClassInstance = new ClassInstance(id_class_booked);
            if (clClassInstance.Id_class_instance == -1)
                MessageBox.Show("The class instance could not be found");
            else
            {
                vLoadBookedList();
                txt_endtime.Text = clClassInstance.EndTime;
                txt_startdate.Text = clClassInstance.DateStart;
                txt_starttime.Text = clClassInstance.StartTime;
                button_enrollmembers.Enabled = true;
            }
        }


        private void dg_currentborrows_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string sEquipmentName = dg_currentborrows.Rows[e.RowIndex].Cells[1].Value.ToString();
            int iBorrowedAmount = int.Parse(dg_currentborrows.Rows[e.RowIndex].Cells[2].Value.ToString());
            int id_equipment = int.Parse(dg_currentborrows.Rows[e.RowIndex].Cells[3].Value.ToString());
            int id_eq_booking = int.Parse(dg_currentborrows.Rows[e.RowIndex].Cells[4].Value.ToString());

            frm_message_box myMessageBox = new frm_message_box();
            string result = myMessageBox.ShowBox(Utils.MB_CUST4, "", "How many " + sEquipmentName + " would you like to return?", iBorrowedAmount.ToString());


            //ref  http://social.msdn.microsoft.com/Forums/en-US/winforms/thread/84990ad2-5046-472b-b103-f862bfcd5dbc


            double Num;
            bool isNum = double.TryParse(result, out Num);
            if (isNum)
            {

                if ((int.Parse(result) > 0) && (result != "Cancel"))
                {
                    this.clEquipmentBooked = new EquipmentBooked(id_eq_booking);
                    this.clEquipmentBooked.BorrowedAmount = int.Parse(result);
                    this.clEquipmentBooked.IsReturned = false;
                    this.clEquipmentBooked.SaveEquipmentBooking();
                }
                else
                {
                    this.clEquipmentBooked = new EquipmentBooked(id_eq_booking);
                    this.clEquipmentBooked.BorrowedAmount = 0;
                    this.clEquipmentBooked.IsReturned = true;
                    this.clEquipmentBooked.SaveEquipmentBooking();

                }
                this.vLoadBookedList();
            }

        }


        public void vLoadBookedList()
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource itemsSource = new BindingSource();
            string query = "SELECT DISTINCT eb.date_due Due, e.name Name, eb.borrowedamount Amount, eb.id_equipment EqID, eb.id_eq_booking BkID FROM equipment e, equipment_bookings eb WHERE eb.id_class_instance = " + clClassInstance.Id_class_instance + " AND (eb.isreturned = 0 OR eb.isreturned is NULL) AND eb.id_equipment = e.id_equipment ORDER BY Due";
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            dg_currentborrows.DataSource = itemsSource;
            dg_currentborrows.AllowUserToAddRows = false;
            dg_currentborrows.ReadOnly = true;
        }


        private void frm_class_instance_arrange_Load(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            
            // Loading Available Classes
            string query = "SELECT id_class, name FROM classes ORDER BY id_class";
            ArrayList myItems = conn.alGetComboFromDb(query, "id_class","name");
            cmb_classes.DisplayMember = "Value";
            cmb_classes.DataSource = myItems;

            // Loading Available Rooms
            query = "SELECT id_room, name FROM rooms ORDER BY id_room";
            myItems = conn.alGetComboFromDb(query, "id_room", "name");
            cmb_rooms.DisplayMember = "Value";
            cmb_rooms.DataSource = myItems;

            // Loading Available Instructor
            //TODO: Inform Katie about the Position -> Instructor field
            query = "SELECT id_staff, CONCAT(lastName,', ', firstName) name FROM staff WHERE position = 'Instructor' ORDER BY id_staff";
            myItems = conn.alGetComboFromDb(query, "id_staff", "name");
            cmb_instructors.DisplayMember = "Value";
            cmb_instructors.DataSource = myItems;

       
            
            // HERE we select the options with the class instance
            if (this.clClassInstance.Id_class_instance != -1)
            {
                cmb_classes.SelectedIndex = cmb_classes.FindString(clClassInstance.ClClass.Name);
                //cmb_instructors.SelectedIndex = cmb_instructors.FindString(clClassInstance.Name+' ');
                cmb_rooms.SelectedIndex = cmb_rooms.FindString(clClassInstance.ClRoom.Name);
                cmb_repeats.SelectedIndex = cmb_repeats.FindString(clClassInstance.Frequency);
                query = "SELECT COUNT(*) q FROM gym.class_bookings WHERE id_class_instance = '" + this.clClassInstance.Id_class_instance + "'";
                List<Hashtable> lhRes = conn.lhSqlQuery(query);
                lbl_currentmembers_amount.Text = lhRes[0]["q"].ToString();
                query = "SELECT r.size FROM gym.class_instance ci, gym.rooms r WHERE ci.id_room = r.id_room AND ci.id_class_instance = '" + this.clClassInstance.Id_class_instance + "'";
                lhRes = conn.lhSqlQuery(query);
                label_maxmembers_amount.Text = lhRes[0]["size"].ToString();
            }
            else
            {
                button_remove.Enabled = false;
                btn_equipment.Enabled = false;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Check data
            string sDate = Utils.sGetMysqlDate(txt_startdate.Text);
            DictionaryEntry de = (DictionaryEntry)cmb_classes.SelectedItem;
            string id_class = de.Key.ToString();

            de = (DictionaryEntry)cmb_instructors.SelectedItem;
            string id_staff = de.Key.ToString();

        
            de = (DictionaryEntry)cmb_rooms.SelectedItem;
            string id_room = de.Key.ToString();

            if(sDate == "0000-00-00")
            {
                MessageBox.Show("Check the date format!");
                return;
            }else if(Utils.bValidateTime(txt_starttime.Text) == false || Utils.bValidateTime(txt_starttime.Text) == false)
            {
                MessageBox.Show("Check the time format!");
                return;
            }
            else if (cmb_classes.Text == "" || cmb_instructors.Text == "" || cmb_rooms.Text == "")
            {
                MessageBox.Show("Missing information to arrange your class. Please check input data.");
                return;
            }

            
            // Check if we found the user
            if (this.clClassInstance.bCheckOverlap(sDate, id_room, id_staff, txt_starttime.Text, txt_endtime.Text))
                MessageBox.Show("The class is overlapping with another class, please specify another date, room or instructor.");
            else
            {
                this.clClassInstance.Id_staff = int.Parse(id_staff);
                this.clClassInstance.ClRoom = new Room(int.Parse(id_room));
                this.clClassInstance.ClClass = new Class(int.Parse(id_class));
                this.clClassInstance.DateStart = sDate;
                this.clClassInstance.EndTime = txt_endtime.Text;
                this.clClassInstance.Frequency = cmb_repeats.Text;
                this.clClassInstance.StartTime = txt_starttime.Text;
                if (this.clClassInstance.SaveClassInstance())
                {
                    button_enrollmembers.Enabled = true;
                    button_remove.Enabled = true;
                    btn_equipment.Enabled = true;
                }
            }

            // Check Equipment availability

        }

        private void button_enrollmembers_Click(object sender, EventArgs e)
        {
            frm_member_list frmMemberList = new frm_member_list(clClassInstance,false);
            frmMemberList.ShowDialog();
        }

        private void button_viewattendants_Click(object sender, EventArgs e)
        {
            frm_member_list frmMemberList = new frm_member_list(clClassInstance, true);
            frmMemberList.ShowDialog();
        }

        private void cmb_rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            DictionaryEntry de = (DictionaryEntry)cmb_rooms.SelectedItem;
            string id_room = de.Key.ToString();
            string query = "SELECT size FROM gym.rooms WHERE id_room = '" + id_room + "'";
            List<Hashtable> lhRes = conn.lhSqlQuery(query);
            label_maxmembers_amount.Text = lhRes[0]["size"].ToString();
        }

        private void button_remove_Click(object sender, EventArgs e)   
        {
            if (dg_currentborrows.RowCount > 0)
                MessageBox.Show("You can't remove this class as the borrowed equipments has to be returned first!");
            else
            {

                DialogResult res = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (this.clClassInstance.RemoveClassInstance() == false)
                    {
                        MessageBox.Show("Please make sure that there aren't any class instances for this class.");
                    }
                    frmClassInstanceList.vLoadDgClassList();
                    this.Close();
                }
            }
        }

        private void btn_equipment_Click(object sender, EventArgs e)
        {

            // Creating the child form login
            frm_equipment_list frmEquipmentList = new frm_equipment_list(this.clClassInstance.Id_class_instance, this);

            if (Utils.bIsAlreadyOpened(frmEquipmentList)) return;
            frmEquipmentList.ShowDialog();  

        }




    }
}
