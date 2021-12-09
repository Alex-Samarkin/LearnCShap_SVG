using SVGClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class GraphDoc : SVGDoc
    {
        public string Title { get; set; } = "Заголовок";
        public string SubTitle { get; set; } = "Подзаголовок";

        public string Author { get; set; } = "Автор";

        public DateTime dateCreated { get; set; } = DateTime.Now;

        public void MakeFormat()
        {
            SVGRectangle rect = new SVGRectangle();
            rect.Pt0.X = 0;
            rect.Pt0.Y = 0;
            rect.Pt1.X = this.Width;
            rect.Pt1.Y = this.Height;
            rect.Brush.StrokeWidth = 1;
            rect.Brush.LineColor = WebColors.BlueViolet;
            Add(rect);

            SVGText text = new SVGText();
            text.Pt0.X = 10;
            text.Pt0.Y = 5;
            text.Text = Author;
            Add(text);

            SVGText text1 = new SVGText();
            text1.Pt0.X = this.Width - 200;
            text1.Pt0.Y = 5;
            text1.Text = dateCreated.ToString();
            Add(text1);

            SVGText text2 = new SVGText();
            text2.Pt0.X = this.Width / 2 - Title.Length*6;
            text2.Pt0.Y = this.Height- 15;
            text2.Text = Title;
            Add(text2);

            SVGText text3 = new SVGText();
            text3.Pt0.X = this.Width / 2 - SubTitle.Length * 6;
            text3.Pt0.Y = this.Height - 15*2;
            text3.Text = SubTitle;
            Add(text3);

            SVGRectangle rect1 = new SVGRectangle();
            rect1 = rect.Inflate(20);
            rect1.Pt1.Y -= 15;
            rect1.Brush.StrokeWidth = 3;
            rect1.Brush.LineColor = WebColors.Black;
            rect1.Brush.FillColor = WebColors.Ivory;
            rect1.Brush.FillOpacity = 0.6;
            Add(rect1);
        }
    
        public void RandomCircles(int count = 5000)
        {
            var r = new Random();
            for (int i = 0; i < count; i++)
            {
                int rad = (int)r.Next(1,100);
                int xc = (int)r.Next(20+rad+5,this.Width-20-rad -5);
                int yc = (int)r.Next(20 + rad + 5, this.Height - 35 - rad - 5);

                var c = new SVGCircle()
                {
                    Center = new SVGPoint() { X = xc, Y = yc },
                    Radius = rad,
                    Brush = new SVGBrush
                    {
                        LineColor = WebColors.DarkOrange,
                        FillColor = WebColors.Ivory,
                        FillOpacity = 0.3,
                        StrokeWidth = 2,
                        StrokeOpacity = 0.5
                    }                    
                };
                Add(c);
            }

        }
    }
}
