using SuperSimpleTcp;
using System.Text;

namespace Workmate_server_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server = new SimpleTcpServer("127.0.0.1:16460");
        private void Form1_Load(object sender, EventArgs e)
        {

            server.Events.ClientConnected += ClientConnected;
            server.Events.ClientDisconnected += ClientDisconnected;
            server.Events.DataReceived += DataReceived;

            server.Start();

        }

        private void DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                logs_txt.Text += $"{DateTime.Now} - {e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";

                if (Encoding.UTF8.GetString(e.Data) == "Hello, world!")
                {
                    server.Send($"{e.IpPort}", "Hello from server");
                }
                else if (Encoding.UTF8.GetString(e.Data) == "Magazzino aggiornato")
                {
                    for (int i = 0; i < ClientsIP.Items.Count; i++)
                        if (ClientsIP.Items[i].ToString() != e.IpPort)
                            server.Send($"{ClientsIP.Items[i]}", "Aggiornare magazzino");
                }
                else if (Encoding.UTF8.GetString(e.Data) == "Prodotti aggiornati")
                {
                    for (int i = 0; i < ClientsIP.Items.Count; i++)
                        if (ClientsIP.Items[i].ToString() != e.IpPort)
                            server.Send($"{ClientsIP.Items[i]}", "Aggiornare prodotti");
                }
                else if (Encoding.UTF8.GetString(e.Data) == "Ordini aggiornati")
                {
                    for (int i = 0; i < ClientsIP.Items.Count; i++)
                        if (ClientsIP.Items[i].ToString() != e.IpPort)
                            server.Send($"{ClientsIP.Items[i]}", "Aggiornare ordini");
                }
                else if (Encoding.UTF8.GetString(e.Data) == "Clienti aggiornati")
                {
                    for (int i = 0; i < ClientsIP.Items.Count; i++)
                        if (ClientsIP.Items[i].ToString() != e.IpPort)
                            server.Send($"{ClientsIP.Items[i]}", "Aggiornare clienti");
                }
                else if (Encoding.UTF8.GetString(e.Data) == "Acquisti aggiornati")
                {
                    for (int i = 0; i < ClientsIP.Items.Count; i++)
                        if (ClientsIP.Items[i].ToString() != e.IpPort)
                            server.Send($"{ClientsIP.Items[i]}", "Aggiornare acquisti");
                }
            });
        }

        private void ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                logs_txt.Text += $"{DateTime.Now} - {e.IpPort}: Disconnesso.{Environment.NewLine}";
                ClientsIP.Items.Remove(e.IpPort);
            });
        }

        private void ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                logs_txt.Text += $"{DateTime.Now} - {e.IpPort}: Connesso.{Environment.NewLine}";
                ClientsIP.Items.Add(e.IpPort);
            });
        }
    }
}