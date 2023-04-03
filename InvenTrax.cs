using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace InvenTrax1
{
    public partial class InvenTrax : Form
    {
        private readonly string _location;

        public InvenTrax(string location)
        {
            InitializeComponent();
            _location = location;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label1.Text = $@"Signed in as: {_location} admin";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem(_location);
            addItem.Show();
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

        private void button7_Click(object sender, EventArgs e)
        {
            LocalRemove localremove = new LocalRemove();
            localremove.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LocalRegistration localreg = new LocalRegistration(_location);
            localreg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity(_location);
            quantity.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RemoveItem removeitem = new RemoveItem(_location);
            removeitem.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EditItem edit = new EditItem(_location);
            edit.Show();
        }

        private void InvenTrax_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LocalPasswordChange localpasswordchange = new LocalPasswordChange(_location);
            localpasswordchange.Show();
        }
    }
}