using HospitalBLL.Manager;
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
    public partial class MdiForm : Form
    {
        
        public MdiForm()
        {
            InitializeComponent();
        }
        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDoctorForm doctorform = new AddDoctorForm();
            ShowForm(doctorform);
        }
        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatientForm patientform = new AddPatientForm();
            ShowForm(patientform);
        }

        private void MdiForm_Load(object sender, EventArgs e)
        {
            
        }
        private void patientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewPatientFrm viewpatient = new ViewPatientFrm();
            ShowForm(viewpatient);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsfrm = new SettingsForm();
            ShowForm(settingsfrm);
        }
        private void doctorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewDoctorFrm viewdoctor = new ViewDoctorFrm();
            ShowForm(viewdoctor);
        }
        private void ShowForm(Form form)
        {
            var child = MdiChildren.FirstOrDefault(x => x.Name.Equals(form.Name));
            if (child != null)
            {
                child.BringToFront();
            }
            else
            {
                form.Show();
                form.MdiParent = this;
            }
        }
    }
}
