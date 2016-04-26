namespace PubsFinalProject
{
    partial class frmJobsMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label job_idLabel;
            System.Windows.Forms.Label job_descLabel;
            System.Windows.Forms.Label min_lvlLabel;
            System.Windows.Forms.Label max_lvlLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobsMain));
            this.pubsDataSet = new PubsFinalProject.PubsDataSet();
            this.jobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobsTableAdapter = new PubsFinalProject.PubsDataSetTableAdapters.jobsTableAdapter();
            this.tableAdapterManager = new PubsFinalProject.PubsDataSetTableAdapters.TableAdapterManager();
            this.employeeTableAdapter = new PubsFinalProject.PubsDataSetTableAdapters.employeeTableAdapter();
            this.jobsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.job_idTextBox = new System.Windows.Forms.TextBox();
            this.job_descTextBox = new System.Windows.Forms.TextBox();
            this.min_lvlTextBox = new System.Windows.Forms.TextBox();
            this.max_lvlTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditJobs = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            job_idLabel = new System.Windows.Forms.Label();
            job_descLabel = new System.Windows.Forms.Label();
            min_lvlLabel = new System.Windows.Forms.Label();
            max_lvlLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingNavigator)).BeginInit();
            this.jobsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // job_idLabel
            // 
            job_idLabel.AutoSize = true;
            job_idLabel.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            job_idLabel.Location = new System.Drawing.Point(224, 40);
            job_idLabel.Name = "job_idLabel";
            job_idLabel.Size = new System.Drawing.Size(52, 17);
            job_idLabel.TabIndex = 1;
            job_idLabel.Text = "Job ID: ";
            // 
            // job_descLabel
            // 
            job_descLabel.AutoSize = true;
            job_descLabel.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            job_descLabel.Location = new System.Drawing.Point(212, 66);
            job_descLabel.Name = "job_descLabel";
            job_descLabel.Size = new System.Drawing.Size(64, 17);
            job_descLabel.TabIndex = 3;
            job_descLabel.Text = "Job Desc: ";
            // 
            // min_lvlLabel
            // 
            min_lvlLabel.AutoSize = true;
            min_lvlLabel.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            min_lvlLabel.Location = new System.Drawing.Point(469, 40);
            min_lvlLabel.Name = "min_lvlLabel";
            min_lvlLabel.Size = new System.Drawing.Size(58, 17);
            min_lvlLabel.TabIndex = 5;
            min_lvlLabel.Text = "Min Lvl: ";
            // 
            // max_lvlLabel
            // 
            max_lvlLabel.AutoSize = true;
            max_lvlLabel.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            max_lvlLabel.Location = new System.Drawing.Point(468, 66);
            max_lvlLabel.Name = "max_lvlLabel";
            max_lvlLabel.Size = new System.Drawing.Size(59, 17);
            max_lvlLabel.TabIndex = 7;
            max_lvlLabel.Text = "Max Lvl: ";
            // 
            // pubsDataSet
            // 
            this.pubsDataSet.DataSetName = "PubsDataSet";
            this.pubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobsBindingSource
            // 
            this.jobsBindingSource.DataMember = "jobs";
            this.jobsBindingSource.DataSource = this.pubsDataSet;
            // 
            // jobsTableAdapter
            // 
            this.jobsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.discountsTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.jobsTableAdapter = this.jobsTableAdapter;
            this.tableAdapterManager.pub_infoTableAdapter = null;
            this.tableAdapterManager.publishersTableAdapter = null;
            this.tableAdapterManager.royschedTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.storesTableAdapter = null;
            this.tableAdapterManager.titleauthorTableAdapter = null;
            this.tableAdapterManager.titlesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PubsFinalProject.PubsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // jobsBindingNavigator
            // 
            this.jobsBindingNavigator.AddNewItem = null;
            this.jobsBindingNavigator.BindingSource = this.jobsBindingSource;
            this.jobsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jobsBindingNavigator.DeleteItem = null;
            this.jobsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.jobsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jobsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jobsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jobsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jobsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jobsBindingNavigator.Name = "jobsBindingNavigator";
            this.jobsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jobsBindingNavigator.Size = new System.Drawing.Size(907, 25);
            this.jobsBindingNavigator.TabIndex = 0;
            this.jobsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // job_idTextBox
            // 
            this.job_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobsBindingSource, "job_id", true));
            this.job_idTextBox.Location = new System.Drawing.Point(280, 37);
            this.job_idTextBox.Name = "job_idTextBox";
            this.job_idTextBox.Size = new System.Drawing.Size(151, 20);
            this.job_idTextBox.TabIndex = 2;
            // 
            // job_descTextBox
            // 
            this.job_descTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobsBindingSource, "job_desc", true));
            this.job_descTextBox.Location = new System.Drawing.Point(280, 63);
            this.job_descTextBox.Name = "job_descTextBox";
            this.job_descTextBox.Size = new System.Drawing.Size(151, 20);
            this.job_descTextBox.TabIndex = 4;
            // 
            // min_lvlTextBox
            // 
            this.min_lvlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobsBindingSource, "min_lvl", true));
            this.min_lvlTextBox.Location = new System.Drawing.Point(533, 37);
            this.min_lvlTextBox.Name = "min_lvlTextBox";
            this.min_lvlTextBox.Size = new System.Drawing.Size(151, 20);
            this.min_lvlTextBox.TabIndex = 6;
            // 
            // max_lvlTextBox
            // 
            this.max_lvlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobsBindingSource, "max_lvl", true));
            this.max_lvlTextBox.Location = new System.Drawing.Point(533, 63);
            this.max_lvlTextBox.Name = "max_lvlTextBox";
            this.max_lvlTextBox.Size = new System.Drawing.Size(151, 20);
            this.max_lvlTextBox.TabIndex = 8;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "FK__employee__job_id__1BFD2C07";
            this.employeeBindingSource.DataSource = this.jobsBindingSource;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(32, 100);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(844, 204);
            this.employeeDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "emp_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "emp_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fname";
            this.dataGridViewTextBoxColumn2.HeaderText = "fname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "minit";
            this.dataGridViewTextBoxColumn3.HeaderText = "minit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "lname";
            this.dataGridViewTextBoxColumn4.HeaderText = "lname";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "job_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "job_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "job_lvl";
            this.dataGridViewTextBoxColumn6.HeaderText = "job_lvl";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "pub_id";
            this.dataGridViewTextBoxColumn7.HeaderText = "pub_id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "hire_date";
            this.dataGridViewTextBoxColumn8.HeaderText = "hire_date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btnEditJobs
            // 
            this.btnEditJobs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditJobs.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditJobs.Location = new System.Drawing.Point(32, 42);
            this.btnEditJobs.Name = "btnEditJobs";
            this.btnEditJobs.Size = new System.Drawing.Size(93, 41);
            this.btnEditJobs.TabIndex = 10;
            this.btnEditJobs.Text = "Edit Jobs";
            this.btnEditJobs.UseVisualStyleBackColor = true;
            this.btnEditJobs.Click += new System.EventHandler(this.btnEditJobs_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(783, 42);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 41);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Main Form";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmJobsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(907, 322);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditJobs);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(job_idLabel);
            this.Controls.Add(this.job_idTextBox);
            this.Controls.Add(job_descLabel);
            this.Controls.Add(this.job_descTextBox);
            this.Controls.Add(min_lvlLabel);
            this.Controls.Add(this.min_lvlTextBox);
            this.Controls.Add(max_lvlLabel);
            this.Controls.Add(this.max_lvlTextBox);
            this.Controls.Add(this.jobsBindingNavigator);
            this.Name = "frmJobsMain";
            this.Text = "Current Jobs and Employees";
            this.Load += new System.EventHandler(this.frmJobsMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingNavigator)).EndInit();
            this.jobsBindingNavigator.ResumeLayout(false);
            this.jobsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PubsDataSet pubsDataSet;
        private System.Windows.Forms.BindingSource jobsBindingSource;
        private PubsDataSetTableAdapters.jobsTableAdapter jobsTableAdapter;
        private PubsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jobsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private PubsDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox job_idTextBox;
        private System.Windows.Forms.TextBox job_descTextBox;
        private System.Windows.Forms.TextBox min_lvlTextBox;
        private System.Windows.Forms.TextBox max_lvlTextBox;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnEditJobs;
        private System.Windows.Forms.Button btnExit;
    }
}