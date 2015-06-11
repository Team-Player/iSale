using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using iSale.WebUI.Models;

namespace iSale.WebUI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
       
    }
}