using System.ComponentModel.DataAnnotations;
using DotPub.ArchivedWebApi.Attributes;
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
    public class UserApiController : ControllerBase
    {
        /// <summary>
        /// Change the password of authenticated user.
        /// </summary>
        /// <remarks>The parameters can also be given in the body of the request, as JSON, if the content-type is set to &#39;application/json&#39;. The parameters can also be given in the body of the request, as XML, if the content-type is set to &#39;application/xml&#39;.</remarks>
        /// <param name="oldPassword">User&#39;s previous password.</param>
        /// <param name="newPassword">Desired new password. If the password does not have high enough entropy, it will be rejected. See https://github.com/wagslane/go-password-validator</param>
        /// <response code="200">Change successful</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized</response>
        /// <response code="403">forbidden</response>
        /// <response code="406">not acceptable</response>
        /// <response code="500">internal error</response>
        [HttpPost]
        [Route("//api/v1/user/password_change")]
        [ValidateModelState]
        [SwaggerOperation("UserPasswordChange")]
        public virtual IActionResult UserPasswordChange([FromForm] [Required()] string oldPassword,
            [FromForm] [Required()] string newPassword)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 406 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(406);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);


            throw new NotImplementedException();
        }
    }
}