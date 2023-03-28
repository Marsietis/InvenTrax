using System;
using System.Windows.Forms;
using System.IO;

namespace InvenTrax1
{
    public partial class AddItem : Form
    {
        private readonly string _location;

        public AddItem(string location)
        {
            InitializeComponent();
            _location = location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = textBox1.Text;
            string itemId = textBox2.Text;
            string itemPrice = textBox3.Text;
            string itemProperties = richTextBox1.Text.Replace(',', ';');
            int itemQuantity = Convert.ToInt32(textBox4.Text);

            string row = $"{_location},{itemName},{itemId},{itemPrice},{itemProperties},{itemQuantity}";

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "items.csv");

            // Check if an item with the same ID already exists in the location
            bool itemExists = false;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    if (fields.Length >= 3 && fields[0] == _location && fields[2] == itemId)
                    {
                        itemExists = true;
                        break;
                    }
                }
            }

            if (itemExists)
            {
                MessageBox.Show(@"An item with the same ID already exists in this location.");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(row);
                }

                MessageBox.Show(@"Items added");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}