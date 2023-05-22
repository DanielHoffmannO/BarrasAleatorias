using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int[] tamanhos = GerarBarrasUnicas(37);

        Console.WriteLine("Barras geradas aleatoriamente:");
        MostrarBarras(tamanhos);

        while (true)
        {
            Console.WriteLine("\nOrganizando barras...");
            OrganizarBarras(tamanhos);

            Thread.Sleep(500);

            Console.Clear();

            EmbaralharBarras(tamanhos);

            Console.WriteLine("\nBarras embaralhadas:");
            MostrarBarras(tamanhos);
        }
    }

    static int[] GerarBarrasUnicas(int quantidade)
    {
        int[] tamanhos = new int[quantidade];
        Random random = new Random();

        for (int i = 0; i < quantidade; i++)
        {
            int tamanho;
            bool repetido;

            do
            {
                tamanho = random.Next(1, 38);
                repetido = false;

                for (int j = 0; j < i; j++)
                {
                    if (tamanhos[j] == tamanho)
                    {
                        repetido = true;
                        break;
                    }
                }
            } while (repetido);

            tamanhos[i] = tamanho;
        }

        return tamanhos;
    }

    static void MostrarBarras(int[] tamanhos)
    {
        int maiorTamanho = tamanhos[0];
        for (int i = 1; i < tamanhos.Length; i++)
        {
            if (tamanhos[i] > maiorTamanho)
                maiorTamanho = tamanhos[i];
        }

        for (int i = maiorTamanho; i > 0; i--)
        {
            for (int j = 0; j < tamanhos.Length; j++)
            {
                if (tamanhos[j] >= i)
                    Console.Write("| ");
                else
                    Console.Write("  ");
            }
            Console.WriteLine();
        }
    }

    static void OrganizarBarras(int[] tamanhos)
    {
        bool ordenado = false;

        while (!ordenado)
        {
            ordenado = true;

            for (int i = 0; i < tamanhos.Length - 1; i++)
            {
                if (tamanhos[i] > tamanhos[i + 1])
                {
                    ordenado = false;

                    Console.Clear();

                    Console.WriteLine();
                    MostrarBarras(tamanhos);
                    Console.WriteLine();

                    Thread.Sleep(50);

                    int temp = tamanhos[i];
                    tamanhos[i] = tamanhos[i + 1];
                    tamanhos[i + 1] = temp;
                }
            }
        }

        Console.Clear();
        Console.WriteLine();
        MostrarBarras(tamanhos);
    }

    static void EmbaralharBarras(int[] tamanhos)
    {
        Random random = new Random();

        for (int i = 0; i < tamanhos.Length; i++)
        {
            int randomIndex = random.Next(i, tamanhos.Length);
            int temp = tamanhos[i];
            tamanhos[i] = tamanhos[randomIndex];
            tamanhos[randomIndex] = temp;
        }
    }
}
