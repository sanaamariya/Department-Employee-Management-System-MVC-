using Microsoft.AspNetCore.Mvc;

namespace crudapp.Controllers
{
    public class Dept1Controller : Controller
    {
        // GET: Dept1
        public ActionResult Index()
        {
            Models.datalayer lst = new Models.datalayer();
            return View("~/Views/Dept1/Index.cshtml", lst.GetDepts());
        }
        // GET: Dept1/Details/5
        public ActionResult Details(int id)
        {
            crudapp.Models.datalayer dpt = new crudapp.Models.datalayer();
            //dpt.GetdeptData(id);
            return View(dpt.GetdeptData(id));
        }
        public ActionResult Create()
        {
            return View();
        }
        // POST: Dept1/Create
        [HttpPost]
        public ActionResult Create(crudapp.Models.Dept dpt)
        {   
            if (!ModelState.IsValid)
    {
        return View(dpt); // Return view with validation errors
    }
            try
            {
                // TODO: Add insert logic here
                crudapp.Models.datalayer created = new crudapp.Models.datalayer();
                var existing = created.GetdeptData(dpt.dno);

                if (existing != null && existing.dno == dpt.dno)
                {
                    ModelState.AddModelError("dno", "Department ID already exists!");
                    return View(dpt); // Return the form with error
                }
                created.createdept(dpt);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();

            }

        }
        // GET: Dept1/Edit/5
        public ActionResult Edit(int id)
        {
            crudapp.Models.datalayer dpt = new crudapp.Models.datalayer();
            // dpt.GetdeptData(id);
            return View(dpt.GetdeptData(id));
        }
        // POST: Dept1/Edit/5
        [HttpPost]
        public ActionResult Edit(int i, crudapp.Models.Dept dpt)
        {
            if (!ModelState.IsValid)
    {
        return View(dpt); // Return view with validation errors
    }
            try
            {
                crudapp.Models.datalayer dpt1 = new crudapp.Models.datalayer();
                dpt1.updatedept(dpt);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Dept1/Delete/5
        public ActionResult Delete(int id)
        {
            crudapp.Models.datalayer dpt = new crudapp.Models.datalayer();
            return View(dpt.GetdeptData(id));

        }
        // POST: Dept1/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                crudapp.Models.datalayer dpt1 = new crudapp.Models.datalayer();
                dpt1.DeleteStudent(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(); 
            }
        }
    }
}