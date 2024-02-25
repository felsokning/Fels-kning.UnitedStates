//-----------------------------------------------------------------------
// <copyright file="Geometry.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NationalWeatherService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Geometry"/> class.
    /// </summary>
    public class Geometry
    {
        /// <summary>
        ///     Gets or sets the Type of Geometry
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
    }
}