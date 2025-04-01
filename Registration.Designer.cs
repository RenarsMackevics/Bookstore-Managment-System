namespace Bookstore
{
    partial class Registration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            txtconfirmpassword = new TextBox();
            register = new Button();
            login = new LinkLabel();
            ShowPass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 36);
            label1.Name = "label1";
            label1.Size = new Size(352, 31);
            label1.TabIndex = 0;
            label1.Text = "Bookstore management system";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 121);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(110, 177);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 242);
            label4.Name = "label4";
            label4.Size = new Size(180, 25);
            label4.TabIndex = 3;
            label4.Text = " Confirm Password :";
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.InactiveCaption;
            txtusername.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(218, 122);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(208, 27);
            txtusername.TabIndex = 4;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.InactiveCaption;
            txtpassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(218, 178);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(208, 27);
            txtpassword.TabIndex = 5;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // txtconfirmpassword
            // 
            txtconfirmpassword.BackColor = SystemColors.InactiveCaption;
            txtconfirmpassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtconfirmpassword.Location = new Point(218, 242);
            txtconfirmpassword.Name = "txtconfirmpassword";
            txtconfirmpassword.PasswordChar = '*';
            txtconfirmpassword.Size = new Size(208, 27);
            txtconfirmpassword.TabIndex = 6;
            txtconfirmpassword.TextChanged += txtconfirmpassword_TextChanged;
            // 
            // register
            // 
            register.BackColor = Color.Transparent;
            register.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            register.Location = new Point(346, 300);
            register.Name = "register";
            register.Size = new Size(94, 29);
            register.TabIndex = 7;
            register.Text = "Register";
            register.UseVisualStyleBackColor = false;
            register.Click += button1_Click;
            // 
            // login
            // 
            login.AutoSize = true;
            login.LinkColor = Color.Black;
            login.Location = new Point(148, 346);
            login.Name = "login";
            login.Size = new Size(292, 20);
            login.TabIndex = 9;
            login.TabStop = true;
            login.Text = "If you have an account, press this to LOGIN.";
            login.LinkClicked += linkLabel1_LinkClicked;
            // 
            // ShowPass
            // 
            ShowPass.AutoSize = true;
            ShowPass.Location = new Point(218, 211);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(132, 24);
            ShowPass.TabIndex = 10;
            ShowPass.Text = "Show Password";
            ShowPass.UseVisualStyleBackColor = true;
            ShowPass.CheckedChanged += ShowPass_CheckedChanged;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(566, 450);
            Controls.Add(ShowPass);
            Controls.Add(login);
            Controls.Add(register);
            Controls.Add(txtconfirmpassword);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtusername;
        private TextBox txtpassword;
        private TextBox txtconfirmpassword;
        private Button register;
        private LinkLabel login;
        private CheckBox ShowPass;
    }
}