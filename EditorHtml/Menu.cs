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
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {

            DrawLine();

            for (int lines = 0; lines <= 10; lines++)
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

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 1);
            Console.Write("Editor HTML");
            Console.SetCursorPosition(3, 2);
            Console.Write("=======================================");
            Console.SetCursorPosition(3, 3);
            Console.Write("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 5);
            Console.Write("1 - Novo arquivo");
            Console.SetCursorPosition(3, 6);
            Console.Write("2 - Abrir arquivo");
            Console.SetCursorPosition(3, 7);
            Console.Write("0 - Sair");
            Console.SetCursorPosition(3, 9);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("NewFile");
                    break;
                case 2:
                    Console.WriteLine("OpenFile");
                    break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }
                    break;
                default:
                    Console.WriteLine("Valor inválido!");
                    break;
            }
        }
    }
}