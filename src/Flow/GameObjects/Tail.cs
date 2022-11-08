using Engine;
using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow.GameObjects
{
    public class Tail : GameObject
    {
        private RectangleShape _rectangleShape;
        private int _spriteSize = 8;


        public Tail(Vector2f startPosition, GameObject nextTailPart)
        {
            _rectangleShape = new RectangleShape(new Vector2f(_spriteSize, _spriteSize));
            _rectangleShape.FillColor = Color.Yellow;

            Position = startPosition;
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;
            target.Draw(_rectangleShape, states);
        }
    }
}
