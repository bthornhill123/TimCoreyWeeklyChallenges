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
    public partial class MessageCreation : Form
    {
        public event EventHandler<MessageModelEventArgs> MessageCreationComplete;

        public MessageCreation()
        {
            InitializeComponent();
        }

        private void CreateMessage_Click(object sender, EventArgs e)
        {
            MessageModel data = new MessageModel();

            data.Name = nameText.Text;
            data.Message = messageText.Text;

            MessageModelEventArgs args = new MessageModelEventArgs
            {
                EventData = data
            };

            MessageCreationComplete?.Invoke(this, args);

            this.Close();
        }
    }
}
