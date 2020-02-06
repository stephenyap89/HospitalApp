namespace HospitalApplication
{
    partial class AddPatientForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DateOfConsultation = new System.Windows.Forms.DateTimePicker();
            this.TxtDiagnosis = new System.Windows.Forms.TextBox();
            this.CboGender = new System.Windows.Forms.ComboBox();
            this.TxtSurName = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtMobile = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtAddress1 = new System.Windows.Forms.TextBox();
            this.TxtAddress2 = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtProvince = new System.Windows.Forms.TextBox();
            this.TxtZip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CboDoctor = new System.Windows.Forms.ComboBox();
            this.CboCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.SaveButton.Location = new System.Drawing.Point(244, 326);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(95, 23);
            this.SaveButton.TabIndex = 38;
            this.SaveButton.Text = "Save Changes";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.AddButton.Location = new System.Drawing.Point(128, 326);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(95, 23);
            this.AddButton.TabIndex = 37;
            this.AddButton.Text = "Add Patient";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DateOfConsultation
            // 
            this.DateOfConsultation.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.DateOfConsultation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfConsultation.Location = new System.Drawing.Point(119, 119);
            this.DateOfConsultation.Name = "DateOfConsultation";
            this.DateOfConsultation.Size = new System.Drawing.Size(100, 21);
            this.DateOfConsultation.TabIndex = 5;
            // 
            // TxtDiagnosis
            // 
            this.TxtDiagnosis.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtDiagnosis.Location = new System.Drawing.Point(119, 151);
            this.TxtDiagnosis.Name = "TxtDiagnosis";
            this.TxtDiagnosis.Size = new System.Drawing.Size(100, 21);
            this.TxtDiagnosis.TabIndex = 6;
            // 
            // CboGender
            // 
            this.CboGender.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CboGender.FormattingEnabled = true;
            this.CboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CboGender.Location = new System.Drawing.Point(119, 65);
            this.CboGender.Name = "CboGender";
            this.CboGender.Size = new System.Drawing.Size(100, 21);
            this.CboGender.TabIndex = 3;
            // 
            // TxtSurName
            // 
            this.TxtSurName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtSurName.Location = new System.Drawing.Point(119, 39);
            this.TxtSurName.Name = "TxtSurName";
            this.TxtSurName.Size = new System.Drawing.Size(100, 21);
            this.TxtSurName.TabIndex = 2;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtFirstName.Location = new System.Drawing.Point(119, 12);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(100, 21);
            this.TxtFirstName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label5.Location = new System.Drawing.Point(55, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Diagnosis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(5, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Date of Consultation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(66, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(57, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "SurName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "FirstName";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtId.Location = new System.Drawing.Point(331, 12);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 21);
            this.TxtId.TabIndex = 20;
            // 
            // TxtMobile
            // 
            this.TxtMobile.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtMobile.Location = new System.Drawing.Point(331, 42);
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.Size = new System.Drawing.Size(100, 21);
            this.TxtMobile.TabIndex = 7;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtEmail.Location = new System.Drawing.Point(331, 69);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 21);
            this.TxtEmail.TabIndex = 8;
            // 
            // TxtAddress1
            // 
            this.TxtAddress1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtAddress1.Location = new System.Drawing.Point(331, 98);
            this.TxtAddress1.Name = "TxtAddress1";
            this.TxtAddress1.Size = new System.Drawing.Size(100, 21);
            this.TxtAddress1.TabIndex = 9;
            // 
            // TxtAddress2
            // 
            this.TxtAddress2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtAddress2.Location = new System.Drawing.Point(331, 127);
            this.TxtAddress2.Name = "TxtAddress2";
            this.TxtAddress2.Size = new System.Drawing.Size(100, 21);
            this.TxtAddress2.TabIndex = 10;
            // 
            // TxtCity
            // 
            this.TxtCity.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtCity.Location = new System.Drawing.Point(331, 154);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(100, 21);
            this.TxtCity.TabIndex = 11;
            // 
            // TxtProvince
            // 
            this.TxtProvince.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtProvince.Location = new System.Drawing.Point(331, 181);
            this.TxtProvince.Name = "TxtProvince";
            this.TxtProvince.Size = new System.Drawing.Size(100, 21);
            this.TxtProvince.TabIndex = 12;
            // 
            // TxtZip
            // 
            this.TxtZip.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtZip.Location = new System.Drawing.Point(331, 235);
            this.TxtZip.Name = "TxtZip";
            this.TxtZip.Size = new System.Drawing.Size(100, 21);
            this.TxtZip.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label6.Location = new System.Drawing.Point(304, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label7.Location = new System.Drawing.Point(244, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Mobile Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label8.Location = new System.Drawing.Point(248, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Email Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label9.Location = new System.Drawing.Point(266, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Address 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label10.Location = new System.Drawing.Point(266, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Address 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label11.Location = new System.Drawing.Point(295, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label12.Location = new System.Drawing.Point(273, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Province";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label13.Location = new System.Drawing.Point(275, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Country";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label14.Location = new System.Drawing.Point(277, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Zipcode";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label15.Location = new System.Drawing.Point(282, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 58;
            this.label15.Text = "Doctor";
            // 
            // TxtAge
            // 
            this.TxtAge.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtAge.Location = new System.Drawing.Point(119, 92);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(100, 21);
            this.TxtAge.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label16.Location = new System.Drawing.Point(65, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Age";
            // 
            // CboDoctor
            // 
            this.CboDoctor.FormattingEnabled = true;
            this.CboDoctor.Items.AddRange(new object[] {
            "Sayson",
            "Oracion"});
            this.CboDoctor.Location = new System.Drawing.Point(331, 265);
            this.CboDoctor.Name = "CboDoctor";
            this.CboDoctor.Size = new System.Drawing.Size(121, 21);
            this.CboDoctor.TabIndex = 15;
            // 
            // CboCountry
            // 
            this.CboCountry.FormattingEnabled = true;
            this.CboCountry.Items.AddRange(new object[] {
            "Philippines",
            "China",
            "Argentina",
            "Korea",
            "Taiwan"});
            this.CboCountry.Location = new System.Drawing.Point(331, 208);
            this.CboCountry.Name = "CboCountry";
            this.CboCountry.Size = new System.Drawing.Size(121, 21);
            this.CboCountry.TabIndex = 13;
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.CboCountry);
            this.Controls.Add(this.CboDoctor);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtZip);
            this.Controls.Add(this.TxtProvince);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtAddress2);
            this.Controls.Add(this.TxtAddress1);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtMobile);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DateOfConsultation);
            this.Controls.Add(this.TxtDiagnosis);
            this.Controls.Add(this.CboGender);
            this.Controls.Add(this.TxtSurName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Patient";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DateTimePicker DateOfConsultation;
        private System.Windows.Forms.TextBox TxtDiagnosis;
        private System.Windows.Forms.ComboBox CboGender;
        private System.Windows.Forms.TextBox TxtSurName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtMobile;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtAddress1;
        private System.Windows.Forms.TextBox TxtAddress2;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtProvince;
        private System.Windows.Forms.TextBox TxtZip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CboDoctor;
        private System.Windows.Forms.ComboBox CboCountry;
    }
}