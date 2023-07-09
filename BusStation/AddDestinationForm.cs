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
    public partial class AddDestinationForm : Form
    {
        public Station station { get; set; }
        public Destination destination { get; set; }

        List<Station> Stations { get; set; }
        public AddDestinationForm()
        {
            InitializeComponent();

            for (int i = 0; i < Form1.Stations.Count; i++)
            {
                bool Found = false;
                Station item = Form1.Stations[i];
                if (Form1.station.City == Form1.Stations[i].City)
                {
                    continue;
                }
                else
                {
                    for (int j = 0; j < Form1.station.destinations.Count; j++)
                    {
                        if (item.City == Form1.station.destinations[j].station.City)
                        {
                            Found = true;
                            break;
                        }
                    }
                    if (!Found)
                    {
                        lbStationsInAdd.Items.Add(item);
                    }
                }
            }

        }     
            
 
        private void AddDestinationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                station = Form1.station;

                int price = 0;
                int distance = 0;
                price = int.Parse(tbPrice.Text);
                distance = int.Parse(tbDistance.Text);
                station = lbStationsInAdd.SelectedItem as Station;
                destination = new Destination(station, price, distance);


                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelAddDestination_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrice.Text.Length == 0)
            {
                errorProvider1.SetError(tbPrice, "Полето за цена е задолжително!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbPrice, null);
                e.Cancel = false;
            }
        }

        private void tbDistance_Validating(object sender, CancelEventArgs e)
        {
            if (tbDistance.Text.Length == 0)
            {
                errorProvider1.SetError(tbDistance, "Полето за далечина е задолжително!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbDistance, null);
                e.Cancel = false;
            }
        }

        private void lbStationsInAdd_Validating(object sender, CancelEventArgs e)
        {
            if (lbStationsInAdd.SelectedIndex == -1)
            {
                errorProvider1.SetError(lbStationsInAdd, "Мора да одберете дестинација!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(lbStationsInAdd, null);
                e.Cancel = false;
            }
        }
    }
}
