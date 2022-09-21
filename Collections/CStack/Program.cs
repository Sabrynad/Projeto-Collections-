using System;
using System.Collections.Generic;
using static System.Console;

namespace CStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá bom vindo a minha pilha de livros.\n");

            Stack<Livro> stack = new Stack<Livro>();

            stack.Push(new Livro("Jogos Vorazes I", 455));
            stack.Push(new Livro("Jogos Vorazes II", 96));
            stack.Push(new Livro("Jogos Vorazes III", 122));

            Console.WriteLine($"{stack.Peek()} é o primeiro livro da pilha.\n");

            Console.WriteLine($"Estou removendo o {stack.Pop().ToString()} da pilha.\n");

            Console.WriteLine($"Livros na pilha: {stack.Count}\n");

            foreach(Livro livro in stack)
            {
               Console.WriteLine($"Possuimos os seguintes livros: {livro.ToString()}");
            }
        }

        internal class Livro
        {
            string Titulo { get; set; }
            int Paginas { get; set; }

            public Livro(string titulo, int paginas)
            {
                Titulo = titulo;
                Paginas = paginas;
            }
            public override string ToString()
            {
                return $"{Titulo}";
            }
            
        }
    }
}