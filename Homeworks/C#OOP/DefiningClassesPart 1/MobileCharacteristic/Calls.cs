namespace MobileCharacteristic
{
    using System;
    public class Calls
    {
        private DateTime date;
        private DateTime time;
        private string phoneNumber;
        private int duration;

        public Calls(DateTime date, DateTime time, string phoneNumber, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string PhoneNumber { get; set; }
        public int Duration { get; set; }

        public override string ToString()
        {
            return this.Date + " " + this.Time + " " + this.PhoneNumber + " " + this.Duration;
        }

    }
}