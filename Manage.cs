using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q_ERP
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            this.cosmeticsTypeTableAdapter.Fill(this.qERPDataSet1.CosmeticsType);
            Connection.connectionDatabase();
            string sql = "select c.CosmeticID as ID,c.Name as Name,t.name as Type,c.Price as Price,c.Quantity as Quantity FROM Cosmetics c INNER JOIN CosmeticsType t ON t.TypeID= c.Type order by c.CosmeticID";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, Connection.connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            GridViewManage.DataSource = table;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Connection.connectionDatabase();
            string sql = "SELECT c.CosmeticID as ID,c.Name as Name,t.name as Type,c.Price as Price,c.Quantity as Quantity FROM Cosmetics c INNER JOIN CosmeticsType t ON t.TypeID= c.Type where c.CosmeticID like '%" + tbFind.Text + "%' OR c.Name like '%" + tbFind.Text + "%' order by c.CosmeticID";
            SqlCommand sqlCommand = new SqlCommand(sql, Connection.connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            GridViewManage.DataSource = table;
            ClearData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You want To Delete?", "Yes");
            if (result == DialogResult.Cancel)
            {
                return;
            }

            Connection.connectionDatabase();
            SqlTransaction transaction;
            transaction = Connection.connection.BeginTransaction();
            try
            {
                string SqlDelete = "DELETE FROM Cosmetics WHERE CosmeticID = " + tbID.Text + " ";
                SqlCommand objCommand = new SqlCommand(SqlDelete, Connection.connection,transaction);
                int r = (int)objCommand.ExecuteNonQuery();
                if (r == -1)
                {
                    MessageBox.Show("Something Problem");
                }
                else
                {
                    MessageBox.Show("Success");
                }
                transaction.Commit();
            }
            catch (SqlException sqlError)
            {
                transaction.Rollback();
            }

            GetData();
            ClearData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "" || tbName.Text == "" || tbQuantity.Text == "" || tbPrice.Text == "") {
                return;
            }

            Connection.connectionDatabase();
            SqlTransaction transaction;
            transaction = Connection.connection.BeginTransaction();

            try
            {
                string SqlInsert = "INSERT INTO Cosmetics(CosmeticID,Name,Type,Quantity,Price) VALUES(@ID,@Name,@Type,@Quantity,@Price)";
                SqlCommand objCommand = new SqlCommand(SqlInsert, Connection.connection, transaction);
                objCommand.Parameters.AddWithValue("ID", tbID.Text);
                objCommand.Parameters.AddWithValue("Name", tbName.Text);
                objCommand.Parameters.AddWithValue("Type", cbType.SelectedValue);
                objCommand.Parameters.AddWithValue("Quantity", tbQuantity.Text);
                objCommand.Parameters.AddWithValue("Price", tbPrice.Text);
                int result = (int)objCommand.ExecuteNonQuery();
                if (result == -1)
                {
                    MessageBox.Show("Something Problem");
                }
                else
                {
                    MessageBox.Show("Success");
                }
                transaction.Commit();
            }
            catch (SqlException sqlError)
            {
                transaction.Rollback();
            }

            GetData();
            ClearData();
        }

        private void ClearData()
        {
            tbFind.Text = "";
            tbID.Text = "";
            tbName.Text = "";
            tbQuantity.Text = "";
            tbPrice.Text = "";
        }      
    }

}
