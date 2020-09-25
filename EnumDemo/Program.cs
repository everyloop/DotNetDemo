using System;

namespace EnumDemo
{
    class Program
    {
        public enum Style
        {
            Bold = 1,
            Italic = 2,
            Underlined = 4,
            StrikeThrough = 8,
            Colored = 16
        }
        static void Main(string[] args)
        {
            RenderText("Fredrik", "Arial.ttf", 15, Style.Underlined | Style.Bold);
        }

        static void RenderText(string text, string font, int size, Style style)
        {
            Console.WriteLine($"Rendering '{text}' with font: {font}");
            
            if ((style & Style.Bold) == Style.Bold)
            {
                Console.WriteLine($"Render text as bold.");
            }

            if ((style & Style.Italic) == Style.Italic)
            {
                Console.WriteLine($"Render text as italic.");
            }

            if ((style & Style.Underlined) == Style.Underlined)
            {
                Console.WriteLine($"Render text as underlined.");
            }

        }
    }
}
