using HospitalBLL.Manager;
using HospitalBLL.Models;
using Microsoft.VisualBasic.FileIO;
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
    public partial class HomeForm : Form
    {
        private readonly PatientManager _manager;
        public Patient _patient;
        //private readonly IList<Patient> _patientList;
        private static string _searchValue;
        public HomeForm()
        {
            _searchValue = String.Empty;
            _manager = new PatientManager();
           
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPatientForm addform = new AddPatientForm();
            addform.Show();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ListViewPatient.SelectedItems.Count > 0)
            {
                List<Patient> patientList = new List<Patient>();

                foreach (ListViewItem patient in ListViewPatient.SelectedItems)
                {
                    patientList.Add(new Patient()
                    {
                        FirstName = patient.SubItems[0].Text,
                        SurName = patient.SubItems[1].Text,
                        Gender = patient.SubItems[2].Text,
                        DateOfConsultation = DateTime.Parse(patient.SubItems[3].Text),
                        Diagnosis = patient.SubItems[4].Text
                    });
                }

                if (_manager.Delete(patientList))
                {
                    MessageBox.Show("Patient/s deleted successfully!");
                    DisplayDataInListView();
                }
                else
                {
                    MessageBox.Show("Patient/s deletion failed!");
                }
            }

            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            


            if (ListViewPatient.SelectedItems.Count > 0)
            {
                _patient = ListViewPatient.SelectedItems[0].Tag as Patient;
            }
            
            AddPatientForm addform = new AddPatientForm(_patient);
            addform.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
                
        }

        private void DisplayDataInListView(/*IList<Patient> patientList*/)
        {
            ListViewPatient.Items.Clear();
            var listViewItems = new List<ListViewItem>();
            var list = _manager.Read();
            foreach (var patient in list)
            {
                var row = new ListViewItem(patient.FirstName);
                row.SubItems.Add(patient.SurName);
                row.SubItems.Add(patient.Gender);
                row.SubItems.Add(patient.DateOfConsultation.ToString());
                row.SubItems.Add(patient.Diagnosis);
                listViewItems.Add(row);
                row.Tag = patient;
            }
            ListViewPatient.Items.AddRange(listViewItems.ToArray());
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListViewPatient.Items)
            {
                if (!item.ToString().ToLower().Contains(TxtSearch.Text.ToLower()))
                {
                    ListViewPatient.Items.Remove(item);                
                }
            }
        }
        private void TxtFilter(object sender, EventArgs e)
        {

        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ListViewPatient.Items.Clear();
            DisplayDataInListView();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void HomeForm_Activated(object sender, EventArgs e)
        {
            DisplayDataInListView();
        }
    }
}
