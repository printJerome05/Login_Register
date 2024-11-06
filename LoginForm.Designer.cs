namespace Login_Register
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            pctrLock = new PictureBox();
            pctrUnlock = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            btnRegister = new Button();
            pictureBox4 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            btnSettings = new Button();
            label1 = new Label();
            lblCreatedBy = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrLock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrUnlock).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pctrLock
            // 
            pctrLock.Image = (Image)resources.GetObject("pctrLock.Image");
            pctrLock.Location = new Point(80, 71);
            pctrLock.Name = "pctrLock";
            pctrLock.Size = new Size(32, 32);
            pctrLock.SizeMode = PictureBoxSizeMode.CenterImage;
            pctrLock.TabIndex = 1;
            pctrLock.TabStop = false;
            pctrLock.Click += pctrLock_Click;
            // 
            // pctrUnlock
            // 
            pctrUnlock.Image = (Image)resources.GetObject("pctrUnlock.Image");
            pctrUnlock.Location = new Point(80, 71);
            pctrUnlock.Name = "pctrUnlock";
            pctrUnlock.Size = new Size(32, 32);
            pctrUnlock.SizeMode = PictureBoxSizeMode.CenterImage;
            pctrUnlock.TabIndex = 2;
            pctrUnlock.TabStop = false;
            pctrUnlock.Click += pctrUnlock_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(231, 236, 237);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(118, 38);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(200, 22);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(231, 236, 237);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(118, 77);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(200, 22);
            txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(80, 126);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 37);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(231, 236, 237);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(pctrLock);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(pctrUnlock);
            panel1.Location = new Point(174, 309);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 193);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(118, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 2);
            panel3.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(118, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 2);
            panel2.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Blue;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.White;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(211, 126);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(107, 37);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(234, 84);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(278, 256);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderColor = Color.White;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.Location = new Point(12, 12);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(53, 45);
            btnSettings.TabIndex = 1;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(573, 557);
            label1.Name = "label1";
            label1.Size = new Size(24, 21);
            label1.TabIndex = 11;
            label1.Text = "©";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.BackColor = Color.Transparent;
            lblCreatedBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreatedBy.ForeColor = Color.White;
            lblCreatedBy.Location = new Point(594, 557);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(24, 21);
            lblCreatedBy.TabIndex = 12;
            lblCreatedBy.Text = "©";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 96, 128);
            ClientSize = new Size(747, 587);
            Controls.Add(lblCreatedBy);
            Controls.Add(label1);
            Controls.Add(btnSettings);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(763, 626);
            MinimumSize = new Size(763, 626);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            KeyDown += LoginForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrLock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrUnlock).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pctrLock;
        private PictureBox pctrUnlock;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Panel panel1;
        private Button btnRegister;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Panel panel2;
        private ErrorProvider errorProvider1;
        private Button btnSettings;
        private Label label1;
        private Label lblCreatedBy;
    }
}