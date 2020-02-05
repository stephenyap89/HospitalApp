using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using HospitalBLL.Constants;


namespace HospitalApplication
{
    public partial class SettingsForm : Form
    {

        private readonly string _xmlPath = $"{Directory.GetCurrentDirectory()}{Settings.FILENAME}";
        public SettingsForm()
        {
            InitializeComponent();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var xml = XDocument.Load(_xmlPath);
                xml.Element(Settings.SETTINGS).Element(Settings.HOSPITALNAME).Value = TxtHospitalName.Text;
                xml.Element(Settings.SETTINGS).Element(Settings.PATHS).Element(Settings.PATIENT_CSV).Value = TxtPatientPath.Text;
                xml.Element(Settings.SETTINGS).Element(Settings.PATHS).Element(Settings.DOCTOR_CSV).Value = TxtDocPath.Text;
                xml.Save(_xmlPath);

                //var xml = new XElement("Settings");
                //var pathValues = new XElement("Paths");
                //pathValues.Add(new XElement("PatientCsv", "C:\\Users\\Administrator\\source\\repos\\HospitalBLL\\HospitalBLL\\CSV\\Patient.csv"));
                ////add ug daghan na path....
                //var ids = new XElement("Data");
                //ids.Add(new XElement("PatientId", 100));
                //ids.Add(new XElement("DoctorId", 200));
                //xml.Add(pathValues);
                //xml.Add(ids);
                //xml.Save(_xmlPath);

                MessageBox.Show("Settings successfully saved!");
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            SaveBtn.TabStop = false;
            EditBtn.TabStop = false;
            var xml = XDocument.Load(_xmlPath);
            TxtHospitalName.Text = xml.Element(Settings.SETTINGS).Element(Settings.HOSPITALNAME).Value;
            TxtPatientPath.Text = xml.Element(Settings.SETTINGS).Element(Settings.PATHS).Element("PatientCsv").Value;
            TxtDocPath.Text = xml.Element(Settings.SETTINGS).Element(Settings.PATHS).Element("DoctorCsv").Value;
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            TxtHospitalName.Enabled = true;
            TxtPatientPath.Enabled = true;
            TxtDocPath.Enabled = true;
        }
    }
}


