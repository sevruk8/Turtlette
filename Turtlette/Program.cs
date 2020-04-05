using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtlette
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Задача 1
            //Turtle.Speed = 9;
            //int i = 0;
            //while (i < 6)
            //{
            //    Turtle.Move(100);
            //    Turtle.Turn(60);
            //    i++;
            //}

            // Задача 2
            /*Turtle.Speed = 9;
            int i = 0;
            int j = 0;
          
            while (j < 3)
                {
                   
                Turtle.Move(30);
                Turtle.Turn(90);
                Turtle.Move(30);
                Turtle.Turn(90);
                Turtle.Move(30);
                Turtle.Turn(-90);

                if (j != 3)
                {

                    
                    Turtle.Move(30);
                    Turtle.Turn(-90);
                }

                j++;
            }
            */

            // Задача 3
            // Торт
            Turtle.Speed = 9;
            Turtle.X = 180;
            Turtle.Y = 220;
            WriteT(60);
            Turtle.X = 200;
            Turtle.Y = 220;
            WriteO(30);
            Turtle.X = 240;
            Turtle.Y = 280;
            WriteP(30);
            Turtle.X = 280;
            Turtle.Y = 220;
            WriteT(30);



        }

        private static void WriteT(int size)
        {
            //Буква Т
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.TurnLeft();
            Turtle.Move(size / 3);
            Turtle.Turn(180);
            Turtle.Move(size / 3 * 2);
        }

        private static void WriteO(int size)
        {
            //Буква О
            Turtle.Angle = 0;
            for(int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
        }

        private static void WriteP(int size)
        { //Буква P
            Turtle.Angle = 0;
            Turtle.Move(60);
            WriteO(size/2);

        }

    }
}
