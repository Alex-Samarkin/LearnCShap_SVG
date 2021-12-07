using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGClassLibrary
{
    public class SVGLine : SVGItem
    {
        public SVGBrush Brush { get; set; } = new SVGBrush() { FillColor = WebColors.none, LineColor = WebColors.Navy };

        public SVGPoint Pt0 { get; set; } = new SVGPoint() { X = 0, Y = 0 };
        public SVGPoint Pt1 { get; set; } = new SVGPoint() { X = 500, Y = 50 };

        #region Overrides of SVGItem

        /*public override string GenerateStart()
        {
            return base.GenerateStart();
        }*/

        public override string GenerateText()
        {
            return $"<line x1=\"{Pt0.X}\" y1=\"{Pt0.Y}\" " +
                   $"x2=\"{Pt1.X}\" y2=\"{Pt1.Y}\" {Brush.StrokeString} />" +
                   Comment("line by two point") +
                   EndL;
        }

        /*public override string GenerateEnd()
        {
            return base.GenerateEnd();
        }*/

        /*public override string GenerateTag()
        {
            return base.GenerateTag();
        }*/

        #endregion
    }
}
