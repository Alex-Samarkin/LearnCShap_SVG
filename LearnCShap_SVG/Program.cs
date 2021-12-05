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
            /// SVG документ
            SVGDoc svg = new SVGDoc();
            /// создание шапки и завершающей части
            Console.WriteLine(svg.GenerateStart());
            Console.WriteLine(svg.GenerateEnd());
            /// запись в файл
            svg.WriteToFile();
            /// отображение файла
            svg.ShowFile();

            /// Часть 2
            Console.WriteLine(SVGNotes.Ch2);
            var key = Console.ReadKey();
        }
    }
}
