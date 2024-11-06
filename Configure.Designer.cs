namespace Login_Register
{
    partial class Configure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configure));
            User = new Label();
            txtUser = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            txtServer = new TextBox();
            SuspendLayout();
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            User.Location = new Point(108, 100);
            User.Name = "User";
            User.Size = new Size(45, 21);
            User.TabIndex = 0;
            User.Text = "User:";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(159, 92);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(274, 29);
            txtUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(149, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 25);
            label1.TabIndex = 2;
            label1.Text = "Mysql Database Setup";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(159, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(274, 45);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 137);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(95, 63);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 5;
            label3.Text = "Server:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(159, 129);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(274, 29);
            txtPassword.TabIndex = 2;
            // 
            // txtServer
            // 
            txtServer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtServer.Location = new Point(159, 55);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(274, 29);
            txtServer.TabIndex = 0;
            // 
            // Configure
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(507, 254);
            Controls.Add(txtServer);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(User);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(523, 293);
            MinimumSize = new Size(523, 293);
            Name = "Configure";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setup";
            Load += Configure_Load;
            KeyDown += Configure_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label User;
        private TextBox txtUser;
        private Label label1;
        private Button btnSave;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtServer;
    }
}