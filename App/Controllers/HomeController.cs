using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess.Interface;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private ICompanyRepository objCompanyRepository;

        public HomeController(ICompanyRepository iCompanyRepository)
        {
            objCompanyRepository = iCompanyRepository;
        }

        public ActionResult Index()
        {
            ViewBag.Companies = objCompanyRepository.GetCompanies();
            return View();
        }

        public ActionResult About()
        {

            
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}