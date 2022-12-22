using System.ComponentModel.DataAnnotations;
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
    public class FollowRequestsApiController : ControllerBase
    { 
        /// <summary>
        /// Accept/authorize follow request from the given account ID.
        /// </summary>
        /// <remarks>Accept a follow request and put the requesting account in your &#39;followers&#39; list.</remarks>
        /// <param name="accountId">ID of the account requesting to follow you.</param>
        /// <response code="200">Your relationship to this account.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/follow_requests/{account_id}/authorize")]
        [ValidateModelState]
        [SwaggerOperation("AuthorizeFollowRequest")]
        [SwaggerResponse(statusCode: 200, type: typeof(AccountRelationship), description: "Your relationship to this account.")]
        public virtual IActionResult AuthorizeFollowRequest([FromRoute][Required]string accountId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AccountRelationship));

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
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize<AccountRelationship>(exampleJson)
            : default(AccountRelationship);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get an array of accounts that have requested to follow you.
        /// </summary>
        /// <remarks>Accounts will be sorted in order of follow request date descending (newest first).</remarks>
        /// <param name="limit">Number of accounts to return.</param>
        /// <response code="200"></response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/follow_requests")]
        [ValidateModelState]
        [SwaggerOperation("GetFollowRequests")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Account>), description: "")]
        public virtual IActionResult GetFollowRequests([FromQuery]int? limit)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Account>));

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
            ? JsonSerializer.Deserialize<List<Account>>(exampleJson)
            : default(List<Account>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Reject/deny follow request from the given account ID.
        /// </summary>
        
        /// <param name="accountId">ID of the account requesting to follow you.</param>
        /// <response code="200">Your relationship to this account.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/follow_requests/{account_id}/reject")]
        [ValidateModelState]
        [SwaggerOperation("RejectFollowRequest")]
        [SwaggerResponse(statusCode: 200, type: typeof(AccountRelationship), description: "Your relationship to this account.")]
        public virtual IActionResult RejectFollowRequest([FromRoute][Required]string accountId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AccountRelationship));

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
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize<AccountRelationship>(exampleJson)
            : default(AccountRelationship);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
