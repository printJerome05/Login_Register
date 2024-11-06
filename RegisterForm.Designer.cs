namespace Login_Register
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            panel1 = new Panel();
            panel6 = new Panel();
            pictureBox5 = new PictureBox();
            btnRegister = new Button();
            panel5 = new Panel();
            txtCellphone = new TextBox();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            txtRetype = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            txtPassword = new TextBox();
            pctrLock = new PictureBox();
            panel2 = new Panel();
            dtBirthdate = new DateTimePicker();
            pictureBox2 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrLock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(146, 210, 254);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(74, 37);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(200, 22);
            txtUsername.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(146, 210, 254);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(txtCellphone);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txtRetype);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(pctrLock);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(dtBirthdate);
            panel1.Location = new Point(31, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 341);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(74, 258);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 2);
            panel6.TabIndex = 23;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(36, 228);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
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
            btnRegister.Location = new Point(36, 280);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(238, 37);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(74, 208);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 2);
            panel5.TabIndex = 20;
            // 
            // txtCellphone
            // 
            txtCellphone.BackColor = Color.FromArgb(146, 210, 254);
            txtCellphone.BorderStyle = BorderStyle.None;
            txtCellphone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCellphone.Location = new Point(74, 185);
            txtCellphone.Name = "txtCellphone";
            txtCellphone.PlaceholderText = "09xxxxxxx";
            txtCellphone.Size = new Size(200, 22);
            txtCellphone.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(36, 178);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(74, 160);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 2);
            panel4.TabIndex = 17;
            // 
            // txtRetype
            // 
            txtRetype.BackColor = Color.FromArgb(146, 210, 254);
            txtRetype.BorderStyle = BorderStyle.None;
            txtRetype.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRetype.Location = new Point(74, 137);
            txtRetype.Name = "txtRetype";
            txtRetype.PlaceholderText = "Retype - Password";
            txtRetype.Size = new Size(200, 22);
            txtRetype.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(36, 130);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(74, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 2);
            panel3.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(146, 210, 254);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(74, 90);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(200, 22);
            txtPassword.TabIndex = 2;
            // 
            // pctrLock
            // 
            pctrLock.Image = (Image)resources.GetObject("pctrLock.Image");
            pctrLock.Location = new Point(36, 83);
            pctrLock.Name = "pctrLock";
            pctrLock.Size = new Size(32, 32);
            pctrLock.SizeMode = PictureBoxSizeMode.CenterImage;
            pctrLock.TabIndex = 11;
            pctrLock.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(74, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 2);
            panel2.TabIndex = 10;
            // 
            // dtBirthdate
            // 
            dtBirthdate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtBirthdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtBirthdate.Location = new Point(74, 235);
            dtBirthdate.Name = "dtBirthdate";
            dtBirthdate.Size = new Size(200, 25);
            dtBirthdate.TabIndex = 24;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(337, 315);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(395, 596);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(411, 635);
            MinimumSize = new Size(411, 635);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += RegisterForm_Load;
            KeyDown += RegisterForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrLock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtPassword;
        private PictureBox pctrLock;
        private Panel panel4;
        private TextBox txtRetype;
        private PictureBox pictureBox3;
        private Panel panel5;
        private TextBox txtCellphone;
        private PictureBox pictureBox4;
        private Button btnRegister;
        private ErrorProvider errorProvider1;
        private Panel panel6;
        private PictureBox pictureBox5;
        private DateTimePicker dtBirthdate;
    }
}