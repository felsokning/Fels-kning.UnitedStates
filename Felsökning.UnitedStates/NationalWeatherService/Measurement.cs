//-----------------------------------------------------------------------
// <copyright file="Measurement.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NationalWeatherService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Measurement"/> class.
    /// </summary>
    public class Measurement
    {
        /// <summary>
        ///     Gets or sets the Unit Code for the Measurement
        /// </summary>
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Value for the Measurement
        /// </summary>
        [JsonPropertyName("value")]
        public float? Value { get; set; }

        /// <summary>
        ///     Gets or sets the Quality Control value for the Measurement
        /// </summary>
        [JsonPropertyName("qualityControl")]
        public string QualityControl { get; set; } = string.Empty;
    }
}