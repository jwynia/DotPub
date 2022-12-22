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
    public class AdminApiController : ControllerBase
    { 
        /// <summary>
        /// Perform an admin action on an account.
        /// </summary>
        
        /// <param name="id">ID of the account.</param>
        /// <param name="type">Type of action to be taken (&#x60;disable&#x60;, &#x60;silence&#x60;, or &#x60;suspend&#x60;).</param>
        /// <param name="text">Optional text describing why this action was taken.</param>
        /// <response code="200">OK</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/admin/accounts/{id}/action")]
        [ValidateModelState]
        [SwaggerOperation("AdminAccountAction")]
        public virtual IActionResult AdminAccountAction([FromRoute][Required]string id, [FromForm][Required()]string type, [FromForm]string text)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

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


            throw new NotImplementedException();
        }

        /// <summary>
        /// Create one or more domain blocks, from a string or a file.
        /// </summary>
        /// <remarks>You have two options when using this endpoint: either you can set &#x60;import&#x60; to &#x60;true&#x60; and upload a file containing multiple domain blocks, JSON-formatted, or you can leave import as &#x60;false&#x60;, and just add one domain block.  The format of the json file should be something like: &#x60;[{\&quot;domain\&quot;:\&quot;example.org\&quot;},{\&quot;domain\&quot;:\&quot;whatever.com\&quot;,\&quot;public_comment\&quot;:\&quot;they smell\&quot;}]&#x60;</remarks>
        /// <param name="import">Signal that a list of domain blocks is being imported as a file. If set to &#x60;true&#x60;, then &#39;domains&#39; must be present as a JSON-formatted file. If set to &#x60;false&#x60;, then &#x60;domains&#x60; will be ignored, and &#x60;domain&#x60; must be present.</param>
        /// <param name="domains">JSON-formatted list of domain blocks to import. This is only used if &#x60;import&#x60; is set to &#x60;true&#x60;.</param>
        /// <param name="domain">Single domain to block. Used only if &#x60;import&#x60; is not &#x60;true&#x60;.</param>
        /// <param name="obfuscate">Obfuscate the name of the domain when serving it publicly. Eg., &#x60;example.org&#x60; becomes something like &#x60;ex***e.org&#x60;. Used only if &#x60;import&#x60; is not &#x60;true&#x60;.</param>
        /// <param name="publicComment">Public comment about this domain block. This will be displayed alongside the domain block if you choose to share blocks. Used only if &#x60;import&#x60; is not &#x60;true&#x60;.</param>
        /// <param name="privateComment">Private comment about this domain block. Will only be shown to other admins, so this is a useful way of internally keeping track of why a certain domain ended up blocked. Used only if &#x60;import&#x60; is not &#x60;true&#x60;.</param>
        /// <response code="200">The newly created domain block, if &#x60;import&#x60; !&#x3D; &#x60;true&#x60;. If a list has been imported, then an &#x60;array&#x60; of newly created domain blocks will be returned instead.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/admin/domain_blocks")]
        [ValidateModelState]
        [SwaggerOperation("DomainBlockCreate")]
        [SwaggerResponse(statusCode: 200, type: typeof(DomainBlock), description: "The newly created domain block, if &#x60;import&#x60; !&#x3D; &#x60;true&#x60;. If a list has been imported, then an &#x60;array&#x60; of newly created domain blocks will be returned instead.")]
        public virtual IActionResult DomainBlockCreate([FromQuery]bool? import, [FromForm]System.IO.Stream domains, [FromForm]string domain, [FromForm]bool? obfuscate, [FromForm]string publicComment, [FromForm]string privateComment)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DomainBlock));

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
            ? JsonSerializer.Deserialize<DomainBlock>(exampleJson)
            : default(DomainBlock);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Delete domain block with the given ID.
        /// </summary>
        
        /// <param name="id">The id of the domain block.</param>
        /// <response code="200">The domain block that was just deleted.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpDelete]
        [Route("//api/v1/admin/domain_blocks/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DomainBlockDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(DomainBlock), description: "The domain block that was just deleted.")]
        public virtual IActionResult DomainBlockDelete([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DomainBlock));

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
            ? JsonSerializer.Deserialize<DomainBlock>(exampleJson)
            : default(DomainBlock);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// View domain block with the given ID.
        /// </summary>
        
        /// <param name="id">The id of the domain block.</param>
        /// <response code="200">The requested domain block.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/admin/domain_blocks/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DomainBlockGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(DomainBlock), description: "The requested domain block.")]
        public virtual IActionResult DomainBlockGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DomainBlock));

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
            ? JsonSerializer.Deserialize<DomainBlock>(exampleJson)
            : default(DomainBlock);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// View all domain blocks currently in place.
        /// </summary>
        
        /// <param name="export">If set to &#x60;true&#x60;, then each entry in the returned list of domain blocks will only consist of the fields &#x60;domain&#x60; and &#x60;public_comment&#x60;. This is perfect for when you want to save and share a list of all the domains you have blocked on your instance, so that someone else can easily import them, but you don&#39;t want them to see the database IDs of your blocks, or private comments etc.</param>
        /// <response code="200">All domain blocks currently in place.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/admin/domain_blocks")]
        [ValidateModelState]
        [SwaggerOperation("DomainBlocksGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<DomainBlock>), description: "All domain blocks currently in place.")]
        public virtual IActionResult DomainBlocksGet([FromQuery]bool? export)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<DomainBlock>));

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
            ? JsonSerializer.Deserialize<List<DomainBlock>>(exampleJson)
            : default(List<DomainBlock>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get a list of existing emoji categories.
        /// </summary>
        
        /// <param name="id">The id of the emoji.</param>
        /// <response code="200">Array of existing emoji categories.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/admin/custom_emojis/categories")]
        [ValidateModelState]
        [SwaggerOperation("EmojiCategoriesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<string>), description: "Array of existing emoji categories.")]
        public virtual IActionResult EmojiCategoriesGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<AdminEmojiCategory>));

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
            ? JsonSerializer.Deserialize<List<string>>(exampleJson)
            : default(List<string>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Upload and create a new instance emoji.
        /// </summary>
        
        /// <param name="shortcode">The code to use for the emoji, which will be used by instance denizens to select it. This must be unique on the instance.</param>
        /// <param name="image">A png or gif image of the emoji. Animated pngs work too! To ensure compatibility with other fedi implementations, emoji size limit is 50kb by default.</param>
        /// <param name="category">Category in which to place the new emoji. 64 characters or less. If left blank, emoji will be uncategorized. If a category with the given name doesn&#39;t exist yet, it will be created.</param>
        /// <response code="200">The newly-created emoji.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="409">conflict - - shortcode for this emoji is already in use</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/admin/custom_emojis")]
        [ValidateModelState]
        [SwaggerOperation("EmojiCreate")]
        [SwaggerResponse(statusCode: 200, type: typeof(Emoji), description: "The newly-created emoji.")]
        public virtual IActionResult EmojiCreate([FromForm][Required()][RegularExpression("/\\w{2,30}/")]string shortcode, [FromForm][Required()]System.IO.Stream image, [FromForm]string category)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Emoji));

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

            //TODO: Uncomment the next line to return response 409 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(409);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonSerializer.Deserialize<Emoji>(exampleJson)
            : default(Emoji);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Delete a **local** emoji with the given ID from the instance.
        /// </summary>
        /// <remarks>Emoji with the given ID will no longer be available to use on the instance.  If you just want to update the emoji image instead, use the &#x60;/api/v1/admin/custom_emojis/{id}&#x60; PATCH route.  To disable emojis from **remote** instances, use the &#x60;/api/v1/admin/custom_emojis/{id}&#x60; PATCH route.</remarks>
        /// <param name="id">The id of the emoji.</param>
        /// <response code="200">The deleted emoji will be returned to the caller in case further processing is necessary.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpDelete]
        [Route("//api/v1/admin/custom_emojis/{id}")]
        [ValidateModelState]
        [SwaggerOperation("EmojiDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(AdminEmoji), description: "The deleted emoji will be returned to the caller in case further processing is necessary.")]
        public virtual IActionResult EmojiDelete([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AdminEmoji));

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
            ? JsonSerializer.Deserialize<AdminEmoji>(exampleJson)
            : default(AdminEmoji);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get the admin view of a single emoji.
        /// </summary>
        
        /// <param name="id">The id of the emoji.</param>
        /// <response code="200">A single emoji.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/admin/custom_emojis/{id}")]
        [ValidateModelState]
        [SwaggerOperation("EmojiGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(AdminEmoji), description: "A single emoji.")]
        public virtual IActionResult EmojiGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AdminEmoji));

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
            ? JsonSerializer.Deserialize<AdminEmoji>(exampleJson)
            : default(AdminEmoji);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Perform admin action on a local or remote emoji known to this instance.
        /// </summary>
        /// <remarks>Action performed depends upon the action &#x60;type&#x60; provided.  &#x60;disable&#x60;: disable a REMOTE emoji from being used/displayed on this instance. Does not work for local emojis.  &#x60;copy&#x60;: copy a REMOTE emoji to this instance. When doing this action, a shortcode MUST be provided, and it must be unique among emojis already present on this instance. A category MAY be provided, and the copied emoji will then be put into the provided category.  &#x60;modify&#x60;: modify a LOCAL emoji. You can provide a new image for the emoji and/or update the category.  Local emojis cannot be deleted using this endpoint. To delete a local emoji, check DELETE /api/v1/admin/custom_emojis/{id} instead.</remarks>
        /// <param name="id">The id of the emoji.</param>
        /// <param name="type">Type of action to be taken. One of: (&#x60;disable&#x60;, &#x60;copy&#x60;, &#x60;modify&#x60;). For REMOTE emojis, &#x60;copy&#x60; or &#x60;disable&#x60; are supported. For LOCAL emojis, only &#x60;modify&#x60; is supported.</param>
        /// <param name="shortcode">The code to use for the emoji, which will be used by instance denizens to select it. This must be unique on the instance. Works for the &#x60;copy&#x60; action type only.</param>
        /// <param name="image">A new png or gif image to use for the emoji. Animated pngs work too! To ensure compatibility with other fedi implementations, emoji size limit is 50kb by default. Works for LOCAL emojis only.</param>
        /// <param name="category">Category in which to place the emoji. 64 characters or less. If a category with the given name doesn&#39;t exist yet, it will be created.</param>
        /// <response code="200">The updated emoji.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPatch]
        [Route("//api/v1/admin/custom_emojis/{id}")]
        [ValidateModelState]
        [SwaggerOperation("EmojiUpdate")]
        [SwaggerResponse(statusCode: 200, type: typeof(AdminEmoji), description: "The updated emoji.")]
        public virtual IActionResult EmojiUpdate([FromRoute][Required]string id, [FromForm][Required()]string type, [FromForm][RegularExpression("/\\w{2,30}/")]string shortcode, [FromForm]System.IO.Stream image, [FromForm]string category)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AdminEmoji));

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
            ? JsonSerializer.Deserialize<AdminEmoji>(exampleJson)
            : default(AdminEmoji);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// View local and remote emojis available to / known by this instance.
        /// </summary>
        /// <remarks>The next and previous queries can be parsed from the returned Link header. Example:  &#x60;&lt;http://localhost:8080/api/v1/admin/custom_emojis?limit&#x3D;30&amp;max_shortcode_domain&#x3D;yell@fossbros-anonymous.io&amp;filter&#x3D;domain:all&gt;; rel&#x3D;\&quot;next\&quot;, &lt;http://localhost:8080/api/v1/admin/custom_emojis?limit&#x3D;30&amp;min_shortcode_domain&#x3D;rainbow@&amp;filter&#x3D;domain:all&gt;; rel&#x3D;\&quot;prev\&quot;&#x60;</remarks>
        /// <param name="filter">Comma-separated list of filters to apply to results. Recognized filters are:  &#x60;domain:[domain]&#x60; - - show emojis from the given domain, eg &#x60;?filter&#x3D;domain:example.org&#x60; will show emojis from &#x60;example.org&#x60; only. Instead of giving a specific domain, you can also give either one of the key words &#x60;local&#x60; or &#x60;all&#x60; to show either local emojis only (&#x60;domain:local&#x60;) or show all emojis from all domains (&#x60;domain:all&#x60;). Note: &#x60;domain:*&#x60; is equivalent to &#x60;domain:all&#x60; (including local). If no domain filter is provided, &#x60;domain:all&#x60; will be assumed.  &#x60;disabled&#x60; - - include emojis that have been disabled.  &#x60;enabled&#x60; - - include emojis that are enabled.  &#x60;shortcode:[shortcode]&#x60; - - show only emojis with the given shortcode, eg &#x60;?filter&#x3D;shortcode:blob_cat_uwu&#x60; will show only emojis with the shortcode &#x60;blob_cat_uwu&#x60; (case sensitive).  If neither &#x60;disabled&#x60; or &#x60;enabled&#x60; are provided, both disabled and enabled emojis will be shown.  If no filter query string is provided, the default &#x60;domain:all&#x60; will be used, which will show all emojis from all domains.</param>
        /// <param name="limit">Number of emojis to return. Less than 1, or not set, means unlimited (all emojis).</param>
        /// <param name="maxShortcodeDomain">Return only emojis with &#x60;[shortcode]@[domain]&#x60; *LOWER* (alphabetically) than given &#x60;[shortcode]@[domain]&#x60;. For example, if &#x60;max_shortcode_domain&#x3D;beep@example.org&#x60;, then returned values might include emojis with &#x60;[shortcode]@[domain]&#x60;s like &#x60;car@example.org&#x60;, &#x60;debian@aaa.com&#x60;, &#x60;test@&#x60; (local emoji), etc. Emoji with the given &#x60;[shortcode]@[domain]&#x60; will not be included in the result set.</param>
        /// <param name="minShortcodeDomain">Return only emojis with &#x60;[shortcode]@[domain]&#x60; *HIGHER* (alphabetically) than given &#x60;[shortcode]@[domain]&#x60;. For example, if &#x60;max_shortcode_domain&#x3D;beep@example.org&#x60;, then returned values might include emojis with &#x60;[shortcode]@[domain]&#x60;s like &#x60;arse@test.com&#x60;, &#x60;0101_binary@hackers.net&#x60;, &#x60;bee@&#x60; (local emoji), etc. Emoji with the given &#x60;[shortcode]@[domain]&#x60; will not be included in the result set.</param>
        /// <response code="200">An array of emojis, arranged alphabetically by shortcode and domain.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("//api/v1/admin/custom_emojis")]
        [ValidateModelState]
        [SwaggerOperation("EmojisGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<AdminEmoji>), description: "An array of emojis, arranged alphabetically by shortcode and domain.")]
        public virtual IActionResult EmojisGet([FromQuery]string filter, [FromQuery]int? limit, [FromQuery]string maxShortcodeDomain, [FromQuery]string minShortcodeDomain)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<AdminEmoji>));

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
            ? JsonSerializer.Deserialize<List<AdminEmoji>>(exampleJson)
            : default(List<AdminEmoji>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Clean up remote media older than the specified number of days.
        /// </summary>
        /// <remarks>Also cleans up unused headers + avatars from the media cache.</remarks>
        /// <param name="remoteCacheDays">Number of days of remote media to keep. Native values will be treated as 0. If value is not specified, the value of media-remote-cache-days in the server config will be used.</param>
        /// <response code="200">Echos the number of days requested. The cleanup is performed asynchronously after the request completes.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/admin/media_cleanup")]
        [ValidateModelState]
        [SwaggerOperation("MediaCleanup")]
        public virtual IActionResult MediaCleanup([FromQuery]long? remoteCacheDays)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

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


            throw new NotImplementedException();
        }

        /// <summary>
        /// Refetch media specified in the database but missing from storage.
        /// </summary>
        /// <remarks>Currently, this only includes remote emojis. This endpoint is useful when data loss has occurred, and you want to try to recover to a working state.</remarks>
        /// <param name="domain">Domain to refetch media from. If empty, all domains will be refetched.</param>
        /// <response code="202">Request accepted and will be processed. Check the logs for progress / errors.</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="404">not found</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal server error</response>
        [HttpPost]
        [Route("//api/v1/admin/media_refetch")]
        [ValidateModelState]
        [SwaggerOperation("MediaRefetch")]
        public virtual IActionResult MediaRefetch([FromQuery]string domain)
        { 
            //TODO: Uncomment the next line to return response 202 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(202);

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


            throw new NotImplementedException();
        }
    }
}
