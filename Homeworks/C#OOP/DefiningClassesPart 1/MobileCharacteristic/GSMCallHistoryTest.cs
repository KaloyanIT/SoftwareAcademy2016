namespace MobileCharacteristic
{
    using System;
    using System.Collections.Generic;

    public class GSMCallHistoryTest
    {
        private const double CallPrice = 0.34;
        public static void TestCallHistory()
        {
            var gsmTester = new GSM("Galaxy", "Nokia");
            List<Calls> afewCalls = new List<Calls>();
            DateTime now = DateTime.Now;
            string number = "08888888888";
            int duration = 180;
            for (int i = 0; i < 10; i++)
            {
                afewCalls.Add(new Calls(now, now, number, duration));
            }

            afewCalls.Add(new Calls(now, now, number, 320));

            Console.WriteLine("Calls are from this number: " + number + " and are " + duration + " seconds long, on date " + now);

            CalculatePriceOfCalls(afewCalls, duration);
            DeleteLongestCall(afewCalls);
            CalculatePriceOfCalls(afewCalls, duration);

            foreach (var item in afewCalls)
            {
                Console.WriteLine(item);
            }
            ClearCallHistory(afewCalls);
        }

        public static void CalculatePriceOfCalls(List<Calls> afewCalls, int duration)
        {
            double sum = afewCalls.Count * duration * CallPrice;
            Console.WriteLine(sum + "$");
        }

        public static void DeleteLongestCall(List<Calls> afewCalls)
        {
            int longestCall = 0;
            int currentIndex = 0;
            for (int i = 0; i < afewCalls.Count; i++)
            {

                int call = afewCalls[i].Duration;

                if (call > longestCall)
                {
                    longestCall = call;
                    currentIndex = i;
                }
            }
            afewCalls.RemoveAt(currentIndex);
        }

        public static void ClearCallHistory(List<Calls> afewCalls)
        {
            afewCalls.Clear();
        }
    }
}