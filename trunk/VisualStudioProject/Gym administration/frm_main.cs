using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OutlookBarNm;

namespace Gym_administration
{

    /**
     * @desc Form Handler for main menu. 
     * This is for initiate user login, displaying outlook bar, 
     * and executing the main menu options available based on the user profile
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */  
    public partial class frm_main : Form
    {
        private int childFormNumber = 0;
        private OutlookBar outlookBar;
        private User userLogged;

        internal User UserLogged
        {
            get { return userLogged; }
            set { userLogged = value; }
        }

        /** 
         * @desc Default constructor for creating main menu.
         * This is for setting up display for main menu
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */ 
        public frm_main()
        {
            InitializeComponent();

            // OUTLOOK BAR!!
            this.outlookBar = new OutlookBar();
            outlookBar.Location = new Point(0, 50);
            outlookBar.Height = 10;
            outlookBar.Width = 170;
            outlookBar.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(outlookBar);
            outlookBar.Initialize();
            outlookBar.Hide();
            
        }

        /** 
          * @desc Executes at panel events
	      * It watches the selectedBand and executes the "if" section that it currently belongs to
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        public void PanelEvent(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            PanelIcon panelIcon = ctrl.Tag as PanelIcon;
            string selectedBand = panelIcon.iconPanel.BandName;

            foreach (Form childForm in MdiChildren)
            childForm.Close();

/////////////////////////  MANAGER OPTIONS BAND   ////////////////////////
// Add Staff
            if (selectedBand == "manager" && panelIcon.Index.ToString() == "0")
            {
                frm_staff frmStaff = new frm_staff();
                frmStaff.ShowDialog();  
            }
// Edit Staff
            if (selectedBand == "manager" && panelIcon.Index.ToString() == "1")
            {
                frm_staff_list frmStaffList = new frm_staff_list();
                frmStaffList.ShowDialog();
            }
// Membership fees
            else if (selectedBand == "manager" && panelIcon.Index.ToString() == "2")
            {
                frm_payment_list frmPayments = new frm_payment_list();
                frmPayments.ShowDialog();  
            }
//Edit Arranged Class
            else if (selectedBand == "manager" && panelIcon.Index.ToString() == "3")
            {
                frm_class_instance_list frmClassArrangeList = new frm_class_instance_list();
                frmClassArrangeList.ShowDialog();
            }
// Add Class
            else if (selectedBand == "manager" && panelIcon.Index.ToString() == "4")
            {
                frm_class frmClass = new frm_class();
                frmClass.ShowDialog();
            }
// Edit Class
            else if (selectedBand == "manager" && panelIcon.Index.ToString() == "5")
            {
                frm_class_list frmClassList = new frm_class_list();
                frmClassList.ShowDialog();
            }
// Add New Equipment
            else if (selectedBand == "manager" && panelIcon.Index.ToString() == "6")
            {
                frm_equipment frmEquipment = new frm_equipment();
                frmEquipment.ShowDialog();
            }
// Edit Equipment
            else if (selectedBand == "manager" && panelIcon.Index.ToString() == "7")
            {
                frm_equipment_list frmEquipmentList = new frm_equipment_list();
                frmEquipmentList.ShowDialog();  
            }
// Edit Room
            else if (selectedBand == "manager" && panelIcon.Index.ToString() == "8")
            {
                frm_room_list frmRoomList = new frm_room_list();
                frmRoomList.ShowDialog();
            }
/////////////////////  STAFF OPTIONS BAND //////////////////////
// Add Member
            else if (selectedBand == "staff" && panelIcon.Index.ToString() == "0")
            {
                frm_member frmMember = new frm_member();
                frmMember.ShowDialog();  
            }
//Edit Member
            else if (selectedBand == "staff" && panelIcon.Index.ToString() == "1")
            {
                frm_member_list frmMemberList = new frm_member_list();
                frmMemberList.ShowDialog();  
            }
//Book Class
            else if (selectedBand == "staff" && panelIcon.Index.ToString() == "2")
            {
                frm_class_instance_arrange frmClassArrange = new frm_class_instance_arrange();
                frmClassArrange.ShowDialog();
            }
//Edit Arranged Class
            else if (selectedBand == "staff" && panelIcon.Index.ToString() == "3")
            {
                frm_class_instance_list frmClassArrangeList = new frm_class_instance_list();
                frmClassArrangeList.ShowDialog();  
            }
// Search Eq. Bookings
            else if (selectedBand == "staff" && panelIcon.Index.ToString() == "4")
            {
                frm_equipment_bookings_list frmEqBookingsList = new frm_equipment_bookings_list();
                frmEqBookingsList.ShowDialog();
            }
// Room Search
            else if (selectedBand == "staff" && panelIcon.Index.ToString() == "5")
            {
                frm_room_list frmRoomList = new frm_room_list();
                frmRoomList.ShowDialog();  
            }
/////////////////////////  LOGIN OPTIONS BAND  ///////////////////////
// Login Options
            else if (selectedBand == "all" && panelIcon.Index.ToString() == "0")
            {
                frm_login_options frmLoginOptions = new frm_login_options(this);
                frmLoginOptions.ShowDialog();
            }
// Log Out
            else if (selectedBand == "all" && panelIcon.Index.ToString() == "1")
            {
                Controls.Remove(this.outlookBar);
                frm_login frmLogin = new frm_login(this);
                frmLogin.ShowDialog();
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }


        // Placeholder - not doing anything meaningful currently
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        // Placeholder - not doing anything meaningful currently
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        // Placeholder - not doing anything meaningful currently
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        /** 
          * @desc This method loads in every time the frm_main is instantiated
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void frm_main_Load(object sender, EventArgs e)
        {   
            frm_login frmLogin = new frm_login(this);
            frmLogin.ShowDialog();     
        }

        /** 
          * @desc This method loads in the outlookbar icons, tags and eventhandlers.
          * This way it also sets up the profiles access rights.
          * @params [string] userProfile: the name of the currently used user profile
          * @return [none] No directly returned data. 
          */
        private void loadOutlookBarButtons(string userProfile)
        {
            switch (userProfile)
            {
                // Staff functions
                case "staff":
                    IconPanel iconPanel1 = new IconPanel("staff");
                    this.outlookBar.AddBand("Staff Functions", iconPanel1);
                    iconPanel1.AddIcon("Add New Member", global::Gym_administration.Properties.Resources.member_add_128, new EventHandler(PanelEvent));                    
                    iconPanel1.AddIcon("Edit Member", global::Gym_administration.Properties.Resources.member_edit_128, new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Arrange Class", global::Gym_administration.Properties.Resources.class_book_add_128, new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Edit Arranged Class", global::Gym_administration.Properties.Resources.class_book_edit_128, new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Edit Equip Bookings", global::Gym_administration.Properties.Resources.equipment_book_edit_128, new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Edit Room List", global::Gym_administration.Properties.Resources.room_edit_128, new EventHandler(PanelEvent));
                    this.outlookBar.SelectBand(0);
                    outlookBar.Show();
                    break;
                // Manager functions
                case "manager":
                    IconPanel iconPanel2 = new IconPanel("manager");
                    this.outlookBar.AddBand("Management Functions", iconPanel2);
                    iconPanel2.AddIcon("Add New Staff", global::Gym_administration.Properties.Resources.staff_add_128, new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Edit Staff", global::Gym_administration.Properties.Resources.staff_edit_128, new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Membership Fees", global::Gym_administration.Properties.Resources.payment_search_128, new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Edit Arranged Class", global::Gym_administration.Properties.Resources.class_book_edit_128, new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Add New Class", global::Gym_administration.Properties.Resources.class_add_128, new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Edit Class", global::Gym_administration.Properties.Resources.class_edit_128, new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Add New Equipment", global::Gym_administration.Properties.Resources.equipment_add_128, new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Edit Equipment", global::Gym_administration.Properties.Resources.equipment_edit_128, new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Edit Room List", global::Gym_administration.Properties.Resources.room_edit_128, new EventHandler(PanelEvent));
                    this.outlookBar.SelectBand(0);
                    outlookBar.Show();
                    break;
                // All users functions
                case "all":
                    IconPanel iconPanel3 = new IconPanel("all");
                    this.outlookBar.AddBand("Login Options", iconPanel3);
                    iconPanel3.AddIcon("Change Password", global::Gym_administration.Properties.Resources.password_edit_128, new EventHandler(PanelEvent));
                    this.outlookBar.SelectBand(0);
                    outlookBar.Show();
                    break;
            }
        }

