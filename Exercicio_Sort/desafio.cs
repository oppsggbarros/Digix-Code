using System;

class Desafio
{
    static void CalcularFaturamento(object[,] produtos)
    {
        for (int i = 0; i < produtos.GetLength(0); i++)
        {
            if (produtos[i, 0] != null)
            {
                int quantidade = Convert.ToInt32(produtos[i, 1]);
                double preco = Convert.ToDouble(produtos[i, 2]);
                produtos[i, 4] = quantidade * preco;
            }
        }
    }
    static Dictionary<string, (double soma, int contagem)> CalcularMediaPorCategoria(object[,] produtos, int numProdutos)
    {
        Dictionary<string, (double soma, int contagem)> categorias = new Dictionary<string, (double, int)>();

        for (int i = 0; i < numProdutos; i++)
        {
            if (produtos[i, 0] != null)
            {
                string categoria = produtos[i, 3].ToString();
                double faturamento = Convert.ToDouble(produtos[i, 4]);

                if (categorias.ContainsKey(categoria))
                {
                    categorias[categoria] = (categorias[categoria].soma + faturamento, categorias[categoria].contagem + 1);
                }
                else
                {
                    categorias[categoria] = (faturamento, 1);
                }
            }
        }

        return categorias;
    }

    static void Ordenar(object[,] produtos, int numProdutos)
    {
        for (int i = 1; i < numProdutos; i++)
        {
            object[] atual = new object[5];
            for (int k = 0; k < 5; k++)
                atual[k] = produtos[i, k];

            int j = i - 1;

            while (j >= 0 &&
                   (Convert.ToDouble(produtos[j, 4]) < Convert.ToDouble(atual[4]) ||
                   (Convert.ToDouble(produtos[j, 4]) == Convert.ToDouble(atual[4]) &&
                    string.Compare(produtos[j, 0].ToString(), atual[0].ToString()) > 0)))
            {
                for (int k = 0; k < 5; k++)
                    produtos[j + 1, k] = produtos[j, k];
                j--;
            }

            for (int k = 0; k < 5; k++)
                produtos[j + 1, k] = atual[k];
        }
    }

