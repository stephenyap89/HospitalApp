using CsvHelper;
using HospitalBLL.Models;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using HospitalBLL.Constants;


namespace HospitalBLL.Repository
{

    public class PatientRepository
    {
        private static IList<Patient> _patientList = new List<Patient>();
        private readonly string _path = ConfigurationManager.AppSettings["PatientCSVPath"];
      

        public bool AddRecord(Patient patient)
        {
            _patientList.Add(patient);
            return UpdateCSVFile();
        }
        public bool Update(Patient oldPatientRecord, Patient newPatientRecord)
        {
            _patientList.Remove(_patientList.FirstOrDefault(patient => patient == oldPatientRecord));
            _patientList.Add(newPatientRecord);
            return UpdateCSVFile();
        }
        public bool Delete(List<Patient> patients)
        {
            patients.ForEach(tobeRemove =>
            {
                _patientList.Remove(_patientList.FirstOrDefault(patient => patient == tobeRemove));
            });
            //foreach (Patient tobeRemove in patients)
            //{
            //    foreach (Patient patient in _patientList)
            //    {
            //        if (patient == tobeRemove)
            //        {
            //            _patientList.Remove(patient);
            //            break;
            //        }
            //    }
            //}
            return UpdateCSVFile();
        }

        public List<Patient> Read()
        {
            if (_patientList.Count == 0)
            {
                var data = File.ReadAllLines(_path);

                foreach (var line in data)
                {
                    var patient = line.Split(',');

                    _patientList.Add(new Patient
                    {
                        FirstName = patient[0],
                        SurName = patient[1],
                        Gender = patient[2],
                        Age = Convert.ToInt32(patient[3]),
                        DateOfConsultation = DateTime.Parse(patient[4]),
                        Diagnosis = patient[5],
                        Id = Convert.ToInt32(patient[6]),
                        MobileNumber = patient[7],
                        EmailAddress = patient[8],
                        Address1 = patient[9],
                        Address2 = patient[10],
                        City = patient[11],
                        Province = patient[12],
                        Country = patient[13],
                        ZipCode = Convert.ToInt32(patient[14]),
                        Doctor = patient[15]
                    });
                }
            }
            return _patientList.ToList();
        }
        private bool UpdateCSVFile()
        {
            try
            {
                var stringBuilder = new StringBuilder();

                foreach (Patient patient in _patientList)
                {
                    string[] value = { patient.FirstName, patient.SurName, patient.Gender, patient.Age.ToString(), patient.DateOfConsultation.ToString(), patient.Diagnosis, patient.Id.ToString(), 
                        patient.MobileNumber.ToString(), patient.EmailAddress, patient.Address1, patient.Address2, patient.City, patient.Province, patient.Country, 
                        patient.ZipCode.ToString(), patient.Doctor, Environment.NewLine };

                    var data = string.Join(",", value);

                    stringBuilder.Append(data);
                }

                using (StreamWriter streamWriter = new StreamWriter(_path))
                {
                    streamWriter.Write(stringBuilder);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

            
        }
    }
}
