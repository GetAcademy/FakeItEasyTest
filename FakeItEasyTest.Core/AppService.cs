using System.Linq;

namespace FakeItEasyTest.Core
{
    public class AppService
    {
        private readonly IIssueService _issueService;

        public AppService(IIssueService issueService)
        {
            _issueService = issueService;
        }

        public int CountIssuesStartingWithA()
        {
            var issues = _issueService.GetAllData();
            return issues.Count(i => i.Name.StartsWith("A"));
        }
    }
}
