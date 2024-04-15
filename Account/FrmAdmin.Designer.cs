namespace Account
{
    partial class FrmAdmin
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
            dtTable = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            txtRepPassword = new TextBox();
            label5 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            btnAddUser = new Button();
            txtBxDeletedUser = new TextBox();
            label4 = new Label();
            btnUserDelete = new Button();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtTable
            // 
            dtTable.AllowUserToAddRows = false;
            dtTable.AllowUserToDeleteRows = false;
            dtTable.AllowUserToOrderColumns = true;
            dtTable.AllowUserToResizeColumns = false;
            dtTable.AllowUserToResizeRows = false;
            dtTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtTable.Columns.AddRange(new DataGridViewColumn[] { ID, UserName, Email, Password });
            dtTable.Dock = DockStyle.Bottom;
            dtTable.Location = new Point(0, 293);
            dtTable.Name = "dtTable";
            dtTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtTable.Size = new Size(800, 210);
            dtTable.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // UserName
            // 
            UserName.HeaderText = "İstifadəçi adı";
            UserName.Name = "UserName";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Password
            // 
            Password.HeaderText = "Parol";
            Password.Name = "Password";
            // 
            // txtRepPassword
            // 
            txtRepPassword.Font = new Font("Segoe UI", 12F);
            txtRepPassword.Location = new Point(12, 204);
            txtRepPassword.Margin = new Padding(5);
            txtRepPassword.Name = "txtRepPassword";
            txtRepPassword.Size = new Size(250, 29);
            txtRepPassword.TabIndex = 23;
            txtRepPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 183);
            label5.Name = "label5";
            label5.Size = new Size(54, 18);
            label5.TabIndex = 22;
            label5.Text = "Repeat";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F);
            txtUserName.Location = new Point(12, 39);
            txtUserName.Margin = new Padding(5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(250, 29);
            txtUserName.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 20;
            label3.Text = "User Name";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(12, 149);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 29);
            txtPassword.TabIndex = 19;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 128);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 18;
            label1.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(12, 94);
            txtEmail.Margin = new Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 29);
            txtEmail.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(41, 18);
            label2.TabIndex = 16;
            label2.Text = "Email";
            // 
            // btnAddUser
            // 
            btnAddUser.Cursor = Cursors.Hand;
            btnAddUser.FlatAppearance.BorderColor = Color.FromArgb(0, 180, 40);
            btnAddUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 180, 40);
            btnAddUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 180, 40);
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddUser.Location = new Point(117, 241);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(145, 35);
            btnAddUser.TabIndex = 24;
            btnAddUser.Text = "User Add";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtBxDeletedUser
            // 
            txtBxDeletedUser.Font = new Font("Segoe UI", 12F);
            txtBxDeletedUser.Location = new Point(28, 110);
            txtBxDeletedUser.Margin = new Padding(5);
            txtBxDeletedUser.Name = "txtBxDeletedUser";
            txtBxDeletedUser.Size = new Size(250, 29);
            txtBxDeletedUser.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 89);
            label4.Name = "label4";
            label4.Size = new Size(82, 18);
            label4.TabIndex = 25;
            label4.Text = "User Name";
            // 
            // btnUserDelete
            // 
            btnUserDelete.Cursor = Cursors.Hand;
            btnUserDelete.FlatAppearance.BorderColor = Color.Red;
            btnUserDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(174, 0, 0);
            btnUserDelete.FlatAppearance.MouseOverBackColor = Color.Red;
            btnUserDelete.FlatStyle = FlatStyle.Flat;
            btnUserDelete.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserDelete.Location = new Point(133, 155);
            btnUserDelete.Name = "btnUserDelete";
            btnUserDelete.Size = new Size(145, 35);
            btnUserDelete.TabIndex = 27;
            btnUserDelete.Text = "User Delete";
            btnUserDelete.UseVisualStyleBackColor = true;
            btnUserDelete.Click += btnUserDelete_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtBxDeletedUser);
            panel1.Controls.Add(btnUserDelete);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(491, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 237);
            panel1.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(87, 29);
            label6.Name = "label6";
            label6.Size = new Size(106, 23);
            label6.TabIndex = 28;
            label6.Text = "Delete User";
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(panel1);
            Controls.Add(btnAddUser);
            Controls.Add(txtRepPassword);
            Controls.Add(label5);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(dtTable);
            Name = "FrmAdmin";
            Text = "FrmAdmin";
            Load += FrmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dtTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtTable;
        private TextBox txtRepPassword;
        private Label label5;
        private TextBox txtUserName;
        private Label label3;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private Button btnAddUser;
        private TextBox txtBxDeletedUser;
        private Label label4;
        private Button btnUserDelete;
        private Panel panel1;
        private Label label6;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
    }
}