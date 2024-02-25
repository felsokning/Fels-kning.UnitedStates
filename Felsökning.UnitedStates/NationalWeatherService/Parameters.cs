//-----------------------------------------------------------------------
// <copyright file="Reference.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NationalWeatherService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Parameters"/> class.
    /// </summary>
    public class Parameters
    {
        /// <summary>
        ///     Gets or sets the AWIPS Identifier for the Parameters
        /// </summary>
        [JsonPropertyName("AWIPSidentifier")]
        public List<string> AWIPSidentifier { get; set; } = new List<string>(0);

        /// <summary>
        ///     Gets or sets the WMO Identifier for the Parameters
        /// </summary>
        [JsonPropertyName("WMOidentifier")]
        public List<string> WMOidentifier { get; set; } = new List<string>(0);

        /// <summary>
        ///     Gets or sets the BLOCKCHANNEL for the Parameters
        /// </summary>
        [JsonPropertyName("BLOCKCHANNEL")]
        public List<string> BLOCKCHANNEL { get; set; } = new List<string>(0);

        /// <summary>
        ///     Gets or sets the EAS ORG for the Parameters
        /// </summary>
        [JsonPropertyName("EAS-ORG")]
        public List<string> EASORG { get; set; } = new List<string>(0);

        /// <summary>
        ///     Gets or sets the VTEC for the Parameters
        /// </summary>
        [JsonPropertyName("VTEC")]
        public List<string> VTEC { get; set; } = new List<string>(0);

        /// <summary>
        ///     Gets or sets the Event Ending Time for the Parameters
        /// </summary>
        [JsonPropertyName("eventEndingTime")]
        public List<DateTime> EventEndingTime { get; set; } = new List<DateTime>(0);

        /// <summary>
        ///     Gets or sets the NWS Headline for the Parameters
        /// </summary>
        [JsonPropertyName("NWSheadline")]
        public List<string> NWSheadline { get; set; } = new List<string>(0);

        /// <summary>
        ///     Gets or sets the Expired References for the Parameters
        /// </summary>
        [JsonPropertyName("expiredReferences")]
        public List<string> ExpiredReferences { get; set; } = new List<string>(0);
    }
}