using System;
using System.Windows.Forms;

namespace InvenTrax1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Remove remove = new Remove();
            remove.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminRegistration reg = new AdminRegistration();
            reg.Show();
        }
    }
}