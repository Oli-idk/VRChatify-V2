using CoreOSC;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Management;


namespace VRChatify
{
    internal class Program
    {
        public static UDPSender? oscSender1;
        public static UDPSender? oscSender2;
        public static UDPSender? oscSender3;
        public static UDPListener? oscReceiver;
        public static MediaManagement mediaManagement = new();
        public static MainPage? mainPage;

        public static bool toggle = false;

        public static string oscText = Config.GetConfig("ChatBoxMessage") ?? "{SONG} - {ARTIST} | CPU: {CPU}% | RAM: {RAM}% | GPU: {GPU}% | Time: {TIME} |";
        public static Dictionary<int, string> textBoxData = new();

        public static PerformanceCounterCategory category = new("GPU Engine");
        public static ManagementClass cimobject1 = new("Win32_PhysicalMemory");
        public static ManagementClass cimobject2 = new("Win32_PerfFormattedData_PerfOS_Memory");
        public static ManagementClass mc = new("Win32_ComputerSystem");

        public static ResourceMonitor resourceMonitor = new();

        [STAThread]
        static void Main()
        {
            oscSender1 = new UDPSender("127.0.0.1", 9000);
            oscSender2 = new UDPSender("127.0.0.1", 9002);
            oscSender3 = new UDPSender("127.0.0.1", 9003);
            oscReceiver = new UDPListener(9001, OnOscPacket);
            mediaManagement.Init();
            resourceMonitor.Init();
            if (File.Exists("data.json"))
            {
                string jsonData = File.ReadAllText("data.json");
                textBoxData = JsonConvert.DeserializeObject<Dictionary<int, string>>(jsonData);
            }
            Task.Run(async () =>
            {

                await RunInBackground(TimeSpan.FromSeconds(5), async () =>
                {
                    await resourceMonitor.update();
                    if (toggle)
                    {
                        string msg = Utils.ParsePlaceholders(oscText);
                        oscSender1!.Send(new OscMessage("/chatbox/input", msg, true, false));
                        oscSender2!.Send(new OscMessage("/chatbox/input", msg, true, false));
                        oscSender3!.Send(new OscMessage("/chatbox/input", msg, true, false));
                    }
                });
            });


            mainPage = new MainPage();
            Application.Run(mainPage);
        }

        public static async Task RunInBackground(TimeSpan timeSpan, Action action)
        {
            var periodicTimer = new PeriodicTimer(timeSpan);
            while (await periodicTimer.WaitForNextTickAsync())
            {
                action();
            }
        }

        private static void OnOscPacket(OscPacket packet)
        {

        }

    }
}
