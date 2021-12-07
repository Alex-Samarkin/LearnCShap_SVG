using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGClassLibrary
{
    public class SVGCircle : SVGLine
    {
        /// <summary>
        /// добавляем поле радиуса
        /// </summary>
        public int Radius { get; set; } = 100;

        /// <summary>
        /// для удобства фактически даем полю Pt0 новое название
        /// </summary>
        public SVGPoint Center
        {
            get { return Pt0; }
            set { Pt0 = value; }
        }

        #region Overrides of SVGLine

        public override string GenerateText()
        {
            return $"<circle cx=\"{Center.X}\" cy=\"{Center.Y}\" r=\"{Radius}\" {Brush.BrushString}/>"+
                   EndL+
                   Comment("Circle is here");
        }

        #endregion
    }
}
