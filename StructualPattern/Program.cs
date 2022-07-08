namespace StructualPattern
{
    interface IDevice
    {
        public bool IsEnabled();
        public void Enable();
        public void Disable();
        public int GetVolume();
        public void SetVolume(int percent);
        public int GetChannel();
        public void SetChannel(int channel);

    }

    class Radio : IDevice
    {
        public void Disable() => Console.WriteLine("Radio Disable");
        public void Enable() => Console.WriteLine("Radio Enable");
        public int GetChannel() => 0;
        public int GetVolume() => 0;
        public bool IsEnabled() => true;
        public void SetChannel(int channel) => channel = 0;
        public void SetVolume(int percent) => percent = 0;
    }

    class Remote
    {
        protected IDevice _device;

        public Remote(IDevice device)
        {
            device = device;
        }

        public void TogglePower()
        {
            if (_device.IsEnabled())
                _device.Disable();
            else
                _device.Enable();
        }

        public void VolumeDown() => _device.SetVolume(_device.GetVolume() - 10);

        public void VolumeUp() => _device.SetVolume(_device.GetVolume() + 10);

        public void ChannelDown() => _device.SetChannel(_device.GetChannel() - 1);

        public void ChannelUp() => _device.SetChannel(_device.GetChannel() + 1);

    }

    class AdvancedRemoteControl : Remote
    {
        public AdvancedRemoteControl(IDevice device)
            : base(device) { }

        public void mute() => _device.SetVolume(0);
    }

    public class Program
    {
        static void Main(string[] args)
        {
            IDevice device = null;
            Radio radio = new Radio();
            Remote remote = new Remote(radio);


            while (true)
            {
                Console.WriteLine("\n1) TogglePower\n2) VolumeDown");
                Console.WriteLine("3) VolumeUp\n4) ChannelDown");
                Console.WriteLine("5) ChannelUp\nOther: Exit");

                Console.Write("\nEnter choice: ");

                string c = Console.ReadLine();
                switch (c)
                {
                    case "1":
                        remote.TogglePower();
                        break;
                    case "2":
                        remote.VolumeDown();
                        break;
                    case "3":
                        remote.VolumeUp();
                        break;
                    case "4":
                        remote.ChannelDown();
                        break;
                    case "5":
                        remote.ChannelUp();
                        break;

                    default:
                        break;
                }

            }
        }
    }
}