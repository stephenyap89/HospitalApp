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
    public partial class AddDoctorForm : Form
    {
        private readonly string _xmlPath = $"{Directory.GetCurrentDirectory()}{Settings.FILENAME}";
        private Doctor _doctor;
        private DoctorManager _doctorManager;
        public AddDoctorForm(Doctor doctor = null)
        {
            _doctor = doctor;
            _doctorManager = new DoctorManager();
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void AddDoctorBtn_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();

            if (!string.IsNullOrEmpty(TxtDoctorFirstName.Text) && !string.IsNullOrEmpty(TxtDoctorLastName.Text))
            {
                try
                {
                    doctor.Id = Convert.ToInt32(TxtDoctorId.Text);
                    doctor.LastName = TxtDoctorLastName.Text;
                    doctor.FirstName = TxtDoctorFirstName.Text;
                    doctor.Department = CboDoctorDepartment.Text;
                    if (true)
                    {
                        _doctorManager.AddDoctor(doctor);
                        MessageBox.Show("New doctor record added!");
                        doctor.Id += 1;
                        var xml = XDocument.Load(_xmlPath);
                        xml.Element(Settings.SETTINGS).Element(Settings.DATA).Element(Settings.DOCTOR_ID).Value = doctor.Id.ToString();
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

        private void AddDoctorForm_Load(object sender, EventArgs e)
        {
            var xml = XDocument.Load(_xmlPath);
            int id;
            id = Convert.ToInt32(xml.Element(Settings.SETTINGS).Element(Settings.DATA).Element(Settings.DOCTOR_ID).Value);
            TxtDoctorId.Text = id.ToString();
        }
    }
}
