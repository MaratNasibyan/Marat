using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCOOPDATA.Models;

namespace MVCOOPDATA.Controllers
{
    public class HumenController : Controller
    {
        private MVCEntities db = new MVCEntities();

        // GET: Humen
        public async Task<ActionResult> Index()
        {
            return View(await db.Humen.ToListAsync());
        }

        // GET: Humen/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Human human = await db.Humen.FindAsync(id);
            if (human == null)
            {
                return HttpNotFound();
            }
            return View(human);
        }

        // GET: Humen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Humen/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ISN,NAME,SURNAME,DATEBIRTH")] Human human)
        {
            if (ModelState.IsValid)
            {
                db.Humen.Add(human);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(human);
        }

        // GET: Humen/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Human human = await db.Humen.FindAsync(id);
            if (human == null)
            {
                return HttpNotFound();
            }
            return View(human);
        }

        // POST: Humen/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ISN,NAME,SURNAME,DATEBIRTH")] Human human)
        {
            if (ModelState.IsValid)
            {
                db.Entry(human).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(human);
        }

        // GET: Humen/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Human human = await db.Humen.FindAsync(id);
            if (human == null)
            {
                return HttpNotFound();
            }
            return View(human);
        }

        // POST: Humen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Human human = await db.Humen.FindAsync(id);
            db.Humen.Remove(human);
            await db.SaveChangesAsync();
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
