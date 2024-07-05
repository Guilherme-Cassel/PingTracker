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
            addressDataGrid1 = new PingTracker_Model.CustomControls.AddressDataGrid();
            addressFamilyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            scopeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isIPv6MulticastDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isIPv6LinkLocalDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isIPv6SiteLocalDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isIPv6TeredoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isIPv6UniqueLocalDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isIPv4MappedToIPv6DataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)addressDataGrid1).BeginInit();
            SuspendLayout();
            // 
            // RichTextBox_Log
            // 
            RichTextBox_Log.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RichTextBox_Log.Location = new Point(278, 295);
            RichTextBox_Log.Name = "RichTextBox_Log";
            RichTextBox_Log.Size = new Size(694, 254);
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
            // addressDataGrid1
            // 
            addressDataGrid1.AllowUserToAddRows = false;
            addressDataGrid1.AllowUserToDeleteRows = false;
            addressDataGrid1.AutoGenerateColumns = false;
            addressDataGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addressDataGrid1.Columns.AddRange(new DataGridViewColumn[] { addressFamilyDataGridViewTextBoxColumn, scopeIdDataGridViewTextBoxColumn, isIPv6MulticastDataGridViewCheckBoxColumn, isIPv6LinkLocalDataGridViewCheckBoxColumn, isIPv6SiteLocalDataGridViewCheckBoxColumn, isIPv6TeredoDataGridViewCheckBoxColumn, isIPv6UniqueLocalDataGridViewCheckBoxColumn, isIPv4MappedToIPv6DataGridViewCheckBoxColumn, addressDataGridViewTextBoxColumn });
            addressDataGrid1.Location = new Point(11, 9);
            addressDataGrid1.Name = "addressDataGrid1";
            addressDataGrid1.ReadOnly = true;
            addressDataGrid1.Size = new Size(255, 539);
            addressDataGrid1.TabIndex = 2;
            // 
            // addressFamilyDataGridViewTextBoxColumn
            // 
            addressFamilyDataGridViewTextBoxColumn.DataPropertyName = "AddressFamily";
            addressFamilyDataGridViewTextBoxColumn.HeaderText = "AddressFamily";
            addressFamilyDataGridViewTextBoxColumn.Name = "addressFamilyDataGridViewTextBoxColumn";
            addressFamilyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scopeIdDataGridViewTextBoxColumn
            // 
            scopeIdDataGridViewTextBoxColumn.DataPropertyName = "ScopeId";
            scopeIdDataGridViewTextBoxColumn.HeaderText = "ScopeId";
            scopeIdDataGridViewTextBoxColumn.Name = "scopeIdDataGridViewTextBoxColumn";
            scopeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isIPv6MulticastDataGridViewCheckBoxColumn
            // 
            isIPv6MulticastDataGridViewCheckBoxColumn.DataPropertyName = "IsIPv6Multicast";
            isIPv6MulticastDataGridViewCheckBoxColumn.HeaderText = "IsIPv6Multicast";
            isIPv6MulticastDataGridViewCheckBoxColumn.Name = "isIPv6MulticastDataGridViewCheckBoxColumn";
            isIPv6MulticastDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isIPv6LinkLocalDataGridViewCheckBoxColumn
            // 
            isIPv6LinkLocalDataGridViewCheckBoxColumn.DataPropertyName = "IsIPv6LinkLocal";
            isIPv6LinkLocalDataGridViewCheckBoxColumn.HeaderText = "IsIPv6LinkLocal";
            isIPv6LinkLocalDataGridViewCheckBoxColumn.Name = "isIPv6LinkLocalDataGridViewCheckBoxColumn";
            isIPv6LinkLocalDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isIPv6SiteLocalDataGridViewCheckBoxColumn
            // 
            isIPv6SiteLocalDataGridViewCheckBoxColumn.DataPropertyName = "IsIPv6SiteLocal";
            isIPv6SiteLocalDataGridViewCheckBoxColumn.HeaderText = "IsIPv6SiteLocal";
            isIPv6SiteLocalDataGridViewCheckBoxColumn.Name = "isIPv6SiteLocalDataGridViewCheckBoxColumn";
            isIPv6SiteLocalDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isIPv6TeredoDataGridViewCheckBoxColumn
            // 
            isIPv6TeredoDataGridViewCheckBoxColumn.DataPropertyName = "IsIPv6Teredo";
            isIPv6TeredoDataGridViewCheckBoxColumn.HeaderText = "IsIPv6Teredo";
            isIPv6TeredoDataGridViewCheckBoxColumn.Name = "isIPv6TeredoDataGridViewCheckBoxColumn";
            isIPv6TeredoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isIPv6UniqueLocalDataGridViewCheckBoxColumn
            // 
            isIPv6UniqueLocalDataGridViewCheckBoxColumn.DataPropertyName = "IsIPv6UniqueLocal";
            isIPv6UniqueLocalDataGridViewCheckBoxColumn.HeaderText = "IsIPv6UniqueLocal";
            isIPv6UniqueLocalDataGridViewCheckBoxColumn.Name = "isIPv6UniqueLocalDataGridViewCheckBoxColumn";
            isIPv6UniqueLocalDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isIPv4MappedToIPv6DataGridViewCheckBoxColumn
            // 
            isIPv4MappedToIPv6DataGridViewCheckBoxColumn.DataPropertyName = "IsIPv4MappedToIPv6";
            isIPv4MappedToIPv6DataGridViewCheckBoxColumn.HeaderText = "IsIPv4MappedToIPv6";
            isIPv4MappedToIPv6DataGridViewCheckBoxColumn.Name = "isIPv4MappedToIPv6DataGridViewCheckBoxColumn";
            isIPv4MappedToIPv6DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormMainScreen
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(984, 561);
            Controls.Add(addressDataGrid1);
            Controls.Add(MaskedTextBox_AddAddress);
            Controls.Add(Button_AddAddress);
            Controls.Add(RichTextBox_Log);
            Name = "FormMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PingTracker";
            Load += FormMainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)addressDataGrid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox RichTextBox_Log;
        private Button Button_AddAddress;
        private MaskedTextBox MaskedTextBox_AddAddress;
        private PingTracker_Model.CustomControls.AddressDataGrid addressDataGrid1;
        private DataGridViewTextBoxColumn addressFamilyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn scopeIdDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isIPv6MulticastDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isIPv6LinkLocalDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isIPv6SiteLocalDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isIPv6TeredoDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isIPv6UniqueLocalDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isIPv4MappedToIPv6DataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private AddressListView addressListView1;
    }
}
