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
    public class NodeinfoApiController : ControllerBase
    {
        /// <summary>
        /// Returns a compliant nodeinfo response to node info queries.
        /// </summary>
        /// <remarks>See: https://nodeinfo.diaspora.software/schema.html</remarks>
        /// <response code="200"></response>
        [HttpGet]
        [Route("//nodeinfo/2.0")]
        [ValidateModelState]
        [SwaggerOperation("NodeInfoGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Nodeinfo), description: "")]
        public virtual IActionResult NodeInfoGet()
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Nodeinfo));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";

            var example = exampleJson != null
                ? JsonSerializer.Deserialize<Nodeinfo>(exampleJson)
                : default(Nodeinfo);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Directs callers to /nodeinfo/2.0.
        /// </summary>
        /// <remarks>eg. &#x60;{\&quot;links\&quot;:[{\&quot;rel\&quot;:\&quot;http://nodeinfo.diaspora.software/ns/schema/2.0\&quot;,\&quot;href\&quot;:\&quot;http://example.org/nodeinfo/2.0\&quot;}]}&#x60; See: https://nodeinfo.diaspora.software/protocol.html</remarks>
        /// <response code="200"></response>
        [HttpGet]
        [Route("//.well-known/nodeinfo")]
        [ValidateModelState]
        [SwaggerOperation("NodeInfoWellKnownGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(WellKnownResponse), description: "")]
        public virtual IActionResult NodeInfoWellKnownGet()
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