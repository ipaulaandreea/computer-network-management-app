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
    public partial class EditUserForm : Form
    {

        public string NumeUtilizator { get; private set; }
        public List<string> GrupuriSelectate { get; private set; } = new();

        public EditUserForm(string numeInitial, List<Grup> toateGrupurile, List<Grup> grupuriUtilizator)
        {
            InitializeComponent();
            tbEditNumeUtilizator.Text = numeInitial;

            clbEditGrupuri.Items.Clear();

            foreach (var grup in toateGrupurile)
            {
                int index = clbEditGrupuri.Items.Add(grup.Nume);
                if (grupuriUtilizator.Any(g => g.Nume == grup.Nume))
                {
                    clbEditGrupuri.SetItemChecked(index, true);
                }
            }
        }

        private void btnModificaUtilizator_Click(object sender, EventArgs e)
        {
            NumeUtilizator = tbEditNumeUtilizator.Text.Trim();

            if (string.IsNullOrWhiteSpace(NumeUtilizator))
            {
                MessageBox.Show("Introduceți un nume valid pentru utilizator.");
                return;
            }

            GrupuriSelectate = clbEditGrupuri.CheckedItems.Cast<string>().ToList();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
