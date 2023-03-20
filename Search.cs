using System;
using System.Windows.Forms;
using System.IO;

namespace InvenTrax1
{
    public partial class Search : Form
    {
        private readonly string _location;

        public Search(string location)
        {
            _location = location;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string searchName = textBox1.Text;
            string searchId = textBox2.Text;
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "items.csv");
            string[] lines = File.ReadAllLines(filePath);
            bool foundItem = false;
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
                    $"Name: {name}, ID: {id}, Price: {price} Eur, Properties: {properties}, Quantity: {quantity}";
                if (location == _location && searchName == name || searchId == id)
                {
                    foundItem = true;
                    listBox1.Items.Add(row);
                }
            }

            if (!foundItem)
            {
                MessageBox.Show(@"No items found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}