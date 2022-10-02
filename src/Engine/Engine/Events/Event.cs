namespace Engine.Events;

public enum EventType
{
    None = 0,
    WindowClose,
    WindowResize,
    WindowFocus,
    WindowLostFocus,
    WindowMoved,
    AppTick,
    AppUpdate,
    AppRender,
    KeyPressed,
    KeyReleased,
    MouseButtonPressed,
    MouseButtonReleased,
    MouseMoved,
    MouseScrolled
}

[Flags]
public enum EventCategory
{
    None = 0,
    Application = 1 << 0,
    Input = 1 << 1,
    Keyboard = 1 << 2,
    Mouse = 1 << 3,
    MouseButton = 1 << 4
}

public abstract class Event
{
    public virtual EventType Type => EventType.None;
    protected virtual EventCategory CategoryFlags => EventCategory.None;
    private string Name => GetType().Name;
    public bool Handled = false;

    public override string ToString() => Name;

    public bool IsInCategory(EventCategory category) =>
        Convert.ToBoolean(CategoryFlags & category);
}

public class EventDispatcher
{
    private readonly Event _event;
    
    public EventDispatcher(Event @event) =>
        _event = @event;

    public bool Dispatch(Event eventDispatch)
    {
        if (_event.Type != eventDispatch.Type) return false;
        _event.Handled = eventDispatch.Handled;
        
        return true;
    }
}