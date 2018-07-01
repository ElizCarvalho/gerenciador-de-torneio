using GameManagement.MVC.Models;
using GameManagement.MVC.DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GameManagement.MVC.Controllers
{
    public class TimeController : Controller
    {
        private static InMemoryTimeListRepository _repository = new InMemoryTimeListRepository();

        List<TimeModel> _times = _repository.GetAllTimes().ToList();

        // GET: Time
        public ActionResult Index()
        {
            return View(_times);
        }

        // GET: Time/Details/5
        public ActionResult Details(int id)
        {
            TimeModel time = _times.FirstOrDefault(i => i.Id == id);
            return View(time);
        }

        // GET: Time/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Time/Create
        [HttpPost]
        public ActionResult Create(TimeModel _model)
        {
            try
            {
                _repository.AddTime(_model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Time/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_times.Where(t => t.Id == id).First());
        }

        // POST: Time/Edit/5
        [HttpPost]
        public ActionResult Edit(TimeModel _model)
        {
            try
            {
                _repository.UpdateTime(_model); 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Time/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_times.Where(t => t.Id == id).First());
        }

        // POST: Time/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, TimeModel _model)
        {
            try
            {
                _repository.DeleteTime(_model.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
