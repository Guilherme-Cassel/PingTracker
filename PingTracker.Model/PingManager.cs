using System.ComponentModel;
using System.Net;

namespace PingTracker.Model;

public class PingManager : PingModel
{
    public BindingList<Address> addresses = [];

    public PingManager() : base()
    {
        base._manager = this;
        _ = RunPingingLoopAsync();
    }

    public void AddAddress(string stringIp)
    {
        if (addresses.Any(x => x.ToString() == stringIp))
            throw new HandledException("Ip Already Exists!");

        var ipArray = IPAddress.Parse(stringIp).GetAddressBytes();

        addresses.Add(new(ipArray));
    }

    private async Task RunPingingLoopAsync()
    {
        while (true)
        {
            await Task.Run(mrse.WaitOne);

            if (addresses.Count <= 0 || !addresses.Any(x => x.IsActive))
            {
                await Task.Delay(500);
                continue;
            }

            var pingTasks = new List<Task<(Address, bool)>>();

            var ips = addresses.Where(x => x.IsActive);

            foreach (var address in ips)
            {
                pingTasks.Add(PingAndLogAsync(address));
            }

            var results = await Task.WhenAll(pingTasks);

            foreach (var (address, success) in results.Where(x => !x.Item2))
            {
                OnPingFailed(address);
            }

            await Task.Delay(1000);
        }
    }

    public async Task<(Address, bool)> PingAndLogAsync(Address address)
    {
        bool result = await address.PingAsync();
        InvokeOnPingCompleted(address, result);
        return (address, result);
    }
}

