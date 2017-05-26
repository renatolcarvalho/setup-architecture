using System.Net;
using System.Web.Mvc;
using App.Business.ViewModel;
using App.Business.Interfaces.Services;
using System;

namespace App.Web.Controllers
{
    public class ExampleController : Controller
    {
        private const string INIT_EXAMPLE = "Log Example";

        private readonly IExampleService _exampleService;
        private readonly IManagerLog _managerLog;
        public ExampleController(IExampleService exampleService, IManagerLog managerLog)
        {
            _exampleService = exampleService;
            _managerLog = managerLog;
        }

        // GET: ExampleViewModels
        public ActionResult Index()
        {
            _managerLog.InfoLog(INIT_EXAMPLE);
            return View(_exampleService.GetAll());
        }

        // GET: ExampleViewModels/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExampleViewModel exampleViewModel = _exampleService.FindById(id.Value);
            if (exampleViewModel == null)
            {
                return HttpNotFound();
            }
            return View(exampleViewModel);
        }

        // GET: ExampleViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExampleViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ExampleId,Description")] ExampleViewModel exampleViewModel)
        {
            if (ModelState.IsValid)
            {
                _exampleService.Add(exampleViewModel);
                return RedirectToAction("Index");
            }

            return View(exampleViewModel);
        }

        // GET: ExampleViewModels/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExampleViewModel exampleViewModel = _exampleService.FindById(id.Value);
            if (exampleViewModel == null)
            {
                return HttpNotFound();
            }
            return View(exampleViewModel);
        }

        // POST: ExampleViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExampleId,Description")] ExampleViewModel exampleViewModel)
        {
            if (ModelState.IsValid)
            {
                _exampleService.Update(exampleViewModel);
                return RedirectToAction("Index");
            }
            return View(exampleViewModel);
        }

        // GET: ExampleViewModels/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExampleViewModel exampleViewModel = _exampleService.FindById(id.Value);
            if (exampleViewModel == null)
            {
                return HttpNotFound();
            }
            return View(exampleViewModel);
        }

        // POST: ExampleViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _exampleService.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _exampleService.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
