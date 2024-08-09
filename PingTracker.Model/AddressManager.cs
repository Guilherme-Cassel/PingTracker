using System.Net;

namespace PingTracker.Model;

public static class AddressManager
{
    public static IPAddress ToIPAddress(this string ip)
    {
        return IPAddress.Parse(ip);
    }

    public static Address ToAddress(this string ip)
    {
        return new(ip.ToIPAddress().GetAddressBytes());
    }

    public static async Task<string> GetDNSName(string ip)
    {
        var entry = await Dns.GetHostEntryAsync(ip);
        var name = entry.HostName.Split('.')[0];
        return name;
    }
}
