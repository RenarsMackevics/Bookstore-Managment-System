namespace Bookstore
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
            backtoregister = new LinkLabel();
            log = new Button();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ShowPass = new CheckBox();
            SuspendLayout();
            // 
            // backtoregister
            // 
            backtoregister.AutoSize = true;
            backtoregister.LinkColor = Color.Black;
            backtoregister.Location = new Point(87, 338);
            backtoregister.Name = "backtoregister";
            backtoregister.Size = new Size(368, 20);
            backtoregister.TabIndex = 19;
            backtoregister.TabStop = true;
            backtoregister.Text = "If you don't have an account PRESS THIS TO REGISTER.";
            backtoregister.LinkClicked += backtoregister_LinkClicked;
            // 
            // log
            // 
            log.BackColor = Color.Transparent;
            log.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            log.Location = new Point(344, 279);
            log.Name = "log";
            log.Size = new Size(94, 29);
            log.TabIndex = 17;
            log.Text = "Login";
            log.UseVisualStyleBackColor = false;
            log.Click += log_Click;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.InactiveCaption;
            txtpassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(230, 210);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(208, 27);
            txtpassword.TabIndex = 15;
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.InactiveCaption;
            txtusername.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(230, 154);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(208, 27);
            txtusername.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(122, 209);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 12;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 153);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 11;
            label2.Text = "Username :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 73);
            label1.Name = "label1";
            label1.Size = new Size(352, 31);
            label1.TabIndex = 10;
            label1.Text = "Bookstore management system";
            // 
            // ShowPass
            // 
            ShowPass.AutoSize = true;
            ShowPass.Location = new Point(230, 243);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(132, 24);
            ShowPass.TabIndex = 20;
            ShowPass.Text = "Show Password";
            ShowPass.UseVisualStyleBackColor = true;
            ShowPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(566, 450);
            Controls.Add(ShowPass);
            Controls.Add(backtoregister);
            Controls.Add(log);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel backtoregister;
        private Button log;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox ShowPass;
    }
}