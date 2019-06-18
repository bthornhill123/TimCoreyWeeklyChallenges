using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void LaunchMessage_Click(object sender, EventArgs e)
        {
            MessageCreation form = new MessageCreation();

            form.MessageCreationComplete += Form_MessageCreationComplete;

            form.Show();
        }

        private void Form_MessageCreationComplete(object sender, MessageModelEventArgs e)
        {
            messageText.Text = e.EventData.Message;
        }

        private void LaunchSubDashboard_Click(object sender, EventArgs e)
        {
            SubDashboard form = new SubDashboard();

            form.Show();
        }
    }
}
