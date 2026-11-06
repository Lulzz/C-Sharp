using System;

namespace SistemaLogin
{
    static class Program
    {
        class Usuario
        {
            public string Nome;
            public string Senha;
        }
        static List<Usuario> usuarios = new List<Usuario>();

        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();            
            Console.WriteLine("Sistema de login");
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Logar");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Digite a opção desejada: ");

            if(!short.TryParse(Console.ReadLine(), out short res))
            {
                Console.WriteLine("Opcao invalida, digite um numero valido:");
                Menu();
                return;
            }

            switch (res)
            {
                case 1: CadastrarUsuario(); break;
                case 2: Logar(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void CadastrarUsuario()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de usuario");

            Console.WriteLine("Difite o nome do usuario: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Digite a senha do usuario:");
            String senha = Console.ReadLine();

            Usuario novoUsuario = new Usuario();
            novoUsuario.Nome = nome;
            novoUsuario.Senha = senha;

            usuarios.Add(novoUsuario);
            Console.WriteLine("Usuario cadastrado com sucesso!");
            Console.ReadLine();
            Menu();


        }
        static void Logar()
        {
            Console.Clear();
            Console.WriteLine("Login");

            Console.WriteLine("Login: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Senha:");
            String senha = Console.ReadLine();   
            
            bool encontrado = false;

            foreach (Usuario u in usuarios)
            {
                if (u.Nome == nome && u.Senha == senha)
                {
                    encontrado = true;
                    break;
                }
            }
            if (encontrado)
            {
                Console.WriteLine("Login realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Usuario ou senha invalidos!");
            }
            Console.ReadLine();
            Menu();
        }
    }

}
