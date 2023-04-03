using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Reflection;

namespace InvenTrax1
{
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
                "login.csv");

            string[] lines = File.ReadAllLines(filePath);

            string remove = textBox1.Text;

            if (remove == "admin")
            {
                MessageBox.Show(@"Cannot remove admin");
                return;
            }

            if (!lines.Any(line => line.Contains(remove)))
            {
                MessageBox.Show(@"User does not exist");
                return;
            }

            if (remove == "")
            {
                MessageBox.Show(@"Please enter a username");
                return;
            }

            lines = lines.Where(line => !line.Contains(remove + " ")).ToArray();

            File.WriteAllLines(filePath, lines);

            MessageBox.Show(@"User removed");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}