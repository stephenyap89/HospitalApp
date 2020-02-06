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
    public partial class MdiForm : Form
    {
        private readonly DoctorManager _doctormanager;
        private readonly PatientManager _patientmanager;
        //public Patient _patient;
        //public Doctor _doctor;
        private readonly IList<Patient> _patientList;
        private readonly IList<Doctor> _doctorList;
        private readonly string _xmlPath = $"{Directory.GetCurrentDirectory()}{Settings.FILENAME}";

        public MdiForm()
        {
            _doctormanager = new DoctorManager();
            _patientmanager = new PatientManager();
            _patientList = _patientmanager.Read();
            _doctorList = _doctormanager.Read();
            InitializeComponent();
        }
        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDoctorForm doctorform = new AddDoctorForm();
            ShowForm(doctorform);
        }
        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatientForm patientform = new AddPatientForm();
            ShowForm(patientform);
        }

        private void MdiForm_Load(object sender, EventArgs e)
        {
            
        }
        private void patientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewPatientFrm viewpatient = new ViewPatientFrm();
            ShowForm(viewpatient);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsfrm = new SettingsForm();
            ShowForm(settingsfrm);
        }
        private void doctorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewDoctorFrm viewdoctor = new ViewDoctorFrm();
            ShowForm(viewdoctor);
        }
        private void ShowForm(Form form)
        {
            var child = MdiChildren.FirstOrDefault(x => x.Name.Equals(form.Name));
            if (child != null)
            {
                child.BringToFront();
            }
            else
            {
                form.Show();
                form.MdiParent = this;
            }
        }

        private void MdiForm_Activated(object sender, EventArgs e)
        {
            var xml = XDocument.Load(_xmlPath);
            string hospitalname = xml.Element("Settings").Element("HospitalName").Value;
            this.Text = hospitalname;
            DisplayPatientInListView(_patientList);
            DisplayDoctorInListView(_doctorList);
        }

        private void DisplayPatientInListView(IList<Patient> patientList)
        {
            ListViewPatient.Items.Clear();
            var listViewItems = new List<ListViewItem>();
            foreach (var patient in patientList)
            {
                var row = new ListViewItem(patient.FirstName);
                row.SubItems.Add(patient.SurName);
                row.SubItems.Add(patient.Gender);
                row.SubItems.Add(patient.Age.ToString());
                row.SubItems.Add(patient.DateOfConsultation.ToString());
                row.SubItems.Add(patient.Diagnosis);
                row.SubItems.Add(patient.Id.ToString());
                row.SubItems.Add(patient.MobileNumber);
                row.SubItems.Add(patient.EmailAddress);
                row.SubItems.Add(patient.Address1);
                row.SubItems.Add(patient.Address2);
                row.SubItems.Add(patient.City);
                row.SubItems.Add(patient.Province);
                row.SubItems.Add(patient.Country);
                row.SubItems.Add(patient.ZipCode.ToString());
                row.SubItems.Add(patient.Doctor);
                listViewItems.Add(row);
                row.Tag = patient;
            }
            ListViewPatient.Items.AddRange(listViewItems.ToArray());
        }

        private void DisplayDoctorInListView(IList<Doctor> doctorList)
        {
            ListViewPatient.Items.Clear();
            var listViewItems = new List<ListViewItem>();
            foreach (var doctor in doctorList)
            {
                var row = new ListViewItem(doctor.Id.ToString());
                row.SubItems.Add(doctor.FirstName);
                row.SubItems.Add(doctor.LastName);
                row.SubItems.Add(doctor.Department);
               
                listViewItems.Add(row);
                row.Tag = doctor;
            }
            ListViewPatient.Items.AddRange(listViewItems.ToArray());
        }
    }
}
