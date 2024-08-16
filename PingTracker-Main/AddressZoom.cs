using PingTracker.Model;

namespace PingTracker;

public partial class AddressZoom : Form
{
    private Address Address = null!;
    public AddressZoom(ref Address address)
    {
        InitializeComponent();
        Address = address;
        ButtonStartStop.Click += ButtonStartStop_Click;
        ButtonExportLog.Click += ButtonExportLog_Click;
        UpdateInfo();
    }

    private void ButtonExportLog_Click(object? sender, EventArgs e)
    {
        using var fbd = new FolderBrowserDialog();
        DialogResult result = fbd.ShowDialog();
        string path = Path.Combine(fbd.SelectedPath, $"");
        File.WriteAllTextAsync(, Address.Log.ToString());
        File.Open();
    }

    private void ButtonStartStop_Click(object? sender, EventArgs e)
    {
        Address.IsActive = !Address.IsActive;
    }

    private void LoadView()
    {
        TextBoxPacketLoss.Text = Address.CalculatePacketLoss();
        TextBoxIP.Text = Address.Ip;
        TextBoxDnsName.Text = Address.DnsName;
        TextBoxActive.Text = Address.IsActive ? "Online" : "Offline";
        LogRichTextBox.Text = Address.Log.ToString();
    }

    private async void UpdateInfo()
    {
        try
        {
            LoadView();
        }
        catch
        {
            MessageBox.Show("Erro ao atualizar informações do IP");
        }
        finally
        {
            await Task.Delay(1000);
            UpdateInfo();
        }
    }


}
