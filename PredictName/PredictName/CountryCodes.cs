namespace PredictName
{
    public class CountryCodes
    {
        public string? Id { get; set; }
        public string? Country { get; set; }

        public CountryCodes(string id, string country)
        {
            Id = id;
            Country = country;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Country: {Country}";
        }
    }
}
