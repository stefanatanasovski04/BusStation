namespace BusStation
{
    public partial class Form1 : Form
    {
        public Station BitolaStation;
        public Station VelesStation;
        public Station SkopjeStation;
        public static Line line;
        public Form1()
        {
            InitializeComponent();
            BitolaStation = new Station("Битола", "Македонија");
            VelesStation = new Station("Велес", "Македонија");
            SkopjeStation = new Station("Скопје", "Македонија");
            BitolaStation.destinations.Add(new Destination(VelesStation, 120, 450));
            BitolaStation.destinations.Add(new Destination(SkopjeStation, 180, 600));
            VelesStation.destinations.Add(new Destination(BitolaStation, 120, 450));
            VelesStation.destinations.Add(new Destination(SkopjeStation, 60, 150));
            SkopjeStation.destinations.Add(new Destination(BitolaStation, 180, 600));
            SkopjeStation.destinations.Add(new Destination(VelesStation, 60, 150));

            SkopjeStation.destinations[0].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[0], new DateTime(2023, 5, 1, 8, 30, 00)));
            SkopjeStation.destinations[0].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[0], new DateTime(2023, 5, 1, 9, 30, 00)));
            SkopjeStation.destinations[0].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[0], new DateTime(2023, 5, 1, 10, 30, 00)));
            SkopjeStation.destinations[0].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[0], new DateTime(2023, 5, 1, 11, 30, 00)));
            SkopjeStation.destinations[0].Lines.Add(new Line(SkopjeStation, SkopjeStation.destinations[0], new DateTime(2023, 5, 1, 12, 30, 00)));
            //var date1 = new DateTime(2008, 5, 1, 8, 30, 52);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbStations.Items.Add(BitolaStation);
            lbStations.Items.Add(VelesStation);
            lbStations.Items.Add(SkopjeStation);
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
            loadDestinations();
        }

        private void lbStations_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDestinations();
        }

        private void lbDestinations_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLines();
        }

        private void lbDestinations_SelectedValueChanged(object sender, EventArgs e)
        {
            loadLines();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            PersonalInformationForm personalInformationForm = new PersonalInformationForm();
            line = lbLines.SelectedItem as Line;
            if (personalInformationForm.ShowDialog() == DialogResult.OK)
            {
                loadLines();
            }
        }
    }
}