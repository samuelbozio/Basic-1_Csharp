using System;

namespace PrimeirProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite quantos alunos quer cadastrar: ");
            int quantAlunos = Int32.Parse(Console.ReadLine());
            string[] nomes = new string[quantAlunos];


           for (int i = 1; i <= nomes.Length; i++)
            {
                Console.WriteLine("Nome do aluno: " + i);
                nomes[i] = Console.ReadLine();
            }




        }


    }


}


