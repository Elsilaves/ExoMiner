namespace ExoMiner.Services.Queries.ExoplanetQueries;
using Services;

internal partial class ExoplanetQueries
{
    public void EarthSizedPlanets()
    {
        h.Header();

        var earthSized = reader.Exoplanets
            .Where(p => p.RadiusEarth is >= 0.8 and <= 1.2)
            .Take(10);

        foreach (var p in earthSized)
            Console.WriteLine(p);
    }
}
