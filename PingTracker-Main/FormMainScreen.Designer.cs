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
            RichTextBox_Log = new RichTextBox();
            ButtonStopAll = new Button();
            TextBox_AddAddress = new TextBox();
            ButtonStartAll = new Button();
            ((System.ComponentModel.ISupportInitialize)AddressesDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddressBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Button_AddAddress
            // 
            Button_AddAddress.Location = new Point(422, 59);
            Button_AddAddress.Name = "Button_AddAddress";
            Button_AddAddress.Size = new Size(100, 40);
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
            AddressesDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AddressesDataGrid.AutoGenerateColumns = false;
            AddressesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            AddressesDataGrid.BackgroundColor = Color.White;
            AddressesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddressesDataGrid.Columns.AddRange(new DataGridViewColumn[] { ipDataGridViewTextBoxColumn1, dnsNameDataGridViewTextBoxColumn1, pingCountDataGridViewTextBoxColumn, packetLossPorcentageDataGridViewTextBoxColumn });
            AddressesDataGrid.DataSource = AddressBindingSource;
            AddressesDataGrid.Location = new Point(12, 20);
            AddressesDataGrid.MultiSelect = false;
            AddressesDataGrid.Name = "AddressesDataGrid";
            AddressesDataGrid.ReadOnly = true;
            AddressesDataGrid.RowHeadersVisible = false;
            AddressesDataGrid.ScrollBars = ScrollBars.Vertical;
            AddressesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AddressesDataGrid.Size = new Size(404, 379);
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
            pingCountDataGridViewTextBoxColumn.DataPropertyName = "PingCount";
            pingCountDataGridViewTextBoxColumn.HeaderText = "PingCount";
            pingCountDataGridViewTextBoxColumn.Name = "pingCountDataGridViewTextBoxColumn";
            pingCountDataGridViewTextBoxColumn.ReadOnly = true;
            pingCountDataGridViewTextBoxColumn.Width = 89;
            // 
            // packetLossPorcentageDataGridViewTextBoxColumn
            // 
            packetLossPorcentageDataGridViewTextBoxColumn.DataPropertyName = "PacketLossPorcentage";
            packetLossPorcentageDataGridViewTextBoxColumn.HeaderText = "PacketLoss";
            packetLossPorcentageDataGridViewTextBoxColumn.Name = "packetLossPorcentageDataGridViewTextBoxColumn";
            packetLossPorcentageDataGridViewTextBoxColumn.ReadOnly = true;
            packetLossPorcentageDataGridViewTextBoxColumn.Width = 90;
            // 
            // AddressBindingSource
            // 
            AddressBindingSource.DataSource = typeof(Address);
            // 
            // RichTextBox_Log
            // 
            RichTextBox_Log.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RichTextBox_Log.Location = new Point(422, 108);
            RichTextBox_Log.Name = "RichTextBox_Log";
            RichTextBox_Log.Size = new Size(450, 291);
            RichTextBox_Log.TabIndex = 1;
            RichTextBox_Log.Text = "";
            // 
            // ButtonStopAll
            // 
            ButtonStopAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonStopAll.Location = new Point(792, 12);
            ButtonStopAll.Name = "ButtonStopAll";
            ButtonStopAll.Size = new Size(80, 40);
            ButtonStopAll.TabIndex = 3;
            ButtonStopAll.Text = "Stop All";
            ButtonStopAll.UseVisualStyleBackColor = true;
            ButtonStopAll.Click += ButtonStopAll_Click;
            // 
            // TextBox_AddAddress
            // 
            TextBox_AddAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox_AddAddress.Location = new Point(422, 24);
            TextBox_AddAddress.Name = "TextBox_AddAddress";
            TextBox_AddAddress.Size = new Size(111, 29);
            TextBox_AddAddress.TabIndex = 0;
            // 
            // ButtonStartAll
            // 
            ButtonStartAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonStartAll.Location = new Point(706, 12);
            ButtonStartAll.Name = "ButtonStartAll";
            ButtonStartAll.Size = new Size(80, 40);
            ButtonStartAll.TabIndex = 4;
            ButtonStartAll.Text = "Start All";
            ButtonStartAll.UseVisualStyleBackColor = true;
            // 
            // FormMainScreen
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(884, 411);
            Controls.Add(ButtonStartAll);
            Controls.Add(TextBox_AddAddress);
            Controls.Add(ButtonStopAll);
            Controls.Add(AddressesDataGrid);
            Controls.Add(Button_AddAddress);
            Controls.Add(RichTextBox_Log);
            MinimumSize = new Size(900, 450);
            Name = "FormMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PingTracker";
            ((System.ComponentModel.ISupportInitialize)AddressesDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddressBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Button_AddAddress;
        private DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dnsNameDataGridViewTextBoxColumn;
        private DataGridView AddressesDataGrid;
        private BindingSource AddressBindingSource;
        private RichTextBox RichTextBox_Log;
        private DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dnsNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pingCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn packetLossPorcentageDataGridViewTextBoxColumn;
        private Button ButtonStopAll;
        private TextBox TextBox_AddAddress;
        private Button ButtonStartAll;
    }
}
