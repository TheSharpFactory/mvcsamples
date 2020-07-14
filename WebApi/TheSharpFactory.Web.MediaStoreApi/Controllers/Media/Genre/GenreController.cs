#region Usings
using Microsoft.AspNetCore.Mvc;
using TheSharpFactory.Domain;
#endregion

namespace TheSharpFactory.Web.Api.Controllers
{
    /// <summary>
    /// <para>API for the Media - Genre functional area</para>
    /// </summary>
    [Produces("application/json")]
    [Area("Media")]
    [Route("api/[area]/[controller]")]
    public partial class GenreController : ApiControllerBase
    {
        private readonly IBLContainer _bl;

        /// <summary>
        /// Constructor for Dependency Injection
        /// </summary>
        /// <param name="bl">Business Logic Container</param>
        public GenreController(IBLContainer bl)
        {
            _bl = bl;
        }

        /*
         *  This is a partial class.  
         *  This file contains constructors and common functions.
         *  The other files are Create.cs, Retrieve.cs, Update.cs, Delete.cs
         *
         */
    }
}
