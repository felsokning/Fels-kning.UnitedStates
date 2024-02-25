//-----------------------------------------------------------------------
// <copyright file="Concepts.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NASA
{
    /// <summary>
    ///     The most relevant concepts within the text explanation.
    ///     <para>Only supplied if concept_tags is set to <see langword="true"/>.</para>
    /// </summary>
    public class Concepts
    {
        [JsonPropertyName("0")]
        public string _0 { get; set; } = string.Empty;

        [JsonPropertyName("1")]
        public string _1 { get; set; } = string.Empty;

        [JsonPropertyName("2")]
        public string _2 { get; set; } = string.Empty;

        [JsonPropertyName("3")]
        public string _3 { get; set; } = string.Empty;

        [JsonPropertyName("4")]
        public string _4 { get; set; } = string.Empty;

        [JsonPropertyName("5")]
        public string _5 { get; set; } = string.Empty;

        [JsonPropertyName("6")]
        public string _6 { get; set; } = string.Empty;

        [JsonPropertyName("7")]
        public string _7 { get; set; } = string.Empty;
    }
}