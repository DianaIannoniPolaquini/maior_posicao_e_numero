using System;

namespace MAIOR_NUMERO_POSICAO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] A;
            Console.WriteLine("Quantidade de números: ");
            int x = int.Parse(Console.ReadLine());
            A = new double[x];

            string[] valores = Console.ReadLine().Split(' ');
            for (int i = 0; i < x; i++)
            {
                A[i] = double.Parse(valores[i]);
            }

            double maior = A[0];
            int PosMaior = 0;

            for (int i = 0;i < x; i++)
            {
                if (A[i] > maior)
                {
                    maior = A[i];
                    PosMaior = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine(maior);
            Console.WriteLine(PosMaior);
        }
    }
}
