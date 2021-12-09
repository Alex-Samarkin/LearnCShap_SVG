using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGClassLibrary
{
    public class SVGPolyLine : SVGPoly
    {
        public SVGPolyLine()
        {
            IsOpen = true;
        }
        public void Triangles(int x0,int y0,int x1,int range,int count)
        {
            Pt0.X = x0;
            Pt0.Y = y0;
            Pt1.X = x1;
            Pt1.Y = y0;

            Points.Clear();

            count = count<2 ? 2:count;
            int step = (x1 - x0) / (count+1);

            for (int i = 1; i <= count; i++)
            {
                Add(Pt0.X + step * i, Pt0.Y + range * (int)Math.Pow(-1, i+1));
            }
        }
    }
}
