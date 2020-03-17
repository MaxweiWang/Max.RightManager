using Microsoft.AspNetCore.Mvc;
//
using Aop;
using Max.Utilities;

namespace Areas.Admin.Controllers
{
    public class ErrorController : AdminBaseController
    {
        public ErrorController()
        {
            this.IgnoreSessionCheck = true;
        }

        public IActionResult Index(ErrorModel _ErrorModel)
        {
            return View(_ErrorModel);
        }

    }
}