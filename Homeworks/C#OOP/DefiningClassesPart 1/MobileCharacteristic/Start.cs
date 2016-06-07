namespace MobileCharacteristic
{
    using System;
    using System.ComponentModel;

    public class Start
    {
        public static void Main(string[] args)
        {
            var peshoBattery = new Battery("kirchova");
            var peshoDisplay = new Display("233x345");
            var peshoPhone = new GSM("Galaxy", "Samsung", 23.34, "Pesho", peshoBattery, peshoDisplay);
            //PrintAllProperties(peshoPhone);

            //System.Console.WriteLine(peshoPhone);

            //string a = GSM.IPhone4S;
            //System.Console.WriteLine(a);

            //var gsmTest = new GSMTest();
            //gsmTest.Add(peshoPhone);
            //gsmTest.PrintAllInstances(gsmTest.GSMInstances);

            GSMCallHistoryTest.TestCallHistory();
        }

        static void PrintAllProperties(object obj)
        {
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(obj);
                System.Console.WriteLine("{0}={1}", name, value);
            }
        }
    }
}
