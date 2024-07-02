// See https://aka.ms/new-console-template for more information

public class Sets
{
    public static void Main()
    {
        HashSet<double> lapTimes = new HashSet<double>(); //Create a new set
        lapTimes.Add(51.3);
        lapTimes.Add(48.5);
        lapTimes.Add(49.2);
        lapTimes.Add(46.3);
        lapTimes.Add(47.8);
        lapTimes.Add(47.5);
        lapTimes.Add(52.6);
        lapTimes.Add(45.7);

        double fastestLap = lapTimes.Max();
        double slowestLap = lapTimes.Min();

        Console.WriteLine($"Your fastest lap was {fastestLap} seconds");
        Console.WriteLine($"Your slowest lap was {slowestLap} seconds");
    }
}
