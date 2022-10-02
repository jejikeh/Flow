namespace Engine.Events;

public abstract class KeyEvent : Event
{
    protected override EventCategory CategoryFlags
    {
        get => EventCategory.Keyboard | EventCategory.Input;
    }

    protected int KeyCode { get; }
    
    protected KeyEvent(int keyCode) => KeyCode = keyCode;
}

public class KeyPressedEvent : KeyEvent
{
    public override EventType Type { get => EventType.KeyPressed; }
    public int RepeatCount { get; }

    public KeyPressedEvent(int keyCode, int repeatedTimes) : base(keyCode) =>
        RepeatCount = repeatedTimes;

    public override string ToString() => 
        TinyLog.Log.Output<KeyPressedEvent>($"{KeyCode} repeated {RepeatCount}");
}

public class KeyReleasedEvent : KeyEvent
{
    public override EventType Type { get => EventType.KeyReleased; }

    public KeyReleasedEvent(int keyCode) : base(keyCode) { }

    public override string ToString() => 
        TinyLog.Log.Output<KeyReleasedEvent>($"{KeyCode} was released");
}