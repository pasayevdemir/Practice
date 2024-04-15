namespace Account
{
    partial class Login
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
            lblExit = new LinkLabel();
            btnRegister = new Button();
            btnLogin = new Button();
            txtBxPassword = new TextBox();
            label3 = new Label();
            txtBxLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblExit);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtBxPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBxLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(100, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 400);
            panel1.TabIndex = 1;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(184, 349);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(33, 20);
            lblExit.TabIndex = 7;
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
            btnRegister.Location = new Point(75, 278);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 35);
            btnRegister.TabIndex = 6;
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
            btnLogin.Location = new Point(180, 278);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(145, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtBxPassword
            // 
            txtBxPassword.Font = new Font("Segoe UI", 12F);
            txtBxPassword.Location = new Point(75, 227);
            txtBxPassword.Name = "txtBxPassword";
            txtBxPassword.Size = new Size(250, 29);
            txtBxPassword.TabIndex = 4;
            txtBxPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 206);
            label3.Name = "label3";
            label3.Size = new Size(69, 18);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtBxLogin
            // 
            txtBxLogin.Font = new Font("Segoe UI", 12F);
            txtBxLogin.Location = new Point(75, 155);
            txtBxLogin.Name = "txtBxLogin";
            txtBxLogin.Size = new Size(250, 29);
            txtBxLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 134);
            label2.Name = "label2";
            label2.Size = new Size(41, 18);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 50);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 0;
            label1.Text = "Sign IN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 221, 221);
            ClientSize = new Size(600, 500);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(600, 500);
            MinimumSize = new Size(600, 500);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel lblExit;
        private Button btnRegister;
        private Button btnLogin;
        private TextBox txtBxPassword;
        private Label label3;
        private TextBox txtBxLogin;
        private Label label2;
        private Label label1;
    }
}