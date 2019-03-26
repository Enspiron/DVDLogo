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
            Scale = new Vector2(1, 1);
        }

        static float speed = 2;

        float xspeed = speed;
        float yspeed = speed;

        float scalex;
        float scaley;

        bool negativeX = false;
        bool negativeY = false;

        Random rnd = new Random();

        public void Animate(Vector2 screen)
        {
            if (!negativeX)
                xspeed = 2 * (screen.X / 800f);
            else
                xspeed = -2 * (screen.X / 800f);

            if (!negativeY)
                yspeed = 2 * (screen.X / 800f);
            else
                yspeed = -2 * (screen.X / 800f);

            scalex = screen.X / 800f;
            scaley = screen.Y / 480f;

            Scale = new Vector2(scalex, scaley);

            //xspeed = xspeed * scalex;
            //yspeed = yspeed * scaley;

            Position.X += xspeed;
            Position.Y += yspeed;

            if(Hitbox.X >= screen.X + 20 || Hitbox.X <= -10)
            {
                Position = new Vector2(20, 20);
            }
            if(Hitbox.Y >= screen.Y + 20 || Hitbox.Y <= -10)
            {
                Position = new Vector2(20, 20);
            }
            if (Hitbox.Y + (Scale.Y * 75 / Scale.Y * Scale.Y) >= screen.Y || Hitbox.Y <= 0)
            {
                Color = new Color(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                yspeed = -yspeed;
                negativeY = !negativeY;
            }
            if(Hitbox.X + (Scale.X * 165 / Scale.X * Scale.X) >= screen.X || Hitbox.X <= 0)
            {
                Color = new Color(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                xspeed = -xspeed;
                negativeX = !negativeX;
            }
        }
    }
}
