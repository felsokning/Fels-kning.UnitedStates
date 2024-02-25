namespace Felsökning.UnitedStates.Louisiana.NewOrleans
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Flight"/> class,
    ///     which is used to return data from the MSY API.
    /// </summary>
    public class Flight
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("type1")]
        public DirectionType Type1 { get; set; }

        [JsonPropertyName("type2")]
        public string Type2 { get; set; } = string.Empty;

        [JsonPropertyName("airline")]
        public string Airline { get; set; } = string.Empty;

        [JsonPropertyName("flight_number")]
        public string FlightNumber { get; set; } = string.Empty;

        [JsonPropertyName("bags")]
        [ExcludeFromCodeCoverage] // Can be an empty return.
        public string Bags { get; set; } = string.Empty;

        [JsonPropertyName("city")]
        public string City { get; set; } = string.Empty;

        [JsonPropertyName("date")]
        public string Date { get; set; } = string.Empty;

        [JsonPropertyName("scheduled_time")]
        public string ScheduledTime { get; set; } = string.Empty;

        [JsonPropertyName("actual_time")]
        public string ActualTime { get; set; } = string.Empty;

        [JsonPropertyName("gate")]
        public string Gate { get; set; } = string.Empty;

        [JsonPropertyName("remarks")]
        [ExcludeFromCodeCoverage] // Can be an empty return.
        public string Remarks { get; set; } = string.Empty;

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; } = string.Empty;

        [JsonPropertyName("airline_name")]
        public string AirlineName { get; set; } = string.Empty;

        [JsonPropertyName("airline_abbreviation")]
        public string AirlineAbbreviation { get; set; } = string.Empty;

        [JsonPropertyName("airline_logo")]
        public string AirlineLogo { get; set; } = string.Empty;
    }
}