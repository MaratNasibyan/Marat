using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCOOP1.Models;

namespace MVCOOP1.Controllers
{
    public class HumenController : Controller
    {
        private MVCEntities1 db = new MVCEntities1();

        // GET: Humen
        public ActionResult Index()
        {
            return View(db.Humen.ToList());
        }
        //public ActionResult Index(int page = 1)
        //{
        //    int pageSize = 3; // количество объектов на страницу
        //    IEnumerable<Human> phonesPerPages = Human.Skip((page - 1) * pageSize).Take(pageSize);
        //    PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = Humans.Count };
        //    IndexViewModel ivm = new IndexViewModel { PageInfo = pageInfo, Humans = phonesPerPages };
        //    return View(ivm);
        //}
    }

    // GET: Humen/Details/5
    public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Human human = db.Humen.Find(id);
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
        public ActionResult Create([Bind(Include = "ISN,NAME,SURNAME,DATEBIRTH")] Human human)
        {
            if (ModelState.IsValid)
            {
                db.Humen.Add(human);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(human);
        }

        // GET: Humen/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Human human = db.Humen.Find(id);
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
        public ActionResult Edit([Bind(Include = "ISN,NAME,SURNAME,DATEBIRTH")] Human human)
        {
            if (ModelState.IsValid)
            {
                db.Entry(human).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(human);
        }

        // GET: Humen/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Human human = db.Humen.Find(id);
            if (human == null)
            {
                return HttpNotFound();
            }
            return View(human);
        }

        // POST: Humen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Human human = db.Humen.Find(id);
            db.Humen.Remove(human);
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
        public string Info()
        {
            string browser = HttpContext.Request.Browser.Browser;
            string user_agent = HttpContext.Request.UserAgent;
            string url = HttpContext.Request.RawUrl;
            string ip = HttpContext.Request.UserHostAddress;
            string referrer = HttpContext.Request.UrlReferrer == null ? "" : HttpContext.Request.UrlReferrer.AbsoluteUri;
            return "<p>Browser: " + browser + "</p><p>User-Agent: " + user_agent + "</p><p>Url запроса: " + url +
                "</p><p>Реферер: " + referrer + "</p><p>IP-адрес: " + ip + "</p>";
        }
    }
}
