//-----------------------------------------------------------------------
// <copyright file="NotamsWrapperTests.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.Tests.FAA
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class NotamsWrapperTests
    {
        [TestMethod]
        public async Task GetPublishedNotamsForAirportAsync_Fails_For_Empty_ICAO()
        {
            var sut = new NotamsWrapper();

            var exception = await Assert.ThrowsExceptionAsync<ArgumentNullException>(async () => await sut.GetPublishedNotamsForAirportAsync(string.Empty));

            exception.Should().NotBeNull();
            exception.Should().BeOfType<ArgumentNullException>();
        }

        [TestMethod]
        public async Task GetPublishedNotamsForAirportIAsync_Fails_For_Empty_ICAO()
        {
            var sut = new NotamsWrapper();

            var exception = await Assert.ThrowsExceptionAsync<ArgumentNullException>(async () => await sut.GetPublishedNotamsForAirportIAsync(string.Empty));

            exception.Should().NotBeNull();
            exception.Should().BeOfType<ArgumentNullException>();
        }

        [TestMethod]
        public async Task GetPublishedNotamsForAirportAsync_Fails_For_Invalid_ICAO()
        {
            var sut = new NotamsWrapper();

            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await sut.GetPublishedNotamsForAirportAsync("8675309"));

            exception.Should().NotBeNull();
            exception.Should().BeOfType<ArgumentException>();
        }

        [TestMethod]
        public async Task GetPublishedNotamsForAirportIAsync_Fails_For_Invalid_ICAO()
        {
            var sut = new NotamsWrapper();

            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await sut.GetPublishedNotamsForAirportIAsync("8675309"));

            exception.Should().NotBeNull();
            exception.Should().BeOfType<ArgumentException>();
        }

        [TestMethod]
        public async Task GetPublishedNotamsForAirportAsync_Succeeds_For_EIDW()
        {
            var sut = new NotamsWrapper();

            var results = await sut.GetPublishedNotamsForAirportAsync("eidw"); // Dublin

            results.Should().NotBeNull();
            results.Count.Should().BeGreaterThanOrEqualTo(0); // Some ICAOs have no NOTAMs.
        }

        [TestMethod]
        public async Task GetPublishedNotamsForAirportAsync_Succeeds_For_EIKN()
        {
            var sut = new NotamsWrapper();

            var results = await sut.GetPublishedNotamsForAirportAsync("eikn"); // NOC

            results.Should().NotBeNull();
            results.Count.Should().BeGreaterThanOrEqualTo(0); // Some ICAOs have no NOTAMs.
        }

        [TestMethod]
        public async Task GetPublishedNotamsForAirportIAsync_Succeeds_For_EIKN()
        {
            var sut = new NotamsWrapper();

            var results = await sut.GetPublishedNotamsForAirportIAsync("eikn"); // NOC
            await foreach (var item in results) // Some ICAOs have no NOTAMs, so iterate.
            {
                item.Should().NotBeNull();
                item.Should().NotBeNullOrWhiteSpace();
            }
        }

        [TestMethod]
        public async Task GetPublishedNotamsForAirportAsync_Succeeds_For_KMSY()
        {
            var sut = new NotamsWrapper();

            var results = await sut.GetPublishedNotamsForAirportAsync("kmsy"); // New Orleans

            results.Should().NotBeNull();
            results.Count.Should().BeGreaterThanOrEqualTo(0); // Some ICAOs have no NOTAMs.
        }


        [TestMethod]
        public async Task GetPublishedNotamsForAirportIAsync_Succeeds_For_KMSY()
        {
            var sut = new NotamsWrapper();

            var results = await sut.GetPublishedNotamsForAirportIAsync("kmsy"); // New Orleans
            await foreach (var item in results) // Some ICAOs have no NOTAMs, so iterate.
            {
                item.Should().NotBeNull();
                item.Should().NotBeNullOrWhiteSpace();
            }
        }
    }
}