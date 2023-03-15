using Microsoft.AspNetCore.Mvc;
using VegetableStoreMvc.Models;

namespace VegetableStoreMvc.Controllers
{
    public class VegetablesController : Controller
    {
        FakeDataBase fakeDataBase;

        public VegetablesController(FakeDataBase fakeDataBase)
        {
            this.fakeDataBase = fakeDataBase;
        }

        // GET: VegetablesController
        [HttpGet("")]
        public ActionResult Index()
        {
            Vegetable[] model = fakeDataBase.GetAll();
            return View(model);
        }

        // GET: VegetablesController/Details/5
        [HttpGet("/details")]
        public ActionResult Details(int id)
        {
            var model = fakeDataBase.Find(id);
            return View(model);
        }

        // GET: VegetablesController/Create
        [HttpGet("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: VegetablesController/Create
        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vegetable item)
        {
            try
            {
                fakeDataBase.Add(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VegetablesController/Edit/5
        //[HttpGet("Edit")]
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: VegetablesController/Edit/5
        [HttpGet("Edit")]
        public ActionResult Edit(int id, Vegetable item)
        {
            if (!ModelState.IsValid)
                return View();
            fakeDataBase.Update(id, item);
            return RedirectToAction(nameof(Index));
        }

       
        // POST: VegetablesController/Delete/5
        [HttpGet("Delete")]
        public ActionResult Delete(int id)
        {
            fakeDataBase.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
