using PingTracker.Model;

namespace PingTracker;

public partial class AddressZoom : Form
{
    private Address Address = null!;
    public AddressZoom(ref Address address)
    {
        InitializeComponent();
        Address = address;
        UpdateLoop();
    }

    private void LoadView()
    {
        TextBoxPacketLoss.Text = Address.CalculatePacketLoss();
        TextBoxIP.Text = Address.Ip;
        TextBoxDnsName.Text = Address.DnsName;
        TextBoxActive.Text = Address.IsActive ? "Online" : "Offline";
        LogRichTextBox.Text = Address.Log.ToString();
    }

    private async void UpdateLoop()
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
            UpdateLoop();
        }
    }
}
