using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GraphLibrary;

namespace GraphApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphDoc doc = new GraphDoc();
            doc.GenerateStart();
            doc.MakeFormat();
            /// doc.RandomCircles(110000);
            doc.RandomRect(80000);
            doc.SVGGenerateText();
            doc.GenerateEnd();
            doc.WriteToFile();
            doc.ShowFile();

        }
    }
}
