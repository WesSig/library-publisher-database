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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnDisplayTitles_Click(object sender, EventArgs e)
        {
            frmCurrentTitles myCurrentTitles = new frmCurrentTitles();

            myCurrentTitles.ShowDialog(); 
        }

        private void btnDisplayAuthorData_Click(object sender, EventArgs e)
        {
            frmAuthorData myAuthorData = new frmAuthorData();

            myAuthorData.ShowDialog(); 
        }

        private void btnDisplayStores_Click(object sender, EventArgs e)
        {
            frmStoreMain myStoreMain = new frmStoreMain();

            myStoreMain.ShowDialog(); 
        }

        private void btnDisplayJobs_Click(object sender, EventArgs e)
        {
            frmJobsMain myJobsMain = new frmJobsMain();

            myJobsMain.ShowDialog(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        //this makes the pictures clickable as well, they connect
        //with their corresponding buttons
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCurrentTitles myCurrentTitles = new frmCurrentTitles();

            myCurrentTitles.ShowDialog(); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAuthorData myAuthorData = new frmAuthorData();

            myAuthorData.ShowDialog(); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmStoreMain myStoreMain = new frmStoreMain();

            myStoreMain.ShowDialog(); 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmJobsMain myJobsMain = new frmJobsMain();

            myJobsMain.ShowDialog(); 
        }
    }
}
