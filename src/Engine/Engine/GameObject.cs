using SFML.Graphics;

namespace Engine;

public abstract class GameObject : Transformable, Drawable
{
    public abstract void Draw(RenderTarget target, RenderStates states);
}