using System.Web.Mvc;
using IMaps.BusinessRules.Contracts;
using IMaps.BusinessRules.Repository;
using System.Configuration;

namespace IMaps.Web.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      var domainRepository = new DomainRepository(ConfigurationManager.AppSettings["MarketingXml"]);
      var programs = domainRepository.GetProgram();
      domainRepository = new DomainRepository(ConfigurationManager.AppSettings["MemberPreferencesXml"]);
      var memberPreferences = domainRepository.GetMemberPreferences();
      domainRepository = new DomainRepository(ConfigurationManager.AppSettings["TeamPreferencesXml"]);
      var teamPreferences = domainRepository.GetTeamPreferences();
      ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your quintessential app description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your quintessential contact page.";

      return View();
    }
  }
}
