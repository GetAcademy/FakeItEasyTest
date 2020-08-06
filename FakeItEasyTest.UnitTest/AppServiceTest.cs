using System;
using FakeItEasy;
using FakeItEasyTest.Core;
using Xunit;

namespace FakeItEasyTest.UnitTest
{
    public class AppServiceTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var issueService = A.Fake<IIssueService>();
            var testIssues = new[]
            {
                new Issue {Name = "Aaa"},
                new Issue {Name = "Bbb"},
            };
            A.CallTo(() => issueService.GetAllData())
                .Returns(testIssues);

            // Act
            var appService = new AppService(issueService);
            var count= appService.CountIssuesStartingWithA();

            // Assert
            Assert.Equal(1, count);
        }
    }
}
