using System.Net.NetworkInformation;
using System.Net;
using System.Text;

namespace PingTracker;

public class AddressPinger(Address address)
{
    public Address Address { get; set; } = address;

    private CancellationTokenSource cancellationTokenSource = new();
    public double PingDropCount { get; private set; }
    public StringBuilder LogBank { get; private set; } = new();
    public Task? LoopingTask { get; set; } = null;

    private async Task<bool> Ping()
    {
        List<IPStatus> UnsuccessfullStatuses = new()
        {
            IPStatus.DestinationHostUnreachable,
            IPStatus.DestinationUnreachable,
            IPStatus.TimedOut,
            IPStatus.TimeExceeded
        };

        using Ping ping = new();
        PingReply reply = await ping.SendPingAsync(Address.Ip);

        Address.PingCount++;

        await Task.Delay(1000);

        if (UnsuccessfullStatuses.Any(x => x == reply.Status))
            return false;

        return true;
    }

    private async Task PingLoop()
    {
        double backupDropCount;
        bool result;

        while (true)
        {
            if (cancellationTokenSource.IsCancellationRequested)
                break;

            backupDropCount = PingDropCount;

            result = await Ping();

            if (result)
                continue;

            DateTime dropTime = DateTime.Now;
            double connectionLostPoint = backupDropCount + 5;
            while (!result)
            {
                PingDropCount++;

                result = await Ping();

                if (PingDropCount == connectionLostPoint)
                    Log(dropTime, "Connection Lost");

                if (result && PingDropCount >= connectionLostPoint)
                    Log(DateTime.Now, "Connection Reestabilished");
            }
        }
    }

    public async Task StopPing() => await cancellationTokenSource.CancelAsync();

    public async Task StartPing()
    {
        if (cancellationTokenSource.IsCancellationRequested)
            cancellationTokenSource = new();

        try
        {
            if (LoopingTask is null || LoopingTask.Status != TaskStatus.Running)
            {
                LoopingTask = Task.Run(PingLoop);
                await LoopingTask;
            }
        }
        catch (TaskCanceledException)
        {
            MessageBox.Show($"The ping of {Address.Ip} has stopped");
        }
    }

    private void Log(DateTime time, string msg)
    {
        LogBank.AppendLine($"({time}) {Address.Ip} | {Address.DnsName} - {msg}");
    }
}
