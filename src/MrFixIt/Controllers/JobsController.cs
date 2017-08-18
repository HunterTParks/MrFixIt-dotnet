using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MrFixIt.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MrFixIt.Controllers
{
    public class JobsController : Controller
    {
        private MrFixItContext db = new MrFixItContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(db.Jobs.Include(i => i.Worker).ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Job job)
        {
            db.Jobs.Add(job);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Claim(int id)
        {
            var thisItem = db.Jobs.FirstOrDefault(items => items.JobId == id);
            return View(thisItem);
        }

        [HttpPost]
        public IActionResult Claim(Job job)
        {
            job.Worker = db.Workers.FirstOrDefault(i => i.UserName == User.Identity.Name);
            db.Entry(job).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ClaimJob(string job)
        {
            int jobId;
            int.TryParse(job, out jobId);
            Worker test = db.Workers.FirstOrDefault(i => i.UserName == User.Identity.Name);
            Job findJob = db.Jobs.FirstOrDefault(j => j.JobId == jobId);
            if (test.Avaliable == false)
            {
                return Json(job);
            }
            findJob.Worker = test;
            test.Avaliable = false;
            db.Entry(test).State = EntityState.Modified;
            db.Entry(findJob).State = EntityState.Modified;
            db.SaveChanges();
            return Json(findJob);
        }

        [HttpPost]
        public IActionResult JobDone(string job)
        {
            int jobId;
            int.TryParse(job, out jobId);

            Worker worker = db.Workers.FirstOrDefault(w => w.UserName == User.Identity.Name);
            Job finishedJob = db.Jobs.FirstOrDefault(j => j.JobId == jobId);
            worker.Avaliable = true;
            finishedJob.Completed = true;

            db.Entry(worker).State = EntityState.Modified;
            db.Entry(finishedJob).State = EntityState.Modified;
            db.SaveChanges();
            return Json(finishedJob.Title);
        }
    }
}
