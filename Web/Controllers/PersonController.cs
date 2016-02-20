using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
using Web.ContextDbs;

namespace Web.Controllers
{
    public class PersonController : Controller
    {
		private PeopleContext db;

		public PersonController ()
		{
			this.db = new PeopleContext ();
		}

        public ActionResult Index()
        {
            return View ();
        }

		public ActionResult TestAddition()
		{
			Person person = new Person ()
			{
				FirstName = "Some",
				LastName = "Guy",
				BirthDate = DateTime.Now
			};

			db.People.Add(person); 
			db.SaveChanges(); 
			return RedirectToAction("Index", "Home"); 

		}

        public ActionResult Details(int id)
        {
            return View ();
        }

        public ActionResult Create()
        {
            return View ();
        } 

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
        
        public ActionResult Edit(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        public ActionResult Delete(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
    }
}