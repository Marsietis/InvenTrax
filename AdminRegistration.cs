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

        private void button1_Click(object sender, EventArgs e)
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


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}