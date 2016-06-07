namespace MobileCharacteristic
{
    using System.Collections.Generic;
    public class GSMTest
    {
        private List<GSM> gsmInstances;

        public GSMTest()
        {
            this.GSMInstances = new List<GSM>();
        }

        public List<GSM> GSMInstances
        {
            get
            {
                return this.gsmInstances;
            }
            set
            {
                this.gsmInstances = value;
            }
        }

        public void Add(GSM item)
        {
            gsmInstances.Add(item);
        }

        public void PrintAllInstances(List<GSM> instances)
        {
            foreach (var item in instances)
            {
                System.Console.WriteLine(item);
            }
        }


    }
}