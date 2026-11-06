using System;
using System.Runtime;

namespace ListaDeTarefas
{
    class Program
    {      
        static List<string> tarefas = new List<string>();
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Adicionar tarefas");
            Console.WriteLine("2 - Lista de tarefas");
            Console.WriteLine("3 - Marcar como concluido");
            Console.WriteLine("4 - Remover tarefa");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:System.Environment.Exit(0); break;
                case 1: Adicionar(); break;
                case 2: Lista(); break;
                case 3: Remover(); break;
            }
        }
        static void Adicionar()
        {
            Console.Clear();
            Console.WriteLine("Adicionar;");
            string tarefa = Console.ReadLine();

            tarefas.add(tarefa);

        }
        static void Lista()
        {
            Console.Clear();
            Console.WriteLine("Listar");
            for (int i = 0; i< tarefas.Count; i++)
            {
            Console.WriteLine($"{i}- {tarefas[i]}");
            }
            Console.ReadKey();
        }
        static void Remover()
        {
            Console.WriteLine("Digite um numero da tarefa:");
            Lista();
            int index;
            int.TryParse(Console.ReadLine(), out index);
            
            if(index >=0 && index < tarefas.Count)
            {
                tarefas.RemoveAt(index);
            }

        }
    }
}