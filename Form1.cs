using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.RegularExpressions;

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
                    _ = RouterIP.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., show a message box)
                _ = MessageBox.Show("An error occurred: " + ex.Message);
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
            string routerIP;
            try
            {
                // Attempt to extract the value from RouterIP.Text
                routerIP = RouterIP.Text.Replace(" ", "").Split(',')[1];
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., show a message box or log the error)
                _ = MessageBox.Show("An error occurred while extracting routerIP: " + ex.Message + "\nUsing default value: 51.89.206.24");
                // continue with the default value
                routerIP = "51.89.206.24";
            }
            int startPort = (int)StartPort.Value;
            int endPort = (int)EndPort.Value;

            // Create a list to hold NAT objects
            List<object> natList = new();

            // Create a list to hold Access objects
            List<object> accessList = new();

            // Initialize the DNS Dictionary
            Dictionary<string, Dictionary<string, object>> dnsDict = new();

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


            // Loop through each tab in DomainTabs
            foreach (TabPage tabPage in DomainTabs.TabPages)
            {
                string domainName = tabPage.Text;
                Dictionary<string, object> recordDict = new();

                // Get the ListBox control from the current TabPage
                ListBox DomainRecordsList = (ListBox)tabPage.Controls[0];

                // Loop through each item in DomainRecordsList
                foreach (string record in DomainRecordsList.Items)
                {
                    if (record == "Wildcard")
                    {
                        recordDict["Wildcard"] = true;
                        continue;
                    }

                    // Split the record by ': {' and '}'
                    string[] parts = record.Split(new string[] { ": {", "}" }, StringSplitOptions.None);

                    if (parts.Length >= 2)
                    {
                        string type = parts[0];  // Record type like "IP", "TXT" etc
                        string value = parts[1]; // Record value

                        // If the type already exists in recordDict, append the new value to the existing list
                        if (recordDict.ContainsKey(type))
                        {
                            ((List<string>)recordDict[type]).Add(value);
                        }
                        else
                        {
                            // Create a new list with the current value and add it to the recordDict
                            recordDict[type] = new List<string> { value };
                        }
                    }
                }

                dnsDict[domainName] = recordDict;
            }

            // Create a JSON object
            var jsonObject = new
            {
                UID = accountId,
                APIKey = apiKey,
                IP = ipaddr,
                Tag = vpnname,
                InternetAccess = internetAccess,
                LocalNetworkAccess = localNetworkAccess,
                availableMbps,
                UserMbps = userMbps,
                InterfaceIP = interfaceIP,
                RouterIP = routerIP,
                StartPort = startPort,
                EndPort = endPort,
                NAT = natList,
                Access = accessList,
                DNS = dnsDict
            };

            try
            {
                // Serialize the JSON object to a formatted (indented) JSON string
                string jsonString = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

                // Get the current executable directory
                string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // create a folder if it doesnt exist called profiles
                Directory.CreateDirectory(exeDirectory + "profiles");

                // Combine the directory and file name and save into profiles
                string filePath = Path.Combine(exeDirectory + "profiles", vpnname + ".json");

                // Write the formatted JSON string to a file
                File.WriteAllText(filePath, jsonString);

                _ = MessageBox.Show("JSON file saved successfully!");

                // open explorer to the file
                Process.Start("explorer.exe", "/select, \"" + filePath + "\"");
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void users_insert_btn_Click(object sender, EventArgs e)
        {
            // Adds user to list
            _ = user_list.Items.Add(Access_UID_TXT.Text + "/" + Access_Tag_TXT.Text);
        }

        private void users_delete_btn_Click(object sender, EventArgs e)
        {
            // Removes user from list
            user_list.Items.RemoveAt(user_list.SelectedIndex);
        }

        private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = txtDomainName.Text;

            // Regex for validating an IP address
            string ipPattern = @"^(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)$";

            // Regex for validating a domain name, modified to accept single-character subdomains
            string domainPattern = @"^([a-zA-Z0-9\-]{1,61}\.)+[a-zA-Z]{2,}$";


            if (!Regex.IsMatch(input, ipPattern) && !Regex.IsMatch(input, domainPattern))
            {
                _ = MessageBox.Show("Invalid domain name or IP address");
                return;
            }

            // Add a new tab to the tab control "DomainTabs" with the text from "txtDomainName"
            DomainTabs.TabPages.Add(txtDomainName.Text);

            // create a new "DomainRecordsList" [ListBox] and add it to the new tab
            ListBox DomainRecordsList = new();
            DomainTabs.TabPages[^1].Controls.Add(DomainRecordsList);

            // make the dock style fill
            DomainRecordsList.Dock = DockStyle.Fill;
        }


        private void removeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Remove the current selected tab from the tab control "DomainTabs" if there are no more tabs to remove then we'll just return
            if (DomainTabs.TabPages.Count == 0)
            {
                return;
            }
            else
            {
                DomainTabs.TabPages.Remove(DomainTabs.SelectedTab);
            }


        }

        private void insertItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // With the current selected DomainTabs add a new item to the DomainRecordsList
                // it'll be added to the current selected DomainRecordsList in the current selected DomainTabs
                // well grab the text from "RecordType" and "RecordValue"
                // it'll be in the format of "RecordType: {RecordValue}"

                // get the current selected DomainRecordsList
                ListBox DomainRecordsList = (ListBox)DomainTabs.SelectedTab.Controls[0];

                // add the new item to the DomainRecordsList 
                // if RecordType is Wildcard then just add the RecordType and not the RecordValue
                if (RecordType.Text == "Wildcard")
                {
                    // if wildcard already exists then skip
                    if (DomainRecordsList.Items.Contains("Wildcard"))
                    {
                        return;
                    }
                    else
                    {
                        _ = DomainRecordsList.Items.Add(RecordType.Text);
                    }
                }
                else
                {
                    _ = DomainRecordsList.Items.Add(RecordType.Text + ": {" + RecordValue.Text + "}");
                }
            }
            catch
            {
                // if something goes wrong then do nothing and return.
                return;
            }

        }

        private void removeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // remove the selected item from the current selected DomainRecordsList
                // get the current selected DomainRecordsList
                ListBox DomainRecordsList = (ListBox)DomainTabs.SelectedTab.Controls[0];

                // remove the selected item from the DomainRecordsList
                DomainRecordsList.Items.RemoveAt(DomainRecordsList.SelectedIndex);
            }
            catch
            {
                // nothing is selected then do nothing and return
                return;
            }


        }
    }
}
