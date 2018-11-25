using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q_ERP
{
    public partial class ListData : Form
    {
        public ListData()
        {
            InitializeComponent();
        }

        private void ListData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qERPDataSet1.Foods' table. You can move, or remove it, as needed.
            this.foodsTableAdapter1.Fill(this.qERPDataSet1.Foods);
            // TODO: This line of code loads data into the 'qERPDataSet.Foods' table. You can move, or remove it, as needed.
            this.foodsTableAdapter.Fill(this.qERPDataSet.Foods);

        }
    }
}
