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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btmanage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage manage = new Manage();
            manage.Show();
        }

        private void btorder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order order = new Order();
            order.Show();
        }
    }
}
