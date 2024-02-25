//-----------------------------------------------------------------------
// <copyright file="Reference.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NationalWeatherService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Reference"/> class.
    /// </summary>
    public class Reference
    {
        /// <summary>
        ///     Gets or sets the Id for the Reference
        /// </summary>
        [JsonPropertyName("@id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Identifier for the Reference
        /// </summary>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Sender for the Reference
        /// </summary>
        [JsonPropertyName("sender")]
        public string Sender { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Sent for the Reference
        /// </summary>
        [JsonPropertyName("sent")]
        public DateTime Sent { get; set; }
    }
}