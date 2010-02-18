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
    public partial class frm_main : Form
    {
        private int childFormNumber = 0;
        private OutlookBar outlookBar;

        public frm_main()
        {
            InitializeComponent();

            // OUTLOOK BAR!!
            this.outlookBar = new OutlookBar();
            outlookBar.Location = new Point(0, 50);
            //outlookBar.Size = new Size(150, 100);
            outlookBar.Height = 10;
            outlookBar.Width = 150;
            outlookBar.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(outlookBar);
            outlookBar.Initialize();
            outlookBar.Hide();
        }

        public void PanelEvent(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            PanelIcon panelIcon = ctrl.Tag as PanelIcon;
            MessageBox.Show("#" + panelIcon.Index.ToString(), "Panel Event");
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

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

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

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

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

        private void frm_main_Load(object sender, EventArgs e)
        {   
            // Creating the child form login
            frm_login mdiFrmLogin = new frm_login(this);
            // Set the Parent Form of the Child window.
            mdiFrmLogin.MdiParent = this;
            // Display the new form.
            mdiFrmLogin.Show();     
            
        }

        // Loads form options depending on the user profile
        public void ShowUserOptions(string userProfile)
        {
            switch (userProfile)
            {
                case "manager":

                    IconPanel iconPanel1 = new IconPanel();
                    IconPanel iconPanel2 = new IconPanel();
                    IconPanel iconPanel3 = new IconPanel();
                    this.outlookBar.AddBand("Outlook Shortcuts", iconPanel1);
                    this.outlookBar.AddBand("My Shortcuts", iconPanel2);
                    this.outlookBar.AddBand("Other Shortcuts", iconPanel3);
                    MessageBox.Show(Directory.GetCurrentDirectory());
                    iconPanel1.AddIcon("Outlook Today", Image.FromFile("icons/1.ico"), new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Calendar", Image.FromFile("icons/2.ico"), new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Contacts", Image.FromFile("icons/3.ico"), new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Tasks", Image.FromFile("icons/4.ico"), new EventHandler(PanelEvent));
                    this.outlookBar.SelectBand(0);
                    outlookBar.Show();

                    break;
            }
        }
    }
}
