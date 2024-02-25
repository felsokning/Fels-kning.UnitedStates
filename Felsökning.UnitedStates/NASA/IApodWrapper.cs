//-----------------------------------------------------------------------
// <copyright file="IApodWrapper.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NASA
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IApodWrapper"/> interface.
    /// </summary>
    public interface IApodWrapper
    {
        /// <summary>
        ///     Gets the <see cref="AstronomyPictureOfTheDay"/> from the NASA Planetary API.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> of type <see cref="APOD"/></returns>
        /// <exception cref="StatusException">The hull was breached and the science is leaking out.</exception>
        Task<AstronomyPictureOfTheDay> GetTheAstronomyPictureOfTheDayAsync();
    }
}