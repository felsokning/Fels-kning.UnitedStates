//-----------------------------------------------------------------------
// <copyright file="Properties.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NationalWeatherService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Properties"/> class.
    /// </summary>
    public class Properties
    {
        /// <summary>
        ///     Gets or sets the At ID for the Properties
        /// </summary>
        [JsonPropertyName("@id")]
        public string AtId { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the ID for the Properties
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Affected Zones for the Properties
        /// </summary>
        [JsonPropertyName("affectedZones")]
        public List<string> AffectedZones { get; set; } = new List<string>(0);

        /// <summary>
        ///     Gets or sets the Area Description for the Properties
        /// </summary>
        [JsonPropertyName("areaDesc")]
        public string AreaDesc { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Effective value for the Properties
        /// </summary>
        [JsonPropertyName("effective")]
        public DateTime Effective { get; set; }


        /// <summary>
        ///     Gets or sets the Geocode for the Properties
        /// </summary>
        [JsonPropertyName("geocode")]
        public Geocode Geocode { get; set; } = new Geocode();

        /// <summary>
        ///     Gets or sets the Type for the Properties
        /// </summary>
        [JsonPropertyName("@type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the County for the Properties
        /// </summary>
        [JsonPropertyName("county")]
        public string County { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Elevation for the Properties
        /// </summary>
        [JsonPropertyName("elevation")]
        public Elevation Elevation { get; set; } = new Elevation();

        /// <summary>
        ///     Gets or sets the Station for the Properties
        /// </summary>
        [JsonPropertyName("station")]
        public string Station { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Timestamp for the Properties
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        ///     Gets or sets the Raw Message for the Properties
        /// </summary>
        [JsonPropertyName("rawMessage")]
        public string RawMessage { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Text Description for the Properties
        /// </summary>
        [JsonPropertyName("textDescription")]
        public string TextDescription { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Icon for the Properties
        /// </summary>
        [JsonPropertyName("icon")]
        public object Icon { get; set; } = new object();

        /// <summary>
        ///     Gets or sets the Present Weather for the Properties
        /// </summary>
        [JsonPropertyName("presentWeather")]
        [JsonConverter(typeof(SingleItemOrListConverter<object>))]
        public List<object> PresentWeather { get; set; } = new List<object>(0);

        /// <summary>
        ///     Gets or sets the Temperature for the Properties
        /// </summary>
        [JsonPropertyName("temperature")]
        public Measurement Temperature { get; set; } = new Measurement();

        /// <summary>
        ///     Gets or sets the Dewpoint for the Properties
        /// </summary>
        [JsonPropertyName("dewpoint")]
        public Measurement Dewpoint { get; set; } = new Measurement();

        /// <summary>
        ///     Gets or sets the Wind Direction for the Properties
        /// </summary>
        [JsonPropertyName("windDirection")]
        public Measurement WindDirection { get; set; } = new Measurement();

        /// <summary>
        ///     Gets or sets the Wind Speed for the Properties
        /// </summary>
        [JsonPropertyName("windSpeed")]
        public Measurement WindSpeed { get; set; } = new Measurement();

        /// <summary>
        ///     Gets or sets the Wind Gust for the Properties
        /// </summary>
        [JsonPropertyName("windGust")]
        public Measurement WindGust { get; set; } = new Measurement();

        /// <summary>
        ///     Gets or sets the Barometric Pressure for the Properties
        /// </summary>
        [JsonPropertyName("barometricPressure")]
        public Measurement BarometricPressure { get; set; } = new Measurement();

        /// <summary>
        ///     Gets or sets the Sea Level Pressure for the Properties
        /// </summary>
        [JsonPropertyName("seaLevelPressure")]
        public Measurement SeaLevelPressure { get; set; } = new Measurement();

        /// <summary>
        ///     Gets or sets the State for the Properties
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Visibility for the Properties
        /// </summary>
        [JsonPropertyName("visibility")]
        public Measurement Visibility { get; set; } = new Measurement();

        /// <summary>
        ///     Gets or sets the Max Temperature for the Last 24 Hours for the Properties
        /// </summary>
        [JsonPropertyName("maxTemperatureLast24Hours")]
        public Measurement MaxTemperatureLast24Hours { get; set; } = new Measurement();

        /// <summary>
        ///     Gets or sets the Min Temperature for the Last 24 Hours for the Properties
        /// </summary>
        [JsonPropertyName("minTemperatureLast24Hours")]
        public Measurement MinTemperatureLast24Hours { get; set; } = new Measurement();

        /// <summary>
        ///     Gets or sets the Precipitation for the Last 3Hours for the Properties
        /// </summary>
        [JsonPropertyName("precipitationLast3Hours")]
        public Measurement PrecipitationLast3Hours { get; set; } = new Measurement();

        /// <summary>
        ///     Gets or sets the Relative Humidity for the Properties
        /// </summary>
        [JsonPropertyName("relativeHumidity")]
        public Measurement RelativeHumidity { get; set; } = new Measurement();

        /// <summary>
        ///     Gets or sets the Wind Chill for the Properties
        /// </summary>
        [JsonPropertyName("windChill")]
        public Measurement WindChill { get; set; } = new Measurement();

        /// <summary>
        ///     Gets or sets the Heat Index for the Properties
        /// </summary>
        [JsonPropertyName("heatIndex")]
        public Measurement HeatIndex { get; set; } = new Measurement();

        /// <summary>
        ///     Gets or sets the Cloud Layers for the Properties
        /// </summary>
        [JsonPropertyName("cloudLayers")]
        [JsonConverter(typeof(SingleItemOrListConverter<object>))]
        public List<object> CloudLayers { get; set; } = new List<object>(0);

        /// <summary>
        ///     Gets or sets the References for the Properties
        /// </summary>
        [JsonPropertyName("references")]
        public List<Reference> References { get; set; } = new List<Reference>(0);

        /// <summary>
        ///     Gets or sets the Sent for the Properties
        /// </summary>
        [JsonPropertyName("sent")]
        public DateTime Sent { get; set; }

        /// <summary>
        ///     Gets or sets the Onset for the Properties
        /// </summary>
        [JsonPropertyName("onset")]
        public DateTime Onset { get; set; }

        /// <summary>
        ///     Gets or sets the Expires for the Properties
        /// </summary>
        [JsonPropertyName("expires")]
        public DateTime Expires { get; set; }

        /// <summary>
        ///     Gets or sets the Ends for the Properties
        /// </summary>
        [JsonPropertyName("ends")]
        public DateTime? Ends { get; set; }

        /// <summary>
        ///     Gets or sets the Status for the Properties
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Message Type for the Properties
        /// </summary>
        [JsonPropertyName("messageType")]
        public string MessageType { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Category for the Properties
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Severity for the Properties
        /// </summary>
        [JsonPropertyName("severity")]
        public string Severity { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Certainty for the Properties
        /// </summary>
        [JsonPropertyName("certainty")]
        public string Certainty { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Urgency for the Properties
        /// </summary>
        [JsonPropertyName("urgency")]
        public string Urgency { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Event for the Properties
        /// </summary>
        [JsonPropertyName("event")]
        public string Event { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Sender for the Properties
        /// </summary>
        [JsonPropertyName("sender")]
        public string Sender { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Sender Name for the Properties
        /// </summary>
        [JsonPropertyName("senderName")]
        public string SenderName { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Headline for the Properties
        /// </summary>
        [JsonPropertyName("headline")]
        public string Headline { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Description for the Properties
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Instruction for the Properties
        /// </summary>
        [JsonPropertyName("instruction")]
        public string Instruction { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Response for the Properties
        /// </summary>
        [JsonPropertyName("response")]
        public string Response { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Parameters for the Properties
        /// </summary>
        [JsonPropertyName("parameters")]
        public Parameters Parameters { get; set; } = new Parameters();
    }
}