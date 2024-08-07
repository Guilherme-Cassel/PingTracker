using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

public class Address : IPAddress, INotifyPropertyChanged
{
    private bool _isActive = true;
    public bool IsActive
    {
        get { return _isActive; }
        set
        {
            if (_isActive != value)
            {
                _isActive = value;
                OnPropertyChanged();
            }
        }
    }
    public int TotalPingsSent { get; private set; }
    public int TotalPingsReceived { get; private set; }
    public StringBuilder Log { get; private set; } = new();
    public event PropertyChangedEventHandler? PropertyChanged;

    public Address(byte[] address) : base(address) { }
    public Address(long address) : base(address) { }

    protected virtual void OnPropertyChanged(string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public async Task<bool> PingAsync()
    {
        using Ping ping = new();

        try
        {
            var reply = await ping.SendPingAsync(this.ToString(), 1000);
            TotalPingsSent++;
            if (reply.Status == IPStatus.Success)
            {
                TotalPingsReceived++;
                return true;
            }
            return false;
        }
        catch
        {
            TotalPingsSent++;
            return false;
        }
    }

    public double CalculatePacketLoss()
    {
        if (TotalPingsSent == 0)
            return 0.0;

        int lostPackets = TotalPingsSent - TotalPingsReceived;
        return (double)lostPackets / TotalPingsSent * 100;
    }
}