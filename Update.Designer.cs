﻿namespace Bookstore
{
    partial class Update
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtGenre = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 70);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "ID(required) -";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 112);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Title -";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 154);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Author -";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 196);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Genre -";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 241);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "Price -";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 291);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 5;
            label6.Text = "Stock - ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 28);
            label7.Name = "label7";
            label7.Size = new Size(238, 20);
            label7.TabIndex = 6;
            label7.Text = "Enter the data you want to update.";
            // 
            // txtID
            // 
            txtID.Location = new Point(137, 70);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 7;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(137, 112);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 8;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(137, 154);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 9;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(137, 196);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(125, 27);
            txtGenre.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(137, 241);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 11;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(137, 288);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(304, 329);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 387);
            Controls.Add(button1);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtGenre);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Update";
            Text = "Update";
            Load += Update_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox txtID;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtGenre;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Button button2;
        private Button button1;
    }
}