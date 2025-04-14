//-----------------------------------------------------------------------
// <copyright file="NwsWrapper.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.NationalWeatherService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NwsWrapper"/> class, which is used to wrap calls to the National Weather Service (NWS) API.
    ///     <para>The NWS API provides weather alerts and warnings for the United States.</para>
    ///     <para>The API requires a valid location code (Universal Geographic Code - UGC) for the area targeted.</para>
    ///     <para>The UGC can be derived from the latest Census data: https://www2.census.gov/programs-surveys/popest/geographies/2019/all-geocodes-v2019.xlsx</para>
    /// </summary>
    /// <inheritdoc cref="HttpBase"/>
    /// <inheritdoc cref="INwsWrapper"/>
    public class NwsWrapper : HttpBase, INwsWrapper
    {
        private readonly string _baseAddress = "https://api.weather.gov";
        /// <summary>
        ///     Initializes a new instance of the <see cref="NwsWrapper"/> class.
        /// </summary>
        /// <param name="locationCode">The location to query for the alerts.
        /// <para>The location code is the Universal Geographic Code (UGC) for the area targeted.</para>
        /// <para>The UGC can be derived from the latest Census data: https://www2.census.gov/programs-surveys/popest/geographies/2019/all-geocodes-v2019.xlsx</para>
        /// </param>
        public NwsWrapper([Optional] string locationCode)
            : base(HttpVersion.Version20, "Felsökning.UnitedStates.NationalWeatherService")
        {
            if (locationCode == null || string.IsNullOrWhiteSpace(locationCode))
            {
                this.LocationCode = "DCC001";
            }
            else
            {
                this.LocationCode = locationCode;
            }

            this.HttpClient.BaseAddress = new Uri(this._baseAddress);
        }

        /// <summary>
        ///     The URL for obtaining the current active alerts for the area.
        /// </summary>
        internal const string ActiveAlertsUrl = "/alerts/active?zone=";

        /// <summary>
        ///     The URL for obtaining the list of previous alerts for the area.
        /// </summary>
        internal const string HistoricAlertsUrl = "/alerts?zone=";


        /// <summary>
        ///     Gets or sets the Universal Geographic Code (UGC) used for the queries.
        /// </summary>
        public string LocationCode { get; set; }

        /// <summary>
        ///     Gets the current active alerts for a given area.
        /// </summary>
        /// <returns>An awaitable <see cref="Task{TResult}"/> of <see cref="ActiveAlerts"/></returns>
        public async Task<ActiveAlerts> GetActiveAlertsAsync()
        {
            string url = $"{ActiveAlertsUrl}{this.LocationCode}";
            return await this.HttpClient.GetAsync<ActiveAlerts>(url);
        }

        /// <summary>
        ///     Obtains the Historic Alerts from the NWS API.
        /// </summary>
        /// <returns>An awaitable <see cref="Task{TResult}"/> of <see cref="HistoricAlerts"/>.</returns>
        public async Task<HistoricAlerts> GetHistoricAlertsAsync()
        {
            string url = $"{HistoricAlertsUrl}{this.LocationCode}";
            return await this.HttpClient.GetAsync<HistoricAlerts>(url);
        }
    }
}