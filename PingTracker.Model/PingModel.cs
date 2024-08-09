namespace PingTracker.Model;

public class PingModel()
{
    public required Action Action { get; set; }

    public PingManager _manager = null!;
    public event Action<Address, bool>? OnPingCompleted;
    public CancellationTokenSource CancelationTokenSource { get; set; } = null!;

    public virtual void OnPingDisconnect(Address address, DateTime time)
    {
        try
        {
            string message = $"({time}) {address.Ip} | {address.DnsName} - Connection Lost!";
            address.Log.AppendLine(message);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro ao salvar um Log:\n\n{ex.Message}", "Erro Capturado");
        }
    }

    public virtual void OnPingFailed(Address address)
    {
        address.IsActive = false;
        var startTime = DateTime.Now;

        _ = Task.Run(async () =>
        {
            while (!address.IsActive)
            {
                if (address.TotalPingsSent == address.TotalPingsReceived + 5)
                    OnPingDisconnect(address, startTime);

                (Address, bool) result = await _manager.PingAndLogAsync(address);
                address.IsActive = result.Item2;
                await Task.Delay(1000);
            }

            if (address.DnsName == string.Empty)
                address.FillDnsName();
        }, CancelationTokenSource.Token);
    }

    public virtual void StartPinging()
    {
        CancelationTokenSource = new();
    }

    public virtual void StopPinging()
    {
        CancelationTokenSource.Cancel();
    }

    protected virtual void InvokeOnPingCompleted(Address address, bool result)
    {
        OnPingCompleted?.Invoke(address, result);
    }
}
