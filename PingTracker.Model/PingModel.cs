using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PingTracker.Model;

public class PingModel : ThreadMonitor
{
    public PingManager _manager = null!;
    public event Action<Address, bool>? OnPingCompleted;

    public virtual void OnPingReconnect(Address address)
    {
        try
        {
            string message = $"({DateTime.Now.ToLongDateString()}) {address.Ip} | {address.DnsName} - Reconnected!";
            address.Log.AppendLine(message);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro ao salvar um Log:\n\n{ex.Message}", "Erro Capturado");
        }
    }

    public virtual void OnPingDisconnect(Address address, DateTime time)
    {
        try
        {
            string message = $"({time.ToLongDateString()}) {address.Ip} | {address.DnsName} - Connection Lost!";
            address.Log.AppendLine(message);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro ao salvar um Log:\n\n{ex.Message}", "Erro Capturado");
        }
    }

    public virtual void OnPingFailed(Address address)
    {
        _ = Task.Run(async () =>
        {
            address.IsActive = false;
            var startTime = DateTime.Now;

            while (!address.IsActive)
            {
                await Task.Run(mrse.WaitOne);

                if (address.TotalPingsSent == address.TotalPingsReceived + 5)
                    OnPingDisconnect(address, startTime);

                (Address, bool) result = await _manager.PingAndLogAsync(address);

                address.IsActive = result.Item2;

                await Task.Delay(1000);
            }

            if (address.DnsName == string.Empty)
                address.FillDnsName();

            OnPingReconnect(address);
        });
    }

    protected virtual void InvokeOnPingCompleted(Address address, bool result)
    {
        OnPingCompleted?.Invoke(address, result);
    }
}
