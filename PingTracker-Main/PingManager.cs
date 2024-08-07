using System.ComponentModel;
using System.Net;
using System.Threading;

namespace PingTracker;

public class PingManager
{
    public BindingList<Address> addresses;
    public event Action<Address, bool> OnPingCompleted = null!;
    private event Action<Address> OnPingFailed = null!;
    private event Action<Address, DateTime> OnPingDisconnect = null!;
    private CancellationTokenSource CancelationTokenSource { get; set; } = null!;

    public PingManager()
    {
        OnPingFailed += PingManager_OnPingFailed;
        OnPingDisconnect += PingManager_OnPingDisconnect;

        CancelationTokenSource = new();
        addresses = [];
        _ = RunPingingLoopAsync();
    }

    private async void PingManager_OnPingDisconnect(Address address, DateTime time)
    {
        try
        {
            IPHostEntry hostEntry = await Dns.GetHostEntryAsync(address.ToString(), CancelationTokenSource.Token);
            string message = $"({time}) {address} | {hostEntry.HostName} - Connection Lost!";
            address.Log.AppendLine(message);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro ao salvar um Log:\n\n{ex.Message}", "Erro Capturado");
        }
    }

    private void PingManager_OnPingFailed(Address address)
    {
        address.IsActive = false;
        var startPoint = address.TotalPingsReceived;
        var startTime = DateTime.Now;

        _ = Task.Run(async () =>
        {
            while (!address.IsActive)
            {
                if (startPoint == address.TotalPingsReceived + 5)
                    OnPingDisconnect.Invoke(address, startTime);

                address.IsActive = await address.PingAsync();
                await Task.Delay(1000);
            }
        }, CancelationTokenSource.Token);
    }

    public void StartPinging()
    {
        CancelationTokenSource = new();
        _ = RunPingingLoopAsync();
    }

    public void StopPinging()
    {
        CancelationTokenSource.Cancel();
    }

    public void AddAddress(string stringIp)
    {
        Address address = (Address)IPAddress.Parse(stringIp);

        if (addresses.Contains(address))
            throw new HandledException("Ip Already Exists!");

        addresses.Add(address);
    }

    public void RemoveAddress(Address address)
    {
        addresses.Remove(address);
    }

    private async Task RunPingingLoopAsync()
    {
        while (!CancelationTokenSource.Token.IsCancellationRequested)
        {
            if (addresses.Count <= 0 || !addresses.Any(x => x.IsActive))
            {
                await Task.Delay(1000, CancelationTokenSource.Token);
                continue;
            }

            var pingTasks = new List<Task<(Address, bool)>>();

            var ips = addresses.Where(x => x.IsActive);

            foreach (var address in ips)
            {
                pingTasks.Add(PingAndLogAsync(address));
            }

            var results = await Task.WhenAll(pingTasks);

            foreach (var (address, success) in results)
            {
                if (success)
                    continue;

                OnPingFailed?.Invoke(address);
            }

            await Task.Delay(1000, CancelationTokenSource.Token);
        }
    }

    private async Task<(Address, bool)> PingAndLogAsync(Address address)
    {
        bool result = await address.PingAsync();
        OnPingCompleted?.Invoke(address, result);
        return (address, result);
    }
}

