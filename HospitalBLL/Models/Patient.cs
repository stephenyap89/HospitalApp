using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalBLL.Models
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfConsultation { get; set; }
        public string Diagnosis { get; set; }
    }
}
