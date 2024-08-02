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

        TextBox_AddAddress.KeyDown += TextBox_AddAddress_KeyDown;
        Button_AddAddress.Click += Button_AddAddress_Click;
        ToolStripStartAll.Click += ToolStripStartAll_Click;
        ToolStripStopAll.Click += ToolStripStopAll_Click;
        ToolStripClearList.Click += ToolStripClearList_Click;
        AddressesDataGrid.DoubleClick += AddressesDataGrid_DoubleClick;
    }

    private void AddressesDataGrid_DoubleClick(object? sender, EventArgs e)
    {
        if (sender is not DataGridView dataGrid)
            return;

        var selectedRow = dataGrid.SelectedRows[0];
        var rowObject = selectedRow.DataBoundItem;

        if (rowObject is not Address address)
        {
            MessageBox.Show("Could not retrieve the Address from the selection", "Error");
            return;
        }

        AddressZoom zoomForm = new(ref address);
        zoomForm.ShowDialog();
    }

    private void TextBox_AddAddress_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            Button_AddAddress_Click(null, new());
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

            await AddNewAddress(ip);
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

    private async Task AddNewAddress(string ip)
    {
        Address address = await Address.GetAddress(ip);

        address.PropertyChanged += Address_PropertyChanged;

        await address.InitializePinger();

        Addresses.Insert(0, address);
    }

    private async void Address_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        await Task.Run(AddressesDataGrid.Invalidate);
    }

    private void ToolStripStartAll_Click(object? sender, EventArgs e)
    {
        foreach (var address in Addresses)
        {
            if (address.Pinger.LoopingTask is not null)
                continue;

            _ = address.Pinger!.StartPing();
        }
    }

    private async void ToolStripStopAll_Click(object? sender, EventArgs e)
    {
        foreach (var address in Addresses)
        {
            await address.Pinger!.StopPing();
        }
    }

    private void ToolStripClearList_Click(object? sender, EventArgs e)
    {
        ToolStripStopAll_Click(null, new());

        Addresses.Clear();
    }
}
