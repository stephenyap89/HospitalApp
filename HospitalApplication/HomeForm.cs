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
        private PatientManager _manager = new PatientManager();
        private readonly string _filePath = @"C:\Users\63906\source\repos\HospitalBLL\HospitalApplication\bin\Patient.csv";
        public HomeForm()
        {
            InitializeComponent();
        }
        

        private void AddButton_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            
            try
            {
                patient.FirstName = TxtFirstName.Text;
                patient.SurName = TxtSurName.Text;
                patient.Gender = CboGender.Text;
                patient.DateOfConsultation = DtpDoc.Value;
                patient.Diagnosis = TxtDiagnosis.Text;

                if (true)
                {
                    _manager.AddRecord(patient);
                    MessageBox.Show("Data saved successfully");
                    //TxtFirstName.Clear();
                    //TxtSurName.Clear();
                    //TxtSurName.Clear();
                    //CboGender.SelectedIndex = -1;
                    //TxtDiagnosis.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill empty fields");
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            var patientList = _manager.Read();

            DisplayDataInListView(patientList);

            //var people = GetPeopleList();
            //foreach (var person in people)
            //{
            //    var row = new string[] { person.FirstName, person.SurName };
            //    var lvi = new ListViewItem(row);
            //    lvi.Tag = person;
            //    ListViewPatient.Items.Add(lvi);
            //}

            //try
            //{
            //    //using (StreamReader sr = new StreamReader(@"C:\Users\63906\source\repos\HospitalBLL\HospitalApplication\bin\Patient.csv"))
            //    //{
            //    //    //String lines = sr.ReadLine();
            //    String[] lines = File.ReadAllLines(@"C:\Users\63906\source\repos\HospitalBLL\HospitalApplication\bin\Patient.csv");
            //    foreach (var line in lines)
            //    {
            //        string[] tokens = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            //        ListViewPatient.Items.Add(tokens[0]);
            //        ListViewPatient.SubItems.Add(tokens[1]);
            //        ListViewPatient.Items.Add(tokens[2]);
            //        ListViewPatient.Items.Add(tokens[3]);
            //        ListViewPatient.Items.Add(tokens[4]);
            //        //ListViewPatient.Items[ListViewPatient.Items.Count - 1].SubItems.Add(tokens[3]);
            //    }
                   
            //    //}
            //}
            //catch (IOException)
            //{
            //    MessageBox.Show("Error");
            //}
        }

        

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            //    try
            //    {
            //        openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //        openFileDialog1.DefaultExt = "csv";
            //        openFileDialog1.Title = "Open file";
            //        openFileDialog1.Filter = "CSV (*.csv)|*.csv";
            //        if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //        {
            //            FileStream srcFS;
            //            srcFS = new FileStream(openFileDialog1.FileName, FileMode.Open);
            //            StreamReader srcSR = new StreamReader(srcFS, System.Text.Encoding.Default);
            //            do
            //            {
            //                string ins = srcSR.ReadLine();
            //                string[] columns = ins.Split(',');

            //                ListViewItem lvi = new ListViewItem(columns[0]);

            //                lvi.SubItems.Add(ins);

            //                for (int i = 1; i < columns.Count(); i++)
            //                {
            //                    lvi.SubItems.Add(columns[i]);
            //                }

            //                ListViewPatient.Items.Add(lvi);

            //            } while (true);
            //        }
            //    }
            //    catch (Exception errorMsg)
            //    {
            //        MessageBox.Show(errorMsg.Message, "Error reading a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //using (TextFieldParser parser = new TextFieldParser(@"C:\Users\63906\source\repos\HospitalBLL\HospitalApplication\bin\Patient.csv"))
            //{
            //    parser.Delimiters = new string[] { "," };
            //    while (true)
            //    {
            //        string[] parts = parser.ReadFields();
            //        if (parts == null)
            //        {
            //            break;
            //        }
            //        MessageBox.Show(parts.Length.ToString());
                    
            //    }
            //}
        }

        private void DisplayDataInListView(IList<Patient> patientList)
        {
            ListViewPatient.Items.Clear();

            foreach (var patient in patientList)
            {
                var row = new ListViewItem(patient.FirstName);
                row.SubItems.Add(patient.SurName);
                row.SubItems.Add(patient.Gender);
                row.SubItems.Add(patient.DateOfConsultation.ToString());
                row.SubItems.Add(patient.Diagnosis);

                row.Tag = patient;

                ListViewPatient.Items.Add(row);
            }
        }
    }
}
