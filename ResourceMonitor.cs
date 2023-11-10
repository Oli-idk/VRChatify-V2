using LibreHardwareMonitor.Hardware;

namespace VRChatify
{
    public class ResourceMonitor
    {
        private readonly Computer computer = new()
        {
            IsCpuEnabled = true,
            IsGpuEnabled = true,
            IsMemoryEnabled = true,
        };

        public void Init() => Task.Run(() =>
        {
            computer.Open();
        });

        public void Shutdown() => Task.Run(() =>
        {
            computer.Close();
        });

        public async Task update() => await Task.Run(() =>
        {
            foreach (var hardware in computer.Hardware)
            {
                updateHardware(hardware);
            }
        });

        private void updateHardware(IHardware hardware)
        {
            hardware.Update();
            foreach (var item in hardware.SubHardware)
            {
                updateHardware(item);
            }
        }

        public float GetCpuUsage()
        {
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "CPU Total")
                        {
                            return sensor.Value.Value;
                        }
                    }
                }
            }
            return -1;
        }

        public float GetGpuUsage()
        {
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuNvidia)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "GPU Core")
                        {
                            return sensor.Value.Value;
                        }
                    }
                }
            }
            return -1;
        }

        public float GetRamUsage()
        {
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Memory)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                        {
                            return sensor.Value.Value;
                        }
                    }
                }
            }
            return -1;
        }

    }
}
