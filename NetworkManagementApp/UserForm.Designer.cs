namespace NetworkManagementApp
{
    partial class UserForm
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lvParticipants = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            utilizatoriToolStripMenuItem = new ToolStripMenuItem();
            grupuriToolStripMenuItem = new ToolStripMenuItem();
            roluriToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 31);
            textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(162, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 2;
            label1.Text = "Utilizator";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 89);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 3;
            label2.Text = "Grup";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 137);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adauga Utilizator";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lvParticipants
            // 
            lvParticipants.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lvParticipants.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvParticipants.FullRowSelect = true;
            lvParticipants.GridLines = true;
            lvParticipants.Location = new Point(12, 212);
            lvParticipants.Margin = new Padding(4);
            lvParticipants.MinimumSize = new Size(770, 4);
            lvParticipants.Name = "lvParticipants";
            lvParticipants.Size = new Size(776, 228);
            lvParticipants.TabIndex = 7;
            lvParticipants.UseCompatibleStateImageBehavior = false;
            lvParticipants.View = View.Details;
            lvParticipants.SelectedIndexChanged += lvParticipants_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Utilizator";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Grupuri";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Roluri";
            columnHeader3.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(391, 48);
            button1.Name = "button1";
            button1.Size = new Size(185, 44);
            button1.TabIndex = 4;
            button1.Text = "Adauga utilizator";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { utilizatoriToolStripMenuItem, grupuriToolStripMenuItem, roluriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // utilizatoriToolStripMenuItem
            // 
            utilizatoriToolStripMenuItem.Name = "utilizatoriToolStripMenuItem";
            utilizatoriToolStripMenuItem.Size = new Size(102, 29);
            utilizatoriToolStripMenuItem.Text = "Utilizatori";
            // 
            // grupuriToolStripMenuItem
            // 
            grupuriToolStripMenuItem.Name = "grupuriToolStripMenuItem";
            grupuriToolStripMenuItem.Size = new Size(87, 29);
            grupuriToolStripMenuItem.Text = "Grupuri";
            // 
            // roluriToolStripMenuItem
            // 
            roluriToolStripMenuItem.Name = "roluriToolStripMenuItem";
            roluriToolStripMenuItem.Size = new Size(73, 29);
            roluriToolStripMenuItem.Text = "Roluri";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvParticipants);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "UserForm";
            Text = "Utilizatori";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private ListView lvParticipants;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem utilizatoriToolStripMenuItem;
        private ToolStripMenuItem grupuriToolStripMenuItem;
        private ToolStripMenuItem roluriToolStripMenuItem;
    }
}