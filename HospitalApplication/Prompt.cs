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
    public partial class Prompt : Form
    {
        public Prompt()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string _name;
            if (true)
            {
                SaveSettings();
                MessageBox.Show("Hospital saved successfully");
                this.Close();
                _name = TxtHospitalName.Text;
                
            }
        }

        

        public void SaveSettings()
        {
                //Properties.Settings.Default.HospitalName = TxtHospitalName.Text;
                //Properties.Settings.Default.Save();
                
        }

        private void Prompt_Load(object sender, EventArgs e)
        {

        }
    }
}
