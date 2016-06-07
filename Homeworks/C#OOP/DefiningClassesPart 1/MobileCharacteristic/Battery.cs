namespace MobileCharacteristic
{
    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private string batteryTypes;
        public Battery(string model)
        {
            this.Model = model;
            this.BatteryTypes = BatteryType.LiOn.ToString();
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }
        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }

        public string BatteryTypes
        {
            get
            {
                return this.batteryTypes;
            }
            set
            {
                this.batteryTypes = value;
            }
        }

        public override string ToString()
        {
            return this.Model + " " + this.HoursIdle + " " + this.HoursTalk + " ";
        }
    }
}