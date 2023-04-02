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
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show(@"Please enter a valid username and password");
                return;
            }

            string pathLogin = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
                "login.txt");

            try
            {
                string[] lines = File.ReadAllLines(pathLogin);
                if (ButtonValidateLogin(lines))
                {
                    Hide(); //<-------- problem is here
                }
                else
                {
                    MessageBox.Show(@"Incorrect username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ButtonValidateLogin(string[] lines)
        {
            foreach (string line in lines)
            {
                string[] values = line.Split(' ');

                if (values.Length != 4)
                {
                    continue;
                }

                if (values[0] == "admin" && values[1] == Username.Text && values[2] == Password.Text)
                {
                    Admin admin = new Admin();
                    admin.Show();
                    return true;
                }

                if (values[0] == "local" && values[1] == Username.Text && values[2] == Password.Text)
                {
                    InvenTrax invenTrax = new InvenTrax(values[3]);
                    invenTrax.Show();
                    return true;
                }

                if (values[0] == "user" && values[1] == Username.Text && values[2] == Password.Text)
                {
                    InvenTraxUser user = new InvenTraxUser(values[3]);
                    user.Show();
                    return true;
                }
            }

            return false;
        }
    }
}