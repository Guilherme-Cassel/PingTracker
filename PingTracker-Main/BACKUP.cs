using System.Net.NetworkInformation;

class Program
{
    public static readonly Dictionary<string, string> ipAddresses = new()
    {
        //{"Bruna's Notebook - RGO0104","192.168.0.6"},
        //{"Bruna's Cable - RGO0104","192.168.0.55"},
        //{"Bruna's E-Adapter - RGO0104","192.168.0.58" },
        //{"Altermar - RGO0162", "192.168.0.41"},
        //{"Rodrigo - RGO0117","192.168.0.37" }
        {"Alane's Cable- RGO0131","192.168.0.23" }
    };

    static async Task Main()
    {
        foreach (string ip in ipAddresses.Values)
        {
            _ = Task.Run(async () =>
            {
                await PingInLoop(ip);
            });
        }

        await Task.Delay(Timeout.InfiniteTimeSpan);
    }

    public static async Task PingInLoop(string ip)
    {
        string deviceName = ipAddresses.First(x => x.Value == ip).Key;

        int dropCount;
        bool result;
        while (true)
        {
            dropCount = 0;

            result = await PingIp(ip);

            if (result)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Pinged {ip} Successfully");
                continue;
            }

            DateTime dropTime = DateTime.Now;
            while (!result)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Pinged {ip} Unsuccessfully");

                dropCount++;

                result = await PingIp(ip);

                if (dropCount == 5)
                {
                    LogInstability($"{dropTime} - Connection Lost: {deviceName}");
                }

                if (result && dropCount >= 5)
                {
                    LogInstability($"{DateTime.Now} - Connection Reestabilished: {deviceName}");
                }
            }
        }
    }

    public static async Task<bool> PingIp(string ipAddress)
    {
        try
        {
            using Ping ping = new();
            PingReply reply = ping.Send(ipAddress);

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
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Error Ocurred When Pinging \"{ipAddress}\": {ex.InnerException}");
            return false;
        }
    }

    public static void LogInstability(string message, bool retry = true)
    {
        const int MaxTries = 5;

        int @try = 0;
        while (@try <= MaxTries)
        {
            try
            {
                string currentPath = Environment.CurrentDirectory;
                string logFilePath = Path.Combine(currentPath, "PingLog.txt");

                using StreamWriter writer = new(logFilePath, true);

                writer.WriteLine(message);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{DateTime.Now} - Drop Log Registered Sucessfully");
                break;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{DateTime.Now} - Error Ocurred When Printing Log");

                if (!retry) break;

                _ = Task.Run(() =>
                {
                    MessageBox.Show($"{DateTime.Now} - Error Ocurred While Log Try: {ex.Message}");
                });

                @try++;

                if (@try == MaxTries)
                {
                    LogInstability($"{DateTime.Now} - Error Ocurred While Log Try: {ex.Message}", false);
                }
            }
        }
    }
}