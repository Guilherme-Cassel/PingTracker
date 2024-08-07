using System.ComponentModel;
using System.Data;
using System.Net;

namespace PingTracker;

public partial class FormMainScreen : Form
{
    public static PingManager PingManager = null!;

    public FormMainScreen()
    {
        InitializeComponent();

        AddressBindingSource.DataSource = PingManager.addresses;
        PingManager.OnPingCompleted += PingManager_OnPingCompleted;

        TextBox_AddAddress.KeyDown += TextBox_AddAddress_KeyDown;
        Button_AddAddress.Click += Button_AddAddress_Click;
        ToolStripStartAll.Click += ToolStripStartAll_Click; ;
        ToolStripStopAll.Click += ToolStripStopAll_Click;
        ToolStripClearList.Click += ToolStripClearList_Click;
        AddressesDataGrid.DoubleClick += AddressesDataGrid_DoubleClick;
    }

    private void ToolStripStopAll_Click(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void ToolStripStartAll_Click(object? sender, EventArgs e)
    {
        foreach (var address in PingManager.addresses)
        {
            address.IsActive = false;
        }
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
            PingManager.AddAddress(ip);
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

    private async void PingManager_OnPingCompleted(Address address, bool e)
    {
        await Task.Run(AddressesDataGrid.Invalidate);
    }

    private void ToolStripClearList_Click(object? sender, EventArgs e)
    {
        PingManager.addresses.Clear();
    }
}
