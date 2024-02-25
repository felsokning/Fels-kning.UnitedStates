//-----------------------------------------------------------------------
// <copyright file="Geocode.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NationalWeatherService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Geocode"/> class.
    /// </summary>
    public class Geocode
    {
        /// <summary>
        ///     Gets or sets the SAME for the Geocode
        /// </summary>
        [JsonPropertyName("SAME")]
        public List<string> SAME { get; set; } = new List<string>(0);

        /// <summary>
        ///     Gets or sets the UGC for the Geocode
        /// </summary>
        [JsonPropertyName("UGC")]
        public List<string> UGC { get; set; } = new List<string>(0);
    }
}