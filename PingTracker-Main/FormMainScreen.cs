namespace PingTracker_Main
{
    public partial class FormMainScreen : Form
    {
        public FormMainScreen()
        {
            InitializeComponent();
        }

        private void Button_AddAddress_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MaskedTextBox_AddAddress.Text);
        }
    }
}
