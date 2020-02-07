namespace HospitalApplication
{
    partial class AddDoctorForm
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
            this.TxtDoctorLastName = new System.Windows.Forms.TextBox();
            this.TxtDoctorFirstName = new System.Windows.Forms.TextBox();
            this.CboDoctorDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveChangesBtn = new System.Windows.Forms.Button();
            this.AddDoctorBtn = new System.Windows.Forms.Button();
            this.TxtDoctorId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDoctorLastName
            // 
            this.TxtDoctorLastName.Location = new System.Drawing.Point(210, 127);
            this.TxtDoctorLastName.Name = "TxtDoctorLastName";
            this.TxtDoctorLastName.Size = new System.Drawing.Size(100, 21);
            this.TxtDoctorLastName.TabIndex = 2;
            // 
            // TxtDoctorFirstName
            // 
            this.TxtDoctorFirstName.Location = new System.Drawing.Point(210, 101);
            this.TxtDoctorFirstName.Name = "TxtDoctorFirstName";
            this.TxtDoctorFirstName.Size = new System.Drawing.Size(100, 21);
            this.TxtDoctorFirstName.TabIndex = 1;
            // 
            // CboDoctorDepartment
            // 
            this.CboDoctorDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboDoctorDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboDoctorDepartment.FormattingEnabled = true;
            this.CboDoctorDepartment.Items.AddRange(new object[] {
            "Pediatrics",
            "Family and Community Medicine"});
            this.CboDoctorDepartment.Location = new System.Drawing.Point(209, 153);
            this.CboDoctorDepartment.Name = "CboDoctorDepartment";
            this.CboDoctorDepartment.Size = new System.Drawing.Size(182, 21);
            this.CboDoctorDepartment.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Department";
            // 
            // SaveChangesBtn
            // 
            this.SaveChangesBtn.Location = new System.Drawing.Point(233, 193);
            this.SaveChangesBtn.Name = "SaveChangesBtn";
            this.SaveChangesBtn.Size = new System.Drawing.Size(85, 23);
            this.SaveChangesBtn.TabIndex = 9;
            this.SaveChangesBtn.Text = "Save Changes";
            this.SaveChangesBtn.UseVisualStyleBackColor = true;
            // 
            // AddDoctorBtn
            // 
            this.AddDoctorBtn.Location = new System.Drawing.Point(147, 193);
            this.AddDoctorBtn.Name = "AddDoctorBtn";
            this.AddDoctorBtn.Size = new System.Drawing.Size(66, 23);
            this.AddDoctorBtn.TabIndex = 10;
            this.AddDoctorBtn.Text = "Add Doctor";
            this.AddDoctorBtn.UseVisualStyleBackColor = true;
            this.AddDoctorBtn.Click += new System.EventHandler(this.AddDoctorBtn_Click);
            // 
            // TxtDoctorId
            // 
            this.TxtDoctorId.Enabled = false;
            this.TxtDoctorId.Location = new System.Drawing.Point(209, 75);
            this.TxtDoctorId.Name = "TxtDoctorId";
            this.TxtDoctorId.Size = new System.Drawing.Size(100, 21);
            this.TxtDoctorId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Doctor ID";
            // 
            // AddDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDoctorId);
            this.Controls.Add(this.AddDoctorBtn);
            this.Controls.Add(this.SaveChangesBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboDoctorDepartment);
            this.Controls.Add(this.TxtDoctorFirstName);
            this.Controls.Add(this.TxtDoctorLastName);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Doctor";
            this.Load += new System.EventHandler(this.AddDoctorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtDoctorLastName;
        private System.Windows.Forms.TextBox TxtDoctorFirstName;
        private System.Windows.Forms.ComboBox CboDoctorDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveChangesBtn;
        private System.Windows.Forms.Button AddDoctorBtn;
        private System.Windows.Forms.TextBox TxtDoctorId;
        private System.Windows.Forms.Label label1;
    }
}