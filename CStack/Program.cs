using System;
using System.Collections.Generic;
using static CQueue.Program;

namespace CStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Pilha");

            Stack<Pessoa> pilhaPessoas = new Stack<Pessoa>();

            pilhaPessoas.Push(new Pessoa("Fabio", "Bruxelas", 36));
            pilhaPessoas.Push(new Pessoa("Amanda", "Rio", 49));
            pilhaPessoas.Push(new Pessoa("Thaina", "Barcelona", 12));
            pilhaPessoas.Push(new Pessoa("Gabriel", "Tokio", 30));

            Console.WriteLine($"Quantidade de pessoas: {pilhaPessoas.Count}");

            Console.WriteLine($"Primeira pessoa do topo: {pilhaPessoas.Peek()}");

            pilhaPessoas.Pop();

            Console.WriteLine($"Primeira pessoa do topo: {pilhaPessoas.Peek()}");

            foreach (Pessoa pessoa in pilhaPessoas)
            {
                Console.WriteLine($"{pessoa.ToString()}");
            }
        }
    }
}
