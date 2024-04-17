namespace Account
{
    partial class FrmAccount
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
            button2 = new Button();
            panel2 = new Panel();
            btnLogOut = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            TxtBxPassword = new TextBox();
            TxtBxEmail = new TextBox();
            TxtBxUserName = new TextBox();
            BtnUpdate = new Button();
            BtnSave = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1315, 17);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 0;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 80);
            panel2.TabIndex = 1;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Right;
            btnLogOut.BackColor = Color.FromArgb(192, 192, 255);
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatAppearance.BorderColor = Color.White;
            btnLogOut.FlatAppearance.MouseOverBackColor = Color.White;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(715, 18);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(75, 35);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 24);
            label1.Name = "label1";
            label1.Size = new Size(95, 32);
            label1.TabIndex = 0;
            label1.Text = "Logo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 118);
            label3.Name = "label3";
            label3.Size = new Size(92, 18);
            label3.TabIndex = 20;
            label3.Text = "User Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 200);
            label2.Name = "label2";
            label2.Size = new Size(74, 18);
            label2.TabIndex = 18;
            label2.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 157);
            label4.Name = "label4";
            label4.Size = new Size(51, 18);
            label4.TabIndex = 16;
            label4.Text = "Email: ";
            // 
            // TxtBxPassword
            // 
            TxtBxPassword.Enabled = false;
            TxtBxPassword.Font = new Font("Segoe UI", 12F);
            TxtBxPassword.Location = new Point(118, 195);
            TxtBxPassword.Margin = new Padding(5);
            TxtBxPassword.Name = "TxtBxPassword";
            TxtBxPassword.Size = new Size(250, 29);
            TxtBxPassword.TabIndex = 23;
            TxtBxPassword.Text = "admin";
            // 
            // TxtBxEmail
            // 
            TxtBxEmail.Enabled = false;
            TxtBxEmail.Font = new Font("Segoe UI", 12F);
            TxtBxEmail.Location = new Point(118, 152);
            TxtBxEmail.Margin = new Padding(5);
            TxtBxEmail.Name = "TxtBxEmail";
            TxtBxEmail.Size = new Size(250, 29);
            TxtBxEmail.TabIndex = 24;
            TxtBxEmail.Text = "admin";
            // 
            // TxtBxUserName
            // 
            TxtBxUserName.Enabled = false;
            TxtBxUserName.Font = new Font("Segoe UI", 12F);
            TxtBxUserName.Location = new Point(118, 113);
            TxtBxUserName.Margin = new Padding(5);
            TxtBxUserName.Name = "TxtBxUserName";
            TxtBxUserName.Size = new Size(250, 29);
            TxtBxUserName.TabIndex = 25;
            TxtBxUserName.Text = "admin";
            // 
            // BtnUpdate
            // 
            BtnUpdate.Cursor = Cursors.Hand;
            BtnUpdate.FlatAppearance.BorderColor = Color.Blue;
            BtnUpdate.FlatAppearance.MouseDownBackColor = Color.Blue;
            BtnUpdate.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(118, 251);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(100, 35);
            BtnUpdate.TabIndex = 27;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnSave
            // 
            BtnSave.Cursor = Cursors.Hand;
            BtnSave.FlatAppearance.BorderColor = Color.Green;
            BtnSave.FlatAppearance.MouseDownBackColor = Color.Green;
            BtnSave.FlatAppearance.MouseOverBackColor = Color.Green;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSave.Location = new Point(268, 251);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 35);
            BtnSave.TabIndex = 28;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // FrmAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSave);
            Controls.Add(BtnUpdate);
            Controls.Add(TxtBxUserName);
            Controls.Add(TxtBxEmail);
            Controls.Add(TxtBxPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(panel2);
            Name = "FrmAccount";
            Text = "Account";
            FormClosed += FrmAccount_FormClosed;
            Load += FrmAccount_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Panel panel2;
        private Button btnLogOut;
        private Label label1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox TxtBxPassword;
        private TextBox TxtBxEmail;
        private TextBox TxtBxUserName;
        private Button BtnUpdate;
        private Button BtnSave;
    }
}