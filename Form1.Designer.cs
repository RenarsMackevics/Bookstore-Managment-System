namespace Bookstore
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Name = new Label();
            Author = new Label();
            label3 = new Label();
            label4 = new Label();
            Stock = new Label();
            txtName = new TextBox();
            txtAuthor = new TextBox();
            txtGenre = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            View = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name.Location = new Point(59, 64);
            Name.Name = "Name";
            Name.Size = new Size(58, 28);
            Name.TabIndex = 0;
            Name.Text = "Title :";
            Name.Click += Title_Click;
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Font = new Font("Segoe UI", 12F);
            Author.Location = new Point(55, 107);
            Author.Name = "Author";
            Author.Size = new Size(77, 28);
            Author.TabIndex = 1;
            Author.Text = "Author:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(55, 149);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 2;
            label3.Text = "Genre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(65, 190);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 3;
            label4.Text = "Price :";
            // 
            // Stock
            // 
            Stock.AutoSize = true;
            Stock.Font = new Font("Segoe UI", 12F);
            Stock.Location = new Point(55, 237);
            Stock.Name = "Stock";
            Stock.Size = new Size(69, 28);
            Stock.TabIndex = 4;
            Stock.Text = "Stock :";
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(234, 27);
            txtName.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(138, 111);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(234, 27);
            txtAuthor.TabIndex = 6;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(138, 153);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(234, 27);
            txtGenre.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(138, 194);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(234, 27);
            txtPrice.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(138, 241);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(234, 27);
            txtStock.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(421, 241);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(544, 241);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(667, 241);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 306);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(969, 364);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // View
            // 
            View.Location = new Point(793, 237);
            View.Name = "View";
            View.Size = new Size(94, 29);
            View.TabIndex = 15;
            View.Text = "View all";
            View.UseVisualStyleBackColor = true;
            View.Click += View_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 682);
            Controls.Add(View);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtGenre);
            Controls.Add(txtAuthor);
            Controls.Add(txtName);
            Controls.Add(Stock);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Author);
            Controls.Add(Name);
            Name.Text = "Title";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name;
        private Label Author;
        private Label label3;
        private Label label4;
        private Label Stock;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtName;
        private TextBox txtAuthor;
        private TextBox txtGenre;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button View;
    }
}
