using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace InvenTrax1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathLogin = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
                "login.txt");

            string[] lines = File.ReadAllLines(pathLogin);

            bool login = false;
            foreach (string line in lines)
            {
                string[] values = line.Split(' ');

                if (values[0] == "admin" && values[1] == Username.Text && values[2] == Password.Text)
                {
                    login = true;
                    Admin admin = new Admin();
                    admin.Show();
                    Hide();
                }

                else if (values[0] != "admin" && values[1] == Username.Text && values[2] == Password.Text)
                {
                    login = true;
                    InvenTrax invenTrax = new InvenTrax(values[3]);
                    invenTrax.Show();
                    Hide();
                }
            }

            if (login == false)
            {
                MessageBox.Show(@"Incorrect username or password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}