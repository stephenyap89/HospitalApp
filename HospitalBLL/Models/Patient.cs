using CsvHelper.Configuration;
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
		public int Age { get; set; }
		public DateTime DateOfConsultation { get; set; }
		public string Diagnosis { get; set; }
		public int Id { get; set; }
		public string MobileNumber { get; set; }
		public string EmailAddress { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string Province { get; set; }
		public string Country { get; set; }
		public int ZipCode { get; set; }
		public string Doctor { get; set; }
		public bool isEqual(Patient patient)
		{
			var isTheSame = false;

			if (SurName.Equals(patient.SurName)
				&& FirstName.Equals(patient.FirstName)
				&& Gender.Equals(patient.Gender)
				&& DateOfConsultation.ToString().Equals(patient.DateOfConsultation.ToString())
				&& Diagnosis.Equals(patient.Diagnosis))
			{
				isTheSame = true;
			}

			return isTheSame;
		}

		public class ViewMap : ClassMap<Patient>
		{
			public ViewMap()
			{
				Map(m => m.FirstName).Index(0);
				Map(m => m.SurName).Index(1);
				Map(m => m.Gender).Index(2);
				Map(m => m.Age).Index(3);
				Map(m => m.DateOfConsultation).Index(4);
				Map(m => m.Diagnosis).Index(5);
				Map(m => m.Id).Index(6);
				Map(m => m.MobileNumber).Index(7);
				Map(m => m.EmailAddress).Index(8);
				Map(m => m.Address1).Index(9);
				Map(m => m.Address2).Index(10);
				Map(m => m.City).Index(11);
				Map(m => m.Province).Index(11);
				Map(m => m.Country).Index(12);
				Map(m => m.ZipCode).Index(13);
				Map(m => m.City).Index(14);
				Map(m => m.Doctor).Index(15);
			}
		}

	}
}
