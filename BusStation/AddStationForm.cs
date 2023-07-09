using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation
{
    public partial class AddStationForm : Form
    {
        public Station station { get; set; }
        public AddStationForm()
        {
            InitializeComponent();
        }

        private void AddStationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStation_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                station = new Station(tbCity.Text, tbCountry.Text);
                DialogResult = DialogResult.OK;
                Form1.Stations.Add(station);
            }
        }

        private void btnCancelAddStation_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if (tbCity.Text.Length == 0)
            {
                errorProvider1.SetError(tbCity, "Полето за град е задолжително!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCity, null);
                e.Cancel = false;
            }
        }

        private void tbCountry_Validating(object sender, CancelEventArgs e)
        {
            if (tbCountry.Text.Length == 0)
            {
                errorProvider1.SetError(tbCountry, "Полето за држава е задолжително!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCountry, null);
                e.Cancel = false;
            }
        }
    }
}
