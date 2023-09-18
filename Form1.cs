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


        // Code is documented with generilized comments to make it easier to understand


        private void Form1_Load(object sender, EventArgs e)
        {
            //  make RouterIP read only
            RouterIP.DropDownStyle = ComboBoxStyle.DropDownList;
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

            // Create a list to hold Access objects
            List<object> accessList = new List<object>();

            // Create a NAT object
            var natObject = new
            {
                Tag = NAT_Tag.Text.Replace(" ", "-"),
                Network = NAT_Network.Text.Replace(" ", ""),
                Nat = NAT_Nat.Text.Replace(" ", "")
            };

            // Populate accessList from user_list (assuming user_list is a ListBox)
            foreach (string user in user_list.Items)
            {
                string[] parts = user.Split('/');
                if (parts.Length == 2)
                {
                    string uid = parts[0];
                    string tag = parts[1];

                    var accessObject = new
                    {
                        UID = uid,
                        Tag = tag
                    };

                    accessList.Add(accessObject);
                }
            }

            // Add the NAT object to the list
            natList.Add(natObject);

            // Create a JSON object
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
                NAT = natList,
                Access = accessList
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

        private void users_insert_btn_Click(object sender, EventArgs e)
        {
            // Adds user to list
            user_list.Items.Add(Access_UID_TXT.Text + "/" + Access_Tag_TXT.Text);
        }

        private void users_delete_btn_Click(object sender, EventArgs e)
        {
            // Removes user from list
            user_list.Items.RemoveAt(user_list.SelectedIndex);
        }
    }
}
