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
    public class AccountsApiController : ControllerBase
    { 
        /// <summary>
        /// Block account with id.
        /// </summary>
        
        /// <param name="id">The id of the account to block.</param>
        /// <response code="200">Your relationship to the account.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/accounts/{id}/block")]
        [ValidateModelState]
        [SwaggerOperation("AccountBlock")]
        [SwaggerResponse(statusCode: 200, type: typeof(AccountRelationship), description: "Your relationship to the account.")]
        public virtual IActionResult AccountBlock([FromRoute][Required]string id)
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
        /// Create a new account using an application token.
        /// </summary>
        /// <remarks>The parameters can also be given in the body of the request, as JSON, if the content-type is set to &#39;application/json&#39;. The parameters can also be given in the body of the request, as XML, if the content-type is set to &#39;application/xml&#39;.</remarks>
        /// <param name="reason">Text that will be reviewed by moderators if registrations require manual approval.</param>
        /// <param name="username">The desired username for the account.</param>
        /// <param name="email">The email address to be used for login.</param>
        /// <param name="password">The password to be used for login. This will be hashed before storage.</param>
        /// <param name="agreement">The user agrees to the terms, conditions, and policies of the instance.</param>
        /// <param name="locale">The language of the confirmation email that will be sent.</param>
        /// <response code="200">An OAuth2 access token for the newly-created account.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/accounts")]
        [ValidateModelState]
        [SwaggerOperation("AccountCreate")]
        [SwaggerResponse(statusCode: 200, type: typeof(OauthToken), description: "An OAuth2 access token for the newly-created account.")]
        public virtual IActionResult AccountCreate([FromQuery]string reason, [FromQuery]string username, [FromQuery]string email, [FromQuery]string password, [FromQuery]bool? agreement, [FromQuery]string locale)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OauthToken));

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
            ? JsonSerializer.Deserialize<OauthToken>(exampleJson)
            : default(OauthToken);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Delete your account.
        /// </summary>
        
        /// <param name="password">Password of the account user, for confirmation.</param>
        /// <response code="202">The account deletion has been accepted and the account will be deleted.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/accounts/delete")]
        [ValidateModelState]
        [SwaggerOperation("AccountDelete")]
        public virtual IActionResult AccountDelete([FromForm][Required()]string password)
        { 
            //TODO: Uncomment the next line to return response 202 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(202);

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


            throw new NotImplementedException();
        }

        /// <summary>
        /// Follow account with id.
        /// </summary>
        /// <remarks>The parameters can also be given in the body of the request, as JSON, if the content-type is set to &#39;application/json&#39;. The parameters can also be given in the body of the request, as XML, if the content-type is set to &#39;application/xml&#39;.</remarks>
        /// <param name="id">ID of the account to follow.</param>
        /// <param name="reblogs">Show reblogs from this account.</param>
        /// <param name="notify">Notify when this account posts.</param>
        /// <response code="200">Your relationship to this account.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/accounts/{id}/follow")]
        [ValidateModelState]
        [SwaggerOperation("AccountFollow")]
        [SwaggerResponse(statusCode: 200, type: typeof(AccountRelationship), description: "Your relationship to this account.")]
        public virtual IActionResult AccountFollow([FromRoute][Required]string id, [FromForm]bool? reblogs, [FromForm]bool? notify)
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
        /// See followers of account with given id.
        /// </summary>
        
        /// <param name="id">Account ID.</param>
        /// <response code="200">Array of accounts that follow this account.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/accounts/{id}/followers")]
        [ValidateModelState]
        [SwaggerOperation("AccountFollowers")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Account>), description: "Array of accounts that follow this account.")]
        public virtual IActionResult AccountFollowers([FromRoute][Required]string id)
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
        /// See accounts followed by given account id.
        /// </summary>
        
        /// <param name="id">Account ID.</param>
        /// <response code="200">Array of accounts that are followed by this account.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/accounts/{id}/following")]
        [ValidateModelState]
        [SwaggerOperation("AccountFollowing")]
        public virtual IActionResult AccountFollowing([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

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


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get information about an account with the given ID.
        /// </summary>
        
        /// <param name="id">The id of the requested account.</param>
        /// <response code="200">The requested account.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/accounts/{id}")]
        [ValidateModelState]
        [SwaggerOperation("AccountGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Account), description: "The requested account.")]
        public virtual IActionResult AccountGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Account));

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
            ? JsonSerializer.Deserialize<Account>(exampleJson)
            : default(Account);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// See your account&#39;s relationships with the given account IDs.
        /// </summary>
        
        /// <param name="id">Account IDs.</param>
        /// <response code="200">Array of account relationships.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/accounts/relationships")]
        [ValidateModelState]
        [SwaggerOperation("AccountRelationships")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<AccountRelationship>), description: "Array of account relationships.")]
        public virtual IActionResult AccountRelationships([FromQuery][Required()]List<string> id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<AccountRelationship>));

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
            ? JsonSerializer.Deserialize<List<AccountRelationship>>(exampleJson)
            : default(List<AccountRelationship>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// See statuses posted by the requested account.
        /// </summary>
        /// <remarks>The statuses will be returned in descending chronological order (newest first), with sequential IDs (bigger &#x3D; newer).</remarks>
        /// <param name="id">Account ID.</param>
        /// <param name="limit">Number of statuses to return.</param>
        /// <param name="excludeReplies">Exclude statuses that are a reply to another status.</param>
        /// <param name="excludeReblogs">Exclude statuses that are a reblog/boost of another status.</param>
        /// <param name="maxId">Return only statuses *OLDER* than the given max status ID. The status with the specified ID will not be included in the response.</param>
        /// <param name="minId">Return only statuses *NEWER* than the given min status ID. The status with the specified ID will not be included in the response.</param>
        /// <param name="pinnedOnly">Show only pinned statuses. In other words, exclude statuses that are not pinned to the given account ID.</param>
        /// <param name="onlyMedia">Show only statuses with media attachments.</param>
        /// <param name="onlyPublic">Show only statuses with a privacy setting of &#39;public&#39;.</param>
        /// <response code="200">Array of statuses.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/accounts/{id}/statuses")]
        [ValidateModelState]
        [SwaggerOperation("AccountStatuses")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Status>), description: "Array of statuses.")]
        public virtual IActionResult AccountStatuses([FromRoute][Required]string id, [FromQuery]int? limit, [FromQuery]bool? excludeReplies, [FromQuery]bool? excludeReblogs, [FromQuery]string maxId, [FromQuery]string minId, [FromQuery]bool? pinnedOnly, [FromQuery]bool? onlyMedia, [FromQuery]bool? onlyPublic)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Status>));

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
            ? JsonSerializer.Deserialize<List<Status>>(exampleJson)
            : default(List<Status>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Unblock account with ID.
        /// </summary>
        
        /// <param name="id">The id of the account to unblock.</param>
        /// <response code="200">Your relationship to this account.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/accounts/{id}/unblock")]
        [ValidateModelState]
        [SwaggerOperation("AccountUnblock")]
        [SwaggerResponse(statusCode: 200, type: typeof(AccountRelationship), description: "Your relationship to this account.")]
        public virtual IActionResult AccountUnblock([FromRoute][Required]string id)
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
        /// Unfollow account with id.
        /// </summary>
        
        /// <param name="id">The id of the account to unfollow.</param>
        /// <response code="200">Your relationship to this account.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/accounts/{id}/unfollow")]
        [ValidateModelState]
        [SwaggerOperation("AccountUnfollow")]
        [SwaggerResponse(statusCode: 200, type: typeof(AccountRelationship), description: "Your relationship to this account.")]
        public virtual IActionResult AccountUnfollow([FromRoute][Required]string id)
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
        /// Update your account.
        /// </summary>
        
        /// <param name="discoverable">Account should be made discoverable and shown in the profile directory (if enabled).</param>
        /// <param name="bot">Account is flagged as a bot.</param>
        /// <param name="displayName">The display name to use for the account.</param>
        /// <param name="note">Bio/description of this account.</param>
        /// <param name="avatar">Avatar of the user.</param>
        /// <param name="header">Header of the user.</param>
        /// <param name="locked">Require manual approval of follow requests.</param>
        /// <param name="sourcePrivacy">Default post privacy for authored statuses.</param>
        /// <param name="sourceSensitive">Mark authored statuses as sensitive by default.</param>
        /// <param name="sourceLanguage">Default language to use for authored statuses (ISO 6391).</param>
        /// <param name="sourceStatusFormat">Default format to use for authored statuses (plain or markdown).</param>
        /// <param name="customCss">Custom CSS to use when rendering this account&#39;s profile or statuses. String must be no more than 5,000 characters (~5kb).</param>
        /// <param name="enableRss">Enable RSS feed for this account&#39;s Public posts at &#x60;/[username]/feed.rss&#x60;</param>
        /// <response code="200">The newly updated account.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPatch]
        [Route("//api/v1/accounts/update_credentials")]
        [ValidateModelState]
        [SwaggerOperation("AccountUpdate")]
        [SwaggerResponse(statusCode: 200, type: typeof(Account), description: "The newly updated account.")]
        public virtual IActionResult AccountUpdate([FromForm]bool? discoverable, [FromForm]bool? bot, [FromForm]string displayName, [FromForm]string note, [FromForm]System.IO.Stream avatar, [FromForm]System.IO.Stream header, [FromForm]bool? locked, [FromForm]string sourcePrivacy, [FromForm]bool? sourceSensitive, [FromForm]string sourceLanguage, [FromForm]string sourceStatusFormat, [FromForm]string customCss, [FromForm]bool? enableRss)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Account));

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
            ? JsonSerializer.Deserialize<Account>(exampleJson)
            : default(Account);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Verify a token by returning account details pertaining to it.
        /// </summary>
        
        /// <response code="200"></response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/accounts/verify_credentials")]
        [ValidateModelState]
        [SwaggerOperation("AccountVerify")]
        [SwaggerResponse(statusCode: 200, type: typeof(Account), description: "")]
        public virtual IActionResult AccountVerify()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Account));

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
            ? JsonSerializer.Deserialize<Account>(exampleJson)
            : default(Account);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
