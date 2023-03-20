using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace InvenTrax1
{
    public partial class RemoveItem : Form
    {
        private readonly string _location;

        public RemoveItem(string location)
        {
            _location = location;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchId = textBox1.Text;
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "items.csv");
            List<string> newLines = new List<string>();
            bool foundItem = false;
            foreach (string line in File.ReadLines(filePath))
            {
                string[] items = line.Split(',');
                string location = items[0];
                string id = items[2];
                if (location == _location && searchId == id)
                {
                    foundItem = true;
                    MessageBox.Show(@"Item removed");
                    continue;
                }

                newLines.Add(line);
            }

            if (!foundItem)
            {
                MessageBox.Show(@"No items found");
            }
            else
            {
                File.WriteAllLines(filePath, newLines);
            }
        }
    }
}