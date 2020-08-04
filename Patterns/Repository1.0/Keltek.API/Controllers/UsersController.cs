using System.Reflection.Metadata.Ecma335;
using Keltek.Core.Interfaces;
using Keltek.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Keltek.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class UsersController : ControllerBase
  {
    private readonly IRepositoryWrapper _repositoryWrapper;
    public UsersController(IRepositoryWrapper repositoryWrapper)
    {
      _repositoryWrapper = repositoryWrapper;
    }

    [HttpGet]
    public ActionResult<User> Get() => Ok(_repositoryWrapper.User.FindAll());
  }
}
