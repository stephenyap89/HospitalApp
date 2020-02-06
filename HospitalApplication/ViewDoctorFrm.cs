using HospitalBLL.Manager;
using HospitalBLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApplication
{
    public partial class ViewDoctorFrm : Form
    {
        private readonly DoctorManager _doctormanager;
        public Doctor _doctor;
        private readonly IList<Doctor> _doctorList;
      
        
        public ViewDoctorFrm()
        {
            _doctormanager = new DoctorManager();
            _doctorList = _doctormanager.Read();
            InitializeComponent();
        }

        private void ViewDoctorFrm_Load(object sender, EventArgs e)
        {
            DisplayDoctorInListView(_doctorList);
        }

        private void DisplayDoctorInListView(IList<Doctor> doctorList)
        {
            ListViewDoctor.Items.Clear();
            var listViewItems = new List<ListViewItem>();
            foreach (var doctor in doctorList)
            {
                var row = new ListViewItem(doctor.Id.ToString());
                row.SubItems.Add(doctor.FirstName);
                row.SubItems.Add(doctor.LastName);
                row.SubItems.Add(doctor.Department);

                listViewItems.Add(row);
                row.Tag = doctor;
            }
            ListViewDoctor.Items.AddRange(listViewItems.ToArray());
        }
    }
}
