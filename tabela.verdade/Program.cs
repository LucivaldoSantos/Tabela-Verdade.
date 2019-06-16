using System;

namespace tabela.verdade
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vamos construir a tabela verdade do E e do OU com suas afirmativas.");
            Console.WriteLine("Insira a primeira afirmação:");
            string pergunta1 = Console.ReadLine();
            Console.WriteLine("Insira a segunda afirmação");
            string pergunta2 = Console.ReadLine();

            Console.WriteLine("A frase '" + pergunta1 + "' é verdadeira?");
            Console.WriteLine("Responda com True ou False:");
            string resposta1 = Console.ReadLine();

            Console.WriteLine("A frase '" + pergunta2 + "' é verdadeira?");
            Console.WriteLine("Responda com True ou False:");
            string resposta2 = Console.ReadLine();

            if (resposta1.Contains("True") && resposta2.Contains("True"))
            {
                Console.WriteLine("O resutada lógico da frase: " + pergunta1 + " e " + pergunta2 + " é: True");
            }
            else
            {
                Console.WriteLine("O resutada lógico da frase: " + pergunta1 + " e " + pergunta2 + " é: False");
            }
            if (resposta1.Contains("True") || resposta2.Contains("True"))
            {
                Console.WriteLine("O resutada lógico da frase: " + pergunta1 + " ou " + pergunta2 + " é: True");
            }
            else
            {
                Console.WriteLine("O resutada lógico da frase: " + pergunta1 + " ou " + pergunta2 + " é: False");
            }
        }
    }
}

