namespace PingTracker
{
    partial class AddressZoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBoxIP = new TextBox();
            label1 = new Label();
            LogRichTextBox = new RichTextBox();
            label2 = new Label();
            TextBoxDnsName = new TextBox();
            label3 = new Label();
            TextBoxPacketLoss = new TextBox();
            label4 = new Label();
            TextBoxActive = new TextBox();
            SuspendLayout();
            // 
            // TextBoxIP
            // 
            TextBoxIP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxIP.Location = new Point(12, 45);
            TextBoxIP.Name = "TextBoxIP";
            TextBoxIP.ReadOnly = true;
            TextBoxIP.Size = new Size(120, 29);
            TextBoxIP.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 1;
            label1.Text = "IP Address";
            // 
            // LogRichTextBox
            // 
            LogRichTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LogRichTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogRichTextBox.Location = new Point(12, 137);
            LogRichTextBox.Name = "LogRichTextBox";
            LogRichTextBox.ReadOnly = true;
            LogRichTextBox.Size = new Size(560, 272);
            LogRichTextBox.TabIndex = 4;
            LogRichTextBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 6;
            label2.Text = "DNS Name";
            // 
            // TextBoxDnsName
            // 
            TextBoxDnsName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxDnsName.Location = new Point(12, 101);
            TextBoxDnsName.Name = "TextBoxDnsName";
            TextBoxDnsName.ReadOnly = true;
            TextBoxDnsName.Size = new Size(120, 29);
            TextBoxDnsName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(166, 77);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 10;
            label3.Text = "Packet Loss";
            // 
            // TextBoxPacketLoss
            // 
            TextBoxPacketLoss.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxPacketLoss.Location = new Point(166, 101);
            TextBoxPacketLoss.Name = "TextBoxPacketLoss";
            TextBoxPacketLoss.ReadOnly = true;
            TextBoxPacketLoss.Size = new Size(120, 29);
            TextBoxPacketLoss.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(166, 21);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 8;
            label4.Text = "Status";
            // 
            // TextBoxActive
            // 
            TextBoxActive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxActive.Location = new Point(166, 45);
            TextBoxActive.Name = "TextBoxActive";
            TextBoxActive.ReadOnly = true;
            TextBoxActive.Size = new Size(120, 29);
            TextBoxActive.TabIndex = 7;
            // 
            // AddressZoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 421);
            Controls.Add(label3);
            Controls.Add(TextBoxPacketLoss);
            Controls.Add(label4);
            Controls.Add(TextBoxActive);
            Controls.Add(label2);
            Controls.Add(TextBoxDnsName);
            Controls.Add(LogRichTextBox);
            Controls.Add(label1);
            Controls.Add(TextBoxIP);
            MaximizeBox = false;
            MaximumSize = new Size(600, 460);
            Name = "AddressZoom";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddressZoom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxIP;
        private Label label1;
        private RichTextBox LogRichTextBox;
        private Label label2;
        private TextBox TextBoxDnsName;
        private Label label3;
        private TextBox TextBoxPacketLoss;
        private Label label4;
        private TextBox TextBoxActive;
    }
}