using System;
using System.IO;
using System.Text;

namespace EditorHtml
{
    public class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("----------------------------------------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Deseja salvar este arquivo? (S/N)");

            var response = Console.ReadLine();
            if (response.ToLower() == "s")
            {
                Save(file.ToString());
            }

            Viewer.Show(file.ToString());
        }

        public static void Save(string content)
        {
            Console.WriteLine("Digite o nome do arquivo: ");
            var fileName = Console.ReadLine();

            try
            {
                File.WriteAllText(fileName, content);
                Console.WriteLine($"Arquivo '{fileName}' salvo com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar o arquivo: {ex.Message}");
            }
        }
    }
}
