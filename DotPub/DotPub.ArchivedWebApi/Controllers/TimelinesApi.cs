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
    public class TimelinesApiController : ControllerBase
    {
        /// <summary>
        /// See statuses/posts by accounts you follow.
        /// </summary>
        /// <remarks>The statuses will be returned in descending chronological order (newest first), with sequential IDs (bigger &#x3D; newer).  The returned Link header can be used to generate the previous and next queries when scrolling up or down a timeline.  Example:  &#x60;&#x60;&#x60; &lt;https://example.org/api/v1/timelines/home?limit&#x3D;20&amp;max_id&#x3D;01FC3GSQ8A3MMJ43BPZSGEG29M&gt;; rel&#x3D;\&quot;next\&quot;, &lt;https://example.org/api/v1/timelines/home?limit&#x3D;20&amp;min_id&#x3D;01FC3KJW2GYXSDDRA6RWNDM46M&gt;; rel&#x3D;\&quot;prev\&quot; &#x60;&#x60;&#x60;&#x60;</remarks>
        /// <param name="maxId">Return only statuses *OLDER* than the given max status ID. The status with the specified ID will not be included in the response.</param>
        /// <param name="sinceId">Return only statuses *NEWER* than the given since status ID. The status with the specified ID will not be included in the response.</param>
        /// <param name="minId">Return only statuses *NEWER* than the given since status ID. The status with the specified ID will not be included in the response.</param>
        /// <param name="limit">Number of statuses to return.</param>
        /// <param name="local">Show only statuses posted by local accounts.</param>
        /// <response code="200">Array of statuses.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        [HttpGet]
        [Route("//api/v1/timelines/home")]
        [ValidateModelState]
        [SwaggerOperation("HomeTimeline")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Status>), description: "Array of statuses.")]
        public virtual IActionResult HomeTimeline([FromQuery] string maxId, [FromQuery] string sinceId,
            [FromQuery] string minId, [FromQuery] int? limit, [FromQuery] bool? local)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Status>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{}";

            var example = exampleJson != null
                ? JsonSerializer.Deserialize<List<Status>>(exampleJson)
                : default(List<Status>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// See public statuses/posts that your instance is aware of.
        /// </summary>
        /// <remarks>The statuses will be returned in descending chronological order (newest first), with sequential IDs (bigger &#x3D; newer).  The returned Link header can be used to generate the previous and next queries when scrolling up or down a timeline.  Example:  &#x60;&#x60;&#x60; &lt;https://example.org/api/v1/timelines/public?limit&#x3D;20&amp;max_id&#x3D;01FC3GSQ8A3MMJ43BPZSGEG29M&gt;; rel&#x3D;\&quot;next\&quot;, &lt;https://example.org/api/v1/timelines/public?limit&#x3D;20&amp;min_id&#x3D;01FC3KJW2GYXSDDRA6RWNDM46M&gt;; rel&#x3D;\&quot;prev\&quot; &#x60;&#x60;&#x60;&#x60;</remarks>
        /// <param name="maxId">Return only statuses *OLDER* than the given max status ID. The status with the specified ID will not be included in the response.</param>
        /// <param name="sinceId">Return only statuses *NEWER* than the given since status ID. The status with the specified ID will not be included in the response.</param>
        /// <param name="minId">Return only statuses *NEWER* than the given since status ID. The status with the specified ID will not be included in the response.</param>
        /// <param name="limit">Number of statuses to return.</param>
        /// <param name="local">Show only statuses posted by local accounts.</param>
        /// <response code="200">Array of statuses.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        [HttpGet]
        [Route("//api/v1/timelines/public")]
        [ValidateModelState]
        [SwaggerOperation("PublicTimeline")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Status>), description: "Array of statuses.")]
        public virtual IActionResult PublicTimeline([FromQuery] string maxId, [FromQuery] string sinceId,
            [FromQuery] string minId, [FromQuery] int? limit, [FromQuery] bool? local)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Status>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{}";

            var example = exampleJson != null
                ? JsonSerializer.Deserialize<List<Status>>(exampleJson)
                : default(List<Status>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}