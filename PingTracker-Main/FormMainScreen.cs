using System.ComponentModel;

namespace PingTracker;

public partial class FormMainScreen : Form
{
    public static BindingList<Address> Addresses = [];

    public FormMainScreen()
    {
        InitializeComponent();

        AddressBindingSource.DataSource = Addresses;

        Button_AddAddress.Click += Button_AddAddress_Click;

        InitializePing();
    }

    private async void InitializePing()
    {
        try
        {
            foreach (var address in Addresses)
            {
                if (address.StartPing().IsCompleted)
                    await address.StartPing();
            }
        }
        catch
        {
            throw new HandledException("Ocorreu um erro ao inicializar o Ping");
        }
    }

    private async void Button_AddAddress_Click(object? sender, EventArgs e)
    {
        MaskedTextBox_AddAddress.ReadOnly = true;
        Button_AddAddress.Enabled = false;

        if (MaskedTextBox_AddAddress.Text is not string ip)
            return;

        try
        {
            Address address = await Address.GetAddressFromIp(ip.Trim());
            Addresses.Add(address);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ip}:\n\n{ex.Message}", "Erro Capturado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            MaskedTextBox_AddAddress.Text = string.Empty;
            MaskedTextBox_AddAddress.ReadOnly = false;
            Button_AddAddress.Enabled = true;
        }
    }
}
