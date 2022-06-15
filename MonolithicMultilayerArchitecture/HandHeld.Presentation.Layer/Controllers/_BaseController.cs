using Microsoft.AspNetCore.Mvc;

namespace HandHeld.Presentation.Layer.Controllers
{
    [ApiController]
    [Route(BasePath + "/[controller]")]
    public abstract class _BaseController : ControllerBase
    {
        protected const string BasePath = "HandHeld";
    }
}
