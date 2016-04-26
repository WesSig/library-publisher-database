using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; 

namespace PubsFinalProject
{
    public partial class frmEditAuthorData : Form
    {
        public frmEditAuthorData()
        {
            InitializeComponent();
        }

        private void authorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //validate entries here 
            string authID;
            authID = txtAuthorID.Text;
            string SSNPattern = @"^\d{3}\-?\d{2}\-?\d{4}$";
            Regex regex = new Regex(SSNPattern);
            bool idMatch = regex.IsMatch(authID);

            string phoneNum;
            phoneNum = txtPhone.Text; 
            string phonePattern = @"(\([2-9]\d\d\)|[2-9]\d\d) ?[-.,]? ?[2-9]\d\d ?[-.,]? ?\d{4}";
            Regex phoneRegex = new Regex(phonePattern);
            bool phoneMatch = phoneRegex.IsMatch(phoneNum);

            string zipCode;
            zipCode = txtZip.Text;
            string zipCodePattern = @"^\d{5}-\d{4}|\d{5}|[A-Z]\d[A-Z] \d[A-Z]\d$";
            Regex zipRegex = new Regex(zipCodePattern);
            bool zipMatch = zipRegex.IsMatch(zipCode);

            if (idMatch == false)
            {
                MessageBox.Show("Please enter a AuthorId formatting like this: ###-##-####");
            }
            else if(phoneMatch == false)
            {
                MessageBox.Show("Please enter a 10 digit phone number");
            }
            else if (zipMatch == false)
            {
                MessageBox.Show("Please enter a 5 digit zip code");
            }
            else
            {
                this.Validate();
                this.authorsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.pubsDataSet);
                MessageBox.Show("Record successfully altered"); 
            } 
        }

        private void frmEditAuthorData_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'pubsDataSet.authors' table
            this.authorsTableAdapter.Fill(this.pubsDataSet.authors);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            chbxContract.Checked = true; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pubsDataSet);
            MessageBox.Show("Record successfully removed");
        }
    }
}
