namespace WindowsFormsApplication1
{
    partial class InsertStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxactive = new System.Windows.Forms.CheckBox();
            this.txtgpa = new System.Windows.Forms.TextBox();
            this.txtdob = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Grade Point Avg";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxactive);
            this.groupBox1.Controls.Add(this.txtgpa);
            this.groupBox1.Controls.Add(this.txtdob);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // cboxactive
            // 
            this.cboxactive.AutoSize = true;
            this.cboxactive.Checked = true;
            this.cboxactive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxactive.Location = new System.Drawing.Point(26, 146);
            this.cboxactive.Name = "cboxactive";
            this.cboxactive.Size = new System.Drawing.Size(56, 17);
            this.cboxactive.TabIndex = 2;
            this.cboxactive.Text = "Active";
            this.cboxactive.UseVisualStyleBackColor = true;
            // 
            // txtgpa
            // 
            this.txtgpa.Location = new System.Drawing.Point(162, 92);
            this.txtgpa.Name = "txtgpa";
            this.txtgpa.Size = new System.Drawing.Size(100, 20);
            this.txtgpa.TabIndex = 1;
            this.txtgpa.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtdob
            // 
            this.txtdob.Location = new System.Drawing.Point(162, 59);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(100, 20);
            this.txtdob.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(162, 33);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(217, 274);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox1);
            this.Name = "InsertStudent";
            this.Text = "StudentRegistration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cboxactive;
        private System.Windows.Forms.TextBox txtgpa;
        private System.Windows.Forms.TextBox txtdob;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button1;
    }
}