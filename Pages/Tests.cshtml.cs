
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DotNet.Pages
{
    public class TestsModel : PageModel
    {
        private readonly ILogger<TestsModel> _logger;

        public TestsModel(ILogger<TestsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
