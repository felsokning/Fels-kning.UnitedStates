//-----------------------------------------------------------------------
// <copyright file="AstronomyPictureOfTheDayTests.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.UnitedStates.Tests.NASA
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class AstronomyPictureOfTheDayTests
    {
        [TestMethod]
        public void APOD_ctor()
        {
            var sut = new AstronomyPictureOfTheDay
            {
                Concepts = new Concepts
                {
                    _0 = "Science",
                    _1 = "Science",
                    _2 = "Science",
                    _3 = "Science",
                    _4 = "Science",
                    _5 = "Science",
                    _6 = "Science",
                    _7 = "Science",

                },
                ConceptTags = true,
                Copyright = "Copyright © 2023",
                Date = DateTime.UtcNow.ToString(),
                Explanation = "For Science!",
                HdUrl = "https://www.nasa.gov.co.uk.de/hdurls/image0.png",
                Resource = new Resource
                {
                    ImageSet = "https://www.nasa.gov.co.uk.de/imageset/science/",
                    Planet = "Pluto"
                },
                ServiceVersion = "2.0",
                ThumbnailUrl = string.Empty,
                Title = "Testing for Science",
                Url = "https://www.nasa.gov.co.uk.de/urls/testingForScience.html.htx"
            };

            sut.Should().NotBeNull();
            sut.Concepts.Should().NotBeNull();
            sut.Concepts.Should().BeOfType<Concepts>();
            var concepts = sut.Concepts;
            concepts._0.Should().NotBeNull();
            concepts._0.Should().Be("Science");
            concepts._1.Should().NotBeNull();
            concepts._1.Should().Be("Science");
            concepts._2.Should().NotBeNull();
            concepts._2.Should().Be("Science");
            concepts._3.Should().NotBeNull();
            concepts._3.Should().Be("Science");
            concepts._4.Should().NotBeNull();
            concepts._4.Should().Be("Science");
            concepts._5.Should().NotBeNull();
            concepts._5.Should().Be("Science");
            concepts._6.Should().NotBeNull();
            concepts._6.Should().Be("Science");
            concepts._7.Should().NotBeNull();
            concepts._7.Should().Be("Science");
            sut.ConceptTags.Should().Be(true);
            sut.Copyright.Should().NotBeNullOrWhiteSpace();
            sut.Copyright.Should().Be("Copyright © 2023");
            sut.Date.Should().NotBeNullOrWhiteSpace();
            sut.Explanation.Should().NotBeNullOrWhiteSpace();
            sut.Explanation.Should().Be("For Science!");
            sut.HdUrl.Should().NotBeNullOrWhiteSpace();
            sut.HdUrl.Should().Be("https://www.nasa.gov.co.uk.de/hdurls/image0.png");
            var resource = sut.Resource;
            resource.Should().NotBeNull();
            resource.ImageSet.Should().NotBeNullOrWhiteSpace();
            resource.ImageSet.Should().Be("https://www.nasa.gov.co.uk.de/imageset/science/");
            resource.Planet.Should().NotBeNullOrWhiteSpace();
            resource.Planet.Should().Be("Pluto");
            sut.ServiceVersion.Should().NotBeNullOrWhiteSpace();
            sut.ServiceVersion.Should().Be("2.0");
            sut.ThumbnailUrl.Should().BeNullOrWhiteSpace();
            sut.Title.Should().NotBeNullOrWhiteSpace();
            sut.Title.Should().Be("Testing for Science");
            sut.Url.Should().NotBeNullOrWhiteSpace();
            sut.Url.Should().Be("https://www.nasa.gov.co.uk.de/urls/testingForScience.html.htx");
        }
    }
}