using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q_ERP
{
    public partial class Buy : Form
    {
        public string CosmeticID, CosmeticName, CosmeticPrice, CosmeticType, CosmeticTypeID;
        public bool IsSelect = false;
        public Buy()
        {
            InitializeComponent();
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            Connection.connectionDatabase();
            string sql = "select c.CosmeticID as ID,c.Name as Name,t.name as Type,c.Price as Price,c.Quantity as Quantity, c.Type as TypeID FROM Cosmetics c INNER JOIN CosmeticsType t ON t.TypeID= c.Type order by c.CosmeticID";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, Connection.connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IsSelect = true;
            Int32 row_current;
            if (((dataGridView1 != null)) && (dataGridView1.RowCount > 0))
            {
                if (dataGridView1.CurrentRow != null)
                {
                    row_current = dataGridView1.CurrentRow.Index;
                }
                else
                {
                    row_current = 0;
                }
                try
                {
                    CosmeticID = dataGridView1[0, row_current].Value.ToString();
                    CosmeticName = dataGridView1[1, row_current].Value.ToString();
                    CosmeticType = dataGridView1[2, row_current].Value.ToString();
                    CosmeticPrice = dataGridView1[3, row_current].Value.ToString();
                    CosmeticTypeID = dataGridView1[5, row_current].Value.ToString();
                    this.Close();
                }
                catch
                {
                    CosmeticID = "";
                }
            }
        }
       
    }
}
