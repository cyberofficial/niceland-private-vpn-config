namespace niceland_private_vpn_config
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox4 = new GroupBox();
            sysctlconfigTXT = new TextBox();
            IpTablesTxt = new TextBox();
            label17 = new Label();
            label16 = new Label();
            AfterCreationCheckBox = new CheckBox();
            RefreshRouterIP = new Button();
            GenFileBtn = new Button();
            groupBox3 = new GroupBox();
            user_list = new ListBox();
            menuStrip3 = new MenuStrip();
            newUserToolStripMenuItem = new ToolStripMenuItem();
            Access_UID_TXT = new ToolStripTextBox();
            toolStripMenuItem1 = new ToolStripMenuItem();
            Access_Tag_TXT = new ToolStripTextBox();
            users_insert_btn = new ToolStripMenuItem();
            users_delete_btn = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            DomainTabs = new TabControl();
            tabPage4 = new TabPage();
            DomainRecordsList = new ListBox();
            DomainRecordsMenuBar = new MenuStrip();
            newToolStripMenuItem = new ToolStripMenuItem();
            RecordType = new ToolStripComboBox();
            RecordValue = new ToolStripTextBox();
            insertItemToolStripMenuItem = new ToolStripMenuItem();
            removeSelectedToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            txtDomainName = new ToolStripTextBox();
            newEntryToolStripMenuItem = new ToolStripMenuItem();
            removeCurrentTabToolStripMenuItem = new ToolStripMenuItem();
            RouterIP = new ComboBox();
            UserMbps = new NumericUpDown();
            EndPort = new NumericUpDown();
            StartPort = new NumericUpDown();
            AvailableMbps = new NumericUpDown();
            CBInterfaceIP = new CheckBox();
            LocalNetworkAccess = new CheckBox();
            InternetAccess = new CheckBox();
            InterfaceIP = new MaskedTextBox();
            IP = new MaskedTextBox();
            VPNTag = new TextBox();
            APIKey = new TextBox();
            UID = new TextBox();
            groupBox1 = new GroupBox();
            NAT_Network = new MaskedTextBox();
            NAT_Nat = new MaskedTextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            NAT_Tag = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            menuStrip3.SuspendLayout();
            groupBox2.SuspendLayout();
            DomainTabs.SuspendLayout();
            tabPage4.SuspendLayout();
            DomainRecordsMenuBar.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserMbps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EndPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StartPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AvailableMbps).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1199, 1086);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(AfterCreationCheckBox);
            tabPage1.Controls.Add(RefreshRouterIP);
            tabPage1.Controls.Add(GenFileBtn);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(RouterIP);
            tabPage1.Controls.Add(UserMbps);
            tabPage1.Controls.Add(EndPort);
            tabPage1.Controls.Add(StartPort);
            tabPage1.Controls.Add(AvailableMbps);
            tabPage1.Controls.Add(CBInterfaceIP);
            tabPage1.Controls.Add(LocalNetworkAccess);
            tabPage1.Controls.Add(InternetAccess);
            tabPage1.Controls.Add(InterfaceIP);
            tabPage1.Controls.Add(IP);
            tabPage1.Controls.Add(VPNTag);
            tabPage1.Controls.Add(APIKey);
            tabPage1.Controls.Add(UID);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1191, 1045);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create New VPN";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(sysctlconfigTXT);
            groupBox4.Controls.Add(IpTablesTxt);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label16);
            groupBox4.Location = new Point(8, 784);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1177, 253);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "Commands";
            // 
            // sysctlconfigTXT
            // 
            sysctlconfigTXT.Location = new Point(262, 76);
            sysctlconfigTXT.Multiline = true;
            sysctlconfigTXT.Name = "sysctlconfigTXT";
            sysctlconfigTXT.ReadOnly = true;
            sysctlconfigTXT.Size = new Size(505, 161);
            sysctlconfigTXT.TabIndex = 1;
            // 
            // IpTablesTxt
            // 
            IpTablesTxt.Location = new Point(262, 36);
            IpTablesTxt.Name = "IpTablesTxt";
            IpTablesTxt.ReadOnly = true;
            IpTablesTxt.Size = new Size(905, 34);
            IpTablesTxt.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 85);
            label17.Name = "label17";
            label17.Size = new Size(250, 112);
            label17.TabIndex = 0;
            label17.Text = "2. Add this to sysctl config: \r\n[ /etc/sysctl.conf ]\r\n\r\nsave with: sysctl -p";
            label17.TextAlign = ContentAlignment.TopRight;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(49, 42);
            label16.Name = "label16";
            label16.Size = new Size(211, 28);
            label16.TabIndex = 0;
            label16.Text = "1. IP Tables Command: ";
            // 
            // AfterCreationCheckBox
            // 
            AfterCreationCheckBox.AutoSize = true;
            AfterCreationCheckBox.Location = new Point(133, 709);
            AfterCreationCheckBox.Name = "AfterCreationCheckBox";
            AfterCreationCheckBox.Size = new Size(315, 32);
            AfterCreationCheckBox.TabIndex = 22;
            AfterCreationCheckBox.Text = "Open to directory after creating.";
            AfterCreationCheckBox.UseVisualStyleBackColor = true;
            // 
            // RefreshRouterIP
            // 
            RefreshRouterIP.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RefreshRouterIP.Location = new Point(71, 390);
            RefreshRouterIP.Name = "RefreshRouterIP";
            RefreshRouterIP.Size = new Size(33, 33);
            RefreshRouterIP.TabIndex = 21;
            RefreshRouterIP.Text = "♻️";
            RefreshRouterIP.UseVisualStyleBackColor = true;
            RefreshRouterIP.Click += RefreshRouterIP_Click;
            // 
            // GenFileBtn
            // 
            GenFileBtn.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            GenFileBtn.Location = new Point(133, 648);
            GenFileBtn.Margin = new Padding(3, 4, 3, 4);
            GenFileBtn.Name = "GenFileBtn";
            GenFileBtn.Size = new Size(375, 54);
            GenFileBtn.TabIndex = 20;
            GenFileBtn.Text = "Generate File";
            GenFileBtn.UseVisualStyleBackColor = true;
            GenFileBtn.Click += GenFileBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(user_list);
            groupBox3.Controls.Add(menuStrip3);
            groupBox3.Location = new Point(518, 13);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(667, 405);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "USERS";
            // 
            // user_list
            // 
            user_list.Dock = DockStyle.Fill;
            user_list.FormattingEnabled = true;
            user_list.ItemHeight = 28;
            user_list.Items.AddRange(new object[] { "6501ba548a32a75e4a309911/User-1" });
            user_list.Location = new Point(3, 64);
            user_list.Margin = new Padding(3, 4, 3, 4);
            user_list.Name = "user_list";
            user_list.Size = new Size(661, 337);
            user_list.TabIndex = 1;
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { newUserToolStripMenuItem, Access_UID_TXT, toolStripMenuItem1, Access_Tag_TXT, users_insert_btn, users_delete_btn });
            menuStrip3.Location = new Point(3, 31);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Padding = new Padding(7, 3, 0, 3);
            menuStrip3.Size = new Size(661, 33);
            menuStrip3.TabIndex = 0;
            menuStrip3.Text = "menuStrip3";
            // 
            // newUserToolStripMenuItem
            // 
            newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            newUserToolStripMenuItem.Size = new Size(86, 27);
            newUserToolStripMenuItem.Text = "New User";
            // 
            // Access_UID_TXT
            // 
            Access_UID_TXT.Name = "Access_UID_TXT";
            Access_UID_TXT.Size = new Size(171, 27);
            Access_UID_TXT.Text = "UID";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(29, 27);
            toolStripMenuItem1.Text = "/";
            // 
            // Access_Tag_TXT
            // 
            Access_Tag_TXT.Name = "Access_Tag_TXT";
            Access_Tag_TXT.Size = new Size(114, 27);
            Access_Tag_TXT.Text = "TAG";
            // 
            // users_insert_btn
            // 
            users_insert_btn.Name = "users_insert_btn";
            users_insert_btn.Size = new Size(59, 27);
            users_insert_btn.Text = "Insert";
            users_insert_btn.Click += users_insert_btn_Click;
            // 
            // users_delete_btn
            // 
            users_delete_btn.Name = "users_delete_btn";
            users_delete_btn.Size = new Size(138, 27);
            users_delete_btn.Text = "Remove Selected";
            users_delete_btn.Click += users_delete_btn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DomainTabs);
            groupBox2.Controls.Add(DomainRecordsMenuBar);
            groupBox2.Controls.Add(menuStrip1);
            groupBox2.Location = new Point(515, 425);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(667, 352);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "DNS";
            // 
            // DomainTabs
            // 
            DomainTabs.Controls.Add(tabPage4);
            DomainTabs.Dock = DockStyle.Fill;
            DomainTabs.Location = new Point(3, 98);
            DomainTabs.Margin = new Padding(3, 4, 3, 4);
            DomainTabs.Name = "DomainTabs";
            DomainTabs.SelectedIndex = 0;
            DomainTabs.Size = new Size(661, 250);
            DomainTabs.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(DomainRecordsList);
            tabPage4.Location = new Point(4, 37);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(653, 209);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "example.com";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // DomainRecordsList
            // 
            DomainRecordsList.Dock = DockStyle.Fill;
            DomainRecordsList.FormattingEnabled = true;
            DomainRecordsList.ItemHeight = 28;
            DomainRecordsList.Items.AddRange(new object[] { "CNAME: {meow.com}" });
            DomainRecordsList.Location = new Point(3, 4);
            DomainRecordsList.Margin = new Padding(3, 4, 3, 4);
            DomainRecordsList.Name = "DomainRecordsList";
            DomainRecordsList.Size = new Size(647, 201);
            DomainRecordsList.TabIndex = 1;
            // 
            // DomainRecordsMenuBar
            // 
            DomainRecordsMenuBar.ImageScalingSize = new Size(20, 20);
            DomainRecordsMenuBar.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem, RecordType, RecordValue, insertItemToolStripMenuItem, removeSelectedToolStripMenuItem });
            DomainRecordsMenuBar.Location = new Point(3, 64);
            DomainRecordsMenuBar.Name = "DomainRecordsMenuBar";
            DomainRecordsMenuBar.Padding = new Padding(7, 3, 0, 3);
            DomainRecordsMenuBar.Size = new Size(661, 34);
            DomainRecordsMenuBar.TabIndex = 0;
            DomainRecordsMenuBar.Text = "menuStrip2";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(56, 28);
            newToolStripMenuItem.Text = "New:";
            // 
            // RecordType
            // 
            RecordType.DropDownStyle = ComboBoxStyle.DropDownList;
            RecordType.Items.AddRange(new object[] { "CNAME", "A", "TXT", "Wildcard" });
            RecordType.Name = "RecordType";
            RecordType.Size = new Size(90, 28);
            // 
            // RecordValue
            // 
            RecordValue.Name = "RecordValue";
            RecordValue.Size = new Size(171, 28);
            RecordValue.Text = "value here";
            // 
            // insertItemToolStripMenuItem
            // 
            insertItemToolStripMenuItem.Name = "insertItemToolStripMenuItem";
            insertItemToolStripMenuItem.Size = new Size(93, 28);
            insertItemToolStripMenuItem.Text = "Insert Item";
            insertItemToolStripMenuItem.Click += insertItemToolStripMenuItem_Click;
            // 
            // removeSelectedToolStripMenuItem
            // 
            removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            removeSelectedToolStripMenuItem.Size = new Size(138, 28);
            removeSelectedToolStripMenuItem.Text = "Remove Selected";
            removeSelectedToolStripMenuItem.Click += removeSelectedToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { txtDomainName, newEntryToolStripMenuItem, removeCurrentTabToolStripMenuItem });
            menuStrip1.Location = new Point(3, 31);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(661, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // txtDomainName
            // 
            txtDomainName.Name = "txtDomainName";
            txtDomainName.Size = new Size(175, 27);
            // 
            // newEntryToolStripMenuItem
            // 
            newEntryToolStripMenuItem.Name = "newEntryToolStripMenuItem";
            newEntryToolStripMenuItem.Size = new Size(90, 27);
            newEntryToolStripMenuItem.Text = "New Entry";
            newEntryToolStripMenuItem.Click += newEntryToolStripMenuItem_Click;
            // 
            // removeCurrentTabToolStripMenuItem
            // 
            removeCurrentTabToolStripMenuItem.Name = "removeCurrentTabToolStripMenuItem";
            removeCurrentTabToolStripMenuItem.Size = new Size(156, 27);
            removeCurrentTabToolStripMenuItem.Text = "Remove Current Tab";
            removeCurrentTabToolStripMenuItem.Click += removeCurrentTabToolStripMenuItem_Click;
            // 
            // RouterIP
            // 
            RouterIP.FormattingEnabled = true;
            RouterIP.Location = new Point(207, 387);
            RouterIP.Margin = new Padding(3, 4, 3, 4);
            RouterIP.Name = "RouterIP";
            RouterIP.Size = new Size(301, 36);
            RouterIP.Sorted = true;
            RouterIP.TabIndex = 17;
            // 
            // UserMbps
            // 
            UserMbps.Location = new Point(207, 303);
            UserMbps.Margin = new Padding(3, 4, 3, 4);
            UserMbps.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            UserMbps.Name = "UserMbps";
            UserMbps.Size = new Size(90, 34);
            UserMbps.TabIndex = 16;
            UserMbps.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // EndPort
            // 
            EndPort.Location = new Point(419, 431);
            EndPort.Margin = new Padding(3, 4, 3, 4);
            EndPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            EndPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            EndPort.Name = "EndPort";
            EndPort.Size = new Size(90, 34);
            EndPort.TabIndex = 16;
            EndPort.Value = new decimal(new int[] { 62000, 0, 0, 0 });
            // 
            // StartPort
            // 
            StartPort.Location = new Point(207, 431);
            StartPort.Margin = new Padding(3, 4, 3, 4);
            StartPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            StartPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            StartPort.Name = "StartPort";
            StartPort.Size = new Size(90, 34);
            StartPort.TabIndex = 16;
            StartPort.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // AvailableMbps
            // 
            AvailableMbps.Location = new Point(207, 261);
            AvailableMbps.Margin = new Padding(3, 4, 3, 4);
            AvailableMbps.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            AvailableMbps.Name = "AvailableMbps";
            AvailableMbps.Size = new Size(90, 34);
            AvailableMbps.TabIndex = 16;
            AvailableMbps.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // CBInterfaceIP
            // 
            CBInterfaceIP.AutoSize = true;
            CBInterfaceIP.Location = new Point(382, 344);
            CBInterfaceIP.Margin = new Padding(3, 4, 3, 4);
            CBInterfaceIP.Name = "CBInterfaceIP";
            CBInterfaceIP.Size = new Size(126, 32);
            CBInterfaceIP.TabIndex = 15;
            CBInterfaceIP.Text = "Same as IP";
            CBInterfaceIP.UseVisualStyleBackColor = true;
            // 
            // LocalNetworkAccess
            // 
            LocalNetworkAccess.AutoSize = true;
            LocalNetworkAccess.Location = new Point(207, 221);
            LocalNetworkAccess.Margin = new Padding(3, 4, 3, 4);
            LocalNetworkAccess.Name = "LocalNetworkAccess";
            LocalNetworkAccess.Size = new Size(61, 32);
            LocalNetworkAccess.TabIndex = 15;
            LocalNetworkAccess.Text = "Yes";
            LocalNetworkAccess.UseVisualStyleBackColor = true;
            // 
            // InternetAccess
            // 
            InternetAccess.AutoSize = true;
            InternetAccess.Location = new Point(207, 181);
            InternetAccess.Margin = new Padding(3, 4, 3, 4);
            InternetAccess.Name = "InternetAccess";
            InternetAccess.Size = new Size(61, 32);
            InternetAccess.TabIndex = 15;
            InternetAccess.Text = "Yes";
            InternetAccess.UseVisualStyleBackColor = true;
            // 
            // InterfaceIP
            // 
            InterfaceIP.Location = new Point(207, 345);
            InterfaceIP.Margin = new Padding(3, 4, 3, 4);
            InterfaceIP.Mask = "000.000.000.000";
            InterfaceIP.Name = "InterfaceIP";
            InterfaceIP.Size = new Size(169, 34);
            InterfaceIP.TabIndex = 14;
            InterfaceIP.Text = "18518676193";
            // 
            // IP
            // 
            IP.Location = new Point(207, 97);
            IP.Margin = new Padding(3, 4, 3, 4);
            IP.Mask = "000.000.000.000";
            IP.Name = "IP";
            IP.Size = new Size(169, 34);
            IP.TabIndex = 14;
            IP.Text = "18518676193";
            // 
            // VPNTag
            // 
            VPNTag.Location = new Point(207, 139);
            VPNTag.Margin = new Padding(3, 4, 3, 4);
            VPNTag.Name = "VPNTag";
            VPNTag.Size = new Size(301, 34);
            VPNTag.TabIndex = 13;
            VPNTag.Text = "office network";
            // 
            // APIKey
            // 
            APIKey.Location = new Point(207, 55);
            APIKey.Margin = new Padding(3, 4, 3, 4);
            APIKey.Name = "APIKey";
            APIKey.Size = new Size(301, 34);
            APIKey.TabIndex = 13;
            APIKey.Text = "4c8aa0eb-87df-44d9-9a5b-a2a26fc4b122";
            // 
            // UID
            // 
            UID.Location = new Point(207, 13);
            UID.Margin = new Padding(3, 4, 3, 4);
            UID.Name = "UID";
            UID.Size = new Size(301, 34);
            UID.TabIndex = 13;
            UID.Text = "64a582dd8d9eb9e39599b522";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NAT_Network);
            groupBox1.Controls.Add(NAT_Nat);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(NAT_Tag);
            groupBox1.Location = new Point(133, 473);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(375, 167);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "NAT Settings";
            // 
            // NAT_Network
            // 
            NAT_Network.Location = new Point(117, 111);
            NAT_Network.Margin = new Padding(3, 4, 3, 4);
            NAT_Network.Mask = "000.000.000.000/00";
            NAT_Network.Name = "NAT_Network";
            NAT_Network.Size = new Size(241, 34);
            NAT_Network.TabIndex = 14;
            NAT_Network.Text = "185186 76  024";
            // 
            // NAT_Nat
            // 
            NAT_Nat.Location = new Point(117, 69);
            NAT_Nat.Margin = new Padding(3, 4, 3, 4);
            NAT_Nat.Mask = "000.000.000.000/00";
            NAT_Nat.Name = "NAT_Nat";
            NAT_Nat.Size = new Size(241, 34);
            NAT_Nat.TabIndex = 14;
            NAT_Nat.Text = " 11 11 12  024";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(60, 72);
            label15.Name = "label15";
            label15.Size = new Size(53, 28);
            label15.TabIndex = 2;
            label15.Text = "Nat: ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(17, 114);
            label14.Name = "label14";
            label14.Size = new Size(96, 28);
            label14.TabIndex = 1;
            label14.Text = "Network: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(60, 30);
            label13.Name = "label13";
            label13.Size = new Size(51, 28);
            label13.TabIndex = 0;
            label13.Text = "Tag: ";
            // 
            // NAT_Tag
            // 
            NAT_Tag.Location = new Point(117, 27);
            NAT_Tag.Margin = new Padding(3, 4, 3, 4);
            NAT_Tag.Name = "NAT_Tag";
            NAT_Tag.Size = new Size(241, 34);
            NAT_Tag.TabIndex = 13;
            NAT_Tag.Text = "nat to 11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(318, 433);
            label12.Name = "label12";
            label12.Size = new Size(95, 28);
            label12.TabIndex = 11;
            label12.Text = "End Port: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(104, 433);
            label11.Name = "label11";
            label11.Size = new Size(103, 28);
            label11.TabIndex = 10;
            label11.Text = "Start Port: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(110, 390);
            label10.Name = "label10";
            label10.Size = new Size(100, 28);
            label10.TabIndex = 9;
            label10.Text = "Router IP: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(93, 348);
            label9.Name = "label9";
            label9.Size = new Size(117, 28);
            label9.TabIndex = 8;
            label9.Text = "Interface IP: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(92, 305);
            label8.Name = "label8";
            label8.Size = new Size(115, 28);
            label8.TabIndex = 7;
            label8.Text = "User Mbps: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 263);
            label6.Name = "label6";
            label6.Size = new Size(156, 28);
            label6.TabIndex = 6;
            label6.Text = "Available Mbps: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 221);
            label7.Name = "label7";
            label7.Size = new Size(208, 28);
            label7.TabIndex = 5;
            label7.Text = "Local Network Access: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 182);
            label5.Name = "label5";
            label5.Size = new Size(151, 28);
            label5.TabIndex = 4;
            label5.Text = "Internet Access: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 142);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 3;
            label4.Text = "VPN Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 100);
            label3.Name = "label3";
            label3.Size = new Size(37, 28);
            label3.TabIndex = 2;
            label3.Text = "IP: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 58);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 1;
            label2.Text = "API Key: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(93, 16);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 0;
            label1.Text = "Account ID: ";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 37);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1191, 1045);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Updating VPN";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 37);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(1191, 1045);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete VPN";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 1086);
            Controls.Add(tabControl1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip3;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Niceland VPN - Self Hosted VPN Configuration Tool";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            DomainTabs.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            DomainRecordsMenuBar.ResumeLayout(false);
            DomainRecordsMenuBar.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserMbps).EndInit();
            ((System.ComponentModel.ISupportInitialize)EndPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)StartPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)AvailableMbps).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label11;
        private GroupBox groupBox1;
        private Label label15;
        private Label label14;
        private Label label13;
        private MaskedTextBox IP;
        private TextBox APIKey;
        private TextBox UID;
        private CheckBox InternetAccess;
        private TextBox VPNTag;
        private CheckBox LocalNetworkAccess;
        private NumericUpDown AvailableMbps;
        private NumericUpDown UserMbps;
        private MaskedTextBox InterfaceIP;
        private CheckBox CBInterfaceIP;
        private ComboBox RouterIP;
        private NumericUpDown StartPort;
        private NumericUpDown EndPort;
        private MaskedTextBox NAT_Network;
        private MaskedTextBox NAT_Nat;
        private TextBox NAT_Tag;
        private GroupBox groupBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newEntryToolStripMenuItem;
        private MenuStrip DomainRecordsMenuBar;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripComboBox RecordType;
        private ToolStripTextBox RecordValue;
        private ToolStripMenuItem insertItemToolStripMenuItem;
        private ToolStripMenuItem removeSelectedToolStripMenuItem;
        private ToolStripMenuItem removeCurrentTabToolStripMenuItem;
        private GroupBox groupBox3;
        private ListBox user_list;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem newUserToolStripMenuItem;
        private ToolStripTextBox Access_UID_TXT;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripTextBox Access_Tag_TXT;
        private ToolStripMenuItem users_insert_btn;
        private ToolStripMenuItem users_delete_btn;
        private Button GenFileBtn;
        private Button RefreshRouterIP;
        private ToolStripTextBox txtDomainName;
        private TabControl DomainTabs;
        private TabPage tabPage4;
        private ListBox DomainRecordsList;
        private CheckBox AfterCreationCheckBox;
        private GroupBox groupBox4;
        private TextBox IpTablesTxt;
        private Label label16;
        private Label label17;
        private TextBox sysctlconfigTXT;
    }
}