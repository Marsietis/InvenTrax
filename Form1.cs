using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static InvenTrax1.Encryption;

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
                "login.csv");

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
            string password = Encrypt(Password.Text);
            foreach (string line in lines)
            {
                string[] values = line.Split(' ');

                if (values.Length != 4)
                {
                    continue;
                }

                if (values[0] == "admin" && values[1] == Username.Text && values[2] == password)
                {
                    Admin admin = new Admin();
                    admin.Show();
                    return true;
                }

                if (values[0] == "local" && values[1] == Username.Text && values[2] == password)
                {
                    InvenTrax invenTrax = new InvenTrax(values[3]);
                    invenTrax.Show();
                    return true;
                }

                if (values[0] == "user" && values[1] == Username.Text && values[2] == password)
                {
                    InvenTraxUser user = new InvenTraxUser(values[3]);
                    user.Show();
                    return true;
                }
            }

            return false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.Close();
                }
            }
        }
    }
}