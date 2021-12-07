using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SVGClassLibrary;

namespace LearnCShap_SVG
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Введение
            Console.WriteLine(SVGNotes.Intro);
            Console.WriteLine(SVGNotes.Ch1);

            /// Часть 2
            Console.WriteLine(SVGNotes.Ch2);

            /// Часть 3
            Console.WriteLine(SVGNotes.Ch3);

            /// SVG документ
            SVGDoc svg = new SVGDoc();
            
            /// создание шапки и завершающей части
            Console.WriteLine(svg.GenerateStart());

            /// добавление линии
            svg.Add(new SVGLine());
            /// добавьте еще одну линию 0,900 - 800,300
            SVGLine line = new SVGLine()
            {
                Pt0 = new SVGPoint() { X = 0, Y = 900 },
                Pt1 = new SVGPoint() { X = 800, Y = 300 }
            };
            svg.Add(line);

            /// добавление окружности
            SVGCircle cr = new SVGCircle();
            cr.Center = new SVGPoint() { X = 500, Y = 500 };
            cr.Brush.FillColor = WebColors.AliceBlue;
            cr.Brush.FillOpacity = 0.5;
            svg.Add(cr);

            /// добавление эллипса
            SVGEllipse ell = new SVGEllipse(){Radius = 300};
            ell.Center = new SVGPoint() { X = 500, Y = 500 };
            ell.AspectRatio = 0.3;
            ell.Brush.FillColor = WebColors.Ivory;
            ell.Brush.FillOpacity = 0.5;
            svg.Add(ell);

            /// прямоугольник
            SVGRectangle rct = new SVGRectangle();
            rct.Pt0.X = 5;
            rct.Pt0.Y = 5;

            rct.Brush.FillColor = WebColors.AntiqueWhite;

            rct.Pt1.X = svg.Width - 5;
            rct.Pt1.Y = svg.Height - 5;

            svg.Add(rct);
            var rct1 = rct.Inflate(10);
            svg.Add(rct1);

            /// скругленный прямоугольник
            SVGRoundRectangle rrct = new SVGRoundRectangle();

            rrct.Pt0.X = 50;
            rrct.Pt0.Y = 50;
            rrct.Brush.FillColor = WebColors.Ivory;
            rrct.Pt1.X = svg.Width - 50;
            rrct.Pt1.Y = svg.Height - 50;
            svg.Add(rrct);



            Console.WriteLine(svg.SVGGenerateText());
            Console.WriteLine(svg.GenerateEnd());
            /// запись в файл
            svg.WriteToFile();
            /// отображение файла
            svg.ShowFile();

           
            var key = Console.ReadKey();
        }
    }
}
