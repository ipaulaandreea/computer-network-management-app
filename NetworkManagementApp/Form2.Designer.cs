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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            errorNumeUtilizator = new ErrorProvider(components);
            errorNumeGrup = new ErrorProvider(components);
            errorNumeDrept = new ErrorProvider(components);
            tabDrepturi = new TabPage();
            btnDeleteDrept = new Button();
            btnEditDrept = new Button();
            btnAddDrept = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            lableDrept = new Label();
            listView1 = new ListView();
            columnHeader6 = new ColumnHeader();
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
            tabUtilizatori = new TabPage();
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            ChartToolStrip = new ToolStripButton();
            clbGrupuri = new CheckedListBox();
            lvUtilizatori = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            tbNume = new TextBox();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            labelGrup = new Label();
            labelNumeUtilizator = new Label();
            menuStrip1 = new MenuStrip();
            xMLSerializationToolStripMenuItem = new ToolStripMenuItem();
            btnSerialize = new ToolStripMenuItem();
            btnDeserialize = new ToolStripMenuItem();
            btnExportToTXT = new ToolStripMenuItem();
            tab = new TabControl();
            printUtilizatori = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)errorNumeUtilizator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNumeGrup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNumeDrept).BeginInit();
            tabDrepturi.SuspendLayout();
            tabGrupuri.SuspendLayout();
            tabUtilizatori.SuspendLayout();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tab.SuspendLayout();
            SuspendLayout();
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
            btnAddDrept.Text = "&Adauga Drept";
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
            clbDrepturi.Location = new Point(140, 78);
            clbDrepturi.Name = "clbDrepturi";
            clbDrepturi.Size = new Size(166, 70);
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
            btnAdaugaGrup.Text = "&Adauga Grup";
            btnAdaugaGrup.UseVisualStyleBackColor = true;
            btnAdaugaGrup.Click += btnAdaugaGrup_Click;
            // 
            // tbNumeGrup
            // 
            tbNumeGrup.Location = new Point(140, 25);
            tbNumeGrup.Margin = new Padding(2);
            tbNumeGrup.Name = "tbNumeGrup";
            tbNumeGrup.Size = new Size(166, 27);
            tbNumeGrup.TabIndex = 14;
            tbNumeGrup.Validating += tbNumeGrup_Validating;
            // 
            // labelDrept
            // 
            labelDrept.AutoSize = true;
            labelDrept.Location = new Point(24, 82);
            labelDrept.Margin = new Padding(2, 0, 2, 0);
            labelDrept.Name = "labelDrept";
            labelDrept.Size = new Size(64, 20);
            labelDrept.TabIndex = 13;
            labelDrept.Text = "Drepturi";
            // 
            // labelNumeGrup
            // 
            labelNumeGrup.AutoSize = true;
            labelNumeGrup.Location = new Point(24, 28);
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
            lvGrupuri.Size = new Size(522, 160);
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
            // tabUtilizatori
            // 
            tabUtilizatori.Controls.Add(toolStrip1);
            tabUtilizatori.Controls.Add(clbGrupuri);
            tabUtilizatori.Controls.Add(lvUtilizatori);
            tabUtilizatori.Controls.Add(tbNume);
            tabUtilizatori.Controls.Add(btnDeleteUser);
            tabUtilizatori.Controls.Add(btnEditUser);
            tabUtilizatori.Controls.Add(btnAddUser);
            tabUtilizatori.Controls.Add(labelGrup);
            tabUtilizatori.Controls.Add(labelNumeUtilizator);
            tabUtilizatori.Controls.Add(menuStrip1);
            tabUtilizatori.Location = new Point(4, 29);
            tabUtilizatori.Margin = new Padding(2);
            tabUtilizatori.Name = "tabUtilizatori";
            tabUtilizatori.Padding = new Padding(2);
            tabUtilizatori.Size = new Size(632, 329);
            tabUtilizatori.TabIndex = 0;
            tabUtilizatori.Text = "Utilizatori";
            tabUtilizatori.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Right;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, ChartToolStrip });
            toolStrip1.Location = new Point(595, 30);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(35, 297);
            toolStrip1.TabIndex = 23;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(32, 24);
            toolStripButton2.Text = "🖨";
            toolStripButton2.ToolTipText = "Printeaza raport utilizatori";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // ChartToolStrip
            // 
            ChartToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ChartToolStrip.Image = (Image)resources.GetObject("ChartToolStrip.Image");
            ChartToolStrip.ImageTransparentColor = Color.Magenta;
            ChartToolStrip.Name = "ChartToolStrip";
            ChartToolStrip.Size = new Size(37, 24);
            ChartToolStrip.Text = "📊";
            ChartToolStrip.ToolTipText = "Genereaza Chart";
            ChartToolStrip.Click += ChartToolStrip_Click;
            // 
            // clbGrupuri
            // 
            clbGrupuri.FormattingEnabled = true;
            clbGrupuri.Location = new Point(134, 74);
            clbGrupuri.Name = "clbGrupuri";
            clbGrupuri.Size = new Size(166, 70);
            clbGrupuri.TabIndex = 21;
            // 
            // lvUtilizatori
            // 
            lvUtilizatori.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvUtilizatori.FullRowSelect = true;
            lvUtilizatori.GridLines = true;
            lvUtilizatori.Location = new Point(4, 163);
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
            // tbNume
            // 
            tbNume.Location = new Point(134, 39);
            tbNume.Margin = new Padding(2);
            tbNume.Name = "tbNume";
            tbNume.Size = new Size(166, 27);
            tbNume.TabIndex = 3;
            tbNume.Validating += tbNume_Validating;
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
            btnAddUser.Text = "&Adauga Utilizator";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // labelGrup
            // 
            labelGrup.AutoSize = true;
            labelGrup.Location = new Point(17, 78);
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
            labelNumeUtilizator.Location = new Point(6, 42);
            labelNumeUtilizator.Margin = new Padding(2, 0, 2, 0);
            labelNumeUtilizator.Name = "labelNumeUtilizator";
            labelNumeUtilizator.Size = new Size(112, 20);
            labelNumeUtilizator.TabIndex = 0;
            labelNumeUtilizator.Text = "Nume utilizator";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { xMLSerializationToolStripMenuItem });
            menuStrip1.Location = new Point(2, 2);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(628, 28);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // xMLSerializationToolStripMenuItem
            // 
            xMLSerializationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnSerialize, btnDeserialize, btnExportToTXT });
            xMLSerializationToolStripMenuItem.Name = "xMLSerializationToolStripMenuItem";
            xMLSerializationToolStripMenuItem.Size = new Size(138, 24);
            xMLSerializationToolStripMenuItem.Text = "XML Serialization";
            // 
            // btnSerialize
            // 
            btnSerialize.Name = "btnSerialize";
            btnSerialize.Size = new Size(182, 26);
            btnSerialize.Text = "Serialized";
            btnSerialize.Click += serializedToolStripMenuItem1_Click;
            // 
            // btnDeserialize
            // 
            btnDeserialize.Name = "btnDeserialize";
            btnDeserialize.Size = new Size(182, 26);
            btnDeserialize.Text = "Deserialized";
            btnDeserialize.Click += btnDeserialize_Click;
            // 
            // btnExportToTXT
            // 
            btnExportToTXT.Name = "btnExportToTXT";
            btnExportToTXT.Size = new Size(182, 26);
            btnExportToTXT.Text = "Export to TXT";
            btnExportToTXT.Click += btnExportToTXT_Click;
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
            // printUtilizatori
            // 
            printUtilizatori.PrintPage += printUtilizatori_PrintPage;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 373);
            Controls.Add(tab);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            ((System.ComponentModel.ISupportInitialize)errorNumeUtilizator).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNumeGrup).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNumeDrept).EndInit();
            tabDrepturi.ResumeLayout(false);
            tabDrepturi.PerformLayout();
            tabGrupuri.ResumeLayout(false);
            tabGrupuri.PerformLayout();
            tabUtilizatori.ResumeLayout(false);
            tabUtilizatori.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox2;
        private Label label2;
        private ErrorProvider errorNumeUtilizator;
        private ErrorProvider errorNumeGrup;
        private ErrorProvider errorNumeDrept;
        private TabControl tab;
        private TabPage tabUtilizatori;
        private CheckedListBox clbGrupuri;
        private ListView lvUtilizatori;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox tbNume;
        private Button btnDeleteUser;
        private Button btnEditUser;
        private Button btnAddUser;
        private Label labelGrup;
        private Label labelNumeUtilizator;
        private TabPage tabGrupuri;
        private CheckedListBox clbDrepturi;
        private Button btnStergeGrup;
        private Button btnModificaGrup;
        private Button btnAdaugaGrup;
        private TextBox tbNumeGrup;
        private Label labelDrept;
        private Label labelNumeGrup;
        private ListView lvGrupuri;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TabPage tabDrepturi;
        private Button btnDeleteDrept;
        private Button btnEditDrept;
        private Button btnAddDrept;
        private TextBox textBox1;
        private Label label1;
        private Label lableDrept;
        private ListView listView1;
        private ColumnHeader columnHeader6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem xMLSerializationToolStripMenuItem;
        private ToolStripMenuItem btnSerialize;
        private ToolStripMenuItem btnDeserialize;
        private ToolStripMenuItem btnExportToTXT;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton2;
        private System.Drawing.Printing.PrintDocument printUtilizatori;
        private ToolStripButton ChartToolStrip;
    }
}