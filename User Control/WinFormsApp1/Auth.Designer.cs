namespace WinFormsApp1
{
    partial class Auth
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbUser = new TextBox();
            tbPassword = new TextBox();
            lblUser = new Label();
            lblPassword = new Label();
            lblTitle = new Label();
            btnAuth = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // tbUser
            // 
            tbUser.Location = new Point(136, 63);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(159, 27);
            tbUser.TabIndex = 0;
            tbUser.TextChanged += tbUser_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(136, 112);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(159, 27);
            tbPassword.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(37, 66);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(38, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "User";
            lblUser.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(37, 112);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(37, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 20);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Please insert your credentials";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnAuth
            // 
            btnAuth.Location = new Point(107, 171);
            btnAuth.Name = "btnAuth";
            btnAuth.Size = new Size(157, 30);
            btnAuth.TabIndex = 5;
            btnAuth.Text = "Login";
            btnAuth.UseVisualStyleBackColor = true;
            btnAuth.Click += btnAuth_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(25, 154);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 6;
            lblError.Click += label1_Click_1;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblError);
            Controls.Add(btnAuth);
            Controls.Add(lblTitle);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Controls.Add(tbPassword);
            Controls.Add(tbUser);
            Name = "Auth";
            Size = new Size(382, 231);
            Load += Auth_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUser;
        private TextBox tbPassword;
        private Label lblUser;
        private Label lblPassword;
        private Label lblTitle;
        private Button btnAuth;
        private Label lblError;
    }
}
