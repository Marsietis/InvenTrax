using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;


namespace InvenTrax1
{
    public partial class InvenTraxUser : Form
    {
        private readonly string _location;

        public InvenTraxUser(string location)
        {
            _location = location;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label1.Text = $@"Signed in as: {_location} user";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "items.csv");
            string[] lines = File.ReadAllLines(filePath);
            List<string> lowQuantityItems = new List<string>();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                string location = items[0];
                string name = items[1];
                string id = items[2];
                string quantity = items[5];

                if (Convert.ToInt32(quantity) < 2 && location == _location)
                {
                    lowQuantityItems.Add(name + " " + id);
                }
            }

            if (lowQuantityItems.Count > 0) // Step 3
            {
                string lowQuantityItemsList = string.Join(", ", lowQuantityItems);
                string titleReminder = "Reminder";
                MessageBox.Show($@"The following items have low quantity: {Environment.NewLine} {lowQuantityItemsList}",
                    titleReminder);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ShowItem showitem = new ShowItem(_location);
            showitem.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search search = new Search(_location);
            search.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity(_location);
            quantity.Show();
        }
    }
}