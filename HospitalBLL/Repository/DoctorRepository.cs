using HospitalBLL.Models;
using HospitalBLL.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalBLL.Repository
{
    public class DoctorRepository
    {
        private static IList<Doctor> _doctorList = new List<Doctor>();
        private readonly string _doctorCSVPath = ConfigurationManager.AppSettings["DoctorCSVPath"];
        private readonly string _DocPath = Directory.GetCurrentDirectory();


        public bool AddDoctor(Doctor doctor)
        {
            _doctorList.Add(doctor);
            return UpdateDoctorCSVFile();
        }
        
        private bool UpdateDoctorCSVFile()
        {
            try
            {
                var stringBuilder = new StringBuilder();

                foreach (Doctor doctor in _doctorList)
                {
                    string[] value = { doctor.Id.ToString(), doctor.LastName, doctor.LastName, doctor.Department, Environment.NewLine };

                    var data = string.Join(",", value);

                    stringBuilder.Append(data);
                }

                using (StreamWriter streamWriter = new StreamWriter(_doctorCSVPath))
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
