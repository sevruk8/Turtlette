using Microsoft.SmallBasic.Library;
using System;

namespace TurtleGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();

            GraphicsWindow.BrushColor = "Grey";

            var eat = Shapes.AddRectangle(10, 10);
            int y = 200;
            int x = 200;
            Shapes.Move(eat, x, y);

            Random rnd = new Random();
            while (true)
            {
                Turtle.Move(10);
                if (Turtle.X >= x && Turtle.X <= x + 11 && Turtle.Y >= y && Turtle.Y <= y + 11)
                {
                    x = rnd.Next(0, GraphicsWindow.Width);
                    y = rnd.Next(0, GraphicsWindow.Height);
                    Shapes.Move(eat, x, y);
                    Turtle.Speed++;
                }
            }

        
        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
                Turtle.Angle = 0;

            else if (GraphicsWindow.LastKey == "Right")
                Turtle.Angle = 90;

            else if (GraphicsWindow.LastKey == "Down")
                Turtle.Angle = 180;

            else if (GraphicsWindow.LastKey == "Left")
                Turtle.Angle = 270;
        }

    }
    
}
