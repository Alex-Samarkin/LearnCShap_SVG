using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace SVGClassLibrary
{
    /// <summary>
    /// базовый класс - элемент SVG файла
    /// реализует интерфейс <see cref="ISVG_Tag"/>
    /// методы класса и его свойства позволяют установить положение системы координат
    /// </summary>
    public class SVGItem : ISVG_Tag
    {
        /// <summary>
        /// завершение строки
        /// </summary>
        protected const string EndL = "\r\n";

        public string Comment(string s) => $"<!-- {s} -->" + EndL;

        /// <summary>
        /// координаты переноса начала координат (по умолчанию в левый нижний угол)
        /// считаем что размер файла 1600 х 900
        /// </summary>
        public int X0 { get; set; } = 0;
        public int Y0 { get; set; } = 900;

        /// <summary>
        /// перенос начала координат
        /// </summary>
        /// <returns>строка переноса</returns>
        public string  Translate()
        {
            return $"<g transform=\"translate({X0},{Y0})\">"+EndL;
        }

        /// <summary>
        /// поворот системы координат в градусах , против часовой стрелки
        /// </summary>
        public double Angle { get; set; } = 0;

        /// <summary>
        /// поворот системы координат
        /// </summary>
        /// <returns>строка поворота</returns>
        public string Rotate()
        {
            return $"<g transform=\"rotate({Angle,5:F2})\">"+EndL;
        }

        /// <summary>
        /// коэффициенты масштаба
        /// </summary>
        public double ScaleX { get; set; } = 1;
        public double ScaleY { get; set; } = 1;

        /// <summary>
        /// строка масштаба
        /// </summary>
        /// <param name="SameScale">если истина - то масштаб одинаков по обоим осям
        /// ложь - отдельнол по X и Y</param>
        /// <returns>строка масштаба</returns>
        public string Scale(bool SameScale = true)
        {
            if (SameScale)
                return $"<g transform=\"scale({ScaleX,5:F2})\">" + EndL;
            return $"<g transform=\"scale({ScaleX,5:F2},{ScaleY,5:F2})\">" + EndL;
        }

        /// <summary>
        /// включить поворот оси Y вверх
        /// </summary>
        public bool RevY { get; set; } = true;

        /// <summary>
        /// специальный случай - разворот оси Y из положения вниз в положение вверх
        /// </summary>
        /// <returns></returns>
        public string ReverseY()
        {
            return $"<g transform=\"scale(1,-1)\">" + EndL;
        }
        #region Implementation of ISVG_Tag

        public virtual string GenerateStart()
        {
           // throw new NotImplementedException();
           return "<g>" +
                  Translate() +
                  (RevY ? ReverseY() : "") +
                  Rotate() +
                  Scale(false)+
                  Comment("translate, rotate and scale setup here");
        }

        public virtual string GenerateText()
        {
            // throw new NotImplementedException();
            return Comment("real code is here");
        }

        public virtual string GenerateEnd()
        {
            // throw new NotImplementedException();
            return "</g></g></g>" + EndL +
                   Comment("end of coord sys setup") +
                   "</g>" +
                   Comment("end of group")+
                   "</g>";
        }

        public virtual string GenerateTag()
        {
            //throw new NotImplementedException();
            return GenerateStart() + GenerateText() + GenerateEnd();
        }

        #endregion

        #region Color

        public WebColors LineColor { get; set; } = WebColors.BlueViolet;
        public WebColors FillColor { get; set; } = WebColors.Ivory;

        #endregion
    }
}
