using System.Text.Json;
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

    [HttpGet("webfinger/{resource}")]
    public ActionResult<WebFingerRecord> WebFinger(string resource)
    {
        if (!resource.StartsWith("acct:")) return Unauthorized();
        var serializeOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };
        var username = resource.Split(':')[1];
        var webFingerRecord = _webFingerService.GetRecordBySubjectOrAlias(username);
        var result = new ContentResult();
        result.ContentType = "application/jrd+json";
        result.Content = JsonSerializer.Serialize(webFingerRecord,serializeOptions);
        return result;
    }

    [HttpGet("nodeinfo")]
    public ActionResult<NodeInfoRecord> NodeInfo()
    {
        return new JsonResult(_webFingerService.GetNodeInfo());
    }
}