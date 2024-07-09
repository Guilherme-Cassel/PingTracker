using System.Net;
using System.Net.NetworkInformation;

namespace PingTracker;

public class Address(string ip, string dnsName)
{
    private CancellationTokenSource cancellationToken = new();
    public int PingCount { get; set; }
    public int PingDropCount { get; set; }
    public string Ip { get; private set; } = ip;
    public string DnsName { get; private set; } = dnsName;

    public static async Task<Address> GetAddressFromIp(string ip)
    {
        IPAddress addr = IPAddress.Parse(ip);
        IPHostEntry entry = await Dns.GetHostEntryAsync(addr);

        string dnsName = entry.HostName[..entry.HostName.IndexOf('.')];

        return new(ip, dnsName);
    }

    private async Task<bool> Ping()
    {
        using Ping ping = new();
        PingReply reply = ping.Send(Ip);

        await Task.Delay(1000);

        switch (reply.Status)
        {
            case IPStatus.DestinationHostUnreachable:
                return false;
            case IPStatus.DestinationUnreachable:
                return false;
            case IPStatus.TimedOut:
                return false;
            case IPStatus.TimeExceeded:
                return false;
            default: return true;
        }
    }

    private async Task PingLoop()
    {
        await Task.Run(async () =>
        {
            int dropCount;
            bool result;

            while (true)
            {
                dropCount = 0;

                result = await Ping();

                if (result)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Pinged {Ip} Successfully");
                    continue;
                }

                DateTime dropTime = DateTime.Now;
                while (!result)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Pinged {Ip} Unsuccessfully");

                    dropCount++;

                    result = await Ping();

                    if (dropCount == 5)
                    {
                        Log($"{dropTime} - Connection Lost: {DnsName}");
                    }

                    if (result && dropCount >= 5)
                    {
                        Log($"{DateTime.Now} - Connection Reestabilished: {DnsName}");
                    }
                }
            }
        }, cancellationToken.Token);
    }

    public void StopPing() => cancellationToken.Cancel();

    public async Task StartPing()
    {
        cancellationToken = new();
        await PingLoop();
    }

    public void Log(string msg)
    {

    }
}
