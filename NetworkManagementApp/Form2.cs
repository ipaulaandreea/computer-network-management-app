﻿using System.ComponentModel;
using System.Data;
using System.Xml.Serialization;
using NetworkManagementApp.Model;
using System.Data.SQLite;

namespace NetworkManagementApp
{
    public partial class Form2 : Form
    {
        List<Utilizator> utilizatori = new();
        List<Grup> grupuri = new();
        List<Drept> drepturi = new();
        private string ConnectionString = "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\DataSource\network-management-app.db");

        private string loggedUser = "guest";



        public Form2()
        {
            InitializeComponent();
            Load += Form2_Load;

        }

        private void LoadDrepturiFromDatabase()
        {
            drepturi.Clear();
            var query = "SELECT * FROM drepturi";

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = (long)reader["id"];
                            var nume = (string)reader["nume"];
                            drepturi.Add(new Drept((int)id, nume));
                        }
                    }
                }
            }
        }

        private void LoadGrupuriFromDatabase()
        {
            grupuri.Clear();

            string queryGrupuri = "SELECT id, nume FROM grupuri";
            string queryDrepturi = @"
        SELECT d.id, d.nume
        FROM grupuri_drepturi gd
        JOIN drepturi d ON d.id = gd.drept_id
        WHERE gd.grup_id = @GrupId";

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (var cmdGrupuri = new SQLiteCommand(queryGrupuri, connection))
                using (var readerGrupuri = cmdGrupuri.ExecuteReader())
                {
                    while (readerGrupuri.Read())
                    {
                        int grupId = Convert.ToInt32(readerGrupuri["id"]);
                        string numeGrup = readerGrupuri["nume"].ToString();

                        var grup = new Grup(grupId, numeGrup);

                        using (var cmdDrepturi = new SQLiteCommand(queryDrepturi, connection))
                        {
                            cmdDrepturi.Parameters.AddWithValue("@GrupId", grupId);

                            using (var readerDrepturi = cmdDrepturi.ExecuteReader())
                            {
                                while (readerDrepturi.Read())
                                {
                                    int dreptId = Convert.ToInt32(readerDrepturi["id"]);
                                    string dreptNume = readerDrepturi["nume"].ToString();
                                    grup.AdaugaDrept(new Drept(dreptId, dreptNume));
                                }
                            }
                        }

                        grupuri.Add(grup);
                    }
                }
            }

            RefreshGrupuriListView();
            RefreshGrupListBox();
        }

        private void LoadUtilizatoriFromDatabase()
        {
            utilizatori.Clear();

            string queryUtilizatori = "SELECT id, nume FROM utilizatori";
            string queryGrupuri = @"
        SELECT g.id, g.nume
        FROM utilizatori_grupuri ug
        JOIN grupuri g ON g.id = ug.grup_id
        WHERE ug.utilizator_id = @UserId";

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (var cmdUtilizatori = new SQLiteCommand(queryUtilizatori, connection))
                using (var readerUtilizatori = cmdUtilizatori.ExecuteReader())
                {
                    while (readerUtilizatori.Read())
                    {
                        int userId = Convert.ToInt32(readerUtilizatori["id"]);
                        string nume = readerUtilizatori["nume"].ToString();

                        var user = new Utilizator(userId, nume);

                        using (var cmdGrupuri = new SQLiteCommand(queryGrupuri, connection))
                        {
                            cmdGrupuri.Parameters.AddWithValue("@UserId", userId);

                            using (var readerGrupuri = cmdGrupuri.ExecuteReader())
                            {
                                while (readerGrupuri.Read())
                                {
                                    int grupId = Convert.ToInt32(readerGrupuri["id"]);
                                    string grupNume = readerGrupuri["nume"].ToString();

                                    var grup = grupuri.FirstOrDefault(g => g.Id == grupId);
                                    if (grup != null)
                                    {
                                        user.AdaugaGrup(grup);
                                    }
                                }
                            }
                        }

                        utilizatori.Add(user);
                    }
                }
            }

            RefreshUsersListView();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            auth1.LoginRequested += LoginControl1_LoginRequested;

            LoadDrepturiFromDatabase();
            LoadGrupuriFromDatabase();
            LoadUtilizatoriFromDatabase();

            RefreshGrupListBox();
            RefreshGrupuriListView();
            RefreshUsersListView();
            RefreshDreptList();
        }

        private void LoginControl1_LoginRequested(object sender, (string Username, string Password) e)
        {
            string username = e.Username.Trim();
            string password = e.Password.Trim();

            if (username == "admin" && password == "1234")
            {
                loggedUser = "admin";
                statusUser.Text = $"Logged user: {loggedUser}";
                MessageBox.Show("Autentificare reușită!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                loggedUser = "guest";
                statusUser.Text = $"Logged user: {loggedUser}";
                MessageBox.Show("Utilizator sau parolă greșită.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
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
                var drepturiStr = string.Join(", ", user.GetDrepturi()
                    .Select(d => d.Nume)
                    .Distinct());
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

                if (string.IsNullOrWhiteSpace(nume)) return;

                if (utilizatori.Any(u => u.Nume.Equals(nume, StringComparison.OrdinalIgnoreCase)))
                    throw new NumeExistentException("Utilizator", nume);

                if (clbGrupuri.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Selectați cel puțin un grup pentru utilizator.");
                    return;
                }

                long utilizatorId;

                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        var cmdInsertUser = new SQLiteCommand("INSERT INTO utilizatori (nume) VALUES (@Nume)", connection);
                        cmdInsertUser.Parameters.AddWithValue("@Nume", nume);
                        cmdInsertUser.ExecuteNonQuery();

                        utilizatorId = connection.LastInsertRowId;

                        foreach (var grupNume in clbGrupuri.CheckedItems)
                        {
                            var grup = grupuri.FirstOrDefault(g => g.Nume == grupNume.ToString());
                            if (grup != null)
                            {
                                var cmdInsertRel = new SQLiteCommand("INSERT INTO utilizatori_grupuri (utilizator_id, grup_id) VALUES (@UserId, @GrupId)", connection);
                                cmdInsertRel.Parameters.AddWithValue("@UserId", utilizatorId);
                                cmdInsertRel.Parameters.AddWithValue("@GrupId", grup.Id);
                                cmdInsertRel.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                }

                var user = new Utilizator((int)utilizatorId, nume);
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
                for (int i = 0; i < clbGrupuri.Items.Count; i++)
                    clbGrupuri.SetItemChecked(i, false);
                clbGrupuri.ClearSelected();
            }
            catch (NumeExistentException ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugare utilizator: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        var cmdInsertGrup = new SQLiteCommand("INSERT INTO grupuri (nume) VALUES (@Nume)", connection);
                        cmdInsertGrup.Parameters.AddWithValue("@Nume", numeGrup);
                        cmdInsertGrup.ExecuteNonQuery();

                        long grupId = connection.LastInsertRowId;

                        foreach (var dreptNume in clbDrepturi.CheckedItems)
                        {
                            var drept = drepturi.FirstOrDefault(d => d.Nume == dreptNume.ToString());
                            if (drept != null)
                            {
                                var cmdInsertLegatura = new SQLiteCommand(
                                    "INSERT INTO grupuri_drepturi (grup_id, drept_id) VALUES (@GrupId, @DreptId)", connection);
                                cmdInsertLegatura.Parameters.AddWithValue("@GrupId", grupId);
                                cmdInsertLegatura.Parameters.AddWithValue("@DreptId", drept.Id);
                                cmdInsertLegatura.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                }

                var grupNou = new Grup(grupuri.Count + 1, numeGrup);
                foreach (var dreptNume in clbDrepturi.CheckedItems)
                {
                    var drept = drepturi.FirstOrDefault(d => d.Nume == dreptNume.ToString());
                    if (drept != null)
                    {
                        grupNou.AdaugaDrept(drept);
                    }
                }

                grupuri.Add(grupNou);
                RefreshGrupuriListView();
                RefreshGrupListBox();
                tbNumeGrup.Clear();

                for (int i = 0; i < clbDrepturi.Items.Count; i++)
                    clbDrepturi.SetItemChecked(i, false);
                clbDrepturi.ClearSelected();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Eroare la baza de date: " + ex.Message, "Eroare SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                var query = "INSERT INTO drepturi (nume) VALUES (@Nume)";
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nume", nume);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

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
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Eroare la baza de date: {ex.Message}", "Eroare SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare neașteptată: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                var result = MessageBox.Show($"Esti sigur ca vrei sa stergi dreptul '{numeDrept}'?", "Confirmare stergere", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var drept = drepturi.FirstOrDefault(d => d.Nume == numeDrept);
                    if (drept == null) return;

                    if (grupuri.Any(g => g.Drepturi.Contains(drept)))
                        throw new DreptInFolosintaException(numeDrept);

                    string query = "DELETE FROM drepturi WHERE nume = @Nume";
                    using (var connection = new SQLiteConnection(ConnectionString))
                    {
                        using (var command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Nume", numeDrept);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    drepturi.Remove(drept);
                    RefreshDreptList();
                }
            }
            catch (DreptInFolosintaException ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Eroare SQL: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare neașteptată: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string numeNou = formEdit.NumeDrept;

                try
                {
                    string query = "UPDATE drepturi SET nume = @NumeNou WHERE nume = @NumeVechi";
                    using (var connection = new SQLiteConnection(ConnectionString))
                    {
                        using (var command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@NumeNou", numeNou);
                            command.Parameters.AddWithValue("@NumeVechi", numeVechi);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    drept.Nume = numeNou;
                    RefreshDreptList();
                    LoadGrupuriFromDatabase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eroare la actualizarea bazei de date: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

                    using (var connection = new SQLiteConnection(ConnectionString))
                    {
                        connection.Open();
                        using (var transaction = connection.BeginTransaction())
                        {
                            var cmdStergeLegaturi = new SQLiteCommand("DELETE FROM grupuri_drepturi WHERE grup_id = @GrupId", connection);
                            cmdStergeLegaturi.Parameters.AddWithValue("@GrupId", grup.Id);
                            cmdStergeLegaturi.ExecuteNonQuery();

                            var cmdStergeGrup = new SQLiteCommand("DELETE FROM grupuri WHERE id = @GrupId", connection);
                            cmdStergeGrup.Parameters.AddWithValue("@GrupId", grup.Id);
                            cmdStergeGrup.ExecuteNonQuery();

                            transaction.Commit();
                        }
                    }

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
            catch (GrupInFolosintaException ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la ștergerea grupului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string numeNou = formEdit.NumeGrup;

                try
                {
                    using (var connection = new SQLiteConnection(ConnectionString))
                    {
                        connection.Open();
                        using (var transaction = connection.BeginTransaction())
                        {
                            var cmdUpdate = new SQLiteCommand("UPDATE grupuri SET nume = @NumeNou WHERE id = @Id", connection);
                            cmdUpdate.Parameters.AddWithValue("@NumeNou", numeNou);
                            cmdUpdate.Parameters.AddWithValue("@Id", grup.Id);
                            cmdUpdate.ExecuteNonQuery();

                            var cmdDeleteDrepturi = new SQLiteCommand("DELETE FROM grupuri_drepturi WHERE grup_id = @Id", connection);
                            cmdDeleteDrepturi.Parameters.AddWithValue("@Id", grup.Id);
                            cmdDeleteDrepturi.ExecuteNonQuery();

                            foreach (var dreptNume in formEdit.DrepturiSelectate.Distinct())
                            {
                                var drept = drepturi.FirstOrDefault(d => d.Nume == dreptNume);
                                if (drept != null)
                                {
                                    var cmdInsert = new SQLiteCommand(
                                        "INSERT INTO grupuri_drepturi (grup_id, drept_id) VALUES (@GrupId, @DreptId)", connection);
                                    cmdInsert.Parameters.AddWithValue("@GrupId", grup.Id);
                                    cmdInsert.Parameters.AddWithValue("@DreptId", drept.Id);
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                        }
                    }

                    grup.Nume = numeNou;
                    grup.Drepturi.Clear();
                    foreach (var dreptNume in formEdit.DrepturiSelectate.Distinct())
                    {
                        var drept = drepturi.FirstOrDefault(d => d.Nume == dreptNume);
                        if (drept != null)
                            grup.AdaugaDrept(drept);
                    }

                    RefreshGrupuriListView();
                    RefreshGrupListBox();
                    RefreshUsersListView();

                    MessageBox.Show("Grupul a fost modificat cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eroare la modificarea grupului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                string numeNou = formEdit.NumeUtilizator;

                try
                {
                    using (var connection = new SQLiteConnection(ConnectionString))
                    {
                        connection.Open();
                        using (var transaction = connection.BeginTransaction())
                        {
                            var cmdUpdate = new SQLiteCommand("UPDATE utilizatori SET nume = @NumeNou WHERE id = @Id", connection);
                            cmdUpdate.Parameters.AddWithValue("@NumeNou", numeNou);
                            cmdUpdate.Parameters.AddWithValue("@Id", user.Id);
                            cmdUpdate.ExecuteNonQuery();

                            var cmdDelete = new SQLiteCommand("DELETE FROM utilizatori_grupuri WHERE utilizator_id = @UserId", connection);
                            cmdDelete.Parameters.AddWithValue("@UserId", user.Id);
                            cmdDelete.ExecuteNonQuery();

                            foreach (var grupNume in formEdit.GrupuriSelectate)
                            {
                                var grup = grupuri.FirstOrDefault(g => g.Nume == grupNume);
                                if (grup != null)
                                {
                                    var cmdInsert = new SQLiteCommand("INSERT INTO utilizatori_grupuri (utilizator_id, grup_id) VALUES (@UserId, @GrupId)", connection);
                                    cmdInsert.Parameters.AddWithValue("@UserId", user.Id);
                                    cmdInsert.Parameters.AddWithValue("@GrupId", grup.Id);
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                        }
                    }

                    user.Nume = numeNou;
                    user.Grupuri.Clear();
                    foreach (var grupNume in formEdit.GrupuriSelectate)
                    {
                        var grup = grupuri.FirstOrDefault(g => g.Nume == grupNume);
                        if (grup != null) user.AdaugaGrup(grup);
                    }

                    RefreshUsersListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la salvarea modificărilor: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                if (utilizator == null) return;

                try
                {
                    using (var connection = new SQLiteConnection(ConnectionString))
                    {
                        connection.Open();
                        using (var transaction = connection.BeginTransaction())
                        {
                            var cmdDeleteRelatii = new SQLiteCommand("DELETE FROM utilizatori_grupuri WHERE utilizator_id = @UserId", connection);
                            cmdDeleteRelatii.Parameters.AddWithValue("@UserId", utilizator.Id);
                            cmdDeleteRelatii.ExecuteNonQuery();

                            var cmdDeleteUser = new SQLiteCommand("DELETE FROM utilizatori WHERE id = @UserId", connection);
                            cmdDeleteUser.Parameters.AddWithValue("@UserId", utilizator.Id);
                            cmdDeleteUser.ExecuteNonQuery();

                            transaction.Commit();
                        }
                    }

                    utilizatori.Remove(utilizator);
                    RefreshUsersListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la ștergerea utilizatorului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void serializedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            saveFileDialog.Title = "Salvează utilizatorii în XML";
            saveFileDialog.FileName = "utilizatori.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Utilizator>));
                        serializer.Serialize(stream, utilizatori);
                    }

                    MessageBox.Show("Fișierul a fost salvat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eroare la salvare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deserializeXML()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog.Title = "Deschide fișierul utilizatori.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Utilizator>));

                try
                {
                    using (FileStream stream = File.OpenRead(openFileDialog.FileName))
                    {
                        utilizatori = (List<Utilizator>)serializer.Deserialize(stream);
                    }

                    MessageBox.Show("Datele au fost încărcate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A apărut o eroare la deserializare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RefreshUsersListView();
            }
        }
        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            deserializeXML();
        }

        private void btnExportToTXT_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FileName = "utilizatori.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var user in utilizatori)
                        {
                            var grupuriStr = string.Join(", ", user.Grupuri.Select(g => g.Nume));
                            var drepturiStr = string.Join(", ", user.GetDrepturi().Select(d => d.Nume));

                            writer.WriteLine($"Nume: {user.Nume}");
                            writer.WriteLine($"  Grupuri: {grupuriStr}");
                            writer.WriteLine($"  Drepturi: {drepturiStr}");
                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show("Export realizat cu succes!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la export: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printUtilizatori;

            if (previewDialog.ShowDialog() == DialogResult.OK)
            {
                printUtilizatori.Print();
            }
        }

        private void printUtilizatori_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = 100;
            var font = new Font("Arial", 12);

            foreach (var user in utilizatori)
            {
                var grupuriStr = string.Join(", ", user.Grupuri.Select(g => g.Nume));
                var drepturiStr = string.Join(", ", user.GetDrepturi().Select(d => d.Nume));
                string linie = $"Nume: {user.Nume}, Grupuri: {grupuriStr}, Drepturi: {drepturiStr}";

                e.Graphics.DrawString(linie, font, Brushes.Black, new PointF(100, y));
                y += 25;
            }
        }

        private void ChartToolStrip_Click(object sender, EventArgs e)
        {
            var chartForm = new ChartForm(grupuri, utilizatori);
            chartForm.ShowDialog();
        }
    }
}