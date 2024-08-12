using PingTracker.Model;

namespace PingTracker;

public partial class FormMainScreen : Form
{
    public static PingManager PingManager = new();

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

    private async void PingManager_OnPingCompleted(Address address, bool e)
    {
        await Task.Run(AddressesDataGrid.Invalidate);
    }

    private void ToolStripStopAll_Click(object? sender, EventArgs e)
    {
        PingManager.Pause();
    }

    private void ToolStripStartAll_Click(object? sender, EventArgs e)
    {
        PingManager.Resume();
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

    private void Button_AddAddress_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(TextBox_AddAddress.Text))
            return;

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

    private void ToolStripClearList_Click(object? sender, EventArgs e)
    {
        PingManager.addresses.Clear();
    }
}
