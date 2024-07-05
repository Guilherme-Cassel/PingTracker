using System.ComponentModel;

namespace PingTracker
{
    public partial class FormMainScreen : Form
    {
        public FormMainScreen()
        {
            InitializeComponent();

            Button_AddAddress.Click += Button_AddAddress_Click1;
        }

        public void InitializeBinding()
        {
            //BindingSource_ListView.DataSource = Addresses;
            //ListView_Addresses.DataBindings.Add(BindingSource_ListView);
        }

        private void Button_AddAddress_Click1(object? sender, EventArgs e)
        {
            var textbox = MaskedTextBox_AddAddress;

            if (textbox.Text is not string ip)
                return;

            //AddressesListView.Addresses.Add(new(ip, "dasd"));

            textbox.Text = string.Empty;
        }

        private void FormMainScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
