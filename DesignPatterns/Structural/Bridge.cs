namespace DesignPatterns
{
    class Bridge
    {
        public Bridge()
        {
            var tv = new Device();
            var homeTheater = new Device();

            var tvRemote = new Remote(tv);
            var htRemote = new AdvancedRemote(homeTheater);

            tvRemote.TurnOn();
            tvRemote.IncreaseVolume();
            tvRemote.TurnOff();

            htRemote.TurnOn();
            htRemote.DecreaseVolume();
            htRemote.Mute();
            htRemote.TurnOff();
        }
    }

    class Device
    {
        private int volume = 0;
        public bool State { get; set; }
        public int Volume { 
            get 
            { 
                return volume; 
            }
            set
            {
                if (value > 100) volume = 100;
                else if (value < 0) volume = 0;
                else volume = value;
            }
        }
    }

    class Remote
    {
        protected Device device;
        public Remote(Device device)
        {
            this.device = device;
        }

        public void TurnOn()
        {
            device.State = true;
        }
        public void TurnOff()
        {
            device.State = false;
        }

        public void IncreaseVolume()
        {
            device.Volume += 10;
        }

        public void DecreaseVolume()
        {
            device.Volume -= 10;
        }
    }

    class AdvancedRemote : Remote
    { 
        public AdvancedRemote(Device device) : base(device)
        { }
        public void Mute()
        {
            device.Volume = 0;
        }
    }

}
