namespace ExoMiner.Services.Queries.ExoplanetQueries;

internal partial class ExoplanetQueries
{
    private readonly CsvReader reader = new CsvReader("PS_2026.01.30_10.53.02.csv");
    private readonly AddHeader h = new AddHeader();
}