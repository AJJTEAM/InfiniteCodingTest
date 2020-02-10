using InfiniteFrontEndApi.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InfiniteFrontEndApi.Controllers;
using InfiniteFrontEndApi.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace InfiniteFrontEndApi.Tests
{
    public class PersonControllerTests
    {
        private readonly Mock<IPersonService> _mockPersonService;

        public PersonControllerTests()
        {
            _mockPersonService = new Mock<IPersonService>();
        }
        [Fact]
        public async  Task Should_Return_Success_When_Called()
        {
            _mockPersonService.Setup(_ => _.GetAsync()).ReturnsAsync(new List<People>()
            {
                new People {FirstName = "John", LastName = "Smith", Age = 20, Address = "33 test street"}
            });
            var sut = new PersonController(_mockPersonService.Object);
            var result = await sut.Get();
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.Equal(200, okResult.StatusCode);
        }
    }
}
