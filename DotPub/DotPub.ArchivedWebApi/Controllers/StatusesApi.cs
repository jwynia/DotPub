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
    public class StatusesApiController : ControllerBase
    { 
        /// <summary>
        /// Bookmark status with the given ID.
        /// </summary>
        
        /// <param name="id">Target status ID.</param>
        /// <response code="200">The status.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/statuses/{id}/bookmark")]
        [ValidateModelState]
        [SwaggerOperation("StatusBookmark")]
        [SwaggerResponse(statusCode: 200, type: typeof(Status), description: "The status.")]
        public virtual IActionResult StatusBookmark([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Status));

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
            ? JsonSerializer.Deserialize<Status>(exampleJson)
            : default(Status);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// View accounts that have reblogged/boosted the target status.
        /// </summary>
        
        /// <param name="id">Target status ID.</param>
        /// <response code="200"></response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        [HttpGet]
        [Route("//api/v1/statuses/{id}/reblogged_by")]
        [ValidateModelState]
        [SwaggerOperation("StatusBoostedBy")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Account>), description: "")]
        public virtual IActionResult StatusBoostedBy([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Account>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "{}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize<List<Account>>(exampleJson)
            : default(List<Account>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Return ancestors and descendants of the given status.
        /// </summary>
        /// <remarks>The returned statuses will be ordered in a thread structure, so they are suitable to be displayed in the order in which they were returned.</remarks>
        /// <param name="id">Target status ID.</param>
        /// <response code="200">Status context object.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/statuses/{id}/context")]
        [ValidateModelState]
        [SwaggerOperation("StatusContext")]
        [SwaggerResponse(statusCode: 200, type: typeof(StatusContext), description: "Status context object.")]
        public virtual IActionResult StatusContext([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(StatusContext));

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
            ? JsonSerializer.Deserialize<StatusContext>(exampleJson)
            : default(StatusContext);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create a new status.
        /// </summary>
        /// <remarks>The parameters can also be given in the body of the request, as JSON, if the content-type is set to &#39;application/json&#39;. The parameters can also be given in the body of the request, as XML, if the content-type is set to &#39;application/xml&#39;.</remarks>
        /// <param name="status">Text content of the status. If media_ids is provided, this becomes optional. Attaching a poll is optional while status is provided.</param>
        /// <param name="mediaIds">Array of Attachment ids to be attached as media. If provided, status becomes optional, and poll cannot be used.  If the status is being submitted as a form, the key is &#39;media_ids[]&#39;, but if it&#39;s json or xml, the key is &#39;media_ids&#39;.</param>
        /// <param name="inReplyToId">ID of the status being replied to, if status is a reply.</param>
        /// <param name="sensitive">Status and attached media should be marked as sensitive.</param>
        /// <param name="spoilerText">Text to be shown as a warning or subject before the actual content. Statuses are generally collapsed behind this field.</param>
        /// <param name="visibility">Visibility of the posted status.</param>
        /// <param name="scheduledAt">ISO 8601 Datetime at which to schedule a status. Providing this parameter will cause ScheduledStatus to be returned instead of Status. Must be at least 5 minutes in the future.</param>
        /// <param name="language">ISO 639 language code for this status.</param>
        /// <param name="format">Format to use when parsing this status.</param>
        /// <param name="federated">This status will be federated beyond the local timeline(s).</param>
        /// <param name="boostable">This status can be boosted/reblogged.</param>
        /// <param name="replyable">This status can be replied to.</param>
        /// <param name="likeable">This status can be liked/faved.</param>
        /// <response code="200">The newly created status.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/statuses")]
        [ValidateModelState]
        [SwaggerOperation("StatusCreate")]
        [SwaggerResponse(statusCode: 200, type: typeof(Status), description: "The newly created status.")]
        public virtual IActionResult StatusCreate([FromForm]string status, [FromForm]List<string> mediaIds, [FromForm]string inReplyToId, [FromForm]bool? sensitive, [FromForm]string spoilerText, [FromForm]string visibility, [FromForm]string scheduledAt, [FromForm]string language, [FromForm]string format, [FromQuery]bool? federated, [FromQuery]bool? boostable, [FromQuery]bool? replyable, [FromQuery]bool? likeable)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Status));

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
            ? JsonSerializer.Deserialize<Status>(exampleJson)
            : default(Status);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Delete status with the given ID. The status must belong to you.
        /// </summary>
        /// <remarks>The deleted status will be returned in the response. The &#x60;text&#x60; field will contain the original text of the status as it was submitted. This is useful when doing a &#39;delete and redraft&#39; type operation.</remarks>
        /// <param name="id">Target status ID.</param>
        /// <response code="200">The status that was just deleted.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpDelete]
        [Route("//api/v1/statuses/{id}")]
        [ValidateModelState]
        [SwaggerOperation("StatusDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(Status), description: "The status that was just deleted.")]
        public virtual IActionResult StatusDelete([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Status));

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
            ? JsonSerializer.Deserialize<Status>(exampleJson)
            : default(Status);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Star/like/favourite the given status, if permitted.
        /// </summary>
        
        /// <param name="id">Target status ID.</param>
        /// <response code="200">The newly faved status.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/statuses/{id}/favourite")]
        [ValidateModelState]
        [SwaggerOperation("StatusFave")]
        [SwaggerResponse(statusCode: 200, type: typeof(Status), description: "The newly faved status.")]
        public virtual IActionResult StatusFave([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Status));

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
            ? JsonSerializer.Deserialize<Status>(exampleJson)
            : default(Status);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// View accounts that have faved/starred/liked the target status.
        /// </summary>
        
        /// <param name="id">Target status ID.</param>
        /// <response code="200"></response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/statuses/{id}/favourited_by")]
        [ValidateModelState]
        [SwaggerOperation("StatusFavedBy")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Account>), description: "")]
        public virtual IActionResult StatusFavedBy([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Account>));

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
            exampleJson = "{}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize<List<Account>>(exampleJson)
            : default(List<Account>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// View status with the given ID.
        /// </summary>
        
        /// <param name="id">Target status ID.</param>
        /// <response code="200">The requested status.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/statuses/{id}")]
        [ValidateModelState]
        [SwaggerOperation("StatusGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Status), description: "The requested status.")]
        public virtual IActionResult StatusGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Status));

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
            ? JsonSerializer.Deserialize<Status>(exampleJson)
            : default(Status);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Reblog/boost status with the given ID.
        /// </summary>
        /// <remarks>If the target status is rebloggable/boostable, it will be shared with your followers. This is equivalent to an ActivityPub &#39;Announce&#39; activity.</remarks>
        /// <param name="id">Target status ID.</param>
        /// <response code="200">The boost of the status.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/statuses/{id}/reblog")]
        [ValidateModelState]
        [SwaggerOperation("StatusReblog")]
        [SwaggerResponse(statusCode: 200, type: typeof(Status), description: "The boost of the status.")]
        public virtual IActionResult StatusReblog([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Status));

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
            ? JsonSerializer.Deserialize<Status>(exampleJson)
            : default(Status);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Unbookmark status with the given ID.
        /// </summary>
        
        /// <param name="id">Target status ID.</param>
        /// <response code="200">The status.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/statuses/{id}/unbookmark")]
        [ValidateModelState]
        [SwaggerOperation("StatusUnbookmark")]
        [SwaggerResponse(statusCode: 200, type: typeof(Status), description: "The status.")]
        public virtual IActionResult StatusUnbookmark([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Status));

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
            ? JsonSerializer.Deserialize<Status>(exampleJson)
            : default(Status);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Unstar/unlike/unfavourite the given status.
        /// </summary>
        
        /// <param name="id">Target status ID.</param>
        /// <response code="200">The unfaved status.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/statuses/{id}/unfavourite")]
        [ValidateModelState]
        [SwaggerOperation("StatusUnfave")]
        [SwaggerResponse(statusCode: 200, type: typeof(Status), description: "The unfaved status.")]
        public virtual IActionResult StatusUnfave([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Status));

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
            ? JsonSerializer.Deserialize<Status>(exampleJson)
            : default(Status);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Unreblog/unboost status with the given ID.
        /// </summary>
        
        /// <param name="id">Target status ID.</param>
        /// <response code="200">The unboosted status.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/statuses/{id}/unreblog")]
        [ValidateModelState]
        [SwaggerOperation("StatusUnreblog")]
        [SwaggerResponse(statusCode: 200, type: typeof(Status), description: "The unboosted status.")]
        public virtual IActionResult StatusUnreblog([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Status));

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
            ? JsonSerializer.Deserialize<Status>(exampleJson)
            : default(Status);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
