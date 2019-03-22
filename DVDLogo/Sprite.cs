using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLogo
{
    class Sprite
    {
        public Vector2 Position;
        public Texture2D Image;
        public Color Color;
        public Vector2 Scale;

        public virtual Rectangle Hitbox
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Image.Width, Image.Height);
            }
        }

        public Sprite(Texture2D image, Vector2 pos, Color tint)
        {
            this.Image = image;
            this.Position = pos;
            this.Color = tint;
        }

        public virtual void Draw(SpriteBatch batch)
        {
            batch.Draw(Image, Position, Color);
        }
    }
}
