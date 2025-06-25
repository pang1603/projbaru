using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projbaru
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void label111_Click(object sender, EventArgs e)
        {

        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Banks' table. You can move, or remove it, as needed.
            this.banksTableAdapter.Fill(this.dataSet1.Banks);
            // TODO: This line of code loads data into the 'dataSet1.Banks' table. You can move, or remove it, as needed.
            this.banksTableAdapter.Fill(this.dataSet1.Banks);
            // TODO: This line of code loads data into the 'dataSet1.OrderDetail' table. You can move, or remove it, as needed.
            this.orderDetailTableAdapter.Fill(this.dataSet1.OrderDetail);
            // TODO: This line of code loads data into the 'dataSet1.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.dataSet1.Order);

        }

        private void labelFoodName_Click(object sender, EventArgs e)
        {

        }
    }
}
