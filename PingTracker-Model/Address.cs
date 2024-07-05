using System.Net.NetworkInformation;

namespace PingTracker;

public class Address(string ip, string dnsName)
{
    public string Ip { get; private set; } = ip;
    public string DnsName { get; private set; } = dnsName;
}
