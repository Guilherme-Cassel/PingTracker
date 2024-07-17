using System.Net;

namespace PingTracker;

public class Address
{
    public string Ip { get; set; }
    public string? DnsName { get; set; }
    public int PingCount { get; set; } = 1;
    public string PacketLossPorcentage => GetPacketLoss();
    public AddressPinger? Pinger { get; private set; }

    private string GetPacketLoss()
    {
        if (Pinger is null)
            return "";

        var value = Pinger.PingDropCount * 100 / PingCount;

        return $"{value:N2}%";
    }

    public Address(string ip = "", string dnsName = "")
    {
        Ip = ip;
        DnsName = dnsName;
    }

    public async Task InitializePinger()
    {
        await Task.Run(() =>
        {
            Pinger = new(this);
        });
    }

    public static async Task<string> GetDnsName(string ip)
    {
        int timeout = 1000;

        Task<IPHostEntry> task = Dns.GetHostEntryAsync(ip);
        Task completedTask = await Task.WhenAny(task, Task.Delay(timeout));

        if (completedTask != task)
            throw new HandledException("Host Não Encontrado");

        IPHostEntry entry = await task;
        return entry.HostName[..entry.HostName.IndexOf('.')];
    }
}
