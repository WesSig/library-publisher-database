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
    public partial class frmAuthorData : Form
    {
        public frmAuthorData()
        {
            InitializeComponent();
        }

        private void authorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pubsDataSet);
        }

        private void frmAuthorData_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'pubsDataSet.authors' table
            this.authorsTableAdapter.Fill(this.pubsDataSet.authors);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditAuthorData myfrmEdit = new frmEditAuthorData();

            myfrmEdit.ShowDialog();

            //re-loads the updated table
            this.authorsTableAdapter.Fill(this.pubsDataSet.authors); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
