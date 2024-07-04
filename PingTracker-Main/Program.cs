namespace PingTracker_Main
{
    static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMainScreen());
        }
    }
}