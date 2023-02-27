using Microsoft.AspNetCore.Mvc;

namespace study_group.Controllers;

[ApiController]
[Route("magic-numbers")] // api enpoint name

public class NewNumbersController
{
    [HttpGet]
    public IEnumerable<int> HelloNumbers(int aNumber)
    {
        return new[] { 9,9,9,9,9 };
    }
}