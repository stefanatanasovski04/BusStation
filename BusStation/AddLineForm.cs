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
    public partial class AddLineForm : Form
    {
        public Line line { get; set; }

        public AddLineForm()
        {
            InitializeComponent();
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yy h:mm tt";
        }

        private void AddLineForm_Load(object sender, EventArgs e)
        {
            string str = "Линија за " + Form1.station.City + "-" + Form1.destination.station.City;
            lblTakeoffDestination.Text = str;

        }

        private void dtpDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpDate.Value < DateTime.Now)
            {
                errorProvider1.SetError(dtpDate, "Внесете валиден датум!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dtpDate, null);
                e.Cancel = false;
            }
        }

        private void nudFreeSeats_Validating(object sender, CancelEventArgs e)
        {

            //{
            //    if (nudFreeSeats.Value < 0)
            //    {
            //        errorProvider1.SetError(nudFreeSeats, "Внесете број поголем од 0!");
            //        e.Cancel = true;
            //    }
            //    else
            //    {
            //        errorProvider1.SetError(nudFreeSeats, null);
            //        e.Cancel = false;
            //    }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            TimeOnly timeOnly = new TimeOnly();

            DateTime date = dtpDate.Value;
            //MessageBox.Show(date.ToString());
            if (ValidateChildren())
            {
                line = new Line(Form1.station, Form1.destination, dtpDate.Value);
                DialogResult = DialogResult.OK;
            }


        }
    }
}
