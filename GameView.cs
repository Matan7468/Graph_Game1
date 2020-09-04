using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Graph_Game.Droid
{
    class GameView:SurfaceView
    {
        Vertex v;
        Vertex v2;
        Basic_Edge be;
        Thread gameThread;

        bool isPlaying;
        bool threadRunning;
        public GameView(Vertex v,Vertex v2,Basic_Edge be, Activity activity):base(activity)
        {
            this.v = v;
            this.v2 = v2;
            this.be = be;
            this.gameThread = new Thread(Run);
            this.gameThread.Start();
            this.isPlaying = true;
            this.threadRunning = true;
        }
        public void Run() //פונקציית הריצה של המשחק
        {
            while (threadRunning)
            {
                if (isPlaying)
                {
                    if (Holder.Surface.IsValid)
                    {
                        Canvas canvas = Holder.LockCanvas();

                        Draw(canvas);

                        Holder.UnlockCanvasAndPost(canvas);
                    }
                }
                Thread.Sleep(1000 / 60);
            }
        }
        public override void Draw(Canvas canvas) //מצייר את כל רכיבי המשחק על גבי הקנבס
        {
            base.Draw(canvas);
            v.Draw(canvas);
            v2.Draw(canvas);
            be.DrawEdge(canvas);
        }
    }
}