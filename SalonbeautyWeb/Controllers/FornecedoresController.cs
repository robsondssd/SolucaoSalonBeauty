using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SalonbeautyWeb.Models;

namespace SalonbeautyWeb.Controllers
{
    public class FornecedoresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Fornecedores/
        public ActionResult Index()
        {
            return View(db.Fornecedores.ToList());
        }

        // GET: /Fornecedores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fornecedores fornecedores = db.Fornecedores.Find(id);
            if (fornecedores == null)
            {
                return HttpNotFound();
            }
            return View(fornecedores);
        }

        // GET: /Fornecedores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Fornecedores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Nome,Bairro,Cidade,Cep,Email,Cnpj,Telefone")] Fornecedores fornecedores)
        {
            if (ModelState.IsValid)
            {
                db.Fornecedores.Add(fornecedores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fornecedores);
        }

        // GET: /Fornecedores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fornecedores fornecedores = db.Fornecedores.Find(id);
            if (fornecedores == null)
            {
                return HttpNotFound();
            }
            return View(fornecedores);
        }

        // POST: /Fornecedores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Nome,Bairro,Cidade,Cep,Email,Cnpj,Telefone")] Fornecedores fornecedores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fornecedores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fornecedores);
        }

        // GET: /Fornecedores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fornecedores fornecedores = db.Fornecedores.Find(id);
            if (fornecedores == null)
            {
                return HttpNotFound();
            }
            return View(fornecedores);
        }

        // POST: /Fornecedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fornecedores fornecedores = db.Fornecedores.Find(id);
            db.Fornecedores.Remove(fornecedores);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
