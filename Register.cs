using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using static InvenTrax1.Encryption;

namespace InvenTrax1
{
    public partial class Register : Form
    {
        public Register()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            string password = Encrypt(textBox2.Text);
            if (CheckIfEmpty() == false)
            {
                string pathLogin =
                    Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
                        "login.csv");

                if (!File.Exists(pathLogin))
                {
                    //replace space in textBox3.Text with underscore
                    if (textBox3.Text.Contains(" "))
                    {
                        textBox3.Text = textBox3.Text.Replace(" ", "_");
                    }

                    File.WriteAllText(pathLogin,
                        $@"local {textBox1.Text} {password} {textBox3.Text}");
                }

                else
                {
                    if (textBox3.Text.Contains(" "))
                    {
                        textBox3.Text = textBox3.Text.Replace(" ", "_");
                    }

                    string[] lines = File.ReadAllLines(pathLogin);
                    int size = lines.Length;
                    size++;
                    string[] newLines = new string[size];
                    for (int i = 0; i < size - 1; i++) newLines[i] = lines[i];
                    newLines[size - 1] = "local " + textBox1.Text + " " + password + " " + textBox3.Text;
                    File.WriteAllLines(pathLogin, newLines);
                }

                MessageBox.Show(@"User registered");

                Close();
            }
            else
            {
                MessageBox.Show(@"Please fill in all fields");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}