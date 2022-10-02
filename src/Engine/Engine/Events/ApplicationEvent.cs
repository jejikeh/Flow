namespace Engine.Events;

public class WindowResizeEvent : Event
{
    public override EventType Type { get => EventType.WindowResize; }
    
    protected override EventCategory CategoryFlags
    {
        get => EventCategory.Application;
    }
    public int Width { get; }
    public int Height { get; }

    public WindowResizeEvent(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public override string ToString() =>
        TinyLog.Log.Output<WindowResizeEvent>($"X: {Width}, Y: {Height}");
}

public class WindowCloseEvent : Event
{
    public override EventType Type { get => EventType.WindowClose; }
    
    protected override EventCategory CategoryFlags
    {
        get => EventCategory.Application;
    }

    public WindowCloseEvent() { }
}

public class AppTickEvent : Event
{
    public override EventType Type { get => EventType.AppTick; }
    
    protected override EventCategory CategoryFlags
    {
        get => EventCategory.Application;
    }

    public AppTickEvent() { }
}

public class AppUpdateEvent : Event
{
    public override EventType Type { get => EventType.AppUpdate; }
    
    protected override EventCategory CategoryFlags
    {
        get => EventCategory.Application;
    }

    public AppUpdateEvent() { }
}

public class AppRenderEvent : Event
{
    public override EventType Type { get => EventType.AppRender; }
    
    protected override EventCategory CategoryFlags
    {
        get => EventCategory.Application;
    }

    public AppRenderEvent() { }
}