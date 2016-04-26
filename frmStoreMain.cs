using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubsFinalProject
{
    public partial class frmStoreMain : Form
    {
        public frmStoreMain()
        {
            InitializeComponent();
        }

        private void storesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pubsDataSet);
        }

        private void frmStoreMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pubsDataSet.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.pubsDataSet.sales);
            // TODO: This line of code loads data into the 'pubsDataSet.stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter.Fill(this.pubsDataSet.stores);
        }
       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.storesTableAdapter.FillByStoreSearch(this.pubsDataSet.stores, txtSearch.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
