using System;
using System.Collections.Generic;
using static CQueue.Program;

namespace CDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Dicionário!");

            Dictionary<string, Pessoa> dic = new Dictionary<string, Pessoa>();

            dic.Add("Tuti", new Pessoa("Maju", "São Paulo", 35));
            dic.Add("Jepam", new Pessoa("Jean", "Macedonia", 20));
            dic.Add("Cupim", new Pessoa("Felipe", "Coimbra", 30));

            foreach(KeyValuePair<string, Pessoa> kvp in dic)
            {
                Console.WriteLine($"Chave = {kvp.Key} | Valor = {kvp.Value}");
            }

        }
    }
}
