namespace PubsFinalProject
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.btnDisplayAuthorData = new System.Windows.Forms.Button();
            this.btnDisplayTitles = new System.Windows.Forms.Button();
            this.btnDisplayJobs = new System.Windows.Forms.Button();
            this.btnDisplayStores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisplayAuthorData
            // 
            this.btnDisplayAuthorData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDisplayAuthorData.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAuthorData.Location = new System.Drawing.Point(68, 89);
            this.btnDisplayAuthorData.Name = "btnDisplayAuthorData";
            this.btnDisplayAuthorData.Size = new System.Drawing.Size(113, 50);
            this.btnDisplayAuthorData.TabIndex = 1;
            this.btnDisplayAuthorData.Text = "Author Directory";
            this.btnDisplayAuthorData.UseVisualStyleBackColor = true;
            this.btnDisplayAuthorData.Click += new System.EventHandler(this.btnDisplayAuthorData_Click);
            // 
            // btnDisplayTitles
            // 
            this.btnDisplayTitles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDisplayTitles.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayTitles.Location = new System.Drawing.Point(68, 33);
            this.btnDisplayTitles.Name = "btnDisplayTitles";
            this.btnDisplayTitles.Size = new System.Drawing.Size(113, 50);
            this.btnDisplayTitles.TabIndex = 0;
            this.btnDisplayTitles.Text = "Current Titles ";
            this.btnDisplayTitles.UseVisualStyleBackColor = true;
            this.btnDisplayTitles.Click += new System.EventHandler(this.btnDisplayTitles_Click);
            // 
            // btnDisplayJobs
            // 
            this.btnDisplayJobs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDisplayJobs.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayJobs.Location = new System.Drawing.Point(68, 201);
            this.btnDisplayJobs.Name = "btnDisplayJobs";
            this.btnDisplayJobs.Size = new System.Drawing.Size(113, 50);
            this.btnDisplayJobs.TabIndex = 3;
            this.btnDisplayJobs.Text = "Current Jobs and Employees ";
            this.btnDisplayJobs.UseVisualStyleBackColor = true;
            this.btnDisplayJobs.Click += new System.EventHandler(this.btnDisplayJobs_Click);
            // 
            // btnDisplayStores
            // 
            this.btnDisplayStores.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDisplayStores.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayStores.Location = new System.Drawing.Point(68, 145);
            this.btnDisplayStores.Name = "btnDisplayStores";
            this.btnDisplayStores.Size = new System.Drawing.Size(113, 50);
            this.btnDisplayStores.TabIndex = 2;
            this.btnDisplayStores.Text = "Stores and Sales";
            this.btnDisplayStores.UseVisualStyleBackColor = true;
            this.btnDisplayStores.Click += new System.EventHandler(this.btnDisplayStores_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(124, 293);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(187, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(187, 147);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(187, 203);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(339, 328);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplayStores);
            this.Controls.Add(this.btnDisplayJobs);
            this.Controls.Add(this.btnDisplayTitles);
            this.Controls.Add(this.btnDisplayAuthorData);
            this.Name = "frmMainForm";
            this.Text = "Table of Contents";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayAuthorData;
        private System.Windows.Forms.Button btnDisplayTitles;
        private System.Windows.Forms.Button btnDisplayJobs;
        private System.Windows.Forms.Button btnDisplayStores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}