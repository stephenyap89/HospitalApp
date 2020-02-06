using HospitalBLL.Constants;
using HospitalBLL.Manager;
using HospitalBLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HospitalApplication
{
    public partial class AddPatientForm : Form
    {
        private readonly DoctorManager _doctormanager;
        private PatientManager _manager;
        private readonly string _xmlPath = $"{Directory.GetCurrentDirectory()}{Settings.FILENAME}";
        private readonly IList<Doctor> _doctorList;

        public AddPatientForm(Patient patient = null)
        {
            _doctormanager = new DoctorManager();
            _doctorList = _doctormanager.Read();
            _manager = new PatientManager();
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtFirstName.Text) && !string.IsNullOrEmpty(TxtSurName.Text))
            {
                Patient patient = new Patient();
                try
                {
                    patient.FirstName = TxtFirstName.Text;
                    patient.SurName = TxtSurName.Text;
                    patient.Gender = CboGender.Text;
                    patient.Age = Convert.ToInt32(TxtAge.Text);
                    patient.DateOfConsultation = DateOfConsultation.Value;
                    patient.Diagnosis = TxtDiagnosis.Text;
                    patient.Id = Convert.ToInt32(TxtId.Text);
                    patient.MobileNumber = TxtMobile.Text;
                    patient.EmailAddress = TxtEmail.Text;
                    patient.Address1 = TxtAddress1.Text;
                    patient.Address2 = TxtAddress2.Text;
                    patient.City = TxtCity.Text;
                    patient.Province = TxtProvince.Text;
                    patient.Country = CboCountry.Text;
                    patient.ZipCode = Convert.ToInt32(TxtZip.Text);
                    patient.Doctor = CboDoctor.Text;

                    if (true)
                    {
                        _manager.AddRecord(patient);
                        MessageBox.Show("Patient record added!");
                        patient.Id += 1;
                        var xml = XDocument.Load(_xmlPath);
                        xml.Element(Settings.SETTINGS).Element(Settings.DATA).Element(Settings.PATIENT_ID).Value = patient.Id.ToString();
                        xml.Save(_xmlPath);
                        this.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Please fill empty fields");
                }
            }
            else
            {
                MessageBox.Show("Please fill empty fields!");
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            var xml = XDocument.Load(_xmlPath);
            int id;
            id = Convert.ToInt32(xml.Element("Settings").Element("Data").Element("PatientId").Value) + 1;
            TxtId.Text = id.ToString();

            DisplayDoctorInListView(_doctorList);


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void DisplayDoctorInListView(IList<Doctor> doctorList)
        {
            foreach (var doctor in doctorList)
            {
                CboDoctor.Items.Add(doctor.FirstName + " " + doctor.LastName + ", " + doctor.Department);
            }
            
            
        }

        private void TxtAge_Leave(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(TxtAge.Text);
            if (age <= 21)
            {
                
            }
        }
    }
}
