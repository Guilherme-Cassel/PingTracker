using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace PingTracker.Model;

public class Address : IPAddress
{
    public string Ip { get; private set; } = null!;
    public string DnsName { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public int TotalPingsSent { get; private set; }
    public int TotalPingsReceived { get; private set; }
    public StringBuilder Log { get; private set; } = new();

    public Address(byte[] address) : base(address)
    {
        Ip = this.ToString();
        FillDnsName();
    }

    public async void FillDnsName()
    {
        try
        {
            DnsName = await AddressManager.GetDNSName(Ip);
        }
        catch
        {
            return;
        }
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