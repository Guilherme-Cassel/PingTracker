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
            ipDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dnsNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pingCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            packetLossPorcentageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            Button_AddAddress.Location = new Point(129, 28);
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
            AddressesDataGrid.Columns.AddRange(new DataGridViewColumn[] { ipDataGridViewTextBoxColumn1, dnsNameDataGridViewTextBoxColumn1, pingCountDataGridViewTextBoxColumn, packetLossPorcentageDataGridViewTextBoxColumn });
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
            // ipDataGridViewTextBoxColumn1
            // 
            ipDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ipDataGridViewTextBoxColumn1.DataPropertyName = "Ip";
            ipDataGridViewTextBoxColumn1.HeaderText = "Ip";
            ipDataGridViewTextBoxColumn1.Name = "ipDataGridViewTextBoxColumn1";
            ipDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dnsNameDataGridViewTextBoxColumn1
            // 
            dnsNameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dnsNameDataGridViewTextBoxColumn1.DataPropertyName = "DnsName";
            dnsNameDataGridViewTextBoxColumn1.HeaderText = "DnsName";
            dnsNameDataGridViewTextBoxColumn1.Name = "dnsNameDataGridViewTextBoxColumn1";
            dnsNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pingCountDataGridViewTextBoxColumn
            // 
            pingCountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            pingCountDataGridViewTextBoxColumn.DataPropertyName = "PingCount";
            pingCountDataGridViewTextBoxColumn.HeaderText = "PingCount";
            pingCountDataGridViewTextBoxColumn.Name = "pingCountDataGridViewTextBoxColumn";
            pingCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packetLossPorcentageDataGridViewTextBoxColumn
            // 
            packetLossPorcentageDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            packetLossPorcentageDataGridViewTextBoxColumn.DataPropertyName = "PacketLossPorcentage";
            packetLossPorcentageDataGridViewTextBoxColumn.HeaderText = "PacketLoss";
            packetLossPorcentageDataGridViewTextBoxColumn.Name = "packetLossPorcentageDataGridViewTextBoxColumn";
            packetLossPorcentageDataGridViewTextBoxColumn.ReadOnly = true;
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
            pingingToolStripMenuItem.Size = new Size(180, 22);
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
            addressListToolStripMenuItem.Size = new Size(180, 22);
            addressListToolStripMenuItem.Text = "Address List";
            // 
            // ToolStripClearList
            // 
            ToolStripClearList.Name = "ToolStripClearList";
            ToolStripClearList.Size = new Size(180, 22);
            ToolStripClearList.Text = "Clear List";
            // 
            // FormMainScreen
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
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
    }
}
