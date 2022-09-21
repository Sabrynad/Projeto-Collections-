using System;
using System.Collections.Generic;


namespace CList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ol� seja muito bem vindo a nossa lista de animais em extin��o");

            List<string> Animais = new List<string>();

            Animais.Add("Mico Le�o Dourado");
            Animais.Add("Arara Azul");
            Animais.Add("Lobo Guara");
            Animais.Add("Pinguim-africano");

            Animais.Insert(2, "Peixe-boi-marinho ");

            Animais.Remove("Pinguim-africano");
            Animais.RemoveAt(1);

            foreach (string i in Animais)
            {
                Console.WriteLine($"Todos eles est�o em estado de extin��o, mas podem ser encontrados em �reas preservadas {i}");
            }


        }
    }
}