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

    public partial class PersonalInformationForm : Form
    {
        public Ticket ticket;
        public PersonalInformationForm()
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string lastName = tbLastName.Text;
            int numOfTickets = (int)nudNumberOfTickets.Value;
            Line line = Form1.line;
            int price = line.destination.Price * numOfTickets;

            ticket = new Ticket(name, lastName, line, numOfTickets);
            Form1.line.availableSeats = Form1.line.availableSeats - numOfTickets;
            DialogResult = DialogResult.OK;



            try
            {
                PrintTicketForm p = new PrintTicketForm();

                p.ticket = ticket; ;
                p.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greshka");
            }

        }

        private void nudNumberOfTickets_ValueChanged(object sender, EventArgs e)
        {
            Line line = Form1.line;
            int numOfTickets = (int)nudNumberOfTickets.Value;
            int price = line.destination.Price * numOfTickets;
            lblTotalPriceTicket.Text = price.ToString();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Length == 0)
            {
                errorProvider1.SetError(tbName, "Полето за име е задолжително!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (tbLastName.Text.Length == 0)
            {
                errorProvider1.SetError(tbLastName, "Полето за име е задолжително!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbLastName, null);
                e.Cancel = false;
            }
        }

        private void PersonalInformationForm_Load(object sender, EventArgs e)
        {
            Line line = Form1.line;
            int numOfTickets = (int)nudNumberOfTickets.Value;
            int price = line.destination.Price * numOfTickets;
            lblTotalPriceTicket.Text = price.ToString();
        }
    }
}
