using System;

class Program6
{
    
    static int SomaVetor(int[] vetor, int tamanho)
    {
        
        if (tamanho == 0)
            return 0;
        else
            
            return vetor[tamanho - 1] + SomaVetor(vetor, tamanho - 1);
    }

    static void Man()
    {
        
        Console.Write("Digite o número de elementos no vetor: ");
        int n = Convert.ToInt32(Console.ReadLine());

        
        int[] vetor = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o elemento {i + 1}: ");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        int soma = SomaVetor(vetor, n);
        Console.WriteLine(soma);
    }
}
