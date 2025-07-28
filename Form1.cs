
namespace Workshop_Selector_App
{
    public partial class Form1 : Form
    {
        Dictionary<string, (int days, double fee)> workshops = new Dictionary<string, (int, double)>()
{
    { "Handling Stress", (3, 1000) },
    { "Supervision Skills", (3, 1500) },
    { "How to Interview", (1, 500) },
    { "Time Management", (3, 800) },
    { "Negotiation", (5, 1300) }
};

        Dictionary<string, double> locations = new Dictionary<string, double>()
{
    { "Austin", 150 },
    { "Dallas", 175 },
    { "Phoenix", 175 },
    { "Chicago", 225 },
    { "Orlando", 300 },
    { "Raleigh", 150 }
};
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstWorkshops.Items.AddRange(workshops.Keys.ToArray());
            lstLocations.Items.AddRange(locations.Keys.ToArray());
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (lstWorkshops.SelectedItem == null || lstLocations.SelectedItem == null)
            {
                MessageBox.Show("Please select both a workshop and a location.");
                return;
            }

            string workshop = lstWorkshops.SelectedItem.ToString();
            string location = lstLocations.SelectedItem.ToString();

            var (days, regFee) = workshops[workshop];
            double lodgingPerDay = locations[location];
            double lodgingTotal = lodgingPerDay * days;
            double total = regFee + lodgingTotal;

            lblRegistration.Text = $"Registration Cost: ${regFee:F2}";
            lblLodging.Text = $"Lodging Cost: ${lodgingTotal:F2}";
            lblTotal.Text = $"Total Cost: ${total:F2}";
        }
    }
}
