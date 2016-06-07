using System;
using System.Collections.Generic;

namespace MobileCharacteristic
{
    public class GSM
    {

        //Fields

        private string model;
        private string manufactor;
        private double price;
        private string owner;
        private int MaxValue = 10;
        private static string iPhone4S = "New brand gsm for work and entertainment";
        private List<Calls> callHistory;
        private const double CostPerMinute = 0.40;

        //Constructors
        public GSM(string model, string manufactor)
        {
            this.Model = model;
            this.Manufactor = manufactor;
        }
        public GSM(string model, string manufactor, double price, string owner) : this(model, manufactor)
        {
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufactor, double price, string owner, Battery phoneBattery, Display phoneDisplay) : this(model, manufactor, price, owner)
        {
            this.PhoneBattery = phoneBattery;
            this.PhoneDisplay = phoneDisplay;
        }

        //Properties
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (IsLengthValid(value, MaxValue))
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("Invalid phone model");
                }
            }
        }
        public string Manufactor
        {
            get
            {
                return this.manufactor;
            }
            set
            {
                if (IsLengthValid(value, MaxValue))
                {
                    this.manufactor = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Manufactor");
                }
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 10000 || value < 20)
                {
                    throw new ArgumentException("Unreal price");
                }
                else
                {
                    this.price = value;
                }

            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new Exception("Invalid Name");
                }
                else
                {
                    this.owner = value;
                }
            }
        }
        public Battery PhoneBattery { get; set; }
        public Display PhoneDisplay { get; set; }

        public List<Calls> CallHistory
        {
            get
            {
                return new List<Calls>();
            }
            set
            {
                this.callHistory = value;
            }
        }

        public static string IPhone4S
        {
            get
            {
                return iPhone4S;
            }
            private set { }
        }
        //
        //Methods
        //
        public override string ToString()
        {
            return this.Model + " " + this.Manufactor + " " + this.Price + " " + this.Owner + " " + this.PhoneBattery + " " + this.PhoneDisplay + " ";
        }

        private static bool IsLengthValid(string str, int max)
        {
            if (str.Length > max || str.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddCall(DateTime date, DateTime time, string phoneNumber, int duration)
        {
            var newCall = new Calls(date, time, phoneNumber, duration);
            callHistory.Add(newCall);
        }

        public void DeleteCall(List<Calls> callHistory, int position)
        {
            callHistory.RemoveAt(position);
        }

        public void CalculateCallPrice(List<Calls> callHistory)
        {
            double sum = 0;
            foreach (var item in callHistory)
            {
                sum += (item.Duration * CostPerMinute);
            }
        }
    }



}