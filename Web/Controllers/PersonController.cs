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
			List< Person > people;
			people = this.db.People.ToList ();

			try{
				people = this.db.People.ToList ();
			} catch (Exception e) {
				string message = e.ToString ();
				return RedirectToAction("Index");
			}

			return View (people);

        }

		public ActionResult Details(int? Id)
        {
			if (Id == null)
			{
				return RedirectToAction("Index");
			}

			Person person;
			person = this.db.People.Find(Id);

			if (person == null)
			{
				return HttpNotFound();
			}

			return View ( person );
        }

        public ActionResult Create()
        {
            return View ();
        } 

        [HttpPost]
		public ActionResult Create([Bind (Include = "FirstName,LastName,BirthDate")]Person p)
        {
			DateTime dBirthDate = new DateTime();
			try{
				dBirthDate = DateTime.Parse (Request.Form["BirthDate"]);
				p.BirthDate = dBirthDate;
			}
			catch{
				ModelState["BirthDate"].Errors.Clear();
				ModelState ["BirthDate"].Errors.Add ("Date Not Cool");
			}

			if (ModelState.IsValid) 
			{ 
				db.People.Add(p); 
				db.SaveChanges(); 
				return RedirectToAction("Index"); 
			} 
			return View ();
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