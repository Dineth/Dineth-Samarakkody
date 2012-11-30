namespace WindowsFormsApplication1
{
    partial class StudentDetails
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
            this.dgwlist = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgwresult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwresult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwlist
            // 
            this.dgwlist.AllowUserToAddRows = false;
            this.dgwlist.AllowUserToDeleteRows = false;
            this.dgwlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.Dob,
            this.GPAvg,
            this.Active});
            this.dgwlist.Location = new System.Drawing.Point(37, 19);
            this.dgwlist.Name = "dgwlist";
            this.dgwlist.ReadOnly = true;
            this.dgwlist.Size = new System.Drawing.Size(444, 233);
            this.dgwlist.TabIndex = 0;
            // 
            // Names
            // 
            this.Names.DataPropertyName = "name";
            this.Names.HeaderText = "Name";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            // 
            // Dob
            // 
            this.Dob.DataPropertyName = "dob";
            this.Dob.HeaderText = "DateOfBirth";
            this.Dob.Name = "Dob";
            this.Dob.ReadOnly = true;
            // 
            // GPAvg
            // 
            this.GPAvg.DataPropertyName = "gpa";
            this.GPAvg.HeaderText = "GPA";
            this.GPAvg.Name = "GPAvg";
            this.GPAvg.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "active";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(155, 267);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(78, 23);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgwresult
            // 
            this.dgwresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwresult.Location = new System.Drawing.Point(37, 23);
            this.dgwresult.Name = "dgwresult";
            this.dgwresult.Size = new System.Drawing.Size(554, 296);
            this.dgwresult.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwlist);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 305);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgwresult);
            this.groupBox2.Location = new System.Drawing.Point(12, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 365);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student List";
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(727, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentDetails";
            this.Text = "StudentDetails";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwresult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwlist;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridView dgwresult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}