using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SVGClassLibrary
{
    public class SVGPoint
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public SVGPoint PtByDelta(int dx, int dy)
        {
            var pt = new SVGPoint();
            pt.X += dx;
            pt.Y += dy;
            return pt;
        }
        public SVGPoint PtByAngle(int r, double angle_deg)
        {
            int dx = (int)(r * Math.Cos(Math.PI / 180 * angle_deg));
            int dy = (int)(r * Math.Sin(Math.PI / 180 * angle_deg));
            return PtByDelta(dx,dy);
        }

        public int Dx(SVGPoint pt) => pt.X - X;
        public int Dy(SVGPoint pt) => pt.Y - Y;
    }
}
