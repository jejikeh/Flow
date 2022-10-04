namespace Engine.Events;

public abstract class KeyEvent : Event
{
    protected override EventCategory CategoryFlags
    {
        get => EventCategory.Keyboard | EventCategory.Input;
    }

    public Keys KeyCode { get; }
    
    protected KeyEvent(Keys keyCode) => KeyCode = keyCode;
}

public class KeyPressedEvent : KeyEvent
{
    public override EventType Type { get => EventType.KeyPressed; }

    public KeyPressedEvent(Keys keyCode) : base(keyCode)
    {
    }

    public override string ToString() => 
        TinyLog.Log.Output<KeyPressedEvent>($"{KeyCode} is down");
}

public class KeyReleasedEvent : KeyEvent
{
    public override EventType Type { get => EventType.KeyReleased; }

    public KeyReleasedEvent(Keys keyCode) : base(keyCode) { }

    public override string ToString() => 
        TinyLog.Log.Output<KeyReleasedEvent>($"{KeyCode} was released");
}