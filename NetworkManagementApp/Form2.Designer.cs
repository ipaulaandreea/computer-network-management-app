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
            components = new System.ComponentModel.Container();
            tab = new TabControl();
            tabUtilizatori = new TabPage();
            clbGrupuri = new CheckedListBox();
            lvUtilizatori = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            tbNume = new TextBox();
            labelGrup = new Label();
            labelNumeUtilizator = new Label();
            tabGrupuri = new TabPage();
            clbDrepturi = new CheckedListBox();
            btnStergeGrup = new Button();
            btnModificaGrup = new Button();
            btnAdaugaGrup = new Button();
            tbNumeGrup = new TextBox();
            labelDrept = new Label();
            labelNumeGrup = new Label();
            lvGrupuri = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            tabDrepturi = new TabPage();
            btnDeleteDrept = new Button();
            btnEditDrept = new Button();
            btnAddDrept = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            lableDrept = new Label();
            listView1 = new ListView();
            columnHeader6 = new ColumnHeader();
            errorNumeUtilizator = new ErrorProvider(components);
            errorNumeGrup = new ErrorProvider(components);
            errorNumeDrept = new ErrorProvider(components);
            tab.SuspendLayout();
            tabUtilizatori.SuspendLayout();
            tabGrupuri.SuspendLayout();
            tabDrepturi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorNumeUtilizator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNumeGrup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNumeDrept).BeginInit();
            SuspendLayout();
            // 
            // tab
            // 
            tab.Controls.Add(tabUtilizatori);
            tab.Controls.Add(tabGrupuri);
            tab.Controls.Add(tabDrepturi);
            tab.Location = new Point(0, 0);
            tab.Margin = new Padding(2);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(640, 362);
            tab.TabIndex = 0;
            tab.Tag = "s";
            // 
            // tabUtilizatori
            // 
            tabUtilizatori.Controls.Add(clbGrupuri);
            tabUtilizatori.Controls.Add(lvUtilizatori);
            tabUtilizatori.Controls.Add(btnDeleteUser);
            tabUtilizatori.Controls.Add(btnEditUser);
            tabUtilizatori.Controls.Add(btnAddUser);
            tabUtilizatori.Controls.Add(tbNume);
            tabUtilizatori.Controls.Add(labelGrup);
            tabUtilizatori.Controls.Add(labelNumeUtilizator);
            tabUtilizatori.Location = new Point(4, 29);
            tabUtilizatori.Margin = new Padding(2);
            tabUtilizatori.Name = "tabUtilizatori";
            tabUtilizatori.Padding = new Padding(2);
            tabUtilizatori.Size = new Size(632, 329);
            tabUtilizatori.TabIndex = 0;
            tabUtilizatori.Text = "Utilizatori";
            tabUtilizatori.UseVisualStyleBackColor = true;
            // 
            // clbGrupuri
            // 
            clbGrupuri.FormattingEnabled = true;
            clbGrupuri.Location = new Point(122, 63);
            clbGrupuri.Name = "clbGrupuri";
            clbGrupuri.Size = new Size(166, 92);
            clbGrupuri.TabIndex = 21;
            // 
            // lvUtilizatori
            // 
            lvUtilizatori.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvUtilizatori.FullRowSelect = true;
            lvUtilizatori.GridLines = true;
            lvUtilizatori.Location = new Point(12, 160);
            lvUtilizatori.Margin = new Padding(2);
            lvUtilizatori.Name = "lvUtilizatori";
            lvUtilizatori.Size = new Size(618, 170);
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
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(362, 114);
            btnDeleteUser.Margin = new Padding(2);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(149, 30);
            btnDeleteUser.TabIndex = 8;
            btnDeleteUser.Text = "Sterge Utilizator";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(362, 68);
            btnEditUser.Margin = new Padding(2);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(149, 30);
            btnEditUser.TabIndex = 7;
            btnEditUser.Text = "Modifica Utilizator";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(362, 24);
            btnAddUser.Margin = new Padding(2);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(149, 29);
            btnAddUser.TabIndex = 6;
            btnAddUser.Text = "Adauga Utilizator";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // tbNume
            // 
            tbNume.Location = new Point(122, 16);
            tbNume.Margin = new Padding(2);
            tbNume.Name = "tbNume";
            tbNume.Size = new Size(166, 27);
            tbNume.TabIndex = 3;
            tbNume.Validating += tbNume_Validating;
            // 
            // labelGrup
            // 
            labelGrup.AutoSize = true;
            labelGrup.Location = new Point(6, 57);
            labelGrup.Margin = new Padding(2, 0, 2, 0);
            labelGrup.Name = "labelGrup";
            labelGrup.Size = new Size(58, 20);
            labelGrup.TabIndex = 1;
            labelGrup.Text = "Grupuri";
            labelGrup.Click += label1_Click;
            // 
            // labelNumeUtilizator
            // 
            labelNumeUtilizator.AutoSize = true;
            labelNumeUtilizator.Location = new Point(6, 17);
            labelNumeUtilizator.Margin = new Padding(2, 0, 2, 0);
            labelNumeUtilizator.Name = "labelNumeUtilizator";
            labelNumeUtilizator.Size = new Size(112, 20);
            labelNumeUtilizator.TabIndex = 0;
            labelNumeUtilizator.Text = "Nume utilizator";
            // 
            // tabGrupuri
            // 
            tabGrupuri.Controls.Add(clbDrepturi);
            tabGrupuri.Controls.Add(btnStergeGrup);
            tabGrupuri.Controls.Add(btnModificaGrup);
            tabGrupuri.Controls.Add(btnAdaugaGrup);
            tabGrupuri.Controls.Add(tbNumeGrup);
            tabGrupuri.Controls.Add(labelDrept);
            tabGrupuri.Controls.Add(labelNumeGrup);
            tabGrupuri.Controls.Add(lvGrupuri);
            tabGrupuri.Location = new Point(4, 29);
            tabGrupuri.Margin = new Padding(2);
            tabGrupuri.Name = "tabGrupuri";
            tabGrupuri.Padding = new Padding(2);
            tabGrupuri.Size = new Size(632, 329);
            tabGrupuri.TabIndex = 1;
            tabGrupuri.Text = "Grupuri";
            tabGrupuri.UseVisualStyleBackColor = true;
            tabGrupuri.Click += tabGrupuri_Click;
            // 
            // clbDrepturi
            // 
            clbDrepturi.FormattingEnabled = true;
            clbDrepturi.Location = new Point(140, 65);
            clbDrepturi.Name = "clbDrepturi";
            clbDrepturi.Size = new Size(166, 92);
            clbDrepturi.TabIndex = 20;
            clbDrepturi.SelectedIndexChanged += clbDrepturi_SelectedIndexChanged;
            // 
            // btnStergeGrup
            // 
            btnStergeGrup.Location = new Point(379, 118);
            btnStergeGrup.Margin = new Padding(2);
            btnStergeGrup.Name = "btnStergeGrup";
            btnStergeGrup.Size = new Size(149, 30);
            btnStergeGrup.TabIndex = 19;
            btnStergeGrup.Text = "Sterge Grup";
            btnStergeGrup.UseVisualStyleBackColor = true;
            btnStergeGrup.Click += btnStergeGrup_Click;
            // 
            // btnModificaGrup
            // 
            btnModificaGrup.Location = new Point(379, 72);
            btnModificaGrup.Margin = new Padding(2);
            btnModificaGrup.Name = "btnModificaGrup";
            btnModificaGrup.Size = new Size(149, 30);
            btnModificaGrup.TabIndex = 18;
            btnModificaGrup.Text = "Modifica Grup";
            btnModificaGrup.UseVisualStyleBackColor = true;
            btnModificaGrup.Click += btnModificaGrup_Click;
            // 
            // btnAdaugaGrup
            // 
            btnAdaugaGrup.Location = new Point(379, 28);
            btnAdaugaGrup.Margin = new Padding(2);
            btnAdaugaGrup.Name = "btnAdaugaGrup";
            btnAdaugaGrup.Size = new Size(149, 29);
            btnAdaugaGrup.TabIndex = 17;
            btnAdaugaGrup.Text = "Adauga Grup";
            btnAdaugaGrup.UseVisualStyleBackColor = true;
            btnAdaugaGrup.Click += btnAdaugaGrup_Click;
            // 
            // tbNumeGrup
            // 
            tbNumeGrup.Location = new Point(140, 20);
            tbNumeGrup.Margin = new Padding(2);
            tbNumeGrup.Name = "tbNumeGrup";
            tbNumeGrup.Size = new Size(166, 27);
            tbNumeGrup.TabIndex = 14;
            tbNumeGrup.Validating += tbNumeGrup_Validating;
            // 
            // labelDrept
            // 
            labelDrept.AutoSize = true;
            labelDrept.Location = new Point(31, 65);
            labelDrept.Margin = new Padding(2, 0, 2, 0);
            labelDrept.Name = "labelDrept";
            labelDrept.Size = new Size(64, 20);
            labelDrept.TabIndex = 13;
            labelDrept.Text = "Drepturi";
            // 
            // labelNumeGrup
            // 
            labelNumeGrup.AutoSize = true;
            labelNumeGrup.Location = new Point(24, 21);
            labelNumeGrup.Margin = new Padding(2, 0, 2, 0);
            labelNumeGrup.Name = "labelNumeGrup";
            labelNumeGrup.Size = new Size(84, 20);
            labelNumeGrup.TabIndex = 11;
            labelNumeGrup.Text = "Nume grup";
            labelNumeGrup.Click += label3_Click;
            // 
            // lvGrupuri
            // 
            lvGrupuri.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            lvGrupuri.FullRowSelect = true;
            lvGrupuri.GridLines = true;
            lvGrupuri.Location = new Point(6, 164);
            lvGrupuri.Margin = new Padding(2);
            lvGrupuri.Name = "lvGrupuri";
            lvGrupuri.Size = new Size(618, 160);
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
            // tabDrepturi
            // 
            tabDrepturi.Controls.Add(btnDeleteDrept);
            tabDrepturi.Controls.Add(btnEditDrept);
            tabDrepturi.Controls.Add(btnAddDrept);
            tabDrepturi.Controls.Add(textBox1);
            tabDrepturi.Controls.Add(label1);
            tabDrepturi.Controls.Add(lableDrept);
            tabDrepturi.Controls.Add(listView1);
            tabDrepturi.Location = new Point(4, 29);
            tabDrepturi.Margin = new Padding(2);
            tabDrepturi.Name = "tabDrepturi";
            tabDrepturi.Padding = new Padding(2);
            tabDrepturi.Size = new Size(632, 329);
            tabDrepturi.TabIndex = 2;
            tabDrepturi.Text = "Drepturi";
            tabDrepturi.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDrept
            // 
            btnDeleteDrept.Location = new Point(382, 112);
            btnDeleteDrept.Margin = new Padding(2);
            btnDeleteDrept.Name = "btnDeleteDrept";
            btnDeleteDrept.Size = new Size(149, 30);
            btnDeleteDrept.TabIndex = 27;
            btnDeleteDrept.Text = "Sterge Drept";
            btnDeleteDrept.UseVisualStyleBackColor = true;
            btnDeleteDrept.Click += btnDeleteDrept_Click;
            // 
            // btnEditDrept
            // 
            btnEditDrept.Location = new Point(382, 66);
            btnEditDrept.Margin = new Padding(2);
            btnEditDrept.Name = "btnEditDrept";
            btnEditDrept.Size = new Size(149, 30);
            btnEditDrept.TabIndex = 26;
            btnEditDrept.Text = "Modifica Drept";
            btnEditDrept.UseVisualStyleBackColor = true;
            btnEditDrept.Click += btnEditDrept_Click;
            // 
            // btnAddDrept
            // 
            btnAddDrept.Location = new Point(34, 114);
            btnAddDrept.Margin = new Padding(2);
            btnAddDrept.Name = "btnAddDrept";
            btnAddDrept.Size = new Size(149, 29);
            btnAddDrept.TabIndex = 25;
            btnAddDrept.Text = "Adauga Drept";
            btnAddDrept.UseVisualStyleBackColor = true;
            btnAddDrept.Click += btnAddDrept_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 50);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 59);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 22;
            // 
            // lableDrept
            // 
            lableDrept.AutoSize = true;
            lableDrept.Location = new Point(34, 50);
            lableDrept.Margin = new Padding(2, 0, 2, 0);
            lableDrept.Name = "lableDrept";
            lableDrept.Size = new Size(47, 20);
            lableDrept.TabIndex = 21;
            lableDrept.Text = "Drept";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader6 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(9, 158);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(618, 160);
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
            // errorNumeUtilizator
            // 
            errorNumeUtilizator.ContainerControl = this;
            // 
            // errorNumeGrup
            // 
            errorNumeGrup.ContainerControl = this;
            // 
            // errorNumeDrept
            // 
            errorNumeDrept.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 373);
            Controls.Add(tab);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Form2";
            tab.ResumeLayout(false);
            tabUtilizatori.ResumeLayout(false);
            tabUtilizatori.PerformLayout();
            tabGrupuri.ResumeLayout(false);
            tabGrupuri.PerformLayout();
            tabDrepturi.ResumeLayout(false);
            tabDrepturi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorNumeUtilizator).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNumeGrup).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNumeDrept).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab;
        private TabPage tabUtilizatori;
        private TabPage tabGrupuri;
        private TabPage tabDrepturi;
        private Label labelGrup;
        private Label labelNumeUtilizator;
        private TextBox tbNume;
        private Button btnDeleteUser;
        private Button btnEditUser;
        private Button btnAddUser;
        private ListView lvUtilizatori;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnStergeGrup;
        private Button btnModificaGrup;
        private Button btnAdaugaGrup;
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
        private CheckedListBox clbDrepturi;
        private CheckedListBox clbGrupuri;
        private ErrorProvider errorNumeUtilizator;
        private ErrorProvider errorNumeGrup;
        private ErrorProvider errorNumeDrept;
    }
}