//-----------------------------------------------------------------------
// <copyright file="INwsWrapper.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NationalWeatherService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="INwsWrapper"/> interface.
    /// </summary>
    public interface INwsWrapper
    {
        /// <summary>
        ///     Gets the current active alerts for a given area.
        /// </summary>
        /// <returns>An awaitable <see cref="Task{TResult}"/> of <see cref="ActiveAlerts"/></returns>
        Task<ActiveAlerts> GetActiveAlertsAsync();

        /// <summary>
        ///     Obtains the Historic Alerts from the NWS API.
        /// </summary>
        /// <returns>An awaitable <see cref="Task{TResult}"/> of <see cref="HistoricAlerts"/>.</returns>
        Task<HistoricAlerts> GetHistoricAlertsAsync();
    }
}