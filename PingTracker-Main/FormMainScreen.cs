using System.ComponentModel;
using System.Data;
using System.Linq;

namespace PingTracker;

public partial class FormMainScreen : Form
{
    public static BindingList<Address> Addresses = [];

    public FormMainScreen()
    {
        InitializeComponent();

        AddressBindingSource.DataSource = Addresses;

        Button_AddAddress.Click += Button_AddAddress_Click;
        RefreshDataGrid();
    }

    private async void RefreshDataGrid()
    {
        while (true)
        {
            await Task.Delay(1000);
            if (Addresses.Count > 0)
                await Task.Run(AddressesDataGrid.Invalidate);
        }
    }

    private async void Button_AddAddress_Click(object? sender, EventArgs e)
    {
        TextBox_AddAddress.ReadOnly = true;
        Button_AddAddress.Enabled = false;

        if (TextBox_AddAddress.Text is not string ip)
            return;

        try
        {
            if (Addresses.Any(x => x.Ip == ip))
                throw new HandledException("Ip Already Added");

            Address address = new(ip)
            {
                DnsName = await Address.GetDnsName(ip)
            };

            await address.InitializePinger();

            Addresses.Insert(0, address);

            address.Pinger!.StartPing();

            MessageBox.Show(
                "IP was added successfully.\n\nIt's Ping Monitor has been started",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ip}:\n\n{ex.Message}", "Erro Capturado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        finally
        {
            TextBox_AddAddress.Text = string.Empty;
            TextBox_AddAddress.ReadOnly = false;
            Button_AddAddress.Enabled = true;
        }
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        foreach (var address in Addresses)
        {
            await address.Pinger?.StopPing();
        }
    }
}
