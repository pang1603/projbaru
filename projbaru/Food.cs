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
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void menuItemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuItemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void menuItemBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.menuItemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Food_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.MenuItem' table. You can move, or remove it, as needed.
            this.menuItemTableAdapter.Fill(this.dataSet1.MenuItem);

        }

        private void pictureBoxFood_Click(object sender, EventArgs e)
        {

        }
    }
}


