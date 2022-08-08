using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousClientServer
{
    public partial class Form1 : Form
    {
        AsynchronousSocketListener socketListener;
        AsynchronousClient asynchronusClient;
        public Form1()
        {
            InitializeComponent();
            this.socketListener = new AsynchronousSocketListener();
            this.asynchronusClient = new AsynchronousClient();
        }

        private void btnStartListener_Click(object sender, EventArgs e)
        {
            Thread listenerThread = null;
            ThreadStart listenerThreadStart;

            listenerThreadStart = new ThreadStart(socketListener.StartListening);
            listenerThread = new Thread(listenerThreadStart);
            listenerThread.Start();

            //listener.StartListening();
        }

        private void btnStartClient_Click(object sender, EventArgs e)
        {
            this.asynchronusClient.StartClient();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            this.asynchronusClient.Send(this.asynchronusClient.GetSocket(), this.tbClientMessageSent.Text);
        }
    }
}
