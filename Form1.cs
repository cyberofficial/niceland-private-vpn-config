using System;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

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
            //  make RouterIP read only
            RouterIP.DropDownStyle = ComboBoxStyle.DropDownList;

            HttpClient httpClient = new();

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
            HttpClient httpClient = new();

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

        private void GenFileBtn_Click(object sender, EventArgs e)
        {
            // Get the values from the TextBox controls by their names
            string accountId = UID.Text;
            string apiKey = APIKey.Text;
            string ipaddr = IP.Text.Replace(" ", "");
            string vpnname = VPNTag.Text.Replace(" ", "-");
            bool internetAccess = InternetAccess.Checked;
            bool localNetworkAccess = LocalNetworkAccess.Checked;
            int availableMbps = (int)AvailableMbps.Value;
            int userMbps = (int)UserMbps.Value;
            string interfaceIP = InterfaceIP.Text.Replace(" ", "");
            // for routerIP we'll need to remove the text before the comma and the comma itself
            string routerIP = string.Empty;
            try
            {
                // Attempt to extract the value from RouterIP.Text
                routerIP = RouterIP.Text.Replace(" ", "").Split(',')[1];
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., show a message box or log the error)
                MessageBox.Show("An error occurred while extracting routerIP: " + ex.Message);
                // continue with the default value
                routerIP = "51.89.206.24";
            }
            int startPort = (int)StartPort.Value;
            int endPort = (int)EndPort.Value;

            // Create a list to hold NAT objects
            List<object> natList = new List<object>();

            // Create a NAT object
            var natObject = new
            {
                Tag = NAT_Tag.Text.Replace(" ", "-"),
                Network = NAT_Network.Text.Replace(" ", ""),
                Nat = NAT_Nat.Text.Replace(" ", "")
            };

            // Add the NAT object to the list
            natList.Add(natObject);

            // Create a JSON object with the NAT section
            var jsonObject = new
            {
                UID = accountId,
                APIKey = apiKey,
                IP = ipaddr,
                Tag = vpnname,
                InternetAccess = internetAccess,
                LocalNetworkAccess = localNetworkAccess,
                availableMbps = availableMbps,
                UserMbps = userMbps,
                InterfaceIP = interfaceIP,
                RouterIP = routerIP,
                StartPort = startPort,
                EndPort = endPort,
                NAT = natList // Add the NAT list to the JSON object
            };

            try
            {
                // Serialize the JSON object to a formatted (indented) JSON string
                string jsonString = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

                // Get the current executable directory
                string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Combine the directory and file name
                string filePath = Path.Combine(exeDirectory, "config.json");

                // Write the formatted JSON string to a file
                File.WriteAllText(filePath, jsonString);

                MessageBox.Show("JSON file saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
