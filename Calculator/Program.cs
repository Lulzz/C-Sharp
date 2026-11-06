using System;

namespace Calculator
{
        class Program
        {
                static void Main(string[] args)
                {
                    while (true)
                    {
                        Menu();
                    }
                }
                static void Menu(){

                    Console.Clear();

                    Console.WriteLine ("O que deseja fazer?");
                    Console.WriteLine ("1 - Soma");
                    Console.WriteLine ("2 - Subtração");
                    Console.WriteLine ("3 - Multiplicação");
                    Console.WriteLine ("4 - Divisão");
                    Console.WriteLine ("5 - Sair");

                    Console.WriteLine ("-------------------");
                    Console.WriteLine ("Selecione uma opção: ");

                    //o shoort é um tipo de dado que armazena numeros inteiros de -32.768 a 32.767
                    short res = short.Parse(Console.ReadLine());

                    switch(res){
                        case 1: Soma(); break;
                        case 2: Subtracao(); break;
                        case 3: Multiplicacao(); break;
                        case 4: Divisao(); break;
                        case 5: System.Environment.Exit(0); break; //vai sair do programa

                        //default: caso o usuario digitar um numero que nao esta na lista ele vai voltar para o menu
                        default: Menu(); break;
                    }
                }
                static void Soma(){   
                    Console.Clear();

                    float v1;
                    Console.WriteLine("Primeiro valor: ");
                    // o TryParse vai tentar converter oq eu digitei para float, se nao conseguir ele vai me pedir para digitar um numero valido
                    while(!float.TryParse(Console.ReadLine(), out v1))
                     {
                     Console.WriteLine("Valor invalido, digite um numero valido:");
                     }
                    //Armazenou o resultado do 1 valor read ele vai ler o valor e ja vai armazenar na variavel v1

                    Console.WriteLine("Segundo valor: ");
                    float v2 = float.Parse(Console.ReadLine());
                    
                    Console.WriteLine("");

                    //Armazenou o resultado da soma na variavel Resultado
                    float Resultado = v1+v2;
                    Console.WriteLine($"Resultado da soma: {Resultado}");// serve para mostrar o resultado da soma 

                    Console.ReadKey();// serve para esperar o usuario apertar uma tecla para continuar
                    Menu();// serve para voltar para o menu
                }
                static void Subtracao(){
                    Console.Clear();

                    float v1;
                    Console.WriteLine("Primeiro valor: ");
                    // o TryParse vai tentar converter oq eu digitei para float, se nao conseguir ele vai me pedir para digitar um numero valido
                    while(!float.TryParse(Console.ReadLine(), out v1))
                    {
                     Console.WriteLine("Valor invalido, digite um numero valido:");
                    }

                    Console.WriteLine("Segunda valor; ");//imprime o valor na tela e deixa eu escrever 
                    float v2 = float.Parse(Console.ReadLine());// vai ler oq eu digitei

                    Console.WriteLine("");
                    
                    // unica coisa que muda que esse é continha de menos
                    float Resultado = v1-v2; // dai armazena em Resultado
                    Console.WriteLine($"Resultado da subtracao: {Resultado}"); // e aqui mostra o resultado da subtração do v1 e v2 

                    Console.ReadKey();// serve para esperar o usuario apertar uma tecla para continuar
                    Menu();// serve para voltar para o menu
                }        
                static void Multiplicacao(){
                    Console.Clear();

                    float v1;
                    Console.WriteLine("Primeiro valor: ");
                    while(!float.TryParse(Console.ReadLine(), out v1))
                    {
                     Console.WriteLine("Valor invalido, digite um numero valido:");
                    }
                    {
                     Console.WriteLine("Valor invalido, digite um numero valido:");
                    }

                    Console.WriteLine("Segundo valor: ");
                    float v2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("");// seve para pular uma linha

                    float Resultado = v1*v2;
                    Console.WriteLine($"Resultado da multiplicacao: {Resultado}");

                    Console.ReadKey();// serve para esperar o usuario apertar uma tecla para continuar
                    Menu();// serve para voltar para o menu
                }
                static void Divisao(){
                    Console.Clear();

                    float v1;
                    Console.WriteLine("Primeiro valor: ");
                    while(!float.TryParse(Console.ReadLine(), out v1))
                    {
                     Console.WriteLine("Valor invalido, digite um numero valido:");
                    }

                    Console.WriteLine("Segundo valor: ");
                    float v2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    if (v2 == 0)//adicionei um if para quando tentar dividir por zero aparecer a frase a baixo 
                    {
                        Console.WriteLine("Nao é possivel dividir por zero. ");
                    }
                    else{
                    float Resultado = v1/v2;
                    Console.WriteLine($"Resultado da divisao; {Resultado}");
                    }

                    Console.ReadKey();// serve para esperar o usuario apertar uma tecla para continuar
                    Menu();// serve para voltar para o menu
                }  
        }
}