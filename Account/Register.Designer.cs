namespace Account
{
    partial class Register
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
            panel1 = new Panel();
            txtRepPassword = new TextBox();
            label5 = new Label();
            lblExit = new LinkLabel();
            btnRegister = new Button();
            btnLogin = new Button();
            label4 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtRepPassword);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblExit);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(50, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 500);
            panel1.TabIndex = 0;
            // 
            // txtRepPassword
            // 
            txtRepPassword.Font = new Font("Segoe UI", 12F);
            txtRepPassword.Location = new Point(125, 307);
            txtRepPassword.Margin = new Padding(5);
            txtRepPassword.Name = "txtRepPassword";
            txtRepPassword.Size = new Size(250, 29);
            txtRepPassword.TabIndex = 15;
            txtRepPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(125, 286);
            label5.Name = "label5";
            label5.Size = new Size(54, 18);
            label5.TabIndex = 14;
            label5.Text = "Repeat";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(234, 449);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(33, 20);
            lblExit.TabIndex = 13;
            lblExit.TabStop = true;
            lblExit.Text = "Exit";
            lblExit.LinkClicked += lblExit_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(0, 180, 40);
            btnRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 180, 40);
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 180, 40);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(230, 378);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(145, 35);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Sign Up";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 140, 200);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 140, 200);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 140, 200);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(125, 378);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 35);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(208, 40);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 9;
            label4.Text = "Sign Up";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F);
            txtUserName.Location = new Point(125, 138);
            txtUserName.Margin = new Padding(5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(250, 29);
            txtUserName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(125, 117);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 7;
            label3.Text = "User Name";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(125, 252);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 29);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 231);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 5;
            label1.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(125, 193);
            txtEmail.Margin = new Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 29);
            txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(125, 172);
            label2.Name = "label2";
            label2.Size = new Size(41, 18);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 221, 221);
            ClientSize = new Size(600, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtEmail;
        private Label label2;
        private Label label4;
        private TextBox txtUserName;
        private Label label3;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtRepPassword;
        private Label label5;
        private LinkLabel lblExit;
        private Button btnRegister;
        private Button btnLogin;
    }
}