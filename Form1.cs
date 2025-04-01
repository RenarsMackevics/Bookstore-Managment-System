using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class Home : Form
    {
        private int userId;

        public Home(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bookstore.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True;";

            decimal price = Convert.ToDecimal(txtPrice.Text);
            decimal stock = Convert.ToDecimal(txtStock.Text);

            string insert = "INSERT INTO BOOKS (Title, Author, Genre, Price, Stock, UserId) VALUES(@Title, @Author, @Genre, @Price, @Stock, @UserId)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insert, connection);
                command.Parameters.AddWithValue("@Title", txtName.Text);
                command.Parameters.AddWithValue("@Author", txtAuthor.Text);
                command.Parameters.AddWithValue("@Genre", txtGenre.Text);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Stock", stock);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cleardata();
        }

        private void cleardata()
        {
            txtName.Clear();
            txtAuthor.Clear();
            txtGenre.Clear();
            txtPrice.Clear();
            txtStock.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.ShowDialog();
        }

        private void Title_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void View_Click(object sender, EventArgs e)
        {
            
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bookstore.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True;";

            string query = "SELECT * FROM Books ";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.ShowDialog();
        }
    }
}