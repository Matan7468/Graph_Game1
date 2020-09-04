using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading;

namespace Graph_Game.Droid
{
    [Activity(Label = "Graph_Game", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);
            GameView gv = new GameView(new Vertex(0, 300, 300), new Vertex(0, 900, 600),new Basic_Edge(new Vertex(0, 300, 300), new Vertex(0, 900, 600)), this);
            this.SetContentView(gv);


        }



    }
}