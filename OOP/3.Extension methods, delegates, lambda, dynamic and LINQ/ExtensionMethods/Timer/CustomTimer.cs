namespace Timer
{
    using System;
    using System.Threading;

    public class CustomTimer
    {
        public static void Execute<T>(Action<T> method, T param, int interval)
        {
            method(param);
            Thread.Sleep(interval);
        }
    }
}
