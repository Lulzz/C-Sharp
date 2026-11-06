using System;
using System.Xml.Serialization;

namespace TextEditor
{
    class Program
    {
        static void Main(String[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que voce deseja ");
            Console.WriteLine("1 - Abrir arquivo ");
            Console.WriteLine("2 - Criar novo arquivo ");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:System.Environment.Exit(0); break;
                case 1: Abrir();break;
                case 2: Editar();break;
                default: Menu(); break;
            }
        }
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            Console.WriteLine("----------------------");
            String patch = Console.ReadLine();    

            using( var file = new StreamReader(patch))
            {
                string text = file.ReadToEnd();
                Console.Write(text);
            }        
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto a baixo (ESC para sair)");
            Console.WriteLine("-----------------------");
            String text = null;

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }
        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"foi salvo com sucesso {path}");
            Console.ReadLine();
            Menu();
        }
    }
}