using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkManagementApp.Model;


namespace NetworkManagementApp
{
    public partial class Form2 : Form
    {
        List<Utilizator> utilizatori = new();
        List<Grup> grupuri = new();
        List<Drept> drepturi = new();

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lvUtilizatori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabGrupuri_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshUsersListView()
        {
            lvUtilizatori.Items.Clear();
            foreach (var user in utilizatori)
            {
                var grupuriStr = string.Join(", ", user.Grupuri.Select(g => g.Nume));
                var drepturiStr = string.Join(", ", user.GetDrepturi().Select(d => d.Nume));

                var item = new ListViewItem(user.Nume);
                item.SubItems.Add(grupuriStr);
                item.SubItems.Add(drepturiStr);
                lvUtilizatori.Items.Add(item);
            }
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string nume = tbNume.Text.Trim();
            if (string.IsNullOrWhiteSpace(nume)) return;

            var grup = lbGrup.SelectedItem?.ToString();
            var drept = lbDrepturi.SelectedItem?.ToString();

            var g = grupuri.FirstOrDefault(x => x.Nume == grup) ?? new Grup(grupuri.Count + 1, grup);
            if (!grupuri.Contains(g)) grupuri.Add(g);

            var d = drepturi.FirstOrDefault(x => x.Nume == drept) ?? new Drept(drepturi.Count + 1, drept);
            if (!drepturi.Contains(d)) drepturi.Add(d);

            if (!g.Drepturi.Contains(d)) g.AdaugaDrept(d);

            var user = new Utilizator(utilizatori.Count + 1, nume);
            user.AdaugaGrup(g);
            utilizatori.Add(user);

            RefreshUsersListView();
        }

        private void RefreshGrupuriListView()
        {
            lvGrupuri.Items.Clear();

            foreach (var grup in grupuri)
            {
                string drepturiStr = string.Join(", ", grup.Drepturi.Select(d => d.Nume));

                var item = new ListViewItem(grup.Nume);
                item.SubItems.Add(drepturiStr);
                lvGrupuri.Items.Add(item);
            }
        }

        private void btnAdaugaGrup_Click(object sender, EventArgs e)
        {
            string numeGrup = tbNumeGrup.Text.Trim();
            if (string.IsNullOrWhiteSpace(numeGrup))
            {
                MessageBox.Show("Introduceți un nume pentru grup.");
                return;
            }

            string dreptSelectat = lbDrepturiGrup.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(dreptSelectat))
            {
                MessageBox.Show("Selectați un drept pentru grup.");
                return;
            }

            var drept = drepturi.FirstOrDefault(d => d.Nume == dreptSelectat);
            if (drept == null)
            {
                drept = new Drept(drepturi.Count + 1, dreptSelectat);
                drepturi.Add(drept);
            }

            var grup = new Grup(grupuri.Count + 1, numeGrup);
            grup.AdaugaDrept(drept);
            grupuri.Add(grup);

            RefreshGrupuriListView();
            RefreshGrupListBox(); 
            tbNumeGrup.Clear();
        }

        private void btnAddDrept_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(nume)) return;

            var drept = new Drept(drepturi.Count + 1, nume);
            drepturi.Add(drept);
            RefreshDreptList();
        }

        private void RefreshDreptList()
        {
            listView1.Items.Clear();
            foreach (var drept in drepturi)
            {
                var item = new ListViewItem(drept.Nume);
                listView1.Items.Add(item);
            }

            lbDrepturi.Items.Clear();
            lbDrepturiGrup.Items.Clear();
            foreach (var d in drepturi)
            {
                lbDrepturi.Items.Add(d.Nume);
                lbDrepturiGrup.Items.Add(d.Nume);
            }
        }

        private void RefreshGrupListBox()
        {
            lbGrup.Items.Clear();
            foreach (var grup in grupuri)
            {
                lbGrup.Items.Add(grup.Nume);
            }
        }


    }


}
