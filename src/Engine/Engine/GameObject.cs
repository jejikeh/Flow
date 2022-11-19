using SFML.Graphics;

namespace Engine;

public abstract class GameObject : Transformable, Drawable
{
    public virtual void Draw(RenderTarget target, RenderStates states)
    {
        states.Transform *= Transform;
    }
}