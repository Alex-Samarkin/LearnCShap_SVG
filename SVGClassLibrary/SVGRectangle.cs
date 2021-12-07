using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGClassLibrary
{
    public class SVGRectangle : SVGLine
    {
        /// <summary>
        /// расчет длины или ее задание
        /// </summary>
        public int Width
        {
            get=>Pt0.Dx(Pt1); 
            set=>Pt1.X=Pt0.X+value;
        }
        /// <summary>
        /// расчет или задание высоты
        /// </summary>
        public int Height
        {
            get => Pt0.Dy(Pt1);
            set => Pt1.Y = Pt0.Y + value;
        }

        #region Overrides of SVGLine

        public override string GenerateText()
        {
            return $"<rect x=\"{Pt0.X}\" y=\"{Pt0.Y}\" width=\"{Width}\" height=\"{Height}\" {Brush.BrushString}/>"+
                   EndL+
                   Comment("Im hard rectangle");
        }

        #endregion
        
        /// <summary>
        /// уменьшаем размер прямоугольника на w
        /// </summary>
        /// <param name="w">величина уменьшения</param>
        /// <returns>измененый прямоугольник</returns>
        public SVGRectangle Inflate(int w = 10)
        {
            var res = new SVGRectangle();
            res.Pt0 = Pt0.CopySvgPoint();
            res.Pt0.X += w;
            res.Pt0.Y += w;

            res.Pt1 = Pt1.CopySvgPoint();
            res.Pt1.X -= w;
            res.Pt1.Y -= w;

            return res;
        }
    }
}
