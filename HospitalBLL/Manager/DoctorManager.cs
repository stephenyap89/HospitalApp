﻿using HospitalBLL.Models;
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
        DoctorRepository doctorRepository = new DoctorRepository();
        public bool AddDoctor(Doctor doctor)
        {
            return doctorRepository.AddDoctor(doctor);
        }
        //public IList<Doctor> Read()
        //{
        //    return doctorRepository.Read();
        //}
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
