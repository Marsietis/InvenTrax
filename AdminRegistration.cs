using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace InvenTrax1
{
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private bool CheckIfEmpty()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                return true;
            }

            return false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckIfEmpty() == false)
            {
                string pathLogin = Path.Combine(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
                    "login.txt");

                string[] lines = File.ReadAllLines(pathLogin);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(' ');

                    if (values[0] == "admin")
                    {
                        lines[i] = "admin " + textBox1.Text + " " + textBox2.Text + " admin";
                        break;
                    }
                }

                File.WriteAllLines(pathLogin, lines);
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