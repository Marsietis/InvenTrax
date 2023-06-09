﻿using System;
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

        private bool CheckIfEmpty()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
                richTextBox1.Text == "")
            {
                return true;
            }

            return false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckIfEmpty())
            {
                MessageBox.Show(@"Please fill in all fields");
                return;
            }

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
                    if (fields.Length >= 3 && fields[2] == itemId)
                    {
                        if (fields[1] != itemName || fields[0] == _location)
                        {
                            itemExists = true;
                            break;
                        }
                    }
                }
            }

            if (itemExists)
            {
                MessageBox.Show(@"An item with the same ID already exists with a different name.");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(row);
                }

                MessageBox.Show(@"Item added");
                Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}