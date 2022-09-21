using System;
using System.Collections.Generic;



namespace CQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------FILA------------------");

            Queue<Cliente> Pessoa = new Queue<Cliente>();

            Pessoa.Enqueue(new Cliente("Tabata Silva", "79"));
            Pessoa.Enqueue(new Cliente("João Marcos", "38"));
            Pessoa.Enqueue(new Cliente("Cristiane Salinas", "45"));
            Pessoa.Enqueue(new Cliente("Mirelly Juana", "21"));
            Pessoa.Enqueue(new Cliente("Garcia Pereira", "60"));
            Pessoa.Enqueue(new Cliente("Fábio Moreira", "55"));

            Console.WriteLine($"\n O primeiro cliente da fila é: {Pessoa.Dequeue()}");

            Pessoa.Peek();

           Console.WriteLine("\n Cadastro: ");

            foreach (var item in Pessoa)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine($"Numero de clientes na fila: {Pessoa.Count}");

        }

        public class Cliente
        {
            public string Nome { get; set; }

            public string Idade { get; set; }

            public Cliente(string nome, string idade)
            {
                Nome = nome;
                Idade = idade;
            }


            public override string ToString()
            {
                return $" > {Nome}, {Idade} anos.";
            }
        }
    }
}