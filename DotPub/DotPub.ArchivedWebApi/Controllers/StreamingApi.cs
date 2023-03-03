using System.ComponentModel.DataAnnotations;
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
    public class StreamingApiController : ControllerBase
    {
        /// <summary>
        /// Initiate a websocket connection for live streaming of statuses and notifications.
        /// </summary>
        /// <remarks>The scheme used should *always* be &#x60;wss&#x60;. The streaming basepath can be viewed at &#x60;/api/v1/instance&#x60;.  On a successful connection, a code &#x60;101&#x60; will be returned, which indicates that the connection is being upgraded to a secure websocket connection.  As long as the connection is open, various message types will be streamed into it.  GoToSocial will ping the connection every 30 seconds to check whether the client is still receiving.  If the ping fails, or something else goes wrong during transmission, then the connection will be dropped, and the client will be expected to start it again.</remarks>
        /// <param name="accessToken">Access token for the requesting account.</param>
        /// <param name="stream">Type of stream to request.  Options are:  &#x60;user&#x60;: receive updates for the account&#39;s home timeline. &#x60;public&#x60;: receive updates for the public timeline. &#x60;public:local&#x60;: receive updates for the local timeline. &#x60;hashtag&#x60;: receive updates for a given hashtag. &#x60;hashtag:local&#x60;: receive local updates for a given hashtag. &#x60;list&#x60;: receive updates for a certain list of accounts. &#x60;direct&#x60;: receive updates for direct messages.</param>
        /// <response code="101"></response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        [HttpGet]
        [Route("//api/v1/streaming")]
        [ValidateModelState]
        [SwaggerOperation("StreamGet")]
        [SwaggerResponse(statusCode: 101, type: typeof(InlineResponse101), description: "")]
        public virtual IActionResult StreamGet([FromQuery] [Required()] string accessToken,
            [FromQuery] [Required()] string stream)
        {
            //TODO: Uncomment the next line to return response 101 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(101, default(InlineResponse101));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);


            throw new NotImplementedException();
        }
    }
}