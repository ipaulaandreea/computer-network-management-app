using System;
using System.Drawing;
using System.Windows.Forms;

namespace NetworkManagementApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl;
        private TabPage tabUsers;
        private TabPage tabGroups;
        private TabPage tabRoles;

        private TextBox txtUsername;
        private ComboBox cbGroup;
        private ComboBox cbRole;
        private Button btnAddUser;
        private ListView lvUsers;

        private TextBox txtGroup;
        private Button btnAddGroup;
        private ListBox lbGroups;

        private TextBox txtRole;
        private Button btnAddRole;
        private ListBox lbRoles;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new TabControl();
            this.tabUsers = new TabPage("Utilizatori");
            this.tabGroups = new TabPage("Grupuri");
            this.tabRoles = new TabPage("Drepturi");

            this.txtUsername = new TextBox { Location = new Point(20, 20) };
            this.cbGroup = new ComboBox { Location = new Point(20, 60) };
            this.cbRole = new ComboBox { Location = new Point(20, 100) };
            this.btnAddUser = new Button { Location = new Point(20, 140), Text = "Adaugă Utilizator" };
            this.btnAddUser.Click += btnAddUser_Click;

            this.lvUsers = new ListView
            {
                Location = new Point(20, 180),
                Size = new Size(550, 200),
                View = View.Details
            };
            this.lvUsers.Columns.Add("Utilizator", 150);
            this.lvUsers.Columns.Add("Grupuri", 150);
            this.lvUsers.Columns.Add("Drepturi", 150);

            this.txtGroup = new TextBox { Location = new Point(20, 20) };
            this.btnAddGroup = new Button { Location = new Point(20, 60), Text = "Adaugă Grup" };
            this.btnAddGroup.Click += btnAddGroup_Click;
            this.lbGroups = new ListBox { Location = new Point(20, 100), Size = new Size(200, 200) };

            this.txtRole = new TextBox { Location = new Point(20, 20) };
            this.btnAddRole = new Button { Location = new Point(20, 60), Text = "Adaugă Drept" };
            this.btnAddRole.Click += btnAddRole_Click;
            this.lbRoles = new ListBox { Location = new Point(20, 100), Size = new Size(200, 200) };

            this.tabUsers.Controls.AddRange(new Control[] { txtUsername, cbGroup, cbRole, btnAddUser, lvUsers });
            this.tabGroups.Controls.AddRange(new Control[] { txtGroup, btnAddGroup, lbGroups });
            this.tabRoles.Controls.AddRange(new Control[] { txtRole, btnAddRole, lbRoles });

            this.tabControl.Dock = DockStyle.Fill;
            this.tabControl.TabPages.AddRange(new[] { tabUsers, tabGroups, tabRoles });

            this.Controls.Add(this.tabControl);
            this.Text = "Network Management App";
            this.ClientSize = new Size(800, 500);
            this.Load += MainForm_Load;
        }
    }
}