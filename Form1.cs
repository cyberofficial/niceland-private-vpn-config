using System;
using System.Windows.Forms;
using System.Net.Http;

namespace niceland_private_vpn_config
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();

            try
            {
                // Download the list from the URL
                string content = await httpClient.GetStringAsync("https://raw.githubusercontent.com/tunnels-is/info/master/all");

                // Split the content by lines
                string[] lines = content.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                // Populate the ComboBox
                foreach (string line in lines)
                {
                    RouterIP.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., show a message box)
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private async void RefreshRouterIP_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();

            try
            {
                // Download the list from the URL
                string content = await httpClient.GetStringAsync("https://raw.githubusercontent.com/tunnels-is/info/master/all");

                RouterIP.Items.Clear();

                // Split the content by lines
                string[] lines = content.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                // Populate the ComboBox
                foreach (string line in lines)
                {
                    RouterIP.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., show a message box)
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
}
