namespace Felsökning.UnitedStates.Tests.Louisiana.NewOrleans
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class MsyWrapperTests
    {
        [TestMethod]
        public void MsyWrapper_ctor()
        {
#pragma warning disable CA1859 // Interfaces shouldn't slow performance
            IMsyWrapper sut = new MsyWrapper();
#pragma warning restore CA1859 // Interfaces shouldn't slow performance

            sut.Should().NotBeNull();
            sut.Should().BeOfType<MsyWrapper>();
        }

        [TestMethod]
        public async Task GetFlightsAsync_Succeeds()
        {
#pragma warning disable CA1859 // Interfaces shouldn't slow performance
            IMsyWrapper sut = new MsyWrapper();
#pragma warning restore CA1859 // Interfaces shouldn't slow performance

            var results = await sut.GetFlightsAsync();

            results.Should().NotBeNull();
            results.Count.Should().BeGreaterThanOrEqualTo(0);

            var arrivals = results.FindAll(x => x.Type1 == DirectionType.A);
            arrivals.Should().NotBeNull();
            arrivals.Count.Should().BeGreaterThanOrEqualTo(0);

            var arrival = arrivals.FirstOrDefault();
            arrival.Should().NotBeNull();
            arrival.ActualTime.Should().NotBeNullOrWhiteSpace();
            arrival.Airline.Should().NotBeNullOrWhiteSpace();
            arrival.AirlineAbbreviation.Should().NotBeNullOrWhiteSpace();
            arrival.AirlineLogo.Should().NotBeNullOrWhiteSpace();
            arrival.AirlineName.Should().NotBeNullOrWhiteSpace();
            arrival.City.Should().NotBeNullOrWhiteSpace();
            arrival.Date.Should().NotBeNullOrWhiteSpace();
            arrival.FlightNumber.Should().NotBeNullOrWhiteSpace();
            arrival.Gate.Should().NotBeNullOrWhiteSpace();
            arrival.Id.Should().NotBeNullOrWhiteSpace();
            arrival.ScheduledTime.Should().NotBeNullOrWhiteSpace();
            arrival.Type1.Should().Be(DirectionType.A);
            arrival.Type2.Should().NotBeNullOrWhiteSpace();
            arrival.UpdatedAt.Should().NotBeNullOrWhiteSpace();

            var departures = results.FindAll(x => x.Type1 == DirectionType.D);
            departures.Should().NotBeNull();
            departures.Count.Should().BeGreaterThanOrEqualTo(0);

            var departure = departures.FirstOrDefault();
            departure.Should().NotBeNull();
            departure.ActualTime.Should().NotBeNullOrWhiteSpace();
            departure.Airline.Should().NotBeNullOrWhiteSpace();
            departure.AirlineAbbreviation.Should().NotBeNullOrWhiteSpace();
            departure.AirlineLogo.Should().NotBeNullOrWhiteSpace();
            departure.AirlineName.Should().NotBeNullOrWhiteSpace();
            departure.City.Should().NotBeNullOrWhiteSpace();
            departure.Date.Should().NotBeNullOrWhiteSpace();
            departure.FlightNumber.Should().NotBeNullOrWhiteSpace();
            departure.Gate.Should().NotBeNullOrWhiteSpace();
            departure.Id.Should().NotBeNullOrWhiteSpace();
            departure.ScheduledTime.Should().NotBeNullOrWhiteSpace();
            departure.Type1.Should().Be(DirectionType.D);
            departure.Type2.Should().NotBeNullOrWhiteSpace();
            departure.UpdatedAt.Should().NotBeNullOrWhiteSpace();
        }
    }
}