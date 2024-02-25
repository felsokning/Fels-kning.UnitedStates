//-----------------------------------------------------------------------
// <copyright file="Feature.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NationalWeatherService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Feature"/> class.
    /// </summary>
    public class Feature
    {
        /// <summary>
        ///     Gets or sets the ID of the Feature
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Type of the Feature
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Geometry of the Feature
        /// </summary>
        [JsonPropertyName("geometry")]
        public Geometry Geometry { get; set; } = new Geometry();

        /// <summary>
        ///     Gets or sets the Properties of the Feature
        /// </summary>
        [JsonPropertyName("properties")]
        public Properties Properties { get; set; } = new Properties();
    }
}