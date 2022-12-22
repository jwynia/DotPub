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
    public class CustomEmojisApiController : ControllerBase
    { 
        /// <summary>
        /// Get an array of custom emojis available on the instance.
        /// </summary>
        
        /// <response code="200">Array of custom emojis.</response>
        /// <response code="401">unauthorized</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/custom_emojis")]
        [ValidateModelState]
        [SwaggerOperation("CustomEmojisGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Emoji>), description: "Array of custom emojis.")]
        public virtual IActionResult CustomEmojisGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Emoji>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 406 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(406);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            string exampleJson = null;
            exampleJson = "{}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize <List<Emoji>>(exampleJson)
            : default(List<Emoji>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
