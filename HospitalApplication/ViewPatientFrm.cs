using HospitalBLL.Manager;
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

namespace HospitalApplication
{
    public partial class ViewPatientFrm : Form
    {
        PatientManager _manager;
        public ViewPatientFrm()
        {
            _manager = new PatientManager();
            InitializeComponent();
        }

        private void ViewPatientForm_Load(object sender, EventArgs e)
        {
            DisplayDataInListView();
        }

        private void DisplayDataInListView(/*IList<Patient> patientList*/)
        {
            ListViewPatient.Items.Clear();
            var listViewItems = new List<ListViewItem>();
            var list = _manager.Read();
            foreach (var patient in list)
            {
                var row = new ListViewItem(patient.FirstName + " " + patient.SurName);
                row.SubItems.Add(patient.Gender);
                row.SubItems.Add(patient.Age.ToString());
                row.SubItems.Add(patient.DateOfConsultation.ToString());
                row.SubItems.Add(patient.Doctor);
                listViewItems.Add(row);
                row.Tag = patient;
            }
            ListViewPatient.Items.AddRange(listViewItems.ToArray());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
