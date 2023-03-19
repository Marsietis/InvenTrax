using System;
using System.Windows.Forms;

namespace InvenTrax1
{
    public partial class InvenTrax : Form
    {
        private readonly string _location;

        public InvenTrax(string location)
        {
            InitializeComponent();
            _location = location;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label1.Text = $@"Signed in as: {_location}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem(_location);
            addItem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}