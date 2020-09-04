using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.InputMethodServices;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Xaml;

namespace Graph_Game.Droid
{
    class Basic_Edge: EdgeIF
    {
        Vertex v1 { get; set; }
        Vertex v2 { get; set; }

        public Basic_Edge(Vertex v1, Vertex v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public void DrawEdge(Canvas canvas)
        {
            Paint paint= new Paint();
            paint.Color = Color.Orange;
            paint.StrokeWidth = 20;
            canvas.DrawLine(v1.x, v1.y, v2.x, v2.y, paint) ;
        }
    }
}