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
    public class NotificationsApiController : ControllerBase
    {
        /// <summary>
        /// Clear/delete all notifications for currently authorized user.
        /// </summary>
        /// <remarks>Will return an empty object &#x60;{}&#x60; to indicate success.</remarks>
        /// <response code="200"></response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/notifications")]
        [ValidateModelState]
        [SwaggerOperation("ClearNotifications")]
        [SwaggerResponse(statusCode: 200, type: typeof(Object), description: "")]
        public virtual IActionResult ClearNotifications()
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Object));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 406 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(406);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            string exampleJson = null;
            exampleJson = "{\n  \"bytes\": [\n    123,\n    125\n  ],\n  \"empty\": false\n}";

            var example = exampleJson != null
                ? JsonSerializer.Deserialize<Object>(exampleJson)
                : default(Object);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get notifications for currently authorized user.
        /// </summary>
        /// <remarks>The notifications will be returned in descending chronological order (newest first), with sequential IDs (bigger &#x3D; newer).  The next and previous queries can be parsed from the returned Link header. Example:  &#x60;&#x60;&#x60; &lt;https://example.org/api/v1/notifications?limit&#x3D;80&amp;max_id&#x3D;01FC0SKA48HNSVR6YKZCQGS2V8&gt;; rel&#x3D;\&quot;next\&quot;, &lt;https://example.org/api/v1/notifications?limit&#x3D;80&amp;since_id&#x3D;01FC0SKW5JK2Q4EVAV2B462YY0&gt;; rel&#x3D;\&quot;prev\&quot; &#x60;&#x60;&#x60;&#x60;</remarks>
        /// <param name="limit">Number of notifications to return.</param>
        /// <param name="excludeTypes"></param>
        /// <param name="maxId">Return only notifications *OLDER* than the given max status ID. The status with the specified ID will not be included in the response.</param>
        /// <param name="sinceId">Return only notifications *NEWER* than the given since status ID. The status with the specified ID will not be included in the response.</param>
        /// <response code="200">Array of notifications.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/notifications")]
        [ValidateModelState]
        [SwaggerOperation("Notifications")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Notification>), description: "Array of notifications.")]
        public virtual IActionResult Notifications([FromQuery] int? limit, [FromQuery] List<string> excludeTypes,
            [FromQuery] string maxId, [FromQuery] string sinceId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Notification>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 406 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(406);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            string exampleJson = null;
            exampleJson = "{}";

            var example = exampleJson != null
                ? JsonSerializer.Deserialize<List<Notification>>(exampleJson)
                : default(List<Notification>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}