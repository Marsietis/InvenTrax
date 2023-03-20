using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace InvenTrax1
{
    public partial class Quantity : Form
    {
        private readonly string _location;

        public Quantity(string location)
        {
            _location = location;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowItem items = new ShowItem(_location);
            items.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchId = textBox1.Text;
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "items.csv");
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                string location = items[0];
                string id = items[2];
                string quantity = items[5];
                if (location == _location && searchId == id)
                {
                    label2.Text = $@"Item found. Quantity: {quantity}";
                }
                else
                {
                    label2.Text = @"Item not found";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchId = textBox1.Text;
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "items.csv");
            string[] lines = File.ReadAllLines(filePath);
            List<string> updatedLines = new List<string>();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                string location = items[0];
                string id = items[2];
                string quantity = items[5];
                if (location == _location && searchId == id)
                {
                    int currentQuantity = int.Parse(quantity);
                    int newQuantity = currentQuantity - 1;
                    if (newQuantity >= 0)
                    {
                        items[5] = newQuantity.ToString();
                        label2.Text = $@"Item found. Quantity: {newQuantity}";
                    }
                }

                updatedLines.Add(string.Join(",", items));
            }

            File.WriteAllLines(filePath, updatedLines.ToArray());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string searchId = textBox1.Text;
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "items.csv");
            string[] lines = File.ReadAllLines(filePath);
            List<string> updatedLines = new List<string>();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                string location = items[0];
                string id = items[2];
                string quantity = items[5];
                if (location == _location && searchId == id)
                {
                    int currentQuantity = int.Parse(quantity);
                    int newQuantity = currentQuantity + 1;
                    items[5] = newQuantity.ToString();
                    label2.Text = $@"Item found. Quantity: {newQuantity}";
                }

                updatedLines.Add(string.Join(",", items));
            }

            File.WriteAllLines(filePath, updatedLines.ToArray());
        }
    }
}