        /** 
          * @desc This method loads in the outlookbar
          * @params [none] No input parameters.
          * @return [none] No directly returned data. 
          */
        public void vLoadOutlookBar()
        {
            // OUTLOOK BAR!!
            this.outlookBar = new OutlookBar();
            outlookBar.Location = new Point(0, 50);
            outlookBar.Height = 10;
            outlookBar.Width = 170;
            outlookBar.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(outlookBar);
            outlookBar.Initialize();
            outlookBar.Hide();
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
        }


        /** 
          * @desc This method displays the outlookbar buttons based on user profile
          * @params [string] userProfile: the name of the currently used user profile
          * @return [none] No directly returned data. 
          */
        public void ShowUserOptions(string userProfile)
        {
            switch (userProfile)
            {
                case "manager":
                    this.loadOutlookBarButtons("staff");
                    this.loadOutlookBarButtons("manager");
                    break;

                case "staff":

                    this.loadOutlookBarButtons("staff");
                    break;
            }
            this.loadOutlookBarButtons("all");
        }

// This method is never used for some reason
        /** 
          * @desc This method sets the current user
          * @params [User] user: the current user
          * @return [none] No directly returned data. 
          */
        private void SetUserLogged(User user)
        {
            this.userLogged = user;
        }

        // Close/Cancel
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

/////////////////   PLACEHOLDER EVENT HANDLERS   ////////////////////
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
    }
}


