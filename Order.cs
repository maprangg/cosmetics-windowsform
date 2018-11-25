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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }
        private void GetData()
        {
            Connection.connectionDatabase();
            string sql = "select c.CosmeticID as ID,c.Name as Name,t.name as Type,c.Price as Price,c.Quantity as Quantity FROM Cosmetics c INNER JOIN CosmeticsType t ON t.TypeID= c.Type where c.CosmeticID = '" + "" + "' order by c.CosmeticID";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, Connection.connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
           // dataGridView1.DataSource = table;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Buy form = new Buy();
            form.ShowDialog();
            if (form.IsSelect)
            {
                lbname.Text = form.CosmeticName;
                lbtype.Text = form.CosmeticType;
                lbprice.Text = form.CosmeticPrice;
                quantity.Focus();
            } 
           
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            string[] row = { lbname.Text, lbtype.Text, quantity.Value.ToString(),lbprice.Text };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);

            int quan = 0;
            int price = 0;
            int total = 0;
            for (int i = 0; i <= listView1.Items.Count - 1; i++)
            {
                quan = Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
                price = Convert.ToInt32(listView1.Items[i].SubItems[3].Text);
                total += quan * price;

            }
            lbamount.Text = Convert.ToString(total);

        }

        private void btbill_Click(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
