using LibreHardwareMonitor.Hardware;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text.RegularExpressions;

namespace VRChatify
{
    public static class Utils
    {
        public static string version = "2.0.0";

        private static readonly List<PerformanceCounter> GpuCounters = new List<PerformanceCounter>();

        static Utils()
        {
            InitializeGpuCounters();
        }

        public static void Error(string Message)
        {
            Console.Write("[");
            Console.Write($"{DateTime.Now}", Color.Red);
            Console.Write("] ");

            Console.Write("[");
            Console.Write("Error", Color.Red);
            Console.Write("] ");
            Console.Write(Message);
            Console.WriteLine();
        }

        private static void InitializeGpuCounters()
        {
            PerformanceCounterCategory category = Program.category;

            foreach (string counterName in category.GetInstanceNames())
            {
                if (counterName.EndsWith("engtype_3D"))
                {
                    foreach (PerformanceCounter counter in category.GetCounters(counterName))
                    {
                        if (counter.CounterName == "Utilization Percentage")
                        {
                            GpuCounters.Add(counter);
                        }
                    }
                }
            }
        }

        #region usages

        public static float GetGPUUsage()
        {
            try
            {
                float result = 0f;

                foreach (PerformanceCounter counter in GpuCounters)
                {
                    _ = counter.NextValue();
                }

                Thread.Sleep(1000);

                foreach (PerformanceCounter counter in GpuCounters)
                {
                    result += counter.NextValue();
                }

                return result;
            }
            catch (Exception e)
            {
                Error("Grabbing GPU usage");
                Error(e.Message);
                return 0f;
            }
        }
        public static double GetRamUsage()
        {
            return Math.Round(GetRamUsed() / GetRamCapacity() * 100, 0);
        }
        public static double GetRamCapacity()
        {
            ManagementObjectCollection moc1 = Program.cimobject1.GetInstances();
            double capacity = 0;
            foreach (ManagementObject mo1 in moc1.Cast<ManagementObject>())
            {
                capacity += Math.Round(long.Parse(mo1.Properties["Capacity"].Value.ToString()!) / 1024 / 1024 / 1024.0, 1);
            }
            moc1.Dispose();
            Program.cimobject1.Dispose();
            return capacity;
        }
        public static double GetRamAvailable()
        {
            ManagementObjectCollection moc2 = Program.cimobject2.GetInstances();
            double available = 0;
            foreach (ManagementObject mo2 in moc2.Cast<ManagementObject>())
            {
                available += ((Math.Round(long.Parse(mo2.Properties["AvailableMBytes"].Value.ToString()!) / 1024.0, 1)));

            }
            moc2.Dispose();
            Program.cimobject2.Dispose();
            return available;
        }
        public static double GetRamUsed()
        {
            return GetRamCapacity() - GetRamAvailable();
        }
        #endregion
        private static int lastMsg = 0;
        private static int lastRandomMsg = 0;

        public static string GetMessage(bool isRandom)
        {
            if (Program.textBoxData.Count == 0)
            {
                return "No strings available"; // Handle the case where the dictionary is empty.
            }

            Random random = new();

            if (isRandom)
            {
                int randomKey;
                do
                {
                    randomKey = Program.textBoxData.Keys.ElementAt(random.Next(Program.textBoxData.Count));
                }
                while (randomKey == lastRandomMsg);

                lastRandomMsg = randomKey;
                return Program.textBoxData[randomKey];
            }
            else
            {
                lastMsg = (lastMsg % Program.textBoxData.Count) + 1;
                return Program.textBoxData[lastMsg];
            }
        }
        public static string CalculateTimeUntilUnixTimestamp(long unixTimestamp)
        {
            DateTime timestampDateTime = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp).DateTime;
            TimeSpan timeDifference = timestampDateTime - DateTime.Now;

            string formattedTimeDifference = $"{timeDifference.Hours:D2}:{timeDifference.Minutes:D2}";

            return formattedTimeDifference;
        }

        public static string ParsePlaceholders(string msg)
        {
            var replacements = new Dictionary<string, Func<string>>
            {
                { "{MESSAGES-RANDOM}", () => GetMessage(true) },
                { "{MESSAGES}", () => GetMessage(false) },
                { "{CPU}", () => Math.Round(Program.resourceMonitor.GetCpuUsage()).ToString() },
                { "{GPU}", () => Math.Round(Program.resourceMonitor.GetGpuUsage()).ToString() },
                { "{RAM}", () => GetRamUsage().ToString() },
                { "{RAM-AVAILABLE}", () => GetRamAvailable().ToString() },
                { "{RAM-USED}", () => GetRamUsed().ToString() },
                { "{RAM-CAPACITY}", () => GetRamCapacity().ToString() },
                { "{SONG}", () => Program.mediaManagement.GetSongName() },
                { "{ARTIST}", () => Program.mediaManagement.GetSongArtist() },
                { "{TIME}", () => DateTime.Now.ToString("h:mm tt") },
                { "{MTIME}", () => DateTime.Now.ToString("HH:mm") },
                { "{DURATION}", () => Program.mediaManagement.GetSongDuration().ToString(@"mm\:ss") },
                { "{POSITION}", () => Program.mediaManagement.GetCurrentSongTime().ToString(@"mm\:ss") },
            };

            foreach (var replacement in replacements)
            {
                msg = Regex.Replace(msg, replacement.Key, replacement.Value.Invoke());
            }

            msg = Regex.Replace(msg, @"\{TIMEUNTIL:(\d+)\}", match =>
            {
                string timestampString = match.Groups[1].Value;
                if (long.TryParse(timestampString, out long unixTimestamp))
                {
                    return CalculateTimeUntilUnixTimestamp(unixTimestamp);
                }
                return match.Value; // Return the original placeholder if timestamp parsing fails
            });

            return msg;
        }

    }
}
