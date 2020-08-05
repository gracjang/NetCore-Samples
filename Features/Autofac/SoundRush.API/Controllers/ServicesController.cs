using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SoundRush.Infrastructure.Services.Interfaces;

namespace SoundRush.API.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]
  public class ServicesController : Controller
  {
    private readonly IServiceA _serviceA;
    private readonly IServiceB _serviceB;

    public ServicesController(IServiceA serviceA, IServiceB serviceB)
    {
      _serviceA = serviceA;
      _serviceB = serviceB;
    }

    // GET
    public ActionResult<List<string>> Get()
    {
      var messages = new List<string> { _serviceA.SendMessage(), _serviceB.SendMessage() } ;
      return Json(messages);
    }
  }
}