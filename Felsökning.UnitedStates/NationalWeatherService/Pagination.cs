//-----------------------------------------------------------------------
// <copyright file="Pagination.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NationalWeatherService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Pagination"/> class.
    /// </summary>
    public class Pagination
    {
        /// <summary>
        ///     Gets or sets the Next of the Pagination
        /// </summary>
        [JsonPropertyName("next")]
        public string Next { get; set; } = string.Empty;
    }
}