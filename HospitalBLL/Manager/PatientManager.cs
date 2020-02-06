using HospitalBLL.Models;
using HospitalBLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace HospitalBLL.Manager
{
    public class PatientManager
    {
        private PatientRepository _patientRepository = new PatientRepository();

        public bool AddRecord(Patient patient)
        {
            return _patientRepository.AddRecord(patient);
        }
        public IList<Patient> Read()
        {
            return _patientRepository.Read();
        }
        public bool Delete(List<Patient> patients)
        {
            return _patientRepository.Delete(patients);
        }
        public bool Update(Patient oldPatientRecord, Patient newPatientRecord)
        {
            return _patientRepository.Update(oldPatientRecord, newPatientRecord);
        }

        
    }
}
