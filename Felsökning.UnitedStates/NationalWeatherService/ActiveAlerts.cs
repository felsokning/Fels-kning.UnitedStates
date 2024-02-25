//-----------------------------------------------------------------------
// <copyright file="ActiveAlerts.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//----------------------------------------------------------------------- 
namespace Felsökning.UnitedStates.NationalWeatherService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ActiveAlerts"/> class.
    /// </summary>
    public class ActiveAlerts
    {
        /// <summary>
        ///     Gets or sets the Context of the Active Alerts
        /// </summary>
        [JsonPropertyName("@context")]
        [JsonConverter(typeof(SingleItemOrListConverter<object>))]
        public List<object> Context { get; set; } = new List<object>();

        /// <summary>
        ///     Gets or sets the Type of the Active Alerts
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Features of the Active Alerts
        /// </summary>
        [JsonPropertyName("features")]
        public List<Feature> Features { get; set; } = new List<Feature>(0);

        /// <summary>
        ///     Gets or sets the Title of the Active Alerts
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Updated value of the Active Alerts
        /// </summary>
        [JsonPropertyName("updated")]
        public DateTime Updated { get; set; }
    }
}