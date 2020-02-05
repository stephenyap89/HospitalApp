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
        private PatientRepository baseRepository = new PatientRepository();

        public bool AddRecord(Patient patient)
        {
            return baseRepository.AddRecord(patient);
        }
        public IList<Patient> Read()
        {
            return baseRepository.Read();
        }
        public bool Delete(List<Patient> patients)
        {
            return baseRepository.Delete(patients);
        }
        public bool Update(Patient oldPatientRecord, Patient newPatientRecord)
        {
            return baseRepository.Update(oldPatientRecord, newPatientRecord);
        }

        
    }
}
