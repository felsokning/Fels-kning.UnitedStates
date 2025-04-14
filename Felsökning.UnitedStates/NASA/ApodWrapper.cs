//-----------------------------------------------------------------------
// <copyright file="ApodWrapper.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NASA
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ApodWrapper"/> class, which is used to retrieve the Astronomy Picture of the Day (APOD) from the NASA Planetary API.
    /// </summary>
    /// <inheritdoc cref="HttpBase"/>
    /// <inheritdoc cref="IApodWrapper"/>
    public class ApodWrapper : HttpBase, IApodWrapper
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ApodWrapper"/>,
        ///     which is used to wrap calls to the NASA APOD API.
        /// </summary>
        /// <param name="apiKey">The API Key Used to access the NASA APIs.
        /// <para>If not supplied, the demo value is used. The rate limits of the Demo Key are:</para>
        /// <para>Hourly Limit: 30 requests per IP address per hour</para>
        /// <para>Daily Limit: 50 requests per IP address per day</para>
        /// </param>
        public ApodWrapper([Optional] string apiKey)
            : base(HttpVersion.Version20, "Felsökning.UnitedStates.NASA")
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                this.ApiKey = "DEMO_KEY";
            else
                this.ApiKey = apiKey;
        }

        /// <summary>
        ///     Gets or sets the Api Key that is used to make calls to the NASA APIs.
        /// </summary>
        public string ApiKey { get; private set; }

        /// <summary>
        ///     Gets the Astronomy Picture of the Day (<see cref="APOD"/>) from the NASA Planetary API.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> of type <see cref="APOD"/></returns>
        /// <exception cref="StatusException">The hull was breached and the science is leaking out.</exception>
        public async Task<AstronomyPictureOfTheDay> GetTheAstronomyPictureOfTheDayAsync()
        {
            return await this.HttpClient.GetAsync<AstronomyPictureOfTheDay>($"https://api.nasa.gov/planetary/apod?api_key={this.ApiKey}");
        }
    }
}