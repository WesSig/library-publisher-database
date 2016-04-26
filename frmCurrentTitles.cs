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
    public partial class frmCurrentTitles : Form
    {
        public frmCurrentTitles()
        {
            InitializeComponent();
        }

        private void titlesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.titlesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pubsDataSet);
        }

        private void frmCurrentTitles_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'pubsDataSet.titles' table
            this.titlesTableAdapter.Fill(this.pubsDataSet.titles);
        }

        private void toolStripSortTitle_Click(object sender, EventArgs e)
        {
            this.titlesTableAdapter.FillByTitlesAscending(this.pubsDataSet.titles);
        }

        private void toolStripSortPrice_Click(object sender, EventArgs e)
        {
            this.titlesTableAdapter.FillByPrice(this.pubsDataSet.titles);
        }

        private void toolStripSortType_Click(object sender, EventArgs e)
        {
            this.titlesTableAdapter.FillByType(this.pubsDataSet.titles);
        }
     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //search function is updated as text is inputed into text box
            this.titlesTableAdapter.FillBySearch(this.pubsDataSet.titles, textBox1.Text);
        }

        private void toolStripTotalSales_Click(object sender, EventArgs e)
        {
            decimal totalSales;

            totalSales = (decimal)this.titlesTableAdapter.TotalSales();

            //displays Total Sales in a Message Box
            MessageBox.Show("Total YTD sales of each title is: " + totalSales.ToString("c")); 
        }
    }
}
