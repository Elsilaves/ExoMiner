using System.Globalization;

namespace ExoMiner;

internal class Exoplanet
{
    // =====================
    // BASIC IDENTIFICATION
    // =====================
    public string? PlanetName { get; private set; }      // pl_name
    public string? HostStar { get; private set; }        // hostname

    // =====================
    // SYSTEM STRUCTURE
    // =====================
    public int? NumberOfStars { get; private set; }      // sy_snum
    public int? NumberOfPlanets { get; private set; }    // sy_pnum

    // =====================
    // DISCOVERY
    // =====================
    public string? DiscoveryMethod { get; private set; } // discoverymethod
    public int? DiscoveryYear { get; private set; }     // disc_year

    // =====================
    // ORBITAL PARAMETERS
    // =====================
    public double? OrbitalPeriodDays { get; private set; } // pl_orbper
    public double? OrbitRadiusAu { get; private set; }     // pl_orbsmax
    public double? Eccentricity { get; private set; }      // pl_orbeccen

    // =====================
    // PLANET PHYSICAL PROPERTIES
    // =====================
    public double? RadiusEarth { get; private set; }       // pl_rade
    public double? MassEarth { get; private set; }         // pl_bmasse
    public double? TemperatureK { get; private set; }      // pl_eqt

    // =====================
    // DISTANCE FROM EARTH
    // =====================
    public double? DistanceParsec { get; private set; } // sy_dist

    // =====================
    // HOST STAR PROPERTIES
    // =====================
    public double? StarTemperatureK { get; private set; }  // st_teff
    public double? StarMassSolar { get; private set; }     // st_mass
    public double? StarRadiusSolar { get; private set; }   // st_rad
    
    
    private static int? ParseNullableInt(string s)
        => int.TryParse(s, out var v) ? v : null;

    private static double? ParseNullableDouble(string s)
        => double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var v) ? v : null;
    
    //Constructor
    public Exoplanet(string[] data)
    {
        PlanetName = data[0];
        HostStar = data[1];

        NumberOfStars = ParseNullableInt(data[3]);      // sy_snum
        NumberOfPlanets = ParseNullableInt(data[4]);    // sy_pnum

        DiscoveryMethod = data[5];
        DiscoveryYear = ParseNullableInt(data[6]);      // disc_year

        OrbitalPeriodDays = ParseNullableDouble(data[11]); // pl_orbper
        OrbitRadiusAu = ParseNullableDouble(data[15]);     // pl_orbsmax

        RadiusEarth = ParseNullableDouble(data[19]);       // pl_rade
        MassEarth = ParseNullableDouble(data[27]);         // pl_bmasse
        Eccentricity = ParseNullableDouble(data[37]);      // pl_orbeccen
        TemperatureK = ParseNullableDouble(data[45]);      // pl_eqt

        StarTemperatureK = ParseNullableDouble(data[49]);  // st_teff
        StarRadiusSolar = ParseNullableDouble(data[53]);   // st_rad
        StarMassSolar = ParseNullableDouble(data[57]);     // st_mass

        DistanceParsec = ParseNullableDouble(data[67]);    // sy_dist (pc)
    }

    public override string ToString()
    {
        return
            $"{PlanetName,-20} " +
            $"{(RadiusEarth?.ToString("0.##", CultureInfo.InvariantCulture) ?? "-"),12} " +
            $"{(MassEarth?.ToString("0.##", CultureInfo.InvariantCulture) ?? "-"),12} " +
            $"{(TemperatureK?.ToString("0", CultureInfo.InvariantCulture) ?? "-"),12}     " +
            $"{HostStar,-22}";
    }

}