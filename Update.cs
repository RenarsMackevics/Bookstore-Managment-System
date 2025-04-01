using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Update_Load(object sender, EventArgs e)
        {
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Use relative database path
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bookstore.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";

            decimal price = Convert.ToDecimal(txtPrice.Text);
            decimal stock = Convert.ToDecimal(txtStock.Text);
            int ID = Convert.ToInt32(txtID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Books SET Title = @Title, Author = @Author, Genre = @Genre, Price = @Price, Stock = @Stock WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@ID", ID);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Database updated successfully, please refresh the table (View all)!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}