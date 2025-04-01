using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using BCrypt.Net;

namespace Bookstore
{
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bookstore.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True;";
            cn = new SqlConnection(connectionString);
            cn.Open();
        }

        private void log_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtpassword.Text) && !string.IsNullOrWhiteSpace(txtusername.Text))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

                string query = "SELECT * FROM Users WHERE Username = @username";
                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@username", txtusername.Text);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string Hashed = dr["Password"].ToString();
                    int userId = Convert.ToInt32(dr["Id"]);
                    dr.Close();

                    if (BCrypt.Net.BCrypt.Verify(txtpassword.Text, Hashed))
                    {
                        this.Hide();
                        Home home = new Home(userId);
                        home.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter values in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked == true)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void backtoregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }
    }
}