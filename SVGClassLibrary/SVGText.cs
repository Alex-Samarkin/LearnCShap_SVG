using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGClassLibrary
{
    public class SVGText : SVGLine
    {
        public bool AsDelta { get; set; } = false;
        public string Text { get; set; } = "Текст text";

        public override string GenerateText()
        {
            /// <text x="20" y="35" class="small">My</text>
            string res1 = $"<text x=\"{Pt0.X}\" y=\"{-Pt0.Y}\"> {Text}</text>";
            string res2 = $"<text dx=\"{Pt1.X}\" dy=\"{-Pt1.Y}\"> {Text}</text>";
            return AsDelta ? res2 : res1;
        }
        public SVGText()
        {
            Angle = 180;
            ScaleX = -1;
        }
    }
}
