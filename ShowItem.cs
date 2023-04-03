using System;
using System.Windows.Forms;
using System.IO;

namespace InvenTrax1
{
    public partial class ShowItem : Form
    {
        private readonly string _location;

        public ShowItem(string location)
        {
            InitializeComponent();
            _location = location;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "items.csv");
            string[] lines = File.ReadAllLines(filePath);
            bool foundItems = false;
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                string location = items[0];
                string name = items[1];
                string id = items[2];
                string price = items[3];
                string properties = items[4];
                string quantity = items[5];
                string row =
                    $"Name: {name}, ID: {id}, Price: {price} Eur, Properties: {properties}, Quantity: {quantity}, Locations: {location}";
                if (radioButton1.Checked)
                {
                    if (location == _location)
                    {
                        listBox1.Items.Add(row);
                        foundItems = true;
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (location != _location)
                    {
                        listBox1.Items.Add(row);
                        foundItems = true;
                    }
                }
                else if (radioButton3.Checked)
                {
                    listBox1.Items.Add(row);
                    foundItems = true;
                }
            }

            if (!foundItems)
            {
                listBox1.Items.Add("No items found.");
            }
        }
    }
}