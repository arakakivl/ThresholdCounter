namespace ThresholdCounter;

public class Program
{
    public static void Main()
    {
        var counter = new Counter();
        var inherited = new InheritCounter();

        counter.ThresholdReached += c_ThresholdReached;
        inherited.ThresholdReached += i_ThresholdReached;

        while(true)
        {
            Console.WriteLine("Press any key!");
            Console.ReadKey();

            counter.Add();
            inherited.Add();
        }
    }

    static void c_ThresholdReached(object? sender, EventArgs e)
    {
        Console.WriteLine("Counter finished at " + DateTime.Now);
        Environment.Exit(0);
    }

    static void i_ThresholdReached(object? sender, EventArgs e)
    {
        Console.WriteLine("Inherited counter finished at " + DateTime.Now);
        Environment.Exit(0);
    }
}