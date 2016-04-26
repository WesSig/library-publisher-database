namespace PubsFinalProject
{
    partial class frmEditJobs
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
            System.Windows.Forms.Label job_idLabel;
            System.Windows.Forms.Label job_descLabel;
            System.Windows.Forms.Label min_lvlLabel;
            System.Windows.Forms.Label max_lvlLabel;
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.txtJobDesc = new System.Windows.Forms.TextBox();
            this.txtMinLvl = new System.Windows.Forms.TextBox();
            this.txtMaxLvl = new System.Windows.Forms.TextBox();
            this.lstbxDisplayEntries = new System.Windows.Forms.ListBox();
            this.btnReturnToTerms = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            job_idLabel = new System.Windows.Forms.Label();
            job_descLabel = new System.Windows.Forms.Label();
            min_lvlLabel = new System.Windows.Forms.Label();
            max_lvlLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // job_idLabel
            // 
            job_idLabel.AutoSize = true;
            job_idLabel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            job_idLabel.Location = new System.Drawing.Point(27, 18);
            job_idLabel.Name = "job_idLabel";
            job_idLabel.Size = new System.Drawing.Size(62, 19);
            job_idLabel.TabIndex = 9;
            job_idLabel.Text = "Job ID: ";
            // 
            // job_descLabel
            // 
            job_descLabel.AutoSize = true;
            job_descLabel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            job_descLabel.Location = new System.Drawing.Point(12, 46);
            job_descLabel.Name = "job_descLabel";
            job_descLabel.Size = new System.Drawing.Size(76, 19);
            job_descLabel.TabIndex = 11;
            job_descLabel.Text = "Job Desc: ";
            // 
            // min_lvlLabel
            // 
            min_lvlLabel.AutoSize = true;
            min_lvlLabel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            min_lvlLabel.Location = new System.Drawing.Point(317, 19);
            min_lvlLabel.Name = "min_lvlLabel";
            min_lvlLabel.Size = new System.Drawing.Size(67, 19);
            min_lvlLabel.TabIndex = 13;
            min_lvlLabel.Text = "Min Lvl: ";
            // 
            // max_lvlLabel
            // 
            max_lvlLabel.AutoSize = true;
            max_lvlLabel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            max_lvlLabel.Location = new System.Drawing.Point(317, 47);
            max_lvlLabel.Name = "max_lvlLabel";
            max_lvlLabel.Size = new System.Drawing.Size(70, 19);
            max_lvlLabel.TabIndex = 15;
            max_lvlLabel.Text = "Max Lvl: ";
            // 
            // txtJobID
            // 
            this.txtJobID.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobID.Location = new System.Drawing.Point(95, 19);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(175, 22);
            this.txtJobID.TabIndex = 10;
            // 
            // txtJobDesc
            // 
            this.txtJobDesc.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobDesc.Location = new System.Drawing.Point(95, 47);
            this.txtJobDesc.Name = "txtJobDesc";
            this.txtJobDesc.Size = new System.Drawing.Size(175, 22);
            this.txtJobDesc.TabIndex = 12;
            // 
            // txtMinLvl
            // 
            this.txtMinLvl.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinLvl.Location = new System.Drawing.Point(390, 19);
            this.txtMinLvl.Name = "txtMinLvl";
            this.txtMinLvl.Size = new System.Drawing.Size(175, 22);
            this.txtMinLvl.TabIndex = 14;
            // 
            // txtMaxLvl
            // 
            this.txtMaxLvl.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxLvl.Location = new System.Drawing.Point(390, 47);
            this.txtMaxLvl.Name = "txtMaxLvl";
            this.txtMaxLvl.Size = new System.Drawing.Size(175, 22);
            this.txtMaxLvl.TabIndex = 16;
            // 
            // lstbxDisplayEntries
            // 
            this.lstbxDisplayEntries.FormattingEnabled = true;
            this.lstbxDisplayEntries.ItemHeight = 14;
            this.lstbxDisplayEntries.Location = new System.Drawing.Point(76, 90);
            this.lstbxDisplayEntries.Name = "lstbxDisplayEntries";
            this.lstbxDisplayEntries.Size = new System.Drawing.Size(461, 158);
            this.lstbxDisplayEntries.TabIndex = 17;
            // 
            // btnReturnToTerms
            // 
            this.btnReturnToTerms.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnToTerms.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToTerms.Location = new System.Drawing.Point(256, 273);
            this.btnReturnToTerms.Name = "btnReturnToTerms";
            this.btnReturnToTerms.Size = new System.Drawing.Size(112, 46);
            this.btnReturnToTerms.TabIndex = 20;
            this.btnReturnToTerms.Text = "Return To Jobs";
            this.btnReturnToTerms.UseVisualStyleBackColor = true;
            this.btnReturnToTerms.Click += new System.EventHandler(this.btnReturnToTerms_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnProcess.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(406, 273);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(112, 46);
            this.btnProcess.TabIndex = 19;
            this.btnProcess.Text = "Add To Database";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(96, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 46);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add Job";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmEditJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(596, 337);
            this.Controls.Add(this.btnReturnToTerms);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstbxDisplayEntries);
            this.Controls.Add(job_idLabel);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(job_descLabel);
            this.Controls.Add(this.txtJobDesc);
            this.Controls.Add(min_lvlLabel);
            this.Controls.Add(this.txtMinLvl);
            this.Controls.Add(max_lvlLabel);
            this.Controls.Add(this.txtMaxLvl);
            this.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEditJobs";
            this.Text = "Edit Jobs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.TextBox txtJobDesc;
        private System.Windows.Forms.TextBox txtMinLvl;
        private System.Windows.Forms.TextBox txtMaxLvl;
        private System.Windows.Forms.ListBox lstbxDisplayEntries;
        private System.Windows.Forms.Button btnReturnToTerms;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnAdd;
    }
}