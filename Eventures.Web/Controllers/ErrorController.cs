using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Web.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index(ErrorMessageViewModel model)
        {
            return View(model);
        }
    }
}