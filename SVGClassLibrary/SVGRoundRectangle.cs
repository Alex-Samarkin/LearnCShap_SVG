// LearnCShap_SVG
// SVGClassLibrary
// SVGRoundRectangle.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 3:19 07 12 2021

namespace SVGClassLibrary
{
    public class SVGRoundRectangle : SVGRectangle
    {
        public int Rx { get; set; } = 10;
        public int Ry { get; set; } = 10;

        #region Overrides of SVGRectangle

        public override string GenerateText()
        {
            return $"<rect x=\"{Pt0.X}\" y=\"{Pt0.Y}\" width=\"{Width}\" height=\"{Height}\" rx=\"{Rx}\" ry=\"{Ry}\" {Brush.BrushString}/>" +
                   EndL +
                   Comment("Im round and accurate rectangle");
        }

        #endregion
    }
}