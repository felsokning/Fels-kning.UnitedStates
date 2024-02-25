//-----------------------------------------------------------------------
// <copyright file="NwsWrapperTests.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.Tests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class NwsWrapperTests
    {
        [TestMethod]
        public void NwsWrapper_ctor()
        {
            var sut = new NwsWrapper(string.Empty);

            sut.Should().NotBeNull();
            sut.Should().BeOfType<NwsWrapper>();
            sut.HttpClient.Should().NotBeNull();
            sut.HttpClient.DefaultRequestHeaders.Count().Should().BeGreaterThan(1);
            sut.LocationCode.Should().Be("DCC001");

            sut = new NwsWrapper();

            sut.Should().NotBeNull();
            sut.Should().BeOfType<NwsWrapper>();
            sut.HttpClient.Should().NotBeNull();
            sut.HttpClient.DefaultRequestHeaders.Count().Should().BeGreaterThan(1);
            sut.LocationCode.Should().Be("DCC001");

            sut = new NwsWrapper("DCC001");

            sut.Should().NotBeNull();
            sut.Should().BeOfType<NwsWrapper>();
            sut.HttpClient.Should().NotBeNull();
            sut.HttpClient.DefaultRequestHeaders.Count().Should().BeGreaterThan(1);
            sut.LocationCode.Should().Be("DCC001");
        }

        [TestMethod]
        public async Task NwsWrapper_GetActiveAlertsAsync_ShouldSucceed()
        {
            var sut = new NwsWrapper(string.Empty);

            var results = await sut.GetActiveAlertsAsync();

            results.Should().NotBeNull();
        }

        [TestMethod]
        public async Task NwsWrapper_GetActiveAlertsAsync_Targeted_ShouldSucceed()
        {
            var sut = new NwsWrapper("LAC105");

            var results = await sut.GetActiveAlertsAsync();

            results.Should().NotBeNull();
        }

        [TestMethod]
        public async Task NwsWrapper_GetHistoricAlertsAsync_ShouldSucceed()
        {
            var sut = new NwsWrapper(string.Empty);

            var results = await sut.GetHistoricAlertsAsync();

            results.Should().NotBeNull();
        }

        [TestMethod]
        public async Task NwsWrapper_GetHistoricAlertsAsync_Targeted_ShouldSucceed()
        {
            var sut = new NwsWrapper("LAC105");

            var results = await sut.GetHistoricAlertsAsync();

            results.Should().NotBeNull();
        }
    }
}