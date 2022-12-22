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
    public class SearchApiController : ControllerBase
    { 
        /// <summary>
        /// Search for statuses, accounts, or hashtags, on this instance or elsewhere.
        /// </summary>
        /// <remarks>If statuses are in the result, they will be returned in descending chronological order (newest first), with sequential IDs (bigger &#x3D; newer).</remarks>
        /// <param name="type">Type of the search query to perform.  Must be one of: &#x60;accounts&#x60;, &#x60;hashtags&#x60;, &#x60;statuses&#x60;.</param>
        /// <param name="q">String to use as a search query.  For accounts, this should be in the format &#x60;@someaccount@some.instance.com&#x60;, or the format &#x60;https://some.instance.com/@someaccount&#x60;  For a status, this can be in the format: &#x60;https://some.instance.com/@someaccount/SOME_ID_OF_A_STATUS&#x60;</param>
        /// <param name="accountId">If type is &#x60;statuses&#x60;, then statuses returned will be authored only by this account.</param>
        /// <param name="maxId">Return results *older* than this id.  The entry with this ID will not be included in the search results.</param>
        /// <param name="minId">Return results *newer* than this id.  The entry with this ID will not be included in the search results.</param>
        /// <param name="excludeUnreviewed">Filter out tags that haven&#39;t been reviewed and approved by an instance admin.</param>
        /// <param name="resolve">Attempt to resolve the query by performing a remote webfinger lookup, if the query includes a remote host.</param>
        /// <param name="limit">Maximum number of results to load, per type.</param>
        /// <param name="offset">Offset for paginating search results.</param>
        /// <param name="following">Only include accounts that the searching account is following.</param>
        /// <response code="200">Results of the search.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/search")]
        [ValidateModelState]
        [SwaggerOperation("SearchGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<SearchResult>), description: "Results of the search.")]
        public virtual IActionResult SearchGet([FromQuery][Required()]string type, [FromQuery][Required()]string q, [FromQuery]string accountId, [FromQuery]string maxId, [FromQuery]string minId, [FromQuery]bool? excludeUnreviewed, [FromQuery]bool? resolve, [FromQuery][Range(1, 40)]long? limit, [FromQuery]long? offset, [FromQuery]bool? following)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<SearchResult>));

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
            ? JsonSerializer.Deserialize<List<SearchResult>>(exampleJson)
            : default(List<SearchResult>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
