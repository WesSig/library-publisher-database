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
    public partial class frmJobsMain : Form
    {
        public frmJobsMain()
        {
            InitializeComponent();
        }

        private void jobsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pubsDataSet);
        }

        private void frmJobsMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pubsDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.pubsDataSet.employee);
            // TODO: This line of code loads data into the 'pubsDataSet.jobs' table. You can move, or remove it, as needed.
            this.jobsTableAdapter.Fill(this.pubsDataSet.jobs);
        }

        private void btnDisplayTableOfContents_Click(object sender, EventArgs e)
        {
            frmMainForm myMainForm = new frmMainForm();

            myMainForm.ShowDialog(); 
        }

        private void btnEditJobs_Click(object sender, EventArgs e)
        {
            frmEditJobs myEditJobs = new frmEditJobs();

            myEditJobs.ShowDialog();

            this.jobsTableAdapter.Fill(this.pubsDataSet.jobs);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
