using HospitalBLL.Models;
using HospitalBLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalBLL.Manager
{
    public class PatientManager
    {
        private BaseRepository baseRepository = new BaseRepository();

        public bool AddRecord(Patient patient)
        {
            return baseRepository.AddRecord(patient);
        }

        public IList<Patient> Read()
        {
            return baseRepository.Read();
        }

    }
}
