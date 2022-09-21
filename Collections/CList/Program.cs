using System;
using System.Collections.Generic;


namespace CList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá seja muito bem vindo a nossa lista de animais em extinção");

            List<string> Animais = new List<string>();

            Animais.Add("Mico Leão Dourado");
            Animais.Add("Arara Azul");
            Animais.Add("Lobo Guara");
            Animais.Add("Pinguim-africano");

            Animais.Insert(2, "Peixe-boi-marinho ");

            Animais.Remove("Pinguim-africano");
            Animais.RemoveAt(1);

            foreach (string i in Animais)
            {
                Console.WriteLine($"Todos eles estão em estado de extinção, mas podem ser encontrados em áreas preservadas {i}");
            }


        }
    }
}