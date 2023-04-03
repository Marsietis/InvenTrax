using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static InvenTrax1.Encryption;

namespace InvenTrax1
{
    public partial class LocalPasswordChange : Form
    {
        private readonly string _location;

        public LocalPasswordChange(string location)
        {
            _location = location;
            InitializeComponent();
        }

        private bool CheckIfEmpty()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                return true;
            }

            return false;
        }

        private bool CheckIfMatch()
        {
            if (textBox1.Text == textBox2.Text)
            {
                return true;
            }

            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckIfEmpty() == false)
            {
                if (CheckIfMatch() == false)
                {
                    MessageBox.Show(@"Passwords do not match");
                    return;
                }

                string pathLogin = Path.Combine(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
                    "login.csv");

                string[] lines = File.ReadAllLines(pathLogin);
                string password = Encrypt(textBox2.Text);

                bool found = false;
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(' ');

                    if (values[3] == _location && values[1] == textBox3.Text)
                    {
                        lines[i] = "local " + values[1] + " " + password + " " + _location;
                        found = true;
                        break;
                    }
                }

                if (found == false)
                {
                    MessageBox.Show(@"User not found");
                    return;
                }


                File.WriteAllLines(pathLogin, lines);
                MessageBox.Show(@"Password updated");
            }
            else
            {
                MessageBox.Show(@"Please fill in all fields");
            }
        }
    }
}