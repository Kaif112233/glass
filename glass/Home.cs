using System.Windows.Forms;
using System;

namespace glass
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Open Dashboard in the panel by default
            LoadFormInPanel(new Dashboard());
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open AddIteam form in the panel
            LoadFormInPanel(new AddIteam());
        }

        private void LoadFormInPanel(Form form)
        {
            // Clear any existing controls in the panel
            panel1.Controls.Clear();

            // Set up the new form to embed into the panel
            form.TopLevel = false;  // Necessary for embedding
            form.Dock = DockStyle.Fill; // Optional: Make it fill the panel
            form.FormBorderStyle = FormBorderStyle.None; // Remove borders

            // Add the form to the panel and display it
            panel1.Controls.Add(form);
            form.Show();
        }
        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Open AddParty form in the panel
            LoadFormInPanel(new AddParty());
        }

    }
}
