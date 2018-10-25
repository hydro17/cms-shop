using CmsShop.Models.Data;
using CmsShop.Models.ViewModels.Pages;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CmsShop.Areas.Admin.Controllers
{
  public class PagesController : Controller
  {
    // GET: Admin/Pages
    public ActionResult Index()
    {
      List<PageVM> pagesList;

      using (Db db = new Db())
      {
        pagesList = db.Pages.ToArray().OrderBy(x => x.Sorting).Select(x => new PageVM(x)).ToList();
      }

      return View(pagesList);
    }
  }
}