// if (Utils.bIsAlreadyOpened(mdiFrmEquipment)) return;
// Set the Parent Form of the Child window.
//mdiFrmEquipment.MdiParent = this;
//mdiFrmEquipment.Show();



/*
  *   mySqlConn conn = new mySqlConn();
      conn.connect();
  * {
                     iconPanel1.AddIcon("Add New Member", conn.loadImageFromDB("3"), new EventHandler(PanelEvent));
                     iconPanel1.AddIcon("Edit Member", conn.loadImageFromDB("4"), new EventHandler(PanelEvent));
                     iconPanel1.AddIcon("Arrange Class", conn.loadImageFromDB("5"), new EventHandler(PanelEvent));
                     iconPanel1.AddIcon("Edit Arranged Class", conn.loadImageFromDB("6"), new EventHandler(PanelEvent));
                     iconPanel1.AddIcon("Edit Equip Bookings", conn.loadImageFromDB("7"), new EventHandler(PanelEvent));
                     iconPanel1.AddIcon("Edit Room List", conn.loadImageFromDB("8"), new EventHandler(PanelEvent));
                     this.outlookBar.SelectBand(0);
                     outlookBar.Show();
                     break;
                 case "manager":
                     IconPanel iconPanel2 = new IconPanel("manager");
                     this.outlookBar.AddBand("Management Functions", iconPanel2);
                     iconPanel2.AddIcon("Add New Staff", conn.loadImageFromDB("9"), new EventHandler(PanelEvent));
                     iconPanel2.AddIcon("Edit Staff", conn.loadImageFromDB("10"), new EventHandler(PanelEvent));
                     iconPanel2.AddIcon("Membership Fees", conn.loadImageFromDB("11"), new EventHandler(PanelEvent));
                     iconPanel2.AddIcon("Edit Arranged Class", conn.loadImageFromDB("6"), new EventHandler(PanelEvent));
                     iconPanel2.AddIcon("Add New Class", conn.loadImageFromDB("12"), new EventHandler(PanelEvent));
                     iconPanel2.AddIcon("Edit Class", conn.loadImageFromDB("13"), new EventHandler(PanelEvent));
                     iconPanel2.AddIcon("Add New Equipment", conn.loadImageFromDB("14"), new EventHandler(PanelEvent));
                     iconPanel2.AddIcon("Edit Equipment", conn.loadImageFromDB("15"), new EventHandler(PanelEvent));
                     iconPanel2.AddIcon("Edit Room List", conn.loadImageFromDB("8"), new EventHandler(PanelEvent));
                     */