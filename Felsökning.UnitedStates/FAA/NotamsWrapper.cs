//-----------------------------------------------------------------------
// <copyright file="NotamsWrapper.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.FAA
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NotamsWrapper"/> class, which is used to wrap calls to the Federal Aviation Administration's (FAA's) Notice to Airmen (NOTAMs) endpoint.
    /// </summary>
    /// <inheritdoc cref="HttpBase"/>
    public class NotamsWrapper : HttpBase
    {
        private readonly string _url;
        private readonly TimeSpan timeout = TimeSpan.FromSeconds(3);

        /// <summary>
        ///     Initializes a new instance of the <see cref="NotamsWrapper"/> class,
        ///     which is used to wrap calls to the Federal Aviation Administration's (FAA's) Notice to Airmen (NOTAMs) endpoint.
        /// </summary>
        /// <inheritdoc cref="HttpBase"/>
        public NotamsWrapper()
            : base(HttpVersion.Version11, "Felsökning.Aviation")
        {
            _url = "https://www.notams.faa.gov/dinsQueryWeb/queryRetrievalMapAction.do?reportType=Raw&retrieveLocId={0}&actionType=notamRetrievalbyICAOs";
        }

        /// <summary>
        ///     Gets the NOTAMs for a given Airport or Aerodome via the ICAO ID.
        /// </summary>
        /// <param name="icaoId"></param>
        /// <returns>A <see cref="List{T}"/> of <see cref="string"/>. <para>There is one string per NOTAM.</para></returns>
        /// <exception cref="ArgumentNullException">The given ICAO was found to be null or empty.</exception>
        /// <exception cref="ArgumentException">The given ICAO was found to not be in the correct format.</exception>
        public async Task<List<string>> GetPublishedNotamsForAirportAsync(string icaoId)
        {
            if (string.IsNullOrWhiteSpace(icaoId))
                throw new ArgumentNullException(nameof(icaoId));
            if (!Regex.IsMatch(icaoId, @"^[a-zA-Z]{3}", RegexOptions.IgnorePatternWhitespace, timeout))
                throw new ArgumentException($"The ICAO Id '{icaoId}' is not valid.");

            var fixedUrl = string.Format(_url, icaoId);
            var result = await this.HttpClient.GetAsync(fixedUrl);
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                var subcontent = content[content.IndexOf("<PRE>")..content.LastIndexOf("</PRE>")];
                var fixedSubContent = Regex.Replace(subcontent, @"(?></?\w+)(?>(?:[^>'""]+|'[^']*'|""[^""]*"")*)>", string.Empty, RegexOptions.None, timeout);
                var tabRemovedFixedSubContent = fixedSubContent.Replace("\t", "");
                return [.. tabRemovedFixedSubContent
                    .Replace("\n \n", string.Empty)
                    .Split("\n\n\n\n\n\n\n\n\n\n\n")];
            }

            return [];
        }

        /// <summary>
        ///     Gets the NOTAMs for a given Airport or Aerodome via the ICAO ID.
        /// </summary>
        /// <param name="icaoId"></param>
        /// <returns>A <see cref="IAsyncEnumerable{T}"/> of <see cref="string"/>. <para>There is one string per NOTAM.</para></returns>
        /// <exception cref="ArgumentNullException">The given ICAO was found to be null or empty.</exception>
        /// <exception cref="ArgumentException">The given ICAO was found to not be in the correct format.</exception>
        public async Task<IAsyncEnumerable<string>> GetPublishedNotamsForAirportIAsync(string icaoId)
        {
            if (string.IsNullOrWhiteSpace(icaoId))
                throw new ArgumentNullException(nameof(icaoId));
            if (!Regex.IsMatch(icaoId, @"^[a-zA-Z]{3}", RegexOptions.IgnorePatternWhitespace, timeout))
                throw new ArgumentException($"The ICAO Id '{icaoId}' is not valid.");

            var fixedUrl = string.Format(_url, icaoId);
            var result = await this.HttpClient.GetAsync(fixedUrl);
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                var subcontent = content.Substring(content.IndexOf("<PRE>"), (content.LastIndexOf("</PRE>") - content.IndexOf("<PRE>")));
                var fixedSubContent = Regex.Replace(subcontent, @"(?></?\w+)(?>(?:[^>'""]+|'[^']*'|""[^""]*"")*)>", string.Empty, RegexOptions.None, timeout);
                var tabRemovedFixedSubContent = fixedSubContent.Replace("\t", "");
                return tabRemovedFixedSubContent
                    .Replace("\n \n", string.Empty)
                    .Split("\n\n\n\n\n\n\n\n\n\n\n").ToList()
                    .ToIAsyncEnumerable();
            }

            return new List<string>(0)
                .ToIAsyncEnumerable();
        }
    }
}