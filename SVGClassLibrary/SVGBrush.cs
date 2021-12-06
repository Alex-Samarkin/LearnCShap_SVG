using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGClassLibrary
{
    public class SVGBrush
    {
        /// <summary>
        /// цвет заливки
        /// </summary>
        public WebColors FillColor { get; set; } = WebColors.AntiqueWhite;
        /// <summary>
        /// прозрачность заливки
        /// </summary>
        public double FillOpacity { get; set; } = 0.1;
        /// <summary>
        /// цвет линии
        /// </summary>
        public WebColors LineColor { get; set; } = WebColors.Chocolate;
        /// <summary>
        /// прозрачность линии
        /// </summary>
        public double StrokeOpacity { get; set; } = 0.95;
        /// <summary>
        /// ширина линии
        /// </summary>
        public int StrokeWidth { get; set; } = 5;

        /// <summary>
        /// строка - часть тега заливки, нет первого пробела, нет переноса строки 
        /// </summary>
        public string FillString => $"fill=\"{FillColor}\" +" +
                                    $"fill-opacity=\"{FillOpacity,4:F2}\"";
        /// <summary>
        /// строка - часть тега строки, нет первого пробела, нет переноса строки 
        /// </summary>

        public string StrokeString => $"stroke=\"{LineColor}\" " +
                                      $"stroke-opacity=\"{StrokeOpacity,4:F2}\" " +
                                      $"stroke-width=\"{StrokeWidth}\"";

        /// <summary>
        /// заливка и линия
        /// </summary>
        public string BrushString => FillString + " " + StrokeString;

    }
}
