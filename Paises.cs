using System.Collections.Generic;


namespace Pr
{
    public partial class Paises
    {
        public Name Name { get; set; }
        public string[] Tld { get; set; }
        public string Cca2 { get; set; }
        public string Ccn3 { get; set; }
        public string Cca3 { get; set; }
        public string Cioc { get; set; }
        public bool? Independent { get; set; }
        public Status Status { get; set; }
        public bool UnMember { get; set; }
        public Currencies Currencies { get; set; }
        public Idd Idd { get; set; }
        public string[] Capital { get; set; }
        public string[] AltSpellings { get; set; }
        public Region Region { get; set; }
        public string Subregion { get; set; }
        public Dictionary<string, string> Languages { get; set; }
        public Dictionary<string, Translation> Translations { get; set; }
        public double[] Latlng { get; set; }
        public bool Landlocked { get; set; }
        public string[] Borders { get; set; }
        public double Area { get; set; }
        public Demonyms Demonyms { get; set; }
        public string Flag { get; set; }
        public Maps Maps { get; set; }
        public long Population { get; set; }
        public Dictionary<string, double> Gini { get; set; }
        public string Fifa { get; set; }
        public Car Car { get; set; }
        public string[] Timezones { get; set; }
        public Continent[] Continents { get; set; }
        public CoatOfArms Flags { get; set; }
        public CoatOfArms CoatOfArms { get; set; }
        public StartOfWeek StartOfWeek { get; set; }
        public CapitalInfo CapitalInfo { get; set; }
        public PostalCode PostalCode { get; set; }
    }
}

