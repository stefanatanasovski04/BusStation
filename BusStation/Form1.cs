namespace BusStation
{
    public partial class Form1 : Form
    {
        public Station BitolaStation;
        public Station VelesStation;
        public Station SkopjeStation;
        public Station PrilepStation;
        public static Line line;
        public static Station station;
        public static Destination destination;
        public static List<Station> Stations;
        public Form1()
        {
            InitializeComponent();
            Stations = new List<Station>();
            BitolaStation = new Station("Битола", "Македонија");
            VelesStation = new Station("Велес", "Македонија");
            SkopjeStation = new Station("Скопје", "Македонија");
            PrilepStation = new Station("Прилеп", "Македонија");
            BitolaStation.destinations.Add(new Destination(VelesStation,450, 120));
            BitolaStation.destinations.Add(new Destination(SkopjeStation, 600, 180));
            VelesStation.destinations.Add(new Destination(BitolaStation, 450, 120));
            VelesStation.destinations.Add(new Destination(SkopjeStation, 150, 60));
            SkopjeStation.destinations.Add(new Destination(BitolaStation, 600, 180));
            SkopjeStation.destinations.Add(new Destination(VelesStation, 150, 60));

            SkopjeStation.destinations[0].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[0], new DateTime(2023, 5, 1, 8, 30, 00)));
            SkopjeStation.destinations[0].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[0], new DateTime(2023, 5, 1, 9, 30, 00)));
            SkopjeStation.destinations[0].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[0], new DateTime(2023, 5, 1, 10, 30, 00)));
            SkopjeStation.destinations[0].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[0], new DateTime(2023, 5, 1, 11, 30, 00)));
            SkopjeStation.destinations[0].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[0], new DateTime(2023, 5, 1, 12, 30, 00)));
            SkopjeStation.destinations[1].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[1], new DateTime(2023, 5, 1, 8, 30, 00)));
            SkopjeStation.destinations[1].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[1], new DateTime(2023, 5, 1, 9, 30, 00)));
            SkopjeStation.destinations[1].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[1], new DateTime(2023, 5, 1, 10, 30, 00)));
            SkopjeStation.destinations[1].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[1], new DateTime(2023, 5, 1, 11, 30, 00)));
            SkopjeStation.destinations[1].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[1], new DateTime(2023, 5, 1, 12, 30, 00)));

            BitolaStation.destinations[0].Lines.Add(new Line(BitolaStation, BitolaStation.destinations[0], new DateTime(2023, 5, 1, 8, 30, 00)));
            BitolaStation.destinations[0].Lines.Add(new Line(BitolaStation, BitolaStation.destinations[0], new DateTime(2023, 5, 2, 8, 30, 00)));
            BitolaStation.destinations[0].Lines.Add(new Line(BitolaStation, BitolaStation.destinations[0], new DateTime(2023, 6, 1, 9, 30, 00)));
            BitolaStation.destinations[0].Lines.Add(new Line(BitolaStation, BitolaStation.destinations[0], new DateTime(2023, 6, 2, 8, 30, 00)));
            BitolaStation.destinations[0].Lines.Add(new Line(BitolaStation, BitolaStation.destinations[0], new DateTime(2023, 7, 1, 11, 30, 00)));
            BitolaStation.destinations[1].Lines.Add(new Line(BitolaStation, BitolaStation.destinations[1], new DateTime(2023, 5, 1, 8, 30, 00)));
            BitolaStation.destinations[1].Lines.Add(new Line(BitolaStation, BitolaStation.destinations[1], new DateTime(2023, 5, 2, 8, 30, 00)));
            BitolaStation.destinations[1].Lines.Add(new Line(BitolaStation, BitolaStation.destinations[1], new DateTime(2023, 6, 1, 9, 30, 00)));
            BitolaStation.destinations[1].Lines.Add(new Line(BitolaStation, BitolaStation.destinations[1], new DateTime(2023, 6, 2, 8, 30, 00)));
            BitolaStation.destinations[1].Lines.Add(new Line(BitolaStation, BitolaStation.destinations[1], new DateTime(2023, 7, 1, 11, 30, 00)));

            VelesStation.destinations[0].Lines.Add(new Line(VelesStation, VelesStation.destinations[0], new DateTime(2023, 5, 1, 8, 30, 00)));
            VelesStation.destinations[0].Lines.Add(new Line(VelesStation, VelesStation.destinations[0], new DateTime(2023, 5, 2, 8, 30, 00)));
            VelesStation.destinations[0].Lines.Add(new Line(VelesStation, VelesStation.destinations[0], new DateTime(2023, 6, 1, 9, 30, 00)));
            VelesStation.destinations[0].Lines.Add(new Line(VelesStation, VelesStation.destinations[0], new DateTime(2023, 6, 2, 8, 30, 00)));
            VelesStation.destinations[0].Lines.Add(new Line(VelesStation, VelesStation.destinations[0], new DateTime(2023, 7, 1, 11, 30, 00)));
            VelesStation.destinations[1].Lines.Add(new Line(VelesStation, VelesStation.destinations[1], new DateTime(2023, 5, 1, 8, 30, 00)));
            VelesStation.destinations[1].Lines.Add(new Line(VelesStation, VelesStation.destinations[1], new DateTime(2023, 5, 2, 8, 30, 00)));
            VelesStation.destinations[1].Lines.Add(new Line(VelesStation, VelesStation.destinations[1], new DateTime(2023, 6, 1, 9, 30, 00)));
            VelesStation.destinations[1].Lines.Add(new Line(VelesStation, VelesStation.destinations[1], new DateTime(2023, 6, 2, 8, 30, 00)));
            VelesStation.destinations[1].Lines.Add(new Line(VelesStation, VelesStation.destinations[1], new DateTime(2023, 7, 1, 11, 30, 00)));

            //var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            Stations.Add(BitolaStation);
            Stations.Add(SkopjeStation);
            Stations.Add(VelesStation);
            Stations.Add(PrilepStation);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Stations.Count; i++)
            {
                lbStations.Items.Add(Stations[i]);
            }
        }

        private void loadLines()
        {
            lbLines.Items.Clear();
            if (lbDestinations.SelectedIndex != -1)
            {
                Destination selectedDestination = lbDestinations.Items[lbDestinations.SelectedIndex] as Destination;
                for (int i = 0; i < selectedDestination.Lines.Count; i++)
                {
                    lbLines.Items.Add(selectedDestination.Lines[i]);
                }
            }
        }

        private void loadDestinations()
        {
            lbDestinations.Items.Clear();
            if (lbStations.SelectedIndex != -1)
            {
                Station selectedStation = lbStations.Items[lbStations.SelectedIndex] as Station;
                for (int i = 0; i < selectedStation.destinations.Count; i++)
                {
                    lbDestinations.Items.Add(selectedStation.destinations[i]);
                }
            }
        }

        private void lbStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            station = lbStations.SelectedItem as Station;
            loadDestinations();
            lbLines.Items.Clear();

        }

        private void lbStations_SelectedValueChanged(object sender, EventArgs e)
        {
            station = lbStations.SelectedItem as Station;
            loadDestinations();
            lbLines.Items.Clear();

        }

        private void lbDestinations_SelectedIndexChanged(object sender, EventArgs e)
        {
            destination = lbDestinations.SelectedItem as Destination;
            loadLines();
        }

        private void lbDestinations_SelectedValueChanged(object sender, EventArgs e)
        {
            destination = lbDestinations.SelectedItem as Destination;
            loadLines();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (lbLines.SelectedIndex == -1)
            {
                MessageBox.Show("Мора да одберете линија!");
            }
            else
            {
                PersonalInformationForm personalInformationForm = new PersonalInformationForm();
                line = lbLines.SelectedItem as Line;
                if (personalInformationForm.ShowDialog() == DialogResult.OK)
                {
                    loadLines();
                }
            }

        }

        private void btnAddStation_Click(object sender, EventArgs e)
        {
            AddStationForm addStationForm = new AddStationForm();
            addStationForm.ShowDialog();


            if (addStationForm.DialogResult == DialogResult.OK)
            {
                //Station station = new Station(addStationForm.station.City, addStationForm.station.Country);
                lbStations.Items.Add(addStationForm.station);
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if (lbStations.SelectedIndex == -1)
            {
                MessageBox.Show("Мора да селектирате појдовна станица!");
            }
            else
            {
                station = lbStations.SelectedItem as Station;
                AddDestinationForm addDestinationForm = new AddDestinationForm();
                addDestinationForm.ShowDialog();
                if (addDestinationForm.DialogResult == DialogResult.OK)
                {
                    lbDestinations.Items.Add(addDestinationForm.destination);
                }
            }

        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            if(lbStations.SelectedIndex == -1 || lbDestinations.SelectedIndex == -1) {
                MessageBox.Show("За да додадете линија мора да имате селектирано појдовна станица и дестинациона станица!");
            }
            else
            {
                AddLineForm addLineForm = new AddLineForm();
                addLineForm.ShowDialog();
                if(addLineForm.DialogResult == DialogResult.OK)
                {
                    destination.Lines.Add(addLineForm.line);
                    loadLines();
                }
            }
        }
    }
}