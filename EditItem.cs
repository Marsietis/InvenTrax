using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace InvenTrax1
{
    public partial class EditItem : Form
    {
        private readonly string _location;

        public EditItem(string location)
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
            ShowItem item = new ShowItem(_location);
            item.Show();
        }

        private bool CheckIfEmpty()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                return true;
            }

            return false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckIfEmpty())
            {
                MessageBox.Show(@"Please fill in all fields");
                return;
            }

            string itemId = textBox1.Text;


            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "items.csv");

            // Read all the existing rows from the file
            List<string> rows = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 3 && parts[2] == itemId && parts[0] == _location)
                    {
                        // ID and location cannot be edited, so skip this row
                        continue;
                    }

                    rows.Add(line);
                }
            }

            string itemName = textBox2.Text;
            string itemPrice = textBox3.Text;
            string itemProperties = richTextBox1.Text.Replace(',', ';');
            string itemQuantity = textBox4.Text;
            string newRow = $"{_location},{itemName},{itemId},{itemPrice},{itemProperties},{itemQuantity}";
            rows.Add(newRow);

            // Write all the rows, including the updated one, back to the file
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (string row in rows)
                {
                    writer.WriteLine(row);
                }
            }

            MessageBox.Show(@"Item updated");
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            textBox4.Clear();
            string itemId = textBox1.Text;
            if (itemId == "")
            {
                MessageBox.Show(@"Please enter an item ID");
                return;
            }

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "items.csv");
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                string location = items[0];
                string name = items[1];
                string id = items[2];
                string price = items[3];
                string properties = items[4];
                string quantity = items[5];
                if (location == _location && id == itemId)
                {
                    textBox2.Text = name;
                    textBox3.Text = price;
                    richTextBox1.Text = properties;
                    textBox4.Text = quantity;
                }
            }
        }
    }
}