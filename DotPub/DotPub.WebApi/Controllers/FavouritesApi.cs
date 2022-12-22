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
	public class FavouritesApiController : ControllerBase
	{
		/// <summary>
		/// Get an array of statuses that the requesting account has favourited.
		/// </summary>
		/// <remarks>The next and previous queries can be parsed from the returned Link header. Example:  &#x60;&#x60;&#x60; &lt;https://example.org/api/v1/favourites?limit&#x3D;80&amp;max_id&#x3D;01FC0SKA48HNSVR6YKZCQGS2V8&gt;; rel&#x3D;\&quot;next\&quot;, &lt;https://example.org/api/v1/favourites?limit&#x3D;80&amp;min_id&#x3D;01FC0SKW5JK2Q4EVAV2B462YY0&gt;; rel&#x3D;\&quot;prev\&quot; &#x60;&#x60;&#x60;&#x60;</remarks>
		/// <param name="limit">Number of statuses to return.</param>
		/// <param name="maxId">Return only favourited statuses *OLDER* than the given favourite ID. The status with the corresponding fave ID will not be included in the response.</param>
		/// <param name="minId">Return only favourited statuses *NEWER* than the given favourite ID. The status with the corresponding fave ID will not be included in the response.</param>
		/// <response code="200"></response>
		/// <response code="400">bad request</response>
		/// <response code="401">unauthorized</response>
		/// <response code="404">not found</response>
		/// <response code="406">not acceptable</response>
		/// <response code="500">internal server error</response>
		[HttpGet]
		[Route("//api/v1/favourites")]
		[ValidateModelState]
		[SwaggerOperation("FavouritesGet")]
		[SwaggerResponse(statusCode: 200, type: typeof(List<Status>), description: "")]
		public virtual IActionResult FavouritesGet([FromQuery] int? limit, [FromQuery] string maxId,
			[FromQuery] string minId)
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
	}
}