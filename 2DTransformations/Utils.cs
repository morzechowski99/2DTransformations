using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows;

namespace _2DTransformations
{
    public static class Utils
    {
        static double DegreesToRadians(double degrees)
        {
            return (Math.PI * degrees) / 180.0;
        }
        public static double GetNewX(this double oldXValue, double oldYValue, double angle, double x, double y)
        {
            var radius = DegreesToRadians(angle);
            return x + (oldXValue - x) * Math.Cos(radius) - (oldYValue - y) * Math.Sin(radius);
        }

        public static double GetNewY(this double oldYValue, double oldXValue, double angle, double x, double y)
        {
            var radius = DegreesToRadians(angle);
            return y + (oldXValue - x) * Math.Sin(radius) + (oldYValue - y) * Math.Cos(radius);
        }

        public static double ScaleX(this double oldXValue, double scale, double x)
        {
            return x + (oldXValue - x) * scale;
        }

        public static double ScaleY(this double oldYValue, double scale, double y)
        {
            return y + (oldYValue - y) * scale;
        }

        public static string SerializePoints(IEnumerable<Point> polygon)
        {
            return JsonConvert.SerializeObject(polygon);
        }
        
        public static List<Point> Deserialize(string serialized)
        {
            return JsonConvert.DeserializeObject<List<Point>>(serialized);
        }
    }
}
