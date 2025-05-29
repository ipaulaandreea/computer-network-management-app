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
            Load += Form2_Load;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RefreshDreptList();
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

        public class NumeExistentException : Exception
        {
            public NumeExistentException(string entitate, string nume)
                : base($"{entitate} cu numele '{nume}' există deja.") { }
        }

        public class DreptInFolosintaException : Exception
        {
            public DreptInFolosintaException(string numeDrept)
                : base($"Dreptul '{numeDrept}' este asociat cu unul sau mai multe grupuri și nu poate fi șters.") { }
        }

        public class GrupInFolosintaException : Exception
        {
            public GrupInFolosintaException(string numeGrup)
                : base($"Grupul '{numeGrup}' este asociat cu unul sau mai mulți utilizatori și nu poate fi șters.") { }
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
            try
            {
                if (!ValidateChildren()) return;

                string nume = tbNume.Text.Trim();

                if (utilizatori.Any(u => u.Nume.Equals(nume, StringComparison.OrdinalIgnoreCase)))
                    throw new NumeExistentException("Utilizator", nume);

                if (string.IsNullOrWhiteSpace(nume)) return;

                if (clbGrupuri.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Selectați cel puțin un grup pentru utilizator.");
                    return;
                }

                var user = new Utilizator(utilizatori.Count + 1, nume);

                foreach (var grupNume in clbGrupuri.CheckedItems)
                {
                    var grup = grupuri.FirstOrDefault(g => g.Nume == grupNume.ToString());
                    if (grup != null)
                    {
                        user.AdaugaGrup(grup);
                    }
                }

                utilizatori.Add(user);
                RefreshUsersListView();

                tbNume.Clear();

                // Resetare selecții grupuri
                for (int i = 0; i < clbGrupuri.Items.Count; i++)
                    clbGrupuri.SetItemChecked(i, false);
                clbGrupuri.ClearSelected();
            }
            catch (NumeExistentException ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

            if (clbDrepturi.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selectați cel puțin un drept pentru grup.");
                return;
            }

            var grup = new Grup(grupuri.Count + 1, numeGrup);

            foreach (var dreptNume in clbDrepturi.CheckedItems)
            {
                var drept = drepturi.FirstOrDefault(d => d.Nume == dreptNume.ToString());
                if (drept == null)
                {
                    drept = new Drept(drepturi.Count + 1, dreptNume.ToString());
                    drepturi.Add(drept);
                }

                grup.AdaugaDrept(drept);
            }

            grupuri.Add(grup);
            RefreshGrupuriListView();
            RefreshGrupListBox();
            tbNumeGrup.Clear();

            for (int i = 0; i < clbDrepturi.Items.Count; i++)
            {
                clbDrepturi.SetItemChecked(i, false);
            }

            clbDrepturi.ClearSelected();

        }

        private void btnAddDrept_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = textBox1.Text.Trim();
                if (string.IsNullOrWhiteSpace(nume))
                    throw new ArgumentException("Numele dreptului nu poate fi gol.");

                if (drepturi.Any(d => d.Nume.Equals(nume, StringComparison.OrdinalIgnoreCase)))
                    throw new NumeExistentException("Drept", nume);

                var drept = new Drept(drepturi.Count + 1, nume);
                drepturi.Add(drept);
                RefreshDreptList();
                textBox1.Clear();

            }
            catch (ArgumentException ex)
            {
                errorNumeDrept.SetError(textBox1, ex.Message);
            }
            catch (NumeExistentException ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

            private void RefreshDreptList()
        {
            listView1.Items.Clear();
            foreach (var drept in drepturi)
            {
                var item = new ListViewItem(drept.Nume);
                listView1.Items.Add(item);
            }


            if (clbDrepturi != null)
            {
                clbDrepturi.Items.Clear();
                foreach (var d in drepturi)
                {
                    clbDrepturi.Items.Add(d.Nume);
                }
            }
        }

        private void RefreshGrupListBox()
        {
            clbGrupuri.Items.Clear();

            foreach (var grup in grupuri)
            {
                clbGrupuri.Items.Add(grup.Nume);
            }
        }

        private void btnDeleteDrept_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0) return;

                var item = listView1.SelectedItems[0];
                var numeDrept = item.Text;

                var result = MessageBox.Show($"Ești sigur că vrei să ștergi dreptul '{numeDrept}'?", "Confirmare ștergere", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var drept = drepturi.FirstOrDefault(d => d.Nume == numeDrept);
                    if (drept == null) return;


                    if (grupuri.Any(g => g.Drepturi.Contains(drept)))
                        throw new DreptInFolosintaException(numeDrept);
                    if (drept != null)
                    {
                        drepturi.Remove(drept);
                        RefreshDreptList();
                    }
                }
            }
            catch (DreptInFolosintaException ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditDrept_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var item = listView1.SelectedItems[0];
            var numeVechi = item.Text;

            var drept = drepturi.FirstOrDefault(d => d.Nume == numeVechi);
            if (drept == null) return;

            var formEdit = new EditDreptForm(numeVechi);
            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                drept.Nume = formEdit.NumeDrept;
                RefreshDreptList();
            }
        }

        private void lbDrepturiGrup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStergeGrup_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvGrupuri.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selectați un grup pentru a-l șterge.");
                    return;
                }

                var item = lvGrupuri.SelectedItems[0];
                var numeGrup = item.Text;

                var confirmare = MessageBox.Show($"Ești sigur că vrei să ștergi grupul '{numeGrup}'?", "Confirmare ștergere", MessageBoxButtons.YesNo);
                if (confirmare == DialogResult.Yes)
                {
                    var grup = grupuri.FirstOrDefault(g => g.Nume == numeGrup);
                    if (grup == null) return;

                    if (utilizatori.Any(u => u.Grupuri.Contains(grup)))
                        throw new GrupInFolosintaException(numeGrup);
                    if (grup != null)
                    {
                        foreach (var user in utilizatori)
                        {
                            user.Grupuri.Remove(grup);
                        }

                        grupuri.Remove(grup);
                        RefreshGrupuriListView();
                        RefreshGrupListBox();
                        RefreshUsersListView();
                    }
                }
            }
            catch (GrupInFolosintaException ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificaGrup_Click(object sender, EventArgs e)
        {
            if (lvGrupuri.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectați un grup pentru a-l modifica.");
                return;
            }

            var item = lvGrupuri.SelectedItems[0];
            var numeGrup = item.Text;

            var grup = grupuri.FirstOrDefault(g => g.Nume == numeGrup);
            if (grup == null) return;

            var formEdit = new EditGrupForm(grup.Nume, drepturi, grup.Drepturi);
            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                grup.Nume = formEdit.NumeGrup;

                grup.Drepturi.Clear();

                foreach (var dreptNume in formEdit.DrepturiSelectate)
                {
                    var drept = drepturi.FirstOrDefault(d => d.Nume == dreptNume);
                    if (drept != null)
                        grup.AdaugaDrept(drept);
                }

                RefreshGrupuriListView();
                RefreshGrupListBox();
                RefreshUsersListView();
            }
        }

        private void clbDrepturi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (lvUtilizatori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectați un utilizator.");
                return;
            }

            var item = lvUtilizatori.SelectedItems[0];
            var numeUtilizator = item.Text;

            var user = utilizatori.FirstOrDefault(u => u.Nume == numeUtilizator);
            if (user == null) return;

            var formEdit = new EditUserForm(user.Nume, grupuri, user.Grupuri);
            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                user.Nume = formEdit.NumeUtilizator;
                user.Grupuri.Clear();

                foreach (var grupNume in formEdit.GrupuriSelectate)
                {
                    var grup = grupuri.FirstOrDefault(g => g.Nume == grupNume);
                    if (grup != null) user.AdaugaGrup(grup);
                }

                RefreshUsersListView();
            }
        }


        private void RefreshUtilizatoriList()
        {
            listView1.Items.Clear();

            foreach (var utilizator in utilizatori)
            {
                var item = new ListViewItem(utilizator.Nume);
                listView1.Items.Add(item);
            }

            if (clbGrupuri != null)
            {
                clbGrupuri.Items.Clear();
                foreach (var g in grupuri)
                {
                    clbGrupuri.Items.Add(g.Nume);
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (lvUtilizatori.SelectedItems.Count == 0) return;

            var item = lvUtilizatori.SelectedItems[0];
            var numeUtilizator = item.Text;

            var result = MessageBox.Show($"Ești sigur că vrei să ștergi utilizatorul '{numeUtilizator}'?", "Confirmare ștergere", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var utilizator = utilizatori.FirstOrDefault(u => u.Nume == numeUtilizator);
                if (utilizator != null)
                {
                    utilizatori.Remove(utilizator);
                    RefreshUsersListView();
                }
            }
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNume.Text))
            {
                errorNumeUtilizator.SetError(tbNume, "Numele utilizatorului nu poate fi gol.");
            }
            else
            {
                errorNumeUtilizator.SetError(tbNume, "");
            }
        }

        private void tbNumeGrup_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNumeGrup.Text))
            {
                errorNumeGrup.SetError(tbNumeGrup, "Numele grupului nu poate fi gol.");
            }
            else
            {
                errorNumeGrup.SetError(tbNumeGrup, "");
            }
        }
    }
}
