using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGClassLibrary
{
    public class SVGEllipse : SVGCircle
    {
        public int Radius2 { get; set; } = 50;

        /// <summary>
        /// поле AspectRatio
        /// задает второй радиус в set или считывает отношение осей эллипса в get
        /// </summary>
        public double AspectRatio
        {
            /// простые геттеры-сеттеры можно задавать через оператор =>
            /// называется expression body 
            get => (double)Radius2/Radius;
            set => Radius2 = (int)(Radius*AspectRatio);
        }

        #region Overrides of SVGCircle

        public override string GenerateText()
        {
            return $"<ellipse cx=\"{Center.X}\" cy=\"{Center.Y}\" rx=\"{Radius}\" ry=\"{Radius2}\" {Brush.BrushString}/>" +
                   EndL +
                   Comment("Im a little ellipse with propeller");
        }

        #endregion
    }
}
