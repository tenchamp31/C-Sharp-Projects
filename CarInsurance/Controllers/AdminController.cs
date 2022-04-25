using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            var mainadmin = new List<Adminviewmodel>();
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees.Where(x => x.Quote > 0).ToList();

                foreach (var insuree in insurees)
                {
                    var thismainAdmin = new Adminviewmodel
                    {
                        Quote = insuree.Quote,
                        FirstName = insuree.FirstName,
                        LastName = insuree.LastName,
                        EmailAddress = insuree.EmailAddress
                    };
                    mainadmin.Add(thismainAdmin);
                }
            }
            return View(mainadmin);
        }
    }
}