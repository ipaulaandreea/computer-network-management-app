﻿namespace NetworkManagementApp
{
    public partial class EditDreptForm : Form
    {

        public string NumeDrept { get; private set; }


        public EditDreptForm(string numeInitial)
        {
            InitializeComponent();
            textBox1.Text = numeInitial;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NumeDrept = textBox1.Text.Trim();
            if (!string.IsNullOrWhiteSpace(NumeDrept))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Introduceți un nume valid.");
            }
        }
    }
   
}
