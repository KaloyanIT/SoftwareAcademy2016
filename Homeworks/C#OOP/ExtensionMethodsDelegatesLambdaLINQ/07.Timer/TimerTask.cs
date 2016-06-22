namespace _07.Timer
{
    using System;
    //using System.Threading;
    using System.Timers;
    class TimerTask
    {
        private Timer timer1;
        static void Main()
        {
            Timer timer = new Timer(PrintSomething, null, 0, 200);

            
        }

        static void PrintSomething(object o)
        {
            Console.WriteLine("In TimerCallback: " + DateTime.Now);
            GC.Collect();
        }

        
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            isonline();
        }


    }
}
