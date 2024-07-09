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
            RichTextBox_Log = new RichTextBox();
            Button_AddAddress = new Button();
            MaskedTextBox_AddAddress = new MaskedTextBox();
            ipDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dnsNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AddressesDataGrid = new DataGridView();
            ipDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dnsNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            AddressBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)AddressesDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddressBindingSource).BeginInit();
            SuspendLayout();
            // 
            // RichTextBox_Log
            // 
            RichTextBox_Log.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RichTextBox_Log.Location = new Point(278, 108);
            RichTextBox_Log.Name = "RichTextBox_Log";
            RichTextBox_Log.Size = new Size(644, 291);
            RichTextBox_Log.TabIndex = 1;
            RichTextBox_Log.Text = "";
            // 
            // Button_AddAddress
            // 
            Button_AddAddress.Location = new Point(278, 60);
            Button_AddAddress.Name = "Button_AddAddress";
            Button_AddAddress.Size = new Size(100, 40);
            Button_AddAddress.TabIndex = 1;
            Button_AddAddress.Text = "Add Address";
            Button_AddAddress.UseVisualStyleBackColor = true;
            // 
            // MaskedTextBox_AddAddress
            // 
            MaskedTextBox_AddAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox_AddAddress.Location = new Point(278, 20);
            MaskedTextBox_AddAddress.Mask = "000,000,0,000";
            MaskedTextBox_AddAddress.Name = "MaskedTextBox_AddAddress";
            MaskedTextBox_AddAddress.Size = new Size(124, 29);
            MaskedTextBox_AddAddress.TabIndex = 0;
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
            AddressesDataGrid.Columns.AddRange(new DataGridViewColumn[] { ipDataGridViewTextBoxColumn1, dnsNameDataGridViewTextBoxColumn1 });
            AddressesDataGrid.DataSource = AddressBindingSource;
            AddressesDataGrid.Location = new Point(12, 20);
            AddressesDataGrid.Name = "AddressesDataGrid";
            AddressesDataGrid.ReadOnly = true;
            AddressesDataGrid.RowHeadersVisible = false;
            AddressesDataGrid.ScrollBars = ScrollBars.Vertical;
            AddressesDataGrid.Size = new Size(257, 379);
            AddressesDataGrid.TabIndex = 2;
            // 
            // ipDataGridViewTextBoxColumn1
            // 
            ipDataGridViewTextBoxColumn1.DataPropertyName = "Ip";
            ipDataGridViewTextBoxColumn1.HeaderText = "Ip";
            ipDataGridViewTextBoxColumn1.MaxInputLength = 20;
            ipDataGridViewTextBoxColumn1.MinimumWidth = 90;
            ipDataGridViewTextBoxColumn1.Name = "ipDataGridViewTextBoxColumn1";
            ipDataGridViewTextBoxColumn1.ReadOnly = true;
            ipDataGridViewTextBoxColumn1.Width = 90;
            // 
            // dnsNameDataGridViewTextBoxColumn1
            // 
            dnsNameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dnsNameDataGridViewTextBoxColumn1.DataPropertyName = "DnsName";
            dnsNameDataGridViewTextBoxColumn1.HeaderText = "DnsName";
            dnsNameDataGridViewTextBoxColumn1.MaxInputLength = 25;
            dnsNameDataGridViewTextBoxColumn1.Name = "dnsNameDataGridViewTextBoxColumn1";
            dnsNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // AddressBindingSource
            // 
            AddressBindingSource.DataSource = typeof(Address);
            // 
            // FormMainScreen
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(934, 411);
            Controls.Add(AddressesDataGrid);
            Controls.Add(MaskedTextBox_AddAddress);
            Controls.Add(Button_AddAddress);
            Controls.Add(RichTextBox_Log);
            Name = "FormMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PingTracker";
            ((System.ComponentModel.ISupportInitialize)AddressesDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddressBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox RichTextBox_Log;
        private Button Button_AddAddress;
        private MaskedTextBox MaskedTextBox_AddAddress;
        private DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dnsNameDataGridViewTextBoxColumn;
        private DataGridView AddressesDataGrid;
        private DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dnsNameDataGridViewTextBoxColumn1;
        private BindingSource AddressBindingSource;
    }
}
