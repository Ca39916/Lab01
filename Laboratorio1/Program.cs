using System; 

namespace Laboratorio1
{ 
    public class Program
    {
        public class Program2
        {

        }
        static void Main(string[] args)
        {  
            System.Console.WriteLine("Hello World!");
            System.Console.ReadLine();

            Console.WriteLine("------ Exercicio 01 ------");
            Console.WriteLine("O que acontece se você remover o comando using System;?");
            Console.WriteLine("Sem o System as classes e os metodos não funcionam");
            Console.WriteLine("");
            Console.WriteLine("O que acontece se você também remover a referência System na chamada System.Console.WriteLine?");
            Console.WriteLine("A classe Console e metodo WriteLine continua ecessiveis");

            Console.WriteLine("------ Exercicio 02 ------");
            Console.WriteLine("Mova o método Main para fora da classe Program. (Isto é, remova as palavras class Program e chaves associadas). O quê acontece?");
            Console.WriteLine("Um namespace não pode conter diretamente membros, como campos, métodos ou instruções");
            Console.WriteLine("");

            Console.WriteLine("------ Exercicio 03 ------");
            Console.WriteLine("O que acontece se você clonar a classe Program (copie, cole, e renomeie para Program2)?");
            Console.WriteLine("Nada compila e executa normalmente");
            Console.WriteLine("");

            Console.WriteLine("------ Exercicio 04 ------");
            Console.ReadKey();
        }

    }
 
    
}