    static void Main()
    {
        object[,] produtos = new object[40, 5];



        produtos[0, 0] = "Produto 1";
        produtos[0, 1] = 10;
        produtos[0, 2] = 20.5;
        produtos[0, 3] = "Categoria A";

        produtos[1, 0] = "Produto 2";
        produtos[1, 1] = 15;
        produtos[1, 2] = 35.7;
        produtos[1, 3] = "Categoria B";

        produtos[2, 0] = "Produto 3";
        produtos[2, 1] = 5;
        produtos[2, 2] = 50.0;
        produtos[2, 3] = "Categoria C";

        produtos[3, 0] = "Produto 4";
        produtos[3, 1] = 20;
        produtos[3, 2] = 15.0;
        produtos[3, 3] = "Categoria D";

        produtos[4, 0] = "Produto 5";
        produtos[4, 1] = 12;
        produtos[4, 2] = 18.0;
        produtos[4, 3] = "Categoria A";

        produtos[5, 0] = "Produto 6";
        produtos[5, 1] = 30;
        produtos[5, 2] = 12.0;
        produtos[5, 3] = "Categoria B";

        produtos[6, 0] = "Produto 7";
        produtos[6, 1] = 8;
        produtos[6, 2] = 45.0;
        produtos[6, 3] = "Categoria C";

        produtos[7, 0] = "Produto 8";
        produtos[7, 1] = 25;
        produtos[7, 2] = 22.0;
        produtos[7, 3] = "Categoria D";

        produtos[8, 0] = "Produto 9";
        produtos[8, 1] = 9;
        produtos[8, 2] = 19.0;
        produtos[8, 3] = "Categoria A";

        produtos[9, 0] = "Produto 10";
        produtos[9, 1] = 18;
        produtos[9, 2] = 20.0;
        produtos[9, 3] = "Categoria B";

        produtos[10, 0] = "Produto 11";
        produtos[10, 1] = 6;
        produtos[10, 2] = 55.0;
        produtos[10, 3] = "Categoria C";

        produtos[11, 0] = "Produto 12";
        produtos[11, 1] = 17;
        produtos[11, 2] = 16.0;
        produtos[11, 3] = "Categoria D";

        produtos[12, 0] = "Produto 13";
        produtos[12, 1] = 14;
        produtos[12, 2] = 25.0;
        produtos[12, 3] = "Categoria A";

        produtos[13, 0] = "Produto 14";
        produtos[13, 1] = 28;
        produtos[13, 2] = 12.5;
        produtos[13, 3] = "Categoria B";

        produtos[14, 0] = "Produto 15";
        produtos[14, 1] = 11;
        produtos[14, 2] = 40.0;
        produtos[14, 3] = "Categoria C";

        produtos[15, 0] = "Produto 16";
        produtos[15, 1] = 22;
        produtos[15, 2] = 18.5;
        produtos[15, 3] = "Categoria D";

        produtos[16, 0] = "Produto 17";
        produtos[16, 1] = 13;
        produtos[16, 2] = 30.0;
        produtos[16, 3] = "Categoria A";

        produtos[17, 0] = "Produto 18";
        produtos[17, 1] = 19;
        produtos[17, 2] = 14.0;
        produtos[17, 3] = "Categoria B";

        produtos[18, 0] = "Produto 19";
        produtos[18, 1] = 7;
        produtos[18, 2] = 60.0;
        produtos[18, 3] = "Categoria C";

        produtos[19, 0] = "Produto 20";
        produtos[19, 1] = 24;
        produtos[19, 2] = 10.5;
        produtos[19, 3] = "Categoria D";

        produtos[20, 0] = "Produto 21";
        produtos[20, 1] = 16;
        produtos[20, 2] = 29.5;
        produtos[20, 3] = "Categoria A";

        produtos[21, 0] = "Produto 22";
        produtos[21, 1] = 12;
        produtos[21, 2] = 18.0;
        produtos[21, 3] = "Categoria B";

        produtos[22, 0] = "Produto 23";
        produtos[22, 1] = 9;
        produtos[22, 2] = 50.0;
        produtos[22, 3] = "Categoria C";

        produtos[23, 0] = "Produto 24";
        produtos[23, 1] = 21;
        produtos[23, 2] = 17.5;
        produtos[23, 3] = "Categoria D";

        produtos[24, 0] = "Produto 25";
        produtos[24, 1] = 13;
        produtos[24, 2] = 23.0;
        produtos[24, 3] = "Categoria A";

        produtos[25, 0] = "Produto 26";
        produtos[25, 1] = 26;
        produtos[25, 2] = 15.0;
        produtos[25, 3] = "Categoria B";

        produtos[26, 0] = "Produto 27";
        produtos[26, 1] = 8;
        produtos[26, 2] = 47.0;
        produtos[26, 3] = "Categoria C";

        produtos[27, 0] = "Produto 28";
        produtos[27, 1] = 19;
        produtos[27, 2] = 20.0;
        produtos[27, 3] = "Categoria D";

        produtos[28, 0] = "Produto 29";
        produtos[28, 1] = 14;
        produtos[28, 2] = 22.0;
        produtos[28, 3] = "Categoria A";

        produtos[29, 0] = "Produto 30";
        produtos[29, 1] = 20;
        produtos[29, 2] = 13.0;
        produtos[29, 3] = "Categoria B";

        produtos[30, 0] = "Produto 31";
        produtos[30, 1] = 10;
        produtos[30, 2] = 55.0;
        produtos[30, 3] = "Categoria C";

        produtos[31, 0] = "Produto 32";
        produtos[31, 1] = 23;
        produtos[31, 2] = 14.5;
        produtos[31, 3] = "Categoria D";

        produtos[32, 0] = "Produto 33";
        produtos[32, 1] = 12;
        produtos[32, 2] = 31.0;
        produtos[32, 3] = "Categoria A";

        produtos[33, 0] = "Produto 34";
        produtos[33, 1] = 17;
        produtos[33, 2] = 16.0;
        produtos[33, 3] = "Categoria B";

        produtos[34, 0] = "Produto 35";
        produtos[34, 1] = 6;
        produtos[34, 2] = 70.0;
        produtos[34, 3] = "Categoria C";

        produtos[35, 0] = "Produto 36";
        produtos[35, 1] = 25;
        produtos[35, 2] = 19.0;
        produtos[35, 3] = "Categoria D";

        produtos[36, 0] = "Produto 37";
        produtos[36, 1] = 14;
        produtos[36, 2] = 28.0;
        produtos[36, 3] = "Categoria A";

        produtos[37, 0] = "Produto 38";
        produtos[37, 1] = 27;
        produtos[37, 2] = 12.0;
        produtos[37, 3] = "Categoria B";

        produtos[38, 0] = "Produto 39";
        produtos[38, 1] = 6;
        produtos[38, 2] = 78.0;
        produtos[38, 3] = "Categoria C";

        produtos[39, 0] = "Produto 40";
        produtos[39, 1] = 25;
        produtos[39, 2] = 12.0;
        produtos[39, 3] = "Categoria D";




        CalcularFaturamento(produtos);


        Ordenar(produtos, 40);


        Console.WriteLine("Produtos Ordenados:");
        for (int i = 0; i < 40; i++)
        {
            if (produtos[i, 0] != null)
            {
                Console.WriteLine($"{produtos[i, 0]}, " +
                                  $"Qtde: {produtos[i, 1]}, " +
                                  $"Preço: {produtos[i, 2]}, " +
                                  $"Categoria: {produtos[i, 3]}, " +
                                  $"Faturamento Total: {produtos[i, 4]}");
            }
        }
        System.Console.WriteLine();
        double MediaTotal = 0;
        for (int i = 0; i < produtos.GetLength(0); i++)
        {
            if (produtos[i, 0] != null)
            {
                MediaTotal += Convert.ToDouble(produtos[i, 4]);
            }
        }
        System.Console.WriteLine($"Faturamento total da Loja: {MediaTotal}");

        
        var mediasPorCategoria = CalcularMediaPorCategoria(produtos, 40);
        Console.WriteLine("\nMédia de Faturamento por Categoria:");
        foreach (var categoria in mediasPorCategoria)
        {
            double media = categoria.Value.soma / categoria.Value.contagem;
            Console.WriteLine($"Categoria: {categoria.Key}, Média de Faturamento: {media:F2}");
        }
        System.Console.WriteLine();
        
    }
}
