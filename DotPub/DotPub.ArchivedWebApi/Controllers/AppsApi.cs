using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using DotPub.ArchivedWebApi.Attributes;
using DotPub.DataContracts.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DotPub.ArchivedWebApi.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [Authorize]
    [ApiController]
    public class AppsApiController : ControllerBase
    { 
        /// <summary>
        /// Register a new application on this instance.
        /// </summary>
        /// <remarks>The registered application can be used to obtain an application token. This can then be used to register a new account, or (through user auth) obtain an access token.  The parameters can also be given in the body of the request, as JSON, if the content-type is set to &#39;application/json&#39;. The parameters can also be given in the body of the request, as XML, if the content-type is set to &#39;application/xml&#39;.</remarks>
        /// <param name="clientName">The name of the application.</param>
        /// <param name="redirectUris">Where the user should be redirected after authorization.  To display the authorization code to the user instead of redirecting to a web page, use &#x60;urn:ietf:wg:oauth:2.0:oob&#x60; in this parameter.</param>
        /// <param name="scopes">Space separated list of scopes.  If no scopes are provided, defaults to &#x60;read&#x60;.</param>
        /// <param name="website">A URL to the web page of the app (optional).</param>
        /// <response code="200">The newly-created application.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/apps")]
        [ValidateModelState]
        [SwaggerOperation("AppCreate")]
        [SwaggerResponse(statusCode: 200, type: typeof(Application), description: "The newly-created application.")]
        public virtual IActionResult AppCreate([FromForm][Required()]string clientName, [FromForm][Required()]string redirectUris, [FromForm]string scopes, [FromForm]string website)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Application));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 406 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(406);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize <Application>(exampleJson)
            : default(Application);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
