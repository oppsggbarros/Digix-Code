using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Aula28_manipulacaoJSON
{
    public class ConsumirJSONparatxt
    {
        static async Task Main(string[] args)
        {
            string url = "https://raw.githubusercontent.com/manami-project/anime-offline-database/master/anime-offline-database-minified.json";
            string nomeArquivo = "animes.txt";
            try
            {
                using (HttpClient cliente = new HttpClient())
                {
                    var response = await cliente.GetAsync(url);
                    var responseString = await response.Content.ReadAsStringAsync();
                
                using (JsonDocument document = JsonDocument.Parse(responseString))
                {
                    var animes = document.RootElement.GetProperty("data");

                    SalvarEmTxt(animes, nomeArquivo);
                }
                System.Console.WriteLine("Informações salvas com sucesso!");
            }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Erro ao consumir o arquivo JSON: " + ex.Message);
            }
        }
        static void SalvarEmTxt(JsonElement animes, string nomeArquivo)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(nomeArquivo))
                {
                    foreach (var anime in animes.EnumerateArray())
                    {
                        string title = anime.GetProperty("title").GetString() ?? "Sem título";
                        string type = anime.GetProperty("type").GetString() ?? "Sem tipo";
                        // string episodes = anime.GetProperty("episodes").GetString() ?? "Sem episódios";
                        string status = anime.GetProperty("status").GetString() ?? "Sem status";
                    
                        string season = "N/A";
                        int year = 0;

                        // if (animes.TryGetProperty("animeSeason", out JsonElement seasonElement))
                        // {
                        //     season = animeSeason.TryGetProperty("season").GetString() ?? "N/A";

                        // }
                        sw.WriteLine($"Titulo: {title}");
                        sw.WriteLine($"Tipo: {type}");
                        // sw.WriteLine($"Episódios: {episodes}");
                        sw.WriteLine($"Status: {status}");
                        sw.WriteLine($"Temporada: {season}");
                        sw.WriteLine($"Ano: {year}");
                        sw.WriteLine();

                    }
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}