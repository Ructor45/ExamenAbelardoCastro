using ExamenAbelardoCastro.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenAbelardoCastro.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            using (DbModels contex = new DbModels())
            {
                return View(contex.Categoria.ToList());
            }
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels contex = new DbModels())
            {
                return View(contex.Categoria.Where(x => x.categoriaId == id).FirstOrDefault());
            }
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            try
            {
                // TODO: Add insert logic here
                using (DbModels contex = new DbModels())
                {
                    contex.Categoria.Add(categoria);
                    contex.SaveChanges();
                }

                return RedirectToAction("Index");
               
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels contex = new DbModels())
            {
                return View(contex.Categoria.Where(x => x.categoriaId == id).FirstOrDefault());
            }
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Categoria categoria)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModels contex = new DbModels())
                {
                    contex.Entry(categoria).State = EntityState.Modified;
                    contex.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels contex = new DbModels())
            {
                return View(contex.Categoria.Where(x => x.categoriaId == id).FirstOrDefault());
            }
        }

        // POST: Categoria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DbModels contex = new DbModels())
                {
                    Categoria categoria = contex.Categoria.Where(x => x.categoriaId == id).FirstOrDefault();
                    contex.Categoria.Remove(categoria);
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
