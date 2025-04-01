using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Bookstore
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Use relative database path
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bookstore.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Books WHERE Id = @ID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    int Id = Convert.ToInt32(txtID.Text);
                    cmd.Parameters.AddWithValue("@Id", Id);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Book deleted!", "Great success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
            }
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}