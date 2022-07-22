using System;
using System.Collections;
using System.Collections.Generic;

namespace CQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Fila");

            Queue<Pessoa> pessoas = new Queue<Pessoa>();

            pessoas.Enqueue(new Pessoa("Jesus", "Las Vegas", 33));
            pessoas.Enqueue(new Pessoa("Israel", "Jerusalém", 45));
            pessoas.Enqueue(new Pessoa("Jesus", "Amsterdan", 25));

            Console.WriteLine($"O primeiro da fila é: {pessoas.Dequeue()}");

            pessoas.Peek();

            Console.WriteLine($"Pessoas na fila: {pessoas.Count}");

            foreach(Pessoa pessoa in pessoas){
                Console.WriteLine(pessoas.ToString());
            }

        }

        public class Pessoa
        {
            public string Nome { get; set; }
            public string Cidade { get; set; }
            public int Idade { get; set; }

            public Pessoa(string nome, string cidade, int idade)
            {
                Nome = nome;
                Cidade = cidade;
                Idade = idade;
            }

            public override string ToString()
            {
                return $"Nome: {Nome} | Cidade: {Cidade} | Idade: {Idade}";
            }


        }

    }
}
