using HospitalBLL.Models;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalBLL.Repository
{

    public class BaseRepository
    {
        private readonly string _path = "C:\\Users\\63906\\source\\repos\\HospitalBLL\\HospitalApplication\\bin\\Patient.csv";
        private static IList<Patient> _patientList = new List<Patient>();
        //public void AddRecord(Patient patient)
        //{
        //    try
        //    {
        //        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\63906\source\repos\HospitalBLL\HospitalApplication\bin\Patient.csv", true))
        //        {
        //            file.WriteLine(patient.FirstName +"," + patient.SurName + "," + patient.Gender + "," + patient.Doc + "," + patient.Diagnosis);
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("This program encountered an error.", ex);
        //    }
        //}
        public bool AddRecord(Patient patient)
        {
            return WriteCsv(patient);
        }

        public List<Patient> Read()
        {


            //using (TextFieldParser parser = new TextFieldParser(_path))
            //{
            //    parser.Delimiters = new string[] { "," };

            //    while (parser.EndOfData)
            //    {
            //        string[] parts = parser.ReadFields();
            //        _patientList.Add(new Patient
            //        {
            //            FirstName = parts[0],
            //            SurName = parts[0],
            //            Gender = parts[0],
            //            DateOfConsultation = DateTime.Parse(parts[3]),
            //            Diagnosis = parts[0],
            //        });
            //    }
            if (_patientList.Count == 0)
            {
                var data = File.ReadAllLines(_path);

                foreach (var line in data)
                {
                    var patient = line.Split(',');

                    _patientList.Add(new Patient()
                    {
                        FirstName = patient[0],
                        SurName = patient[1],
                        Gender = patient[2],
                        DateOfConsultation = DateTime.Parse(patient[3]),
                        Diagnosis = patient[4]
                    });
                }
            }

            return _patientList.ToList();
        }
        private bool WriteCsv(Patient patient)
        {
            
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(_path, true))
                {
                    file.WriteLine(patient.FirstName + "," + patient.SurName + "," + patient.Gender + "," + patient.DateOfConsultation + "," + patient.Diagnosis);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("The program encountered an error.", ex);
            }
        }
    }
}
