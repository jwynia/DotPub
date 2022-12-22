using System.Text.Json;
using DotPub.DataContracts.Models;
using DotPub.WebApi.Attributes;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DotPub.WebApi.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class WebfingerApiController : ControllerBase
    { 
        /// <summary>
        /// Handles webfinger account lookup requests.
        /// </summary>
        /// <remarks>For example, a GET to &#x60;https://goblin.technology/.well-known/webfinger?resource&#x3D;acct:tobi@goblin.technology&#x60; would return:  &#x60;&#x60;&#x60;  {\&quot;subject\&quot;:\&quot;acct:tobi@goblin.technology\&quot;,\&quot;aliases\&quot;:[\&quot;https://goblin.technology/users/tobi\&quot;,\&quot;https://goblin.technology/@tobi\&quot;],\&quot;links\&quot;:[{\&quot;rel\&quot;:\&quot;http://webfinger.net/rel/profile-page\&quot;,\&quot;type\&quot;:\&quot;text/html\&quot;,\&quot;href\&quot;:\&quot;https://goblin.technology/@tobi\&quot;},{\&quot;rel\&quot;:\&quot;self\&quot;,\&quot;type\&quot;:\&quot;application/activity+json\&quot;,\&quot;href\&quot;:\&quot;https://goblin.technology/users/tobi\&quot;}]}  &#x60;&#x60;&#x60;  See: https://webfinger.net/</remarks>
        /// <response code="200"></response>
        [HttpGet]
        [Route("//.well-known/webfinger")]
        [ValidateModelState]
        [SwaggerOperation("WebfingerGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(WellKnownResponse), description: "")]
        public virtual IActionResult WebfingerGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(WellKnownResponse));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize<WellKnownResponse>(exampleJson)
            : default(WellKnownResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
