namespace ThresholdCounter;

/// <summary> Another event sender that inherits from <c>Counter</c> </summary>
/// <remarks> This objects override the <c>OnThresholdReached></c> event raiser. </remarks>
public class InheritCounter : Counter
{
    protected override void OnThresholdReached(EventArgs e)
    {
        Console.WriteLine("Invoking events...");
        base.OnThresholdReached(e);
    }
}