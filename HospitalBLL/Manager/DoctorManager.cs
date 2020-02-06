using HospitalBLL.Models;
using HospitalBLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalBLL.Manager
{
    public class DoctorManager
    {
        DoctorRepository _doctorRepository = new DoctorRepository();
        public bool AddDoctor(Doctor doctor)
        {
            return _doctorRepository.AddDoctor(doctor);
        }
        public IList<Doctor> Read()
        {
            return _doctorRepository.Read();
        }
        //public bool DeleteDoctor(List<Doctor> doctor)
        //{
        //    return doctorRepository.DeleteDoctor(doctor);
        //}
        //public bool UpdateDoctor(Doctor oldDoctorRecord, Doctor newDoctorRecord)
        //{
        //    return doctorRepository.UpdateDoctor(oldDoctorRecord, newDoctorRecord);
        //}
    }
}
