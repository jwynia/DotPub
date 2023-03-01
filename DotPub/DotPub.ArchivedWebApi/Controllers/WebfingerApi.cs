using System.Text.Json;
using DotPub.ArchivedWebApi.Attributes;
using DotPub.DataContracts.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DotPub.ArchivedWebApi.Controllers
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
        public virtual ActionResult<WellKnownResponse> WebfingerGet()
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
        
        /// <summary>
        /// Handles lookups for authentication endpoints.
        /// </summary>
        /// <response code="200"></response>
        [HttpGet]
        [Route("//.well-known/openid-configuration")]
        [ValidateModelState]
        [SwaggerOperation("OpenIDConfigurationGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(WellKnownResponse), description: "")]
        public virtual IActionResult OpenIDConfigurationGet()
        { 
            //https://openid.net/specs/openid-connect-discovery-1_0.html#ProviderMetadata
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
        
        //see also .well-known/oauth-authorization-server
    }
}
