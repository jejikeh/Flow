namespace Engine.Events;

public class MouseMovedEvent : Event
{
    public override EventType Type { get => EventType.MouseMoved; }

    protected override EventCategory CategoryFlags
    {
        get => EventCategory.Mouse | EventCategory.Input;
    }
    public float MouseX { get; }
    public float MouseY { get; }

    public MouseMovedEvent(float x, float y)
    {
        MouseX = x;
        MouseY = y;
    }

    public override string ToString() =>
        TinyLog.Log.Output<MouseMovedEvent>($"X: {MouseX}, Y: {MouseY}");
}

public class MouseScrollEvent : Event
{
    public override EventType Type { get => EventType.MouseScrolled; }

    protected override EventCategory CategoryFlags
    {
        get => EventCategory.Mouse | EventCategory.Input;
    }
    public float OffsetX { get; }
    public float OffsetY { get; }

    public MouseScrollEvent(float offsetX, float offsetY)
    {
        OffsetX = offsetX;
        OffsetY = offsetY;
    }
    
    public override string ToString() =>
        TinyLog.Log.Output<MouseScrollEvent>($"X: {OffsetX}, Y: {OffsetY}");
}

public abstract class MouseButtonEvent : Event
{
    public int Button { get; }
    
    protected override EventCategory CategoryFlags
    {
        get => EventCategory.MouseButton | EventCategory.Input;
    }

    protected MouseButtonEvent(int button) => Button = button;
}

public class MouseButtonPressedEvent : MouseButtonEvent
{
    public override EventType Type { get => EventType.MouseButtonPressed; }
    public MouseButtonPressedEvent(int button) : base(button) { }
    
    public override string ToString() =>
        TinyLog.Log.Output<MouseButtonPressedEvent>($"{Button} was pressed");
}

public class MouseButtonReleasedEvent : MouseButtonEvent
{
    public override EventType Type { get => EventType.MouseButtonReleased; }
    public MouseButtonReleasedEvent(int button) : base(button) { }
    
    public override string ToString() =>
        TinyLog.Log.Output<MouseButtonReleasedEvent>($"{Button} was released");
}