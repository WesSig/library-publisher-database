using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PubsFinalProject
{
    public partial class frmEditJobs : Form
    {
        public frmEditJobs()
        {
            InitializeComponent();
        }

        clsJobs myJobs = new clsJobs();

        List<clsJobs> myJobsList = new List<clsJobs>(); //new list where vairables will be stored 

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //inserting data from input to table
            string cmdString = "SET IDENTITY_INSERT jobs ON INSERT INTO jobs(job_id, job_desc, min_lvl, max_lvl) VALUES (@jobId, @jobdesc, @minlvl, @maxlvl)";

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Pubs.mdf;Integrated Security=True;Connect Timeout=30");

            conn.Close(); 

            foreach (clsJobs job in myJobsList)
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = cmdString;

                    comm.Parameters.AddWithValue("@jobId",job.JobID);
                    comm.Parameters.AddWithValue("@jobdesc",job.JobDesc);
                    comm.Parameters.AddWithValue("@minlvl",job.MinLvl);
                    comm.Parameters.AddWithValue("@maxlvl",job.MaxLvl);

                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Insert Failed" + ex); 
                    }
                }
            }
            MessageBox.Show("Records Added Successfully"); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myJobs = new clsJobs();

            //making sure input is not empty
            if (string.IsNullOrEmpty(txtJobID.Text))
            {
                MessageBox.Show("Please enter a number for JobID"); 
            }
            if (string.IsNullOrEmpty(txtJobDesc.Text))
            {
                MessageBox.Show("Please enter a Job Description");
            }
            if (string.IsNullOrEmpty(txtMinLvl.Text))
            {
                MessageBox.Show("Please enter a number for Min Lvl");
            }
            if (string.IsNullOrEmpty(txtMaxLvl.Text))
            {
                MessageBox.Show("Please enter a number for Max Lvl");
            }
            else
            {
                GetJobsData(myJobs); //calling next method
            }
        }

        private void GetJobsData(clsJobs myJobs)
        {
            myJobs.JobDesc = txtJobDesc.Text;
            myJobs.JobID = txtJobID.Text;

            int minlvl = 0;
            int maxlvl = 0;

            //sending input to variables to be validated later
            if (txtMinLvl.Text != null)
            {
                int.TryParse(txtMinLvl.Text, out minlvl); 
            }
            else
            {
                MessageBox.Show("Please enter a Min Lvl"); 
            }

            if (txtMaxLvl.Text != null)
            {
                int.TryParse(txtMaxLvl.Text, out maxlvl);
            }
            else
            {
                MessageBox.Show("Please enter a Max Lvl");
            }

            //validating minlvl and maxlvl to make sure they are greater than 10
            if (minlvl < 10 || maxlvl < 10)
            {
                MessageBox.Show("Min Lvl and Max Lvl must be atleast 10");
                txtMinLvl.Focus();
            }
            else
            {
                myJobs.MinLvl = minlvl;
                myJobs.MaxLvl = maxlvl;

                myJobsList.Add(myJobs);
                lstbxDisplayEntries.Items.Add(myJobs.JobDesc + "\t" + myJobs.JobID + "\t" + myJobs.MaxLvl + "\t" + myJobs.MinLvl);

                txtJobID.Focus();
                txtJobID.SelectAll();
                txtJobDesc.Text = string.Empty;
                txtMinLvl.Text = string.Empty;
                txtMaxLvl.Text = string.Empty;
            }
        }

        private void btnReturnToTerms_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
