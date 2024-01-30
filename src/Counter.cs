namespace ThresholdCounter;

/// <summary> Event sender. </summary>
/// <remarks> This object raises the event member, and it doesn't know which object or method will handle the event. </remarks>
public class Counter {
    /// <summary> A <c>delegate</c> holds single or multiple references to different methods that match its signature. </summary>
    /// <remarks> An <c>EventHandler</c> is a delegate type that specifies no data for the subscriber. A generic <c>EventHandler&lt;T&gt;</c> version can be used to specify the data to be sent. </remarks>
    public event EventHandler? ThresholdReached;
    
    private readonly int _threshold;
    private int _count;

    public Counter() => 
        this._threshold = new Random().Next(1, 30);

    public void Add()
    {
        this._count++;
        if (this._count >= this._threshold) OnThresholdReached(EventArgs.Empty);
    }

    /// <summary> This method is responsible for raising the event. </summary>
    /// <remarks> Furthermore, inherited classes can override it if needed. </remarks>
    protected virtual void OnThresholdReached(EventArgs e) => 
        ThresholdReached?.Invoke(this, e);
}