using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;

namespace PingTracker;

public class Address(string ip = "", string dnsName = "") : INotifyPropertyChanged
{
    public string Ip { get; set; } = ip;

    public string DnsName { get; set; } = dnsName;

    private int _pingCount = 1;

    public int PingCount
    {
        get => _pingCount;
        set
        {
            if (_pingCount != value)
            {
                _pingCount = value;
                OnPropertyChanged();
            }
        }
    }

    public double PingDropCount { get; set; } = 0;

    public string PacketLossPorcentage => GetPacketLoss();

    public AddressPinger? Pinger { get; private set; }


    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private string GetPacketLoss()
    {
        if (Pinger is null)
            return "";

        var value = PingDropCount * 100 / PingCount;

        return $"{value:N2}%";
    }

    /// <summary>
    /// Assincronously creates Pinger and starts the PingLoop
    /// </summary>
    public async Task InitializePinger()
    {
        await Task.Run(() =>
        {
            Pinger = new(this);
        });

        _ = Pinger!.StartPing();
    }

    public static async Task<Address> GetAddress(string ip)
    {
        int timeout = 1000;

        Task<IPHostEntry> task = Dns.GetHostEntryAsync(ip);
        Task completedTask = await Task.WhenAny(task, Task.Delay(timeout));

        if (completedTask != task)
            throw new HandledException("Host Não Encontrado");

        IPHostEntry entry = await task;

        string mainIp = entry.AddressList[0].ToString();
        string dnsName = entry.HostName;

        if (dnsName.Contains('.'))
        {
            dnsName = entry.HostName[..entry.HostName.IndexOf('.')];
        }

        return new(mainIp, dnsName);
    }
}
