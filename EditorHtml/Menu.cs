using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            DrawScreen();
        }

        public static void DrawScreen()
        {

            DrawLine();

            for (int lines = 0; lines <= 5; lines++)
            {
                Console.Write("|");

                DrawLineSpace();

                Console.Write("|");
                Console.Write("\n");
            }

            DrawLine();
        }

        public static void DrawLine()
        {
            Console.Write("+");
            for (int i = 0; i <= 40; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void DrawLineSpace()
        {
            for (int i = 0; i <= 40; i++)
            {
                Console.Write(" ");
            }
        }


    }
}