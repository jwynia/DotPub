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
    public class InstanceApiController : ControllerBase
    { 
        /// <summary>
        /// View instance information.
        /// </summary>
        
        /// <response code="200">Instance information.</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal error</response>
        [HttpGet]
        [Route("//api/v1/instance")]
        [ValidateModelState]
        [SwaggerOperation("InstanceGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Instance), description: "Instance information.")]
        public virtual IActionResult InstanceGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Instance));

            //TODO: Uncomment the next line to return response 406 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(406);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize<Instance>(exampleJson)
            : default(Instance);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="filter">Comma-separated list of filters to apply to results. Recognized filters are:   - &#x60;open&#x60; - - include peers that are not suspended or silenced   - &#x60;suspended&#x60; - - include peers that have been suspended.  If filter is &#x60;open&#x60;, only instances that haven&#39;t been suspended or silenced will be returned.  If filter is &#x60;suspended&#x60;, only suspended instances will be shown.  If filter is &#x60;open,suspended&#x60;, then all known instances will be returned.  If filter is an empty string or not set, then &#x60;open&#x60; will be assumed as the default.</param>
        /// <response code="200">If no filter parameter is provided, or filter is empty, then a legacy, Mastodon-API compatible response will be returned. This will consist of just a &#39;flat&#39; array of strings like &#x60;[&quot;example.com&quot;, &quot;example.org&quot;]&#x60;, which corresponds to domains this instance peers with.  If a filter parameter is provided, then an array of objects with at least a &#x60;domain&#x60; key set on each object will be returned.  Domains that are silenced or suspended will also have a key &#x60;suspended_at&#x60; or &#x60;silenced_at&#x60; that contains an iso8601 date string. If one of these keys is not present on the domain object, it is open. Suspended instances may in some cases be obfuscated, which means they will have some letters replaced by &#x60;*&#x60; to make it more difficult for bad actors to target instances with harassment.  Whether a flat response or a more detailed response is returned, domains will be sorted alphabetically by hostname.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/instance/peers")]
        [ValidateModelState]
        [SwaggerOperation("InstancePeersGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Domain>), description: "If no filter parameter is provided, or filter is empty, then a legacy, Mastodon-API compatible response will be returned. This will consist of just a &#39;flat&#39; array of strings like &#x60;[&quot;example.com&quot;, &quot;example.org&quot;]&#x60;, which corresponds to domains this instance peers with.  If a filter parameter is provided, then an array of objects with at least a &#x60;domain&#x60; key set on each object will be returned.  Domains that are silenced or suspended will also have a key &#x60;suspended_at&#x60; or &#x60;silenced_at&#x60; that contains an iso8601 date string. If one of these keys is not present on the domain object, it is open. Suspended instances may in some cases be obfuscated, which means they will have some letters replaced by &#x60;*&#x60; to make it more difficult for bad actors to target instances with harassment.  Whether a flat response or a more detailed response is returned, domains will be sorted alphabetically by hostname.")]
        public virtual IActionResult InstancePeersGet([FromQuery]string filter)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Domain>));

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
            ? JsonSerializer.Deserialize<List<Domain>>(exampleJson)
            : default(List<Domain>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update your instance information and/or upload a new avatar/header for the instance.
        /// </summary>
        /// <remarks>This requires admin permissions on the instance.</remarks>
        /// <param name="title">Title to use for the instance.</param>
        /// <param name="contactUsername">Username of the contact account. This must be the username of an instance admin.</param>
        /// <param name="contactEmail">Email address to use as the instance contact.</param>
        /// <param name="shortDescription">Short description of the instance.</param>
        /// <param name="description">Longer description of the instance.</param>
        /// <param name="terms">Terms and conditions of the instance.</param>
        /// <param name="thumbnail">Thumbnail image to use for the instance.</param>
        /// <param name="thumbnailDescription">Image description of the submitted instance thumbnail.</param>
        /// <param name="header">Header image to use for the instance.</param>
        /// <response code="200">The newly updated instance.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPatch]
        [Route("//api/v1/instance")]
        [ValidateModelState]
        [SwaggerOperation("InstanceUpdate")]
        [SwaggerResponse(statusCode: 200, type: typeof(Instance), description: "The newly updated instance.")]
        public virtual IActionResult InstanceUpdate([FromForm]string title, [FromForm]string contactUsername, [FromForm]string contactEmail, [FromForm]string shortDescription, [FromForm]string description, [FromForm]string terms, [FromForm]System.IO.Stream thumbnail, [FromForm]string thumbnailDescription, [FromForm]System.IO.Stream header)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Instance));

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
            ? JsonSerializer.Deserialize<Instance>(exampleJson)
            : default(Instance);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
