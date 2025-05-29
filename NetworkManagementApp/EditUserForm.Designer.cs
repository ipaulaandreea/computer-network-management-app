namespace NetworkManagementApp
{
    partial class EditUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clbEditGrupuri = new CheckedListBox();
            btnModificaUtilizator = new Button();
            tbEditNumeUtilizator = new TextBox();
            labelEditGrupuri = new Label();
            labelEditNumeUtilizator = new Label();
            SuspendLayout();
            // 
            // clbEditGrupuri
            // 
            clbEditGrupuri.FormattingEnabled = true;
            clbEditGrupuri.Location = new Point(226, 99);
            clbEditGrupuri.Name = "clbEditGrupuri";
            clbEditGrupuri.Size = new Size(149, 92);
            clbEditGrupuri.TabIndex = 31;
            // 
            // btnModificaUtilizator
            // 
            btnModificaUtilizator.Location = new Point(61, 172);
            btnModificaUtilizator.Margin = new Padding(2);
            btnModificaUtilizator.Name = "btnModificaUtilizator";
            btnModificaUtilizator.Size = new Size(149, 30);
            btnModificaUtilizator.TabIndex = 30;
            btnModificaUtilizator.Text = "Salvare";
            btnModificaUtilizator.UseVisualStyleBackColor = true;
            btnModificaUtilizator.Click += btnModificaUtilizator_Click;
            // 
            // tbEditNumeUtilizator
            // 
            tbEditNumeUtilizator.Location = new Point(226, 49);
            tbEditNumeUtilizator.Margin = new Padding(2);
            tbEditNumeUtilizator.Name = "tbEditNumeUtilizator";
            tbEditNumeUtilizator.Size = new Size(166, 27);
            tbEditNumeUtilizator.TabIndex = 29;
            // 
            // labelEditGrupuri
            // 
            labelEditGrupuri.AutoSize = true;
            labelEditGrupuri.Location = new Point(108, 99);
            labelEditGrupuri.Margin = new Padding(2, 0, 2, 0);
            labelEditGrupuri.Name = "labelEditGrupuri";
            labelEditGrupuri.Size = new Size(58, 20);
            labelEditGrupuri.TabIndex = 28;
            labelEditGrupuri.Text = "Grupuri";
            // 
            // labelEditNumeUtilizator
            // 
            labelEditNumeUtilizator.AutoSize = true;
            labelEditNumeUtilizator.Location = new Point(108, 52);
            labelEditNumeUtilizator.Margin = new Padding(2, 0, 2, 0);
            labelEditNumeUtilizator.Name = "labelEditNumeUtilizator";
            labelEditNumeUtilizator.Size = new Size(112, 20);
            labelEditNumeUtilizator.TabIndex = 27;
            labelEditNumeUtilizator.Text = "Nume utilizator";
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 251);
            Controls.Add(clbEditGrupuri);
            Controls.Add(btnModificaUtilizator);
            Controls.Add(tbEditNumeUtilizator);
            Controls.Add(labelEditGrupuri);
            Controls.Add(labelEditNumeUtilizator);
            Name = "EditUserForm";
            Text = "EditUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox clbEditGrupuri;
        private Button btnModificaUtilizator;
        private TextBox tbEditNumeUtilizator;
        private Label labelEditGrupuri;
        private Label labelEditNumeUtilizator;
    }
}