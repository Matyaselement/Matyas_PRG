using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    //třída na tahy (AI)
    internal class Stroke
    {
        public List<Point> Points { get; set; }
        public Color Color { get; set; }
        public float Width { get; set; }
        public bool IsEraser { get; set; }

        public Stroke(Color color, float width, bool isEraser = false)
        {
            Points = new List<Point>();
            Color = color;
            Width = width;
            IsEraser = isEraser;
        }
    }
}
