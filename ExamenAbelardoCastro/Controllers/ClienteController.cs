using ExamenAbelardoCastro.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenAbelardoCastro.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            using (DbModels contex = new DbModels())
            {
                return View(contex.Cliente.ToList());
            }
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels contex = new DbModels())
            {
                return View(contex.Cliente.Where(x => x.clienteId == id).FirstOrDefault());
            }
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                using (DbModels contex = new DbModels())
                {
                    contex.Cliente.Add(cliente);
                    contex.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels contex = new DbModels())
            {
                return View(contex.Cliente.Where(x => x.clienteId == id).FirstOrDefault());
            }
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModels contex = new DbModels())
                {
                    contex.Entry(cliente).State = EntityState.Modified;
                    contex.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels contex = new DbModels())
            {
                return View(contex.Cliente.Where(x => x.clienteId == id).FirstOrDefault());
            }
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DbModels contex = new DbModels())
                {
                    Cliente cliente = contex.Cliente.Where(x => x.clienteId == id).FirstOrDefault();
                    contex.Cliente.Remove(cliente);
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
