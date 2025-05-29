namespace NetworkManagementApp
{
    partial class EditGrupForm
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
            labelNumeGrup = new Label();
            labelDrept = new Label();
            tbEditNumeGrup = new TextBox();
            btnModificaGrup = new Button();
            clbEditDrepturi = new CheckedListBox();
            SuspendLayout();
            // 
            // labelNumeGrup
            // 
            labelNumeGrup.AutoSize = true;
            labelNumeGrup.Location = new Point(58, 37);
            labelNumeGrup.Margin = new Padding(2, 0, 2, 0);
            labelNumeGrup.Name = "labelNumeGrup";
            labelNumeGrup.Size = new Size(84, 20);
            labelNumeGrup.TabIndex = 20;
            labelNumeGrup.Text = "Nume grup";
            // 
            // labelDrept
            // 
            labelDrept.AutoSize = true;
            labelDrept.Location = new Point(58, 84);
            labelDrept.Margin = new Padding(2, 0, 2, 0);
            labelDrept.Name = "labelDrept";
            labelDrept.Size = new Size(64, 20);
            labelDrept.TabIndex = 21;
            labelDrept.Text = "Drepturi";
            // 
            // tbEditNumeGrup
            // 
            tbEditNumeGrup.Location = new Point(176, 34);
            tbEditNumeGrup.Margin = new Padding(2);
            tbEditNumeGrup.Name = "tbEditNumeGrup";
            tbEditNumeGrup.Size = new Size(166, 27);
            tbEditNumeGrup.TabIndex = 22;
            // 
            // btnModificaGrup
            // 
            btnModificaGrup.Location = new Point(11, 157);
            btnModificaGrup.Margin = new Padding(2);
            btnModificaGrup.Name = "btnModificaGrup";
            btnModificaGrup.Size = new Size(149, 30);
            btnModificaGrup.TabIndex = 25;
            btnModificaGrup.Text = "Salvare";
            btnModificaGrup.UseVisualStyleBackColor = true;
            btnModificaGrup.Click += btnModificaGrup_Click;
            // 
            // clbEditDrepturi
            // 
            clbEditDrepturi.FormattingEnabled = true;
            clbEditDrepturi.Location = new Point(176, 84);
            clbEditDrepturi.Name = "clbEditDrepturi";
            clbEditDrepturi.Size = new Size(149, 92);
            clbEditDrepturi.TabIndex = 26;
            // 
            // EditGrupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 198);
            Controls.Add(clbEditDrepturi);
            Controls.Add(btnModificaGrup);
            Controls.Add(tbEditNumeGrup);
            Controls.Add(labelDrept);
            Controls.Add(labelNumeGrup);
            Name = "EditGrupForm";
            Text = "EditGrupForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumeGrup;
        private Label labelDrept;
        private TextBox tbEditNumeGrup;
        private Button btnModificaGrup;
        private CheckedListBox clbEditDrepturi;
    }
}