// -----------------------------------------------------------------------
// <copyright file="Elevation.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------                  
namespace Felsökning.UnitedStates.NationalWeatherService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Elevation"/> class.
    /// </summary>
    public class Elevation
    {
        /// <summary>
        ///     Gets or sets the Unit Code for the Elevation Value.
        /// </summary>
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Value for the Elevation.
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }
}