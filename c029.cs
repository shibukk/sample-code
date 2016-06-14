using System;
using System.Collections.Generic;

public class Weather
{
    public int Day { get; set; }
    public int Rate { get; set; }
}

public class Test
{
    public static void Main()
    {
        string[] MN = System.Console.ReadLine().Trim().Split(' ');
        var M       = Int32.Parse(MN[0]);
        var N       = Int32.Parse(MN[1]);

        var totalWeather = new List<Weather>();
        var minWeathers  = new List<Weather>();
        var minRate      = 9999;

        for (var i = 0; i < M; i++) {
            string[] line = System.Console.ReadLine().Trim().Split(' ');
            var day       = Int32.Parse(line[0]);
            var rate      = Int32.Parse(line[1]);
            totalWeather.Add(new Weather{ Day = day, Rate = rate });

            var currentWeathers = new List<Weather>();
            var currentRate     = 0;
            if (i + 1 < N) {
                continue;
            }
            for (var j = i; j > i - N; j--) {
                currentRate += totalWeather[j].Rate;
                currentWeathers.Add(totalWeather[j]);
            }
            if (currentRate < minRate) {
                minRate     = currentRate;
                minWeathers = currentWeathers;
            }
        }

        System.Console.WriteLine("{0} {1}", minWeathers[minWeathers.Count - 1].Day.ToString(), minWeathers[0].Day.ToString());
    }
}