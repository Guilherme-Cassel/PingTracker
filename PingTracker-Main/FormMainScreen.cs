using System.ComponentModel;
using System.Net;

namespace PingTracker
{
    public partial class FormMainScreen : Form
    {
        public FormMainScreen()
        {
            InitializeComponent();

            Button_AddAddress.Click += Button_AddAddress_Click;
        }

        public void InitializeBinding()
        {
            //BindingSource_ListView.DataSource = Addresses;
            //ListView_Addresses.DataBindings.Add(BindingSource_ListView);
        }

        private async void Button_AddAddress_Click(object? sender, EventArgs e)
        {
            MaskedTextBox_AddAddress.ReadOnly = true;
            Button_AddAddress.Enabled = false;

            if (MaskedTextBox_AddAddress.Text is not string ip)
                return;

            try
            {
                IPAddress addr = IPAddress.Parse(ip);
                IPHostEntry entry = await Dns.GetHostEntryAsync(addr);

                MessageBox.Show(entry.HostName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro Capturado");
            }
            finally
            {
                MaskedTextBox_AddAddress.Text = string.Empty;
            }

            MaskedTextBox_AddAddress.ReadOnly = false;
            Button_AddAddress.Enabled = true;
        }

        private void FormMainScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
