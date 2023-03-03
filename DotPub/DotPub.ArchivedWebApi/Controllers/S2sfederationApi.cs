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
    public class S2sfederationApiController : ControllerBase
    {
        /// <summary>
        /// Get the public outbox collection for an actor.
        /// </summary>
        /// <remarks>Note that the response will be a Collection with a page as &#x60;first&#x60;, as shown below, if &#x60;page&#x60; is &#x60;false&#x60;.  If &#x60;page&#x60; is &#x60;true&#x60;, then the response will be a single &#x60;CollectionPage&#x60; without the wrapping &#x60;Collection&#x60;.  HTTP signature is required on the request.</remarks>
        /// <param name="username">Username of the account.</param>
        /// <param name="page">Return response as a CollectionPage.</param>
        /// <param name="minId">Minimum ID of the next status, used for paging.</param>
        /// <param name="maxId">Maximum ID of the next status, used for paging.</param>
        /// <response code="200"></response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        [HttpGet]
        [Route("//users/{username}/outbox")]
        [ValidateModelState]
        [SwaggerOperation("S2sOutboxGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(SwaggerCollection), description: "")]
        public virtual IActionResult S2sOutboxGet([FromRoute] [Required] string username, [FromQuery] bool? page,
            [FromQuery] string minId, [FromQuery] string maxId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SwaggerCollection));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "";

            var example = exampleJson != null
                ? JsonSerializer.Deserialize<SwaggerCollection>(exampleJson)
                : default(SwaggerCollection);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get the replies collection for a status.
        /// </summary>
        /// <remarks>Note that the response will be a Collection with a page as &#x60;first&#x60;, as shown below, if &#x60;page&#x60; is &#x60;false&#x60;.  If &#x60;page&#x60; is &#x60;true&#x60;, then the response will be a single &#x60;CollectionPage&#x60; without the wrapping &#x60;Collection&#x60;.  HTTP signature is required on the request.</remarks>
        /// <param name="username">Username of the account.</param>
        /// <param name="status">ID of the status.</param>
        /// <param name="page">Return response as a CollectionPage.</param>
        /// <param name="onlyOtherAccounts">Return replies only from accounts other than the status owner.</param>
        /// <param name="minId">Minimum ID of the next status, used for paging.</param>
        /// <response code="200"></response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        [HttpGet]
        [Route("//users/{username}/statuses/{status}/replies")]
        [ValidateModelState]
        [SwaggerOperation("S2sRepliesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(SwaggerCollection), description: "")]
        public virtual IActionResult S2sRepliesGet([FromRoute] [Required] string username,
            [FromRoute] [Required] string status, [FromQuery] bool? page, [FromQuery] bool? onlyOtherAccounts,
            [FromQuery] string minId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SwaggerCollection));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "";

            var example = exampleJson != null
                ? JsonSerializer.Deserialize<SwaggerCollection>(exampleJson)
                : default(SwaggerCollection);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}