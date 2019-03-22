using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

namespace DVDLogo
{
    class Logo : Sprite
    {
        Random rand = new Random();
        public override Rectangle Hitbox => new Rectangle((int)Position.X, (int)Position.Y, (int)(Image.Width * Scale.X), (int)(Image.Height * Scale.Y));
        //public int Multiplier = 1;

        public TimeSpan PowerTimer = TimeSpan.Zero;

        public Logo(Texture2D image, Vector2 pos, Color tint)
            : base(image, pos, tint)
        {
            //Scale = new Vector2(0.5f, 0.5f);
        }
        int xspeed = 2;
        int yspeed = 2;

        public void Animate(Vector2 screen)
        {
            Position.X += xspeed;
            Position.Y += yspeed;
            if(Hitbox.Y + 60 >= screen.Y || Hitbox.Y <= 0)
            {
                yspeed = -yspeed;
            }
            if(Hitbox.X + 130 >= screen.X || Hitbox.X <= 0)
            {
                xspeed = -xspeed;
            }
        }
    }
}
