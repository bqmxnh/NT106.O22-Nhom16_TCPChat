using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace TCPChatServer
{
    public partial class ServerForm : Form
    {
        // Form đóng bởi người dùng 
        private bool isClosingByButton = false;
        public ServerForm()
        {
            InitializeComponent();
        }

        private void StartServerButton_Click_1(object sender, EventArgs e)
        {

        }

        private void SendToClientsButton_Click(object sender, EventArgs e)
        {

        }

        private void ServerForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            isClosingByButton = e.CloseReason == CloseReason.UserClosing;
            if (isClosingByButton)
            {
                Application.Exit();
                Environment.Exit(0);
            }
        }
    }
}
