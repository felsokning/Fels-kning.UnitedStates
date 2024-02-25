//-----------------------------------------------------------------------
// <copyright file="AstronomyPictureOfTheDay.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NASA
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AstronomyPictureOfTheDay"/> class,
    ///     which is used to represent the Astronomy Picture of the Day.
    /// </summary>
    public class AstronomyPictureOfTheDay
    {
        /// <summary>
        ///     Gets or sets the most relevant concepts within the text explanation. 
        ///     <para>Only supplied if concept_tags is set to <see langword="true"/>.</para>
        /// </summary>
        [JsonPropertyName("concepts")]
        public Concepts Concepts { get; set; } = new Concepts();

        /// <summary>
        ///     Gets or sets a boolean reflection of the supplied option. 
        ///     <para>Included in response because of default values.</para>
        /// </summary>
        [JsonPropertyName("concept_tags")]
        public bool ConceptTags { get; set; }

        /// <summary>
        ///     Gets or sets the name of the copyright holder.
        /// </summary>
        [JsonPropertyName("copyright")]
        public string Copyright { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the date of image. 
        ///     <para>Included in response because of default values.</para>
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the URL for any high-resolution image for that day. 
        ///     <para>Returned regardless of 'hd' param setting but will be omitted in the response IF it does not exist originally at APOD.</para>
        /// </summary>
        [JsonPropertyName("hdurl")]
        public string HdUrl { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the supplied text explanation of the image or video.
        /// </summary>
        [JsonPropertyName("explanation")]
        public string Explanation { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets a dictionary describing the image_set or planet that the response illustrates, completely determined by the structured endpoint.
        /// </summary>
        [JsonPropertyName("resource")]
        public Resource Resource { get; set; } = new Resource();

        /// <summary>
        ///     Gets or sets the service version used.
        /// </summary>
        [JsonPropertyName("service_version")]
        public string ServiceVersion { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the URL of thumbnail of the video.
        /// </summary>
        [JsonPropertyName("thumbnail_url")]
        public string ThumbnailUrl { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the title of the image.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the URL of the APOD image or video of the day.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
    }
}