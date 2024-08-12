using PingTracker.Model;

namespace PingTracker
{
    partial class FormMainScreen
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
            components = new System.ComponentModel.Container();
            Button_AddAddress = new Button();
            ipDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dnsNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AddressesDataGrid = new DataGridView();
            isActiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            DnsName = new DataGridViewTextBoxColumn();
            Ip = new DataGridViewTextBoxColumn();
            totalPingsSentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPingsReceivedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AddressBindingSource = new BindingSource(components);
            TextBox_AddAddress = new TextBox();
            MenuStrip = new MenuStrip();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            pingingToolStripMenuItem = new ToolStripMenuItem();
            ToolStripStartAll = new ToolStripMenuItem();
            ToolStripStopAll = new ToolStripMenuItem();
            addressListToolStripMenuItem = new ToolStripMenuItem();
            ToolStripClearList = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)AddressesDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddressBindingSource).BeginInit();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // Button_AddAddress
            // 
            Button_AddAddress.Location = new Point(129, 27);
            Button_AddAddress.Name = "Button_AddAddress";
            Button_AddAddress.Size = new Size(111, 29);
            Button_AddAddress.TabIndex = 1;
            Button_AddAddress.Text = "Add Address";
            Button_AddAddress.UseVisualStyleBackColor = true;
            // 
            // ipDataGridViewTextBoxColumn
            // 
            ipDataGridViewTextBoxColumn.DataPropertyName = "Ip";
            ipDataGridViewTextBoxColumn.HeaderText = "Ip";
            ipDataGridViewTextBoxColumn.Name = "ipDataGridViewTextBoxColumn";
            ipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dnsNameDataGridViewTextBoxColumn
            // 
            dnsNameDataGridViewTextBoxColumn.DataPropertyName = "DnsName";
            dnsNameDataGridViewTextBoxColumn.HeaderText = "DnsName";
            dnsNameDataGridViewTextBoxColumn.Name = "dnsNameDataGridViewTextBoxColumn";
            dnsNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AddressesDataGrid
            // 
            AddressesDataGrid.AllowUserToAddRows = false;
            AddressesDataGrid.AllowUserToDeleteRows = false;
            AddressesDataGrid.AllowUserToResizeRows = false;
            AddressesDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressesDataGrid.AutoGenerateColumns = false;
            AddressesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            AddressesDataGrid.BackgroundColor = Color.White;
            AddressesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddressesDataGrid.Columns.AddRange(new DataGridViewColumn[] { isActiveDataGridViewCheckBoxColumn, DnsName, Ip, totalPingsSentDataGridViewTextBoxColumn, totalPingsReceivedDataGridViewTextBoxColumn });
            AddressesDataGrid.DataSource = AddressBindingSource;
            AddressesDataGrid.Location = new Point(12, 63);
            AddressesDataGrid.MultiSelect = false;
            AddressesDataGrid.Name = "AddressesDataGrid";
            AddressesDataGrid.ReadOnly = true;
            AddressesDataGrid.RowHeadersVisible = false;
            AddressesDataGrid.ScrollBars = ScrollBars.Vertical;
            AddressesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AddressesDataGrid.Size = new Size(610, 336);
            AddressesDataGrid.TabIndex = 2;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            isActiveDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            isActiveDataGridViewCheckBoxColumn.HeaderText = "Is Active";
            isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // DnsName
            // 
            DnsName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DnsName.DataPropertyName = "DnsName";
            DnsName.HeaderText = "Dns Name";
            DnsName.Name = "DnsName";
            DnsName.ReadOnly = true;
            // 
            // Ip
            // 
            Ip.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ip.DataPropertyName = "Ip";
            Ip.HeaderText = "Ip";
            Ip.Name = "Ip";
            Ip.ReadOnly = true;
            // 
            // totalPingsSentDataGridViewTextBoxColumn
            // 
            totalPingsSentDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalPingsSentDataGridViewTextBoxColumn.DataPropertyName = "TotalPingsSent";
            totalPingsSentDataGridViewTextBoxColumn.HeaderText = "Pings Sent";
            totalPingsSentDataGridViewTextBoxColumn.Name = "totalPingsSentDataGridViewTextBoxColumn";
            totalPingsSentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPingsReceivedDataGridViewTextBoxColumn
            // 
            totalPingsReceivedDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalPingsReceivedDataGridViewTextBoxColumn.DataPropertyName = "TotalPingsReceived";
            totalPingsReceivedDataGridViewTextBoxColumn.HeaderText = "Pings Received";
            totalPingsReceivedDataGridViewTextBoxColumn.Name = "totalPingsReceivedDataGridViewTextBoxColumn";
            totalPingsReceivedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AddressBindingSource
            // 
            AddressBindingSource.DataSource = typeof(Address);
            // 
            // TextBox_AddAddress
            // 
            TextBox_AddAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox_AddAddress.Location = new Point(12, 27);
            TextBox_AddAddress.Name = "TextBox_AddAddress";
            TextBox_AddAddress.Size = new Size(111, 29);
            TextBox_AddAddress.TabIndex = 0;
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { actionsToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(634, 24);
            MenuStrip.TabIndex = 5;
            MenuStrip.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pingingToolStripMenuItem, addressListToolStripMenuItem });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(59, 20);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // pingingToolStripMenuItem
            // 
            pingingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripStartAll, ToolStripStopAll });
            pingingToolStripMenuItem.Name = "pingingToolStripMenuItem";
            pingingToolStripMenuItem.Size = new Size(137, 22);
            pingingToolStripMenuItem.Text = "Pinging";
            // 
            // ToolStripStartAll
            // 
            ToolStripStartAll.Name = "ToolStripStartAll";
            ToolStripStartAll.Size = new Size(115, 22);
            ToolStripStartAll.Text = "Start All";
            // 
            // ToolStripStopAll
            // 
            ToolStripStopAll.Name = "ToolStripStopAll";
            ToolStripStopAll.Size = new Size(115, 22);
            ToolStripStopAll.Text = "Stop All";
            // 
            // addressListToolStripMenuItem
            // 
            addressListToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripClearList });
            addressListToolStripMenuItem.Name = "addressListToolStripMenuItem";
            addressListToolStripMenuItem.Size = new Size(137, 22);
            addressListToolStripMenuItem.Text = "Address List";
            // 
            // ToolStripClearList
            // 
            ToolStripClearList.Name = "ToolStripClearList";
            ToolStripClearList.Size = new Size(122, 22);
            ToolStripClearList.Text = "Clear List";
            // 
            // FormMainScreen
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(634, 411);
            Controls.Add(TextBox_AddAddress);
            Controls.Add(AddressesDataGrid);
            Controls.Add(Button_AddAddress);
            Controls.Add(MenuStrip);
            MainMenuStrip = MenuStrip;
            MinimumSize = new Size(650, 450);
            Name = "FormMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PingTracker";
            ((System.ComponentModel.ISupportInitialize)AddressesDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddressBindingSource).EndInit();
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Button_AddAddress;
        private DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dnsNameDataGridViewTextBoxColumn;
        private DataGridView AddressesDataGrid;
        private BindingSource AddressBindingSource;
        private TextBox TextBox_AddAddress;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem pingingToolStripMenuItem;
        private ToolStripMenuItem ToolStripStartAll;
        private ToolStripMenuItem ToolStripStopAll;
        private DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dnsNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pingCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn packetLossPorcentageDataGridViewTextBoxColumn;
        private ToolStripMenuItem addressListToolStripMenuItem;
        private ToolStripMenuItem ToolStripClearList;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn DnsName;
        private DataGridViewTextBoxColumn Ip;
        private DataGridViewTextBoxColumn totalPingsSentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPingsReceivedDataGridViewTextBoxColumn;
    }
}
