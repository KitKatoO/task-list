using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Task.Models;
using System.Data;
using Task = Task.Models.Task;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            using (var db = new TaskContext())
            {
                var tasks = db.Tasks.ToList();
                return View(tasks);
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (TaskContext db =new TaskContext())
            {
                var task = db.Tasks.Find(id);
                if (task == null)
                {
                    return HttpNotFound();
                }

                return View(task);
            }
        }

        [HttpPost]
        public ActionResult Edit(Models.Task task)
        {
            using (TaskContext db = new TaskContext())
            {

                if (ModelState.IsValid)
                {
                    var old = db.Tasks.Find(task.TaskID);
                    old.TaskTopic = task.TaskTopic;
                    old.TaskNote = task.TaskNote;
                    old.Date = task.Date;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(task);
            }
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (TaskContext db = new TaskContext())
            {
                var task = db.Tasks.Find(id);
                if (task == null)
                {
                    return HttpNotFound();
                }
                db.Tasks.Remove(task);
                db.SaveChanges();
                return View("Index", db.Tasks.ToList());
                
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Task task)
        {
            using (TaskContext db = new TaskContext())
            {
                if (ModelState.IsValid)
                {
                    db.Tasks.Add(task);
                    db.SaveChanges();
                    return RedirectToAction("Index");

                }
            }

            return View(task);
        }
    }

}

 