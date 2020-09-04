using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gestures;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Graph_Game.Droid
{
    class Vertex
    {
        int deg { get; set; }
        int id;
        public float x { get; set; }
        public float y { get; set; }

        public Vertex(int deg, int id, float x, float y)
        {
            this.deg = deg;
            this.id = id;
            this.x = x;
            this.y = y;
        }
        public Vertex(int id, float x, float y)
        {
            this.deg = 0;
            this.id = id;
            this.x = x;
            this.y = y;
        }

        public void AddDeg(int count)
        {
            deg += count;
        } 

        public void RemoveDeg(int count)
        {
            deg -= count;
        }

        public void Draw(Canvas canvas)
        {
            Paint paint = new Paint();
            
            paint.Color = Android.Graphics.Color.Orange;
            canvas.DrawCircle(x, y, 100, paint);
        }

    }
}