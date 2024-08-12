namespace PingTracker.Model;

public class ThreadMonitor
{
    public ManualResetEvent mrse { get; private set; } = new(true);
    public virtual void Resume() => mrse.Set();
    public virtual void Pause() => mrse.Reset();
}

