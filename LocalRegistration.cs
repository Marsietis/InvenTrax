using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace InvenTrax1
{
    public partial class LocalRegistration : Form
    {
        private readonly string _location;

        public LocalRegistration(string location)
        {
            _location = location;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathLogin =
                Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
                    "login.txt");

            if (!File.Exists(pathLogin))
            {
                File.WriteAllText(pathLogin,
                    $@"user {textBox1.Text} {textBox2.Text} {_location}");
            }

            else
            {
                string[] lines = File.ReadAllLines(pathLogin);
                int size = lines.Length;
                size++;
                string[] newLines = new string[size];
                for (int i = 0; i < size - 1; i++) newLines[i] = lines[i];
                newLines[size - 1] = "user " + textBox1.Text + " " + textBox2.Text + " " + _location;
                File.WriteAllLines(pathLogin, newLines);
            }

            MessageBox.Show(@"User registered");

            Close();
        }
    }
}