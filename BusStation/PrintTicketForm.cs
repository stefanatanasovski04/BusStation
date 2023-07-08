using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace BusStation
{
    public partial class PrintTicketForm : Form
    {
        public Ticket ticket { get; set; }
        public String name { get; set; }
        public PrintTicketForm()
        {
            InitializeComponent();


        }
        public void init()
        {
            name = ticket.Name;
            DataGridViewRow row = (DataGridViewRow)dgPrint.Rows[0].Clone();
            row.Cells[0].Value = ticket.Name;
            row.Cells[1].Value = ticket.LastName;
            row.Cells[2].Value = ticket.line;
            row.Cells[3].Value = ticket.NumberOfSeats;
            row.Cells[4].Value = ticket.PriceTicket;
            dgPrint.Rows.Add(row);


        }


        private void PrintTicketForm_Load(object sender, EventArgs e)
        {
            init();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelPrintTicket_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
