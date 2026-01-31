namespace ExoMiner.Services;

internal class CsvReader
{
    private List<Exoplanet> exoplanets;
    public IReadOnlyList<Exoplanet> Exoplanets => exoplanets;


    public CsvReader(string fileName)
    {
        exoplanets = new List<Exoplanet>();
        
        var basePath = AppContext.BaseDirectory;
        var projectRoot = Path.GetFullPath(Path.Combine(basePath, "..", "..", ".."));
        var fullPath = Path.Combine(projectRoot, "Data", "csv", fileName);
        
        try
        {
            
            StreamReader reader = new StreamReader(fullPath);
            
            // Skip first line
            reader?.ReadLine();
           
            
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                if (line.StartsWith("#")) continue;
                var data = line.Split(',');
                if (data.Length > 0 && data[0] == "pl_name")
                    continue;
                if (data.Length < 16)
                    continue;
                
                exoplanets.Add(new Exoplanet(data));
            }
                
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error reading CSV: {fullPath}");
            Console.WriteLine(e.Message);
            throw;
        }
    }
}