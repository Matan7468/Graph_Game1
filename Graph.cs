using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Graph_Game.Droid
{
    class Graph 
    {
        List<Vertex> vertices { get; set; }
        List<EdgeIF> edges { get; set; }

        public Graph(List<Vertex> vertices)
        {
            this.vertices = vertices;
        }
        public Graph()
        {
            vertices = new List<Vertex>();
        }

        public void AddVertices(Vertex vertex)
        {
            vertices.Add(vertex);
        }

        public void RemoveVertices(Vertex vertex)
        {
            vertices.Remove(vertex);
        }
    }
}