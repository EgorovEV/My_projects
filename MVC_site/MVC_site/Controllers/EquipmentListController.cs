using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_site.Models;

namespace MVC_site.Controllers
{
    public class EquipmentListController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EquipmentList
        public async Task<ActionResult> Index()
        {
            return View(await db.equipmentLists.ToListAsync());
        }

        // GET: EquipmentList/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentList equipmentList = await db.equipmentLists.FindAsync(id);
            if (equipmentList == null)
            {
                return HttpNotFound();
            }
            return View(equipmentList);
        }

        // GET: EquipmentList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquipmentList/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "equipmentId,EquipmentType,EquipmentLocation,EquipmentCondition")] EquipmentList equipmentList)
        {
            if (ModelState.IsValid)
            {
                db.equipmentLists.Add(equipmentList);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(equipmentList);
        }

        // GET: EquipmentList/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentList equipmentList = await db.equipmentLists.FindAsync(id);
            if (equipmentList == null)
            {
                return HttpNotFound();
            }
            return View(equipmentList);
        }

        // POST: EquipmentList/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "equipmentId,EquipmentType,EquipmentLocation,EquipmentCondition")] EquipmentList equipmentList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipmentList).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(equipmentList);
        }

        // GET: EquipmentList/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentList equipmentList = await db.equipmentLists.FindAsync(id);
            if (equipmentList == null)
            {
                return HttpNotFound();
            }
            return View(equipmentList);
        }

        // POST: EquipmentList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            EquipmentList equipmentList = await db.equipmentLists.FindAsync(id);
            db.equipmentLists.Remove(equipmentList);
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
