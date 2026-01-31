namespace ExoMiner.Services.Queries.ExoplanetQueries;

internal partial class ExoplanetQueries
{
    public void HottestPlanets()
    {
        h.Header();

        var hottest = reader.Exoplanets
            .Where(p => p.TemperatureK.HasValue)
            .OrderByDescending(p => p.TemperatureK)
            .Take(10);

        foreach (var p in hottest)
            Console.WriteLine(p);
    }
}