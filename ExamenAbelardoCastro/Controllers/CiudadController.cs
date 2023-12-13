using ExamenAbelardoCastro.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenAbelardoCastro.Controllers
{
    public class CiudadController : Controller
    {
        // GET: Ciudad
        public ActionResult Index()
        {
            using (DbModels contex = new DbModels())
            {
                return View(contex.Ciudad.ToList());
            }
        }

        // GET: Ciudad/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels contex = new DbModels())
            {
                return View(contex.Ciudad.Where(x => x.ciudadId == id).FirstOrDefault());
            }
        }

        // GET: Ciudad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ciudad/Create
        [HttpPost]
        public ActionResult Create(Ciudad ciudad)
        {
            try
            {
                // TODO: Add insert logic here
                using (DbModels contex = new DbModels())
                {
                    contex.Ciudad.Add(ciudad);
                    contex.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ciudad/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels contex = new DbModels())
            {
                return View(contex.Ciudad.Where(x => x.ciudadId == id).FirstOrDefault());
            }
        }

        // POST: Ciudad/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Ciudad ciudad)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModels contex = new DbModels())
                {
                    contex.Entry(ciudad).State = EntityState.Modified;
                    contex.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ciudad/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels contex = new DbModels())
            {
                return View(contex.Ciudad.Where(x => x.ciudadId == id).FirstOrDefault());
            }
        }
    

        // POST: Ciudad/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels contex = new DbModels())
                {
                    Ciudad ciudad = contex.Ciudad.Where(x => x.ciudadId == id).FirstOrDefault();
                    contex.Ciudad.Remove(ciudad);
                    contex.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
