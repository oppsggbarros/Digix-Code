using System;
using System.IO;
using System.Linq;

class Program
{
    static void Min(string[] args)
    {
        Console.Write("Enter the path to the source CSV file: ");
        string filePath = Console.ReadLine();

        try
        {
            
            if (!File.Exists(filePath))
            {
                Console.WriteLine("The specified file does not exist.");
                return;
            }

            
            string baseDir = Path.GetDirectoryName(filePath);
            string outputDir = Path.Combine(baseDir, "out");
            string outputFile = Path.Combine(outputDir, "summary.csv");

            
            Directory.CreateDirectory(outputDir);

            
            var lines = File.ReadAllLines(filePath);
            var processedLines = lines.Select(line =>
            {
                var parts = line.Split(',');
                string name = parts[0];
                double unitPrice = double.Parse(parts[1]);
                int quantity = int.Parse(parts[2]);
                double totalValue = unitPrice * quantity;
                return $"{name}, {totalValue}";
            });

            
            File.WriteAllLines(outputFile, processedLines);

            Console.WriteLine($"Summary file created at: {outputFile}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Data in the source file is not valid.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("The source file is not properly formatted.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
