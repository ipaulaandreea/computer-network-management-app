namespace NetworkManagementApp
{
    partial class Form2
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
            tab = new TabControl();
            tabUtilizatori = new TabPage();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            lbDrepturi = new ListBox();
            lbGrup = new ListBox();
            tbNume = new TextBox();
            labelDrepturi = new Label();
            labelGrup = new Label();
            labelNumeUtilizator = new Label();
            tabGrupuri = new TabPage();
            tabDrepturi = new TabPage();
            lvUtilizatori = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lvGrupuri = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnStergeGrup = new Button();
            btnModificaGrup = new Button();
            btnAdaugaGrup = new Button();
            lbDrepturiGrup = new ListBox();
            tbNumeGrup = new TextBox();
            labelDrept = new Label();
            labelNumeGrup = new Label();
            btnDeleteDrept = new Button();
            btnEditDrept = new Button();
            btnAddDrept = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            lableDrept = new Label();
            listView1 = new ListView();
            columnHeader6 = new ColumnHeader();
            tab.SuspendLayout();
            tabUtilizatori.SuspendLayout();
            tabGrupuri.SuspendLayout();
            tabDrepturi.SuspendLayout();
            SuspendLayout();
            // 
            // tab
            // 
            tab.Controls.Add(tabUtilizatori);
            tab.Controls.Add(tabGrupuri);
            tab.Controls.Add(tabDrepturi);
            tab.Location = new Point(0, 0);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(800, 452);
            tab.TabIndex = 0;
            // 
            // tabUtilizatori
            // 
            tabUtilizatori.Controls.Add(lvUtilizatori);
            tabUtilizatori.Controls.Add(btnDeleteUser);
            tabUtilizatori.Controls.Add(btnEditUser);
            tabUtilizatori.Controls.Add(btnAddUser);
            tabUtilizatori.Controls.Add(lbDrepturi);
            tabUtilizatori.Controls.Add(lbGrup);
            tabUtilizatori.Controls.Add(tbNume);
            tabUtilizatori.Controls.Add(labelDrepturi);
            tabUtilizatori.Controls.Add(labelGrup);
            tabUtilizatori.Controls.Add(labelNumeUtilizator);
            tabUtilizatori.Location = new Point(4, 34);
            tabUtilizatori.Name = "tabUtilizatori";
            tabUtilizatori.Padding = new Padding(3);
            tabUtilizatori.Size = new Size(792, 414);
            tabUtilizatori.TabIndex = 0;
            tabUtilizatori.Text = "Utilizatori";
            tabUtilizatori.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(452, 142);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(186, 38);
            btnDeleteUser.TabIndex = 8;
            btnDeleteUser.Text = "Sterge Utilizator";
            btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(452, 85);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(186, 38);
            btnEditUser.TabIndex = 7;
            btnEditUser.Text = "Modifica Utilizator";
            btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(452, 30);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(186, 36);
            btnAddUser.TabIndex = 6;
            btnAddUser.Text = "Adauga Utilizator";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // lbDrepturi
            // 
            lbDrepturi.FormattingEnabled = true;
            lbDrepturi.ItemHeight = 25;
            lbDrepturi.Location = new Point(152, 119);
            lbDrepturi.Name = "lbDrepturi";
            lbDrepturi.Size = new Size(206, 29);
            lbDrepturi.TabIndex = 5;
            // 
            // lbGrup
            // 
            lbGrup.FormattingEnabled = true;
            lbGrup.ItemHeight = 25;
            lbGrup.Location = new Point(153, 71);
            lbGrup.Name = "lbGrup";
            lbGrup.Size = new Size(205, 29);
            lbGrup.TabIndex = 4;
            // 
            // tbNume
            // 
            tbNume.Location = new Point(153, 20);
            tbNume.Name = "tbNume";
            tbNume.Size = new Size(206, 31);
            tbNume.TabIndex = 3;
            // 
            // labelDrepturi
            // 
            labelDrepturi.AutoSize = true;
            labelDrepturi.Location = new Point(8, 119);
            labelDrepturi.Name = "labelDrepturi";
            labelDrepturi.Size = new Size(77, 25);
            labelDrepturi.TabIndex = 2;
            labelDrepturi.Text = "Drepturi";
            labelDrepturi.Click += label1_Click_1;
            // 
            // labelGrup
            // 
            labelGrup.AutoSize = true;
            labelGrup.Location = new Point(8, 71);
            labelGrup.Name = "labelGrup";
            labelGrup.Size = new Size(51, 25);
            labelGrup.TabIndex = 1;
            labelGrup.Text = "Grup";
            labelGrup.Click += label1_Click;
            // 
            // labelNumeUtilizator
            // 
            labelNumeUtilizator.AutoSize = true;
            labelNumeUtilizator.Location = new Point(8, 21);
            labelNumeUtilizator.Name = "labelNumeUtilizator";
            labelNumeUtilizator.Size = new Size(133, 25);
            labelNumeUtilizator.TabIndex = 0;
            labelNumeUtilizator.Text = "Nume utilizator";
            // 
            // tabGrupuri
            // 
            tabGrupuri.Controls.Add(btnStergeGrup);
            tabGrupuri.Controls.Add(btnModificaGrup);
            tabGrupuri.Controls.Add(btnAdaugaGrup);
            tabGrupuri.Controls.Add(lbDrepturiGrup);
            tabGrupuri.Controls.Add(tbNumeGrup);
            tabGrupuri.Controls.Add(labelDrept);
            tabGrupuri.Controls.Add(labelNumeGrup);
            tabGrupuri.Controls.Add(lvGrupuri);
            tabGrupuri.Location = new Point(4, 34);
            tabGrupuri.Name = "tabGrupuri";
            tabGrupuri.Padding = new Padding(3);
            tabGrupuri.Size = new Size(792, 414);
            tabGrupuri.TabIndex = 1;
            tabGrupuri.Text = "Grupuri";
            tabGrupuri.UseVisualStyleBackColor = true;
            tabGrupuri.Click += tabGrupuri_Click;
            // 
            // tabDrepturi
            // 
            tabDrepturi.Controls.Add(btnDeleteDrept);
            tabDrepturi.Controls.Add(btnEditDrept);
            tabDrepturi.Controls.Add(btnAddDrept);
            tabDrepturi.Controls.Add(textBox1);
            tabDrepturi.Controls.Add(label1);
            tabDrepturi.Controls.Add(lableDrept);
            tabDrepturi.Controls.Add(listView1);
            tabDrepturi.Location = new Point(4, 34);
            tabDrepturi.Name = "tabDrepturi";
            tabDrepturi.Padding = new Padding(3);
            tabDrepturi.Size = new Size(792, 414);
            tabDrepturi.TabIndex = 2;
            tabDrepturi.Text = "Drepturi";
            tabDrepturi.UseVisualStyleBackColor = true;
            // 
            // lvUtilizatori
            // 
            lvUtilizatori.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvUtilizatori.FullRowSelect = true;
            lvUtilizatori.GridLines = true;
            lvUtilizatori.Location = new Point(15, 200);
            lvUtilizatori.Name = "lvUtilizatori";
            lvUtilizatori.Size = new Size(771, 212);
            lvUtilizatori.TabIndex = 9;
            lvUtilizatori.UseCompatibleStateImageBehavior = false;
            lvUtilizatori.View = View.Details;
            lvUtilizatori.SelectedIndexChanged += lvUtilizatori_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nume Utilizator";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Grup";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Drepturi";
            columnHeader3.Width = 447;
            // 
            // lvGrupuri
            // 
            lvGrupuri.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            lvGrupuri.FullRowSelect = true;
            lvGrupuri.GridLines = true;
            lvGrupuri.Location = new Point(8, 205);
            lvGrupuri.Name = "lvGrupuri";
            lvGrupuri.Size = new Size(771, 199);
            lvGrupuri.TabIndex = 10;
            lvGrupuri.UseCompatibleStateImageBehavior = false;
            lvGrupuri.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nume Grup";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Drepturi";
            columnHeader5.Width = 567;
            // 
            // btnStergeGrup
            // 
            btnStergeGrup.Location = new Point(474, 147);
            btnStergeGrup.Name = "btnStergeGrup";
            btnStergeGrup.Size = new Size(186, 38);
            btnStergeGrup.TabIndex = 19;
            btnStergeGrup.Text = "Sterge Grup";
            btnStergeGrup.UseVisualStyleBackColor = true;
            // 
            // btnModificaGrup
            // 
            btnModificaGrup.Location = new Point(474, 90);
            btnModificaGrup.Name = "btnModificaGrup";
            btnModificaGrup.Size = new Size(186, 38);
            btnModificaGrup.TabIndex = 18;
            btnModificaGrup.Text = "Modifica Grup";
            btnModificaGrup.UseVisualStyleBackColor = true;
            // 
            // btnAdaugaGrup
            // 
            btnAdaugaGrup.Location = new Point(474, 35);
            btnAdaugaGrup.Name = "btnAdaugaGrup";
            btnAdaugaGrup.Size = new Size(186, 36);
            btnAdaugaGrup.TabIndex = 17;
            btnAdaugaGrup.Text = "Adauga Grup";
            btnAdaugaGrup.UseVisualStyleBackColor = true;
            btnAdaugaGrup.Click += this.btnAdaugaGrup_Click;

            // 
            // lbDrepturiGrup
            // 
            lbDrepturiGrup.FormattingEnabled = true;
            lbDrepturiGrup.ItemHeight = 25;
            lbDrepturiGrup.Location = new Point(175, 81);
            lbDrepturiGrup.Name = "lbDrepturiGrup";
            lbDrepturiGrup.Size = new Size(206, 29);
            lbDrepturiGrup.TabIndex = 16;
            // 
            // tbNumeGrup
            // 
            tbNumeGrup.Location = new Point(175, 25);
            tbNumeGrup.Name = "tbNumeGrup";
            tbNumeGrup.Size = new Size(206, 31);
            tbNumeGrup.TabIndex = 14;
            // 
            // labelDrept
            // 
            labelDrept.AutoSize = true;
            labelDrept.Location = new Point(39, 81);
            labelDrept.Name = "labelDrept";
            labelDrept.Size = new Size(77, 25);
            labelDrept.TabIndex = 13;
            labelDrept.Text = "Drepturi";
            // 
            // labelNumeGrup
            // 
            labelNumeGrup.AutoSize = true;
            labelNumeGrup.Location = new Point(30, 26);
            labelNumeGrup.Name = "labelNumeGrup";
            labelNumeGrup.Size = new Size(103, 25);
            labelNumeGrup.TabIndex = 11;
            labelNumeGrup.Text = "Nume grup";
            labelNumeGrup.Click += label3_Click;
            // 
            // btnDeleteDrept
            // 
            btnDeleteDrept.Location = new Point(477, 140);
            btnDeleteDrept.Name = "btnDeleteDrept";
            btnDeleteDrept.Size = new Size(186, 38);
            btnDeleteDrept.TabIndex = 27;
            btnDeleteDrept.Text = "Sterge Drept";
            btnDeleteDrept.UseVisualStyleBackColor = true;
            //btnDeleteDrept.Click += this.button1_Click;
            // 
            // btnEditDrept
            // 
            btnEditDrept.Location = new Point(477, 83);
            btnEditDrept.Name = "btnEditDrept";
            btnEditDrept.Size = new Size(186, 38);
            btnEditDrept.TabIndex = 26;
            btnEditDrept.Text = "Modifica Drept";
            btnEditDrept.UseVisualStyleBackColor = true;
            //btnEditDrept.Click += this.btnEditDrept_Click;
            // 
            // btnAddDrept
            // 
            btnAddDrept.Location = new Point(42, 142);
            btnAddDrept.Name = "btnAddDrept";
            btnAddDrept.Size = new Size(186, 36);
            btnAddDrept.TabIndex = 25;
            btnAddDrept.Text = "Adauga Drept";
            btnAddDrept.UseVisualStyleBackColor = true;
            btnAddDrept.Click += this.btnAddDrept_Click;
            
            // 
            // btnAddUser
            // 
            btnAddUser.Click += this.btnAddUser_Click;

            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 31);
            textBox1.TabIndex = 23;
            //textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 74);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 22;
            //label1.Click += this.label1_Click_2;
            // 
            // lableDrept
            // 
            lableDrept.AutoSize = true;
            lableDrept.Location = new Point(42, 62);
            lableDrept.Name = "lableDrept";
            lableDrept.Size = new Size(57, 25);
            lableDrept.TabIndex = 21;
            lableDrept.Text = "Drept";
            //lableDrept.Click += this.label2_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader6 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(11, 198);
            listView1.Name = "listView1";
            listView1.Size = new Size(771, 199);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Nume Drept";
            columnHeader6.Width = 767;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tab);
            Name = "Form2";
            Text = "Form2";
            tab.ResumeLayout(false);
            tabUtilizatori.ResumeLayout(false);
            tabUtilizatori.PerformLayout();
            tabGrupuri.ResumeLayout(false);
            tabGrupuri.PerformLayout();
            tabDrepturi.ResumeLayout(false);
            tabDrepturi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab;
        private TabPage tabUtilizatori;
        private TabPage tabGrupuri;
        private TabPage tabDrepturi;
        private Label labelGrup;
        private Label labelNumeUtilizator;
        private Label labelDrepturi;
        private ListBox lbGrup;
        private TextBox tbNume;
        private Button btnDeleteUser;
        private Button btnEditUser;
        private Button btnAddUser;
        private ListBox lbDrepturi;
        private ListView lvUtilizatori;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnStergeGrup;
        private Button btnModificaGrup;
        private Button btnAdaugaGrup;
        private ListBox lbDrepturiGrup;
        private ListBox listBox2;
        private TextBox tbNumeGrup;
        private Label labelDrept;
        private Label label2;
        private Label labelNumeGrup;
        private ListView lvGrupuri;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnDeleteDrept;
        private Button btnEditDrept;
        private Button btnAddDrept;
        private TextBox textBox1;
        private Label label1;
        private Label lableDrept;
        private ListView listView1;
        private ColumnHeader columnHeader6;
    }
}