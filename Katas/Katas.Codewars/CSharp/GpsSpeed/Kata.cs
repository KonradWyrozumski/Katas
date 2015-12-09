using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas.Codewars.CSharp.GpsSpeed
{
    public class GpsSpeed
    {
        public static int Gps(int s, double[] x)
        {
            if (x.Length < 1)
            {
                return 0;
            }

            if (x.Length == 1)
            {
                return (int) Math.Floor(x[0]);
            }

            var speed = new List<double>();

            for (int i = 1; i < x.Length; i++)
            {
                speed.Add((x[i] - x[i - 1]) * 3600 / s);
            }

            return (int)Math.Floor(speed.Max());
        }
    }
}