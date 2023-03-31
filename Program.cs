using System;

namespace CsE10
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            //EXERCÍCIO 10
            Console.WriteLine("Calculando a duração de um jogo (Informe apenas em numeros Ex: 16  2)\n\n" +
            "HORA DE INICIO E TERMINO DO JOGO: ");
            string[] hora = Console.ReadLine().Split(' ');
            int i = int.Parse(hora[0]);
            int t = int.Parse(hora[1]);
            int duracao;
            if (i < t)
                duracao = t - i;
            else
                duracao = 24 - i + t;

            Console.WriteLine($"\nO JOGO DUROU {duracao} HORA(S)");
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}