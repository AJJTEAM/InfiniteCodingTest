using System.Collections.Generic;
using InfinitePeopleApi.Controllers;
using InfinitePeopleApi.Models;
using InfinitePeopleApi.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace InfinitePeopleApi.Tests
{
    public class PersonControllerTest
    {
        private readonly Mock<IPersonService> _mockPersonService;

        public PersonControllerTest()
        {
            _mockPersonService = new Mock<IPersonService>();
        }
        [Fact]
        public void Should_Return_Success_When_Called()
        {
            _mockPersonService.Setup(_ => _.Get()).Returns(new List<People>()
            {
                new People {GivenName = "John", FamilyName = "Smith", Age = 20, Address = "33 test street"}
            });
            var sut = new PersonController(_mockPersonService.Object);
            var result = sut.Get();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.Equal(200, okResult.StatusCode);
        }
    }
}
