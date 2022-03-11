using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}
