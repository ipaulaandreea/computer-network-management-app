using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NetworkManagementApp.Model;

namespace NetworkManagementApp
{
    public partial class MainForm : Form
    {
        private List<Utilizator> utilizatori = new();
        private List<Grup> grupuri = new();
        private List<Drept> drepturi = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbGroup.Items.AddRange(new string[] { "Admin", "User", "Guest" });
            cbRole.Items.AddRange(new string[] { "Read", "Write", "Execute" });
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var nume = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(nume) || cbGroup.SelectedItem == null || cbRole.SelectedItem == null)
            {
                MessageBox.Show("Completează toate câmpurile.");
                return;
            }

            var grupNume = cbGroup.SelectedItem.ToString();
            var rolNume = cbRole.SelectedItem.ToString();

            var grup = grupuri.FirstOrDefault(g => g.Nume == grupNume);
            if (grup == null)
            {
                grup = new Grup { Id = grupuri.Count + 1, Nume = grupNume };
                grupuri.Add(grup);
            }

            var drept = drepturi.FirstOrDefault(d => d.Nume == rolNume);
            if (drept == null)
            {
                drept = new Drept { Id = drepturi.Count + 1, Nume = rolNume };
                drepturi.Add(drept);
            }

            grup.AdaugaDrept(drept);

            var user = new Utilizator { Id = utilizatori.Count + 1, Nume = nume };
            user.AdaugaGrup(grup);
            utilizatori.Add(user);

            var item = new ListViewItem(new string[]
            {
                user.Nume ?? "",
                string.Join(", ", user.Grupuri.Select(g => g.Nume)),
                string.Join(", ", user.GetDrepturi().Select(d => d.Nume))
            });
            lvUsers.Items.Add(item);

            txtUsername.Clear();
            cbGroup.SelectedIndex = -1;
            cbRole.SelectedIndex = -1;
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            var nume = txtGroup.Text.Trim();
            if (string.IsNullOrEmpty(nume)) return;
            if (!grupuri.Any(g => g.Nume == nume))
            {
                var grup = new Grup { Id = grupuri.Count + 1, Nume = nume };
                grupuri.Add(grup);
                lbGroups.Items.Add(nume);
                cbGroup.Items.Add(nume);
            }
            txtGroup.Clear();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            var nume = txtRole.Text.Trim();
            if (string.IsNullOrEmpty(nume)) return;
            if (!drepturi.Any(d => d.Nume == nume))
            {
                var drept = new Drept { Id = drepturi.Count + 1, Nume = nume };
                drepturi.Add(drept);
                lbRoles.Items.Add(nume);
                cbRole.Items.Add(nume);
            }
            txtRole.Clear();
        }
    }
}
