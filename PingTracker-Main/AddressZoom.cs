using PingTracker.Model;

namespace PingTracker;

public partial class AddressZoom : Form
{
    private Address Address = null!;
    public AddressZoom(ref Address address)
    {
        InitializeComponent();
        Address = address;
        LoadView();
    }

    private void LoadView()
    {
        textBox1.Text = Address.Ip;
        textBox2.Text = Address.DnsName;
        LogRichTextBox.Text = Address.Log.ToString();
    }
}
