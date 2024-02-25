//-----------------------------------------------------------------------
// <copyright file="ApodWrapperTests.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.Tests.NASA
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ApodWrapperTests
    {
        [TestMethod]
        public void ApodWrapper_ctor()
        {
            var sut = new ApodWrapper(string.Empty);

            sut.Should().NotBeNull();
            sut.ApiKey.Should().NotBeNullOrWhiteSpace();
            sut.ApiKey.Should().Be("DEMO_KEY");
            sut.HttpClient.Should().NotBeNull();
            sut.HttpClient.DefaultRequestVersion.Should().Be(HttpVersion.Version20);
            sut.HttpClient.DefaultRequestHeaders.Accept.FirstOrDefault()?.MediaType.Should().Be("application/json");

            sut = new ApodWrapper("science");

            sut.Should().NotBeNull();
            sut.ApiKey.Should().NotBeNullOrWhiteSpace();
            sut.ApiKey.Should().Be("science");
            sut.HttpClient.Should().NotBeNull();
            sut.HttpClient.DefaultRequestVersion.Should().Be(HttpVersion.Version20);
            sut.HttpClient.DefaultRequestHeaders.Accept.FirstOrDefault()?.MediaType.Should().Be("application/json");
        }

        [TestMethod]
        public async Task ApodWrapper_GetTheAstronomyPictureOfTheDayAsync_ShouldSucceed()
        {

            var sut = new ApodWrapper(string.Empty);

            var result = await sut.GetTheAstronomyPictureOfTheDayAsync();

            result.Should().NotBeNull();
            result.Date.Should().NotBeNullOrWhiteSpace();
            result.Title.Should().NotBeNullOrWhiteSpace();
            result.Url.Should().NotBeNullOrWhiteSpace();
            result.Resource.Should().NotBeNull();
            result.Resource.Should().BeOfType<Resource>();
            var resource = result.Resource;
            resource.Planet.Should().NotBeNull();
            resource.ImageSet.Should().NotBeNull();
            result.HdUrl.Should().NotBeNullOrWhiteSpace();
            result.Concepts.Should().NotBeNull();
            var concepts = result.Concepts;
            concepts._0.Should().NotBeNull();
            concepts._1.Should().NotBeNull();
            concepts._2.Should().NotBeNull();
            concepts._3.Should().NotBeNull();
            concepts._4.Should().NotBeNull();
            concepts._5.Should().NotBeNull();
            concepts._6.Should().NotBeNull();
            concepts._7.Should().NotBeNull();
            result.Copyright.Should().NotBeNull();
            result.Explanation.Should().NotBeNullOrWhiteSpace();
            result.ServiceVersion.Should().NotBeNullOrWhiteSpace();
        }
    }
}