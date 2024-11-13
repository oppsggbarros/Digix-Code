using System;
class Progaram
{
    static void oOrdenar(int[] vetor)
    {
        int aux, j;
        for (int i = 0; i < vetor.Length - 1; i++)
        {
            aux = vetor[i];
            j = i - 1;
            while (j >= 0 && vetor[j] > aux)
            {
                vetor[j+1] = vetor[j];
                j--;

            }
            vetor [j+1] = aux;

        }
    }
    static void Imprimir(int[] vetor)
    {

    }
}