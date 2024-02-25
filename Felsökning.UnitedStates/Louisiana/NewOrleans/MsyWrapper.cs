//-----------------------------------------------------------------------
// <copyright file="MsyWrapper.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.Louisiana.NewOrleans
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="MsyWrapper"/> class,
    ///     which is used to query the MSY API for flights to/from MSY.
    /// </summary>
    /// <inheritdoc cref="HttpBase"/>
    /// <inheritdoc cref="IMsyWrapper"/>
    public class MsyWrapper : HttpBase, IMsyWrapper
    {
        private readonly string _baseAddress = "https://flymsy.com";

        /// <summary>
        ///     Initializes a new instance of the <see cref="MsyWrapper"/> class,
        ///     which is used to query the MSY API for flights to/from MSY.
        /// </summary>
        /// <inheritdoc cref="HttpBase"/>
        /// <inheritdoc cref="IMsyWrapper"/>
        public MsyWrapper()
            : base(HttpVersion.Version20, "Felsökning.UnitedStates")
        {
            this.HttpClient.BaseAddress = new Uri(this._baseAddress);
        }

        /// <summary>
        ///     Asynchronously gets all flights To/From MSY Airport.
        /// </summary>
        /// <returns>An awaitable <see cref="Task{TResult}"/> of <see cref="List{T}"/> of <see cref="Flight"/></returns>
        public async Task<List<Flight>> GetFlightsAsync()
        {
            return await this.HttpClient.GetAsync<List<Flight>>("/wp-json/flight-status/flights");
        }
    }
}