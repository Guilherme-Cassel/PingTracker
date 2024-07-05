namespace PingTracker_Main
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
            ListView_Addresses = new ListView();
            RichTextBox_Log = new RichTextBox();
            Button_AddAddress = new Button();
            MaskedTextBox_AddAddress = new MaskedTextBox();
            SuspendLayout();
            // 
            // ListView_Addresses
            // 
            ListView_Addresses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ListView_Addresses.Location = new Point(12, 12);
            ListView_Addresses.Name = "ListView_Addresses";
            ListView_Addresses.Size = new Size(253, 537);
            ListView_Addresses.TabIndex = 0;
            ListView_Addresses.UseCompatibleStateImageBehavior = false;
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
            Button_AddAddress.Click += Button_AddAddress_Click;
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
            // FormMainScreen
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(984, 561);
            Controls.Add(MaskedTextBox_AddAddress);
            Controls.Add(Button_AddAddress);
            Controls.Add(RichTextBox_Log);
            Controls.Add(ListView_Addresses);
            Name = "FormMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PingTracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ListView_Addresses;
        private RichTextBox RichTextBox_Log;
        private Button Button_AddAddress;
        private MaskedTextBox MaskedTextBox_AddAddress;
    }
}
