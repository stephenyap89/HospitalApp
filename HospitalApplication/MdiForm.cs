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
        }

       

        
    }
}
