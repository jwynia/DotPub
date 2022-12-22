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
    public class MediaApiController : ControllerBase
    { 
        /// <summary>
        /// Upload a new media attachment.
        /// </summary>
        
        /// <param name="apiVersion">Version of the API to use. Must be either &#x60;v1&#x60; or &#x60;v2&#x60;.</param>
        /// <param name="_file">The media attachment to upload.</param>
        /// <param name="description">Image or media description to use as alt-text on the attachment. This is very useful for users of screenreaders! May or may not be required, depending on your instance settings.</param>
        /// <param name="focus">Focus of the media file. If present, it should be in the form of two comma-separated floats between -1 and 1. For example: &#x60;-0.5,0.25&#x60;.</param>
        /// <response code="200">The newly-created media attachment.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="422">unprocessable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/{api_version}/media")]
        [ValidateModelState]
        [SwaggerOperation("MediaCreate")]
        [SwaggerResponse(statusCode: 200, type: typeof(Attachment), description: "The newly-created media attachment.")]
        public virtual IActionResult MediaCreate([FromRoute][Required]string apiVersion, [FromForm][Required()]System.IO.Stream _file, [FromForm]string description, [FromForm]string focus)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Attachment));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(422);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize<Attachment>(exampleJson)
            : default(Attachment);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get a media attachment that you own.
        /// </summary>
        
        /// <param name="id">id of the attachment</param>
        /// <response code="200">The requested media attachment.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/media/{id}")]
        [ValidateModelState]
        [SwaggerOperation("MediaGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Attachment), description: "The requested media attachment.")]
        public virtual IActionResult MediaGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Attachment));

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
            ? JsonSerializer.Deserialize<Attachment>(exampleJson)
            : default(Attachment);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update a media attachment.
        /// </summary>
        /// <remarks>You must own the media attachment, and the attachment must not yet be attached to a status.  The parameters can also be given in the body of the request, as JSON, if the content-type is set to &#39;application/json&#39;. The parameters can also be given in the body of the request, as XML, if the content-type is set to &#39;application/xml&#39;.</remarks>
        /// <param name="id">id of the attachment to update</param>
        /// <param name="description">Image or media description to use as alt-text on the attachment. This is very useful for users of screenreaders! May or may not be required, depending on your instance settings.</param>
        /// <param name="focus">Focus of the media file. If present, it should be in the form of two comma-separated floats between -1 and 1. For example: &#x60;-0.5,0.25&#x60;.</param>
        /// <response code="200">The newly-updated media attachment.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPut]
        [Route("//api/v1/media/{id}")]
        [ValidateModelState]
        [SwaggerOperation("MediaUpdate")]
        [SwaggerResponse(statusCode: 200, type: typeof(Attachment), description: "The newly-updated media attachment.")]
        public virtual IActionResult MediaUpdate([FromRoute][Required]string id, [FromForm]string description, [FromForm]string focus)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Attachment));

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
            ? JsonSerializer.Deserialize<Attachment>(exampleJson)
            : default(Attachment);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
