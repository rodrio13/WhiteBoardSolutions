using System;

namespace ClockAngles
{
    public class ClockAngles
    {
        public static double ClockAngle(double Hour, double Minute)
        {
            double HourAngle = (Hour / 12) * 360;
            double MinuteAngle = (Minute / 60) * 360;
            double AngleOfClock = Math.Abs(HourAngle - MinuteAngle);
            Console.WriteLine(AngleOfClock);
            return AngleOfClock;
        }
        static void Main(string[] args)
        {
            ClockAngle(10, 30);
            ClockAngle(9, 50);
        }
    }
}