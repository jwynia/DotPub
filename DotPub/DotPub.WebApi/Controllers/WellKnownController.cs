using DotPub.DataContracts.WebFinger;
using Microsoft.AspNetCore.Mvc;

namespace DotPub.WebApi.Controllers;

[ApiController]
[Route(".well-known")]
public class WellKnownController : ControllerBase
{
    private readonly IWebFingerService _webFingerService;

    public WellKnownController(IWebFingerService webFingerService)
    {
        _webFingerService = webFingerService ?? throw new ArgumentNullException(nameof(webFingerService));
    }
    [HttpGet("webfinger")]
    public IActionResult WebFinger(string resource)
    {
        if (!resource.StartsWith("acct:")) return Unauthorized();

        var username = resource.Split(':')[1].Split('@');
        WebFingerRecord webFingerRecord = _webFingerService.GetRecordBySubjectOrAlias(username);
        return Content("", "application/jrd+json");
    }
}