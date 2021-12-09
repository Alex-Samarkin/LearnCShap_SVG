using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGClassLibrary
{
    public class SVGPath : SVGPoly
    {
        public List<SVGPoint> ControlPoints { get; set; } = new List<SVGPoint>();
        public enum IntervalType
        {
            Q,
            q
        }
        public List<IntervalType> Intervals { get; set; } = new List<IntervalType>();
        public void AddPathPoint(SVGPoint point, 
            SVGPoint control, 
            IntervalType interval = IntervalType.Q )
        {
            Points.Add( point );
            ControlPoints.Add( control );
            Intervals.Add( interval );
        }
        public void AddPathPoint(int x,int y,
            int cx,int cy,
            IntervalType interval = IntervalType.Q)
        {
            Points.Add(new SVGPoint() { X=x,Y=y});
            ControlPoints.Add(new SVGPoint() { X = cx, Y = cy });
            Intervals.Add(interval);
        }
        public void AddDeltaPathPoint(int dx, int dy,int dcx, int dcy)
        {
            Points.Add(new SVGPoint() { X = dx, Y = dy });
            ControlPoints.Add(new SVGPoint() { X = dcx, Y = dcy });
            Intervals.Add(IntervalType.q);
        }

        public override string GenerateText()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"<path d=\"M {Pt0.X},{Pt0.Y} ");
            for (int i = 0; i < Points.Count; i++)
            {
                sb.Append($"{Intervals[i].ToString()} {ControlPoints[i].X},{ControlPoints[i].Y} "+EndL);
                sb.Append($"{Points[i].X},{Points[i].Y} " + EndL);
            }
            sb.AppendLine($"{Pt1.X},{Pt1.Y}\" {Brush.BrushString}/>");

            return sb.ToString();
        }
    }
}
