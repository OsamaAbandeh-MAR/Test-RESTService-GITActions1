using Xunit;
using CustomerSearch.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CustomerSearch.Tests
{
    public class CustomerControllerTests
    {
        [Fact]
        public void SearchCustomer_ReturnsOk()
        {
            // Arrange
            var controller = new CustomerController();

            // Act
            var result = controller.SearchCustomer();

            // Assert
            Assert.IsType<OkObjectResult>(result); // Check if the result is of type OkObjectResult
        }
    }
}
