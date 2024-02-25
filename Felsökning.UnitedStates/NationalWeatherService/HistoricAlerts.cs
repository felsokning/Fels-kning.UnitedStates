//-----------------------------------------------------------------------
// <copyright file="HistoricAlerts.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//----------------------------------------------------------------------- 
namespace Felsökning.UnitedStates.NationalWeatherService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="HistoricAlerts"/> class.
    /// </summary>
    public class HistoricAlerts
    {
        /// <summary>
        ///     Gets or sets the Context for the Historic Alerts
        /// </summary>
        [JsonPropertyName("@context")]
        [JsonConverter(typeof(SingleItemOrListConverter<object>))]
        public List<object> Context { get; set; } = new List<object>(0);

        /// <summary>
        ///     Gets or sets the Type for the Historic Alerts
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Features for the Historic Alerts
        /// </summary>
        [JsonPropertyName("features")]
        [JsonConverter(typeof(SingleItemOrListConverter<Feature>))]
        public List<Feature> Features { get; set; } = new List<Feature>(0);

        /// <summary>
        ///     Gets or sets the Title for the Historic Alerts
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Updated for the Historic Alerts
        /// </summary>
        [JsonPropertyName("updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        ///     Gets or sets the Pagination for the Historic Alerts
        /// </summary>
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; } = new Pagination();
    }
}