using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Reflection;

namespace InvenTrax1
{
    public partial class LocalRemove : Form
    {
        public LocalRemove()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
                "login.txt");

            string[] lines = File.ReadAllLines(filePath);

            string remove = textBox1.Text;

            if (string.IsNullOrWhiteSpace(remove))
            {
                MessageBox.Show(@"Please enter a username");
                return;
            }

            lines = lines.Where(line => !line.Contains(remove) || line.Contains("admin") || line.Contains("local"))
                .ToArray();

            if (lines.Length == 0)
            {
                MessageBox.Show(@"User does not exist");
                return;
            }

            File.WriteAllLines(filePath, lines);

            MessageBox.Show(@"User removed");
            Close();
        }
    }
}