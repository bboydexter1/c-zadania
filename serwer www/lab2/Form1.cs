using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace lab2
{
    public partial class window1 : Form
    {
        Server server;

        public window1()
        {
            InitializeComponent();
            server = new Server();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            server.StartServer(portInput.Text, dirInput.Text);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            server.StopServer();
        }

        private void dirBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.RootFolder = Environment.SpecialFolder.Desktop;
            
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dirInput.Text = folderBrowser.SelectedPath;
            }
        }
    }
}
