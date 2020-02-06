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
        


        public bool AddDoctor(Doctor doctor)
        {
            _doctorList.Add(doctor);
            return UpdateDoctorCSVFile();
        }

        public List<Doctor> Read()
        {
            if (_doctorList.Count == 0)
            {
                var data = File.ReadAllLines(_doctorCSVPath);

                foreach (var line in data)
                {
                    var doctor = line.Split(',');

                    _doctorList.Add(new Doctor
                    {
                        Id = Convert.ToInt32(doctor[0]),
                        FirstName = doctor[1],
                        LastName = doctor[2],
                        Department = doctor[3],
                    });
                }
            }
            return _doctorList.ToList();
        }

            
            private bool UpdateDoctorCSVFile()
            {
            try
            {
                var stringBuilder = new StringBuilder();

                foreach (Doctor doctor in _doctorList)
                {
                    string[] value = { doctor.Id.ToString(), doctor.FirstName, doctor.LastName, doctor.Department, Environment.NewLine };

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
