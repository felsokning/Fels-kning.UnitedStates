//-----------------------------------------------------------------------
// <copyright file="Resource.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NASA
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Resource"/> class,
    ///     which is used for the resources.
    /// </summary>
    public class Resource
    {
        [JsonPropertyName("image_set")]
        public string ImageSet { get; set; } = string.Empty;

        [JsonPropertyName("planet")]
        public string Planet { get; set; } = string.Empty;
    }
}