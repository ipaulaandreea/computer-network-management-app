﻿using System.Data;
using NetworkManagementApp.Model;

namespace NetworkManagementApp
{
    public partial class EditGrupForm : Form
    {

        public string NumeGrup { get; private set; }
        public List<string> DrepturiSelectate { get; private set; } = new();

        public EditGrupForm(string numeInitial, List<Drept> toateDrepturile, List<Drept> drepturiExistente)
        {
            InitializeComponent();
            tbEditNumeGrup.Text = numeInitial;
            PopuleazaDrepturi(toateDrepturile, drepturiExistente);
        }

        private void PopuleazaDrepturi(List<Drept> toateDrepturile, List<Drept> drepturiSelectate)
        {
            clbEditDrepturi.Items.Clear();

            foreach (var drept in toateDrepturile)
            {
                int index = clbEditDrepturi.Items.Add(drept.Nume);
                if (drepturiSelectate.Any(d => d.Nume == drept.Nume))
                {
                    clbEditDrepturi.SetItemChecked(index, true);
                }
            }
        }

        private void btnModificaGrup_Click(object sender, EventArgs e)
        {
            NumeGrup = tbEditNumeGrup.Text.Trim();

            if (!string.IsNullOrWhiteSpace(NumeGrup))
            {
                DrepturiSelectate = clbEditDrepturi.CheckedItems
                    .Cast<string>()
                    .ToList();

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Introduceți un nume valid pentru grup.");
            }
        }
    }
}
