//-----------------------------------------------------------------------
// <copyright file="DirectionType.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.Louisiana.NewOrleans
{
    //[JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Serializable]
    public enum DirectionType
    {
        Unknown,

        [JsonPropertyName("Arrival")]
        [EnumMember(Value = "Arrival")]
        A,

        [JsonPropertyName("Departure")]
        [EnumMember(Value = "Departure")]
        D,
    }
}