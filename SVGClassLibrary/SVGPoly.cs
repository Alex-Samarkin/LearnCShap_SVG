using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGClassLibrary
{
    public class SVGPoly : SVGLine
    {
        public List<SVGPoint> Points { get; set; } = new List<SVGPoint>();
        public int Count => Points.Count;

        public void Add(SVGPoint point)
        {
            Points.Add(point);
        }
        public void Add(int x,int y)
        {
            Points.Add(new SVGPoint() { X=x, Y=y });
        }

        public void RandomX(int count, int range = 10)
        {
            count = count < 1 ? 1 : count;
            var r = new Random();

            Points.Clear();
            double step = (Pt1.Y - Pt0.Y) / (count+1);
            for (int i = 1; i < count; i++)
            {
                Add(Pt0.X+r.Next(-range,range), Pt0.Y+2*(int)(i*step));
            }
        }
        public void RandomY(int count, int range = 10)
        {
            count = count < 1 ? 1 : count;
            var r = new Random();

            Points.Clear();
            double step = (Pt1.X - Pt0.X) / (count+1);
            for (int i = 1; i < count; i++)
            {
                Add(Pt0.X+(int)(2* i * step),Pt0.Y + r.Next(-range, range));
            }
        }
        public void Insert(SVGPoint point, int index)
        {
            index = index<0 ? 0 : (index>Count ? Count : index);
            Points.Insert(index, point);
        }

        public bool IsOpen { get; set; } = true;
        public bool IsClosed { get => !IsOpen; set => IsOpen =!value; }
        
        public string Kind { get => IsOpen ? "polyline" : "polygon"; }

        public override string GenerateText()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"<{Kind} points=\"{Pt0.X},{Pt0.Y} ");
            foreach (SVGPoint item in Points)
            {
                sb.Append($"{item.X},{item.Y} ");
            }
            sb.AppendLine($"{Pt1.X},{Pt1.Y}\" {Brush.BrushString}/>");

            return sb.ToString();
        }
    }
}
