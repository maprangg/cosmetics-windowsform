using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Q_ERP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.connectionDatabase();
            string sql = "SELECT* FROM  Users WHERE Username=@UserName AND Password=@Password";
            SqlCommand sqlCommand = new SqlCommand(sql, Connection.connection);
            sqlCommand.Parameters.Add(new SqlParameter("UserName", username.Text));
            sqlCommand.Parameters.Add(new SqlParameter("Password", password.Text));
            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.HasRows) {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else {
                MessageBox.Show("Please check Username and Password again.");
            }
            reader.Close();
        }
    }
}
