namespace PubsFinalProject
{
    partial class frmStoreMain
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
            System.Windows.Forms.Label stor_idLabel;
            System.Windows.Forms.Label stor_nameLabel;
            System.Windows.Forms.Label stor_addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreMain));
            this.storesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pubsDataSet = new PubsFinalProject.PubsDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stor_idTextBox = new System.Windows.Forms.TextBox();
            this.stor_nameTextBox = new System.Windows.Forms.TextBox();
            this.stor_addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.storesTableAdapter = new PubsFinalProject.PubsDataSetTableAdapters.storesTableAdapter();
            this.tableAdapterManager = new PubsFinalProject.PubsDataSetTableAdapters.TableAdapterManager();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new PubsFinalProject.PubsDataSetTableAdapters.salesTableAdapter();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            stor_idLabel = new System.Windows.Forms.Label();
            stor_nameLabel = new System.Windows.Forms.Label();
            stor_addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingNavigator)).BeginInit();
            this.storesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stor_idLabel
            // 
            stor_idLabel.AutoSize = true;
            stor_idLabel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stor_idLabel.Location = new System.Drawing.Point(65, 38);
            stor_idLabel.Name = "stor_idLabel";
            stor_idLabel.Size = new System.Drawing.Size(70, 19);
            stor_idLabel.TabIndex = 1;
            stor_idLabel.Text = "Store ID:";
            // 
            // stor_nameLabel
            // 
            stor_nameLabel.AutoSize = true;
            stor_nameLabel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stor_nameLabel.Location = new System.Drawing.Point(65, 64);
            stor_nameLabel.Name = "stor_nameLabel";
            stor_nameLabel.Size = new System.Drawing.Size(93, 19);
            stor_nameLabel.TabIndex = 3;
            stor_nameLabel.Text = "Store Name: ";
            // 
            // stor_addressLabel
            // 
            stor_addressLabel.AutoSize = true;
            stor_addressLabel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stor_addressLabel.Location = new System.Drawing.Point(65, 90);
            stor_addressLabel.Name = "stor_addressLabel";
            stor_addressLabel.Size = new System.Drawing.Size(68, 19);
            stor_addressLabel.TabIndex = 5;
            stor_addressLabel.Text = "Address: ";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(374, 38);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(41, 19);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateLabel.Location = new System.Drawing.Point(374, 64);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(51, 19);
            stateLabel.TabIndex = 9;
            stateLabel.Text = "State: ";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zipLabel.Location = new System.Drawing.Point(374, 90);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(39, 19);
            zipLabel.TabIndex = 11;
            zipLabel.Text = "Zip: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(150, 135);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(162, 19);
            label1.TabIndex = 15;
            label1.Text = "Search By Store Name: ";
            // 
            // storesBindingNavigator
            // 
            this.storesBindingNavigator.AddNewItem = null;
            this.storesBindingNavigator.BindingSource = this.storesBindingSource;
            this.storesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.storesBindingNavigator.DeleteItem = null;
            this.storesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.storesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.storesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.storesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.storesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.storesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.storesBindingNavigator.Name = "storesBindingNavigator";
            this.storesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.storesBindingNavigator.Size = new System.Drawing.Size(667, 25);
            this.storesBindingNavigator.TabIndex = 0;
            this.storesBindingNavigator.Text = "bindingNavigator1";
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "stores";
            this.storesBindingSource.DataSource = this.pubsDataSet;
            // 
            // pubsDataSet
            // 
            this.pubsDataSet.DataSetName = "PubsDataSet";
            this.pubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // stor_idTextBox
            // 
            this.stor_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storesBindingSource, "stor_id", true));
            this.stor_idTextBox.Location = new System.Drawing.Point(165, 38);
            this.stor_idTextBox.Name = "stor_idTextBox";
            this.stor_idTextBox.Size = new System.Drawing.Size(165, 20);
            this.stor_idTextBox.TabIndex = 2;
            // 
            // stor_nameTextBox
            // 
            this.stor_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storesBindingSource, "stor_name", true));
            this.stor_nameTextBox.Location = new System.Drawing.Point(165, 64);
            this.stor_nameTextBox.Name = "stor_nameTextBox";
            this.stor_nameTextBox.Size = new System.Drawing.Size(165, 20);
            this.stor_nameTextBox.TabIndex = 4;
            // 
            // stor_addressTextBox
            // 
            this.stor_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storesBindingSource, "stor_address", true));
            this.stor_addressTextBox.Location = new System.Drawing.Point(165, 90);
            this.stor_addressTextBox.Name = "stor_addressTextBox";
            this.stor_addressTextBox.Size = new System.Drawing.Size(165, 20);
            this.stor_addressTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storesBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(431, 38);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(165, 20);
            this.cityTextBox.TabIndex = 8;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storesBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(431, 64);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(165, 20);
            this.stateTextBox.TabIndex = 10;
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storesBindingSource, "zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(431, 90);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(165, 20);
            this.zipTextBox.TabIndex = 12;
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.discountsTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.jobsTableAdapter = null;
            this.tableAdapterManager.pub_infoTableAdapter = null;
            this.tableAdapterManager.publishersTableAdapter = null;
            this.tableAdapterManager.royschedTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.storesTableAdapter = this.storesTableAdapter;
            this.tableAdapterManager.titleauthorTableAdapter = null;
            this.tableAdapterManager.titlesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PubsFinalProject.PubsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "FK__sales__stor_id__0AD2A005";
            this.salesBindingSource.DataSource = this.storesBindingSource;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AutoGenerateColumns = false;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.salesDataGridView.DataSource = this.salesBindingSource;
            this.salesDataGridView.Location = new System.Drawing.Point(12, 171);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.Size = new System.Drawing.Size(645, 189);
            this.salesDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "stor_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "stor_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ord_num";
            this.dataGridViewTextBoxColumn2.HeaderText = "ord_num";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ord_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "ord_date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "qty";
            this.dataGridViewTextBoxColumn4.HeaderText = "qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "payterms";
            this.dataGridViewTextBoxColumn5.HeaderText = "payterms";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "title_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "title_id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(318, 135);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(553, 127);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 37);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Main Form";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStoreMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(667, 372);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.salesDataGridView);
            this.Controls.Add(stor_idLabel);
            this.Controls.Add(this.stor_idTextBox);
            this.Controls.Add(stor_nameLabel);
            this.Controls.Add(this.stor_nameTextBox);
            this.Controls.Add(stor_addressLabel);
            this.Controls.Add(this.stor_addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(zipLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.storesBindingNavigator);
            this.Name = "frmStoreMain";
            this.Text = "Stores and Sales ";
            this.Load += new System.EventHandler(this.frmStoreMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingNavigator)).EndInit();
            this.storesBindingNavigator.ResumeLayout(false);
            this.storesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PubsDataSet pubsDataSet;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private PubsDataSetTableAdapters.storesTableAdapter storesTableAdapter;
        private PubsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator storesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox stor_idTextBox;
        private System.Windows.Forms.TextBox stor_nameTextBox;
        private System.Windows.Forms.TextBox stor_addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private PubsDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExit;
    }
}