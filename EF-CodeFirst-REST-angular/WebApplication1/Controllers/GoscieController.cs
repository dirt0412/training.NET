using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GoscieController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Goscie
        public IQueryable<Goscie> GetGoscies()
        {
            return db.Goscies;
        }

        // GET: api/Goscie/5
        [ResponseType(typeof(Goscie))]
        public IHttpActionResult GetGoscie(int id)
        {
            Goscie goscie = db.Goscies.Find(id);
            if (goscie == null)
            {
                return NotFound();
            }

            return Ok(goscie);
        }

        // PUT: api/Goscie/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGoscie(int id, Goscie goscie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != goscie.Id)
            {
                return BadRequest();
            }

            db.Entry(goscie).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GoscieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Goscie
        [ResponseType(typeof(Goscie))]
        public IHttpActionResult PostGoscie(Goscie goscie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Goscies.Add(goscie);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = goscie.Id }, goscie);
        }

        // DELETE: api/Goscie/5
        [ResponseType(typeof(Goscie))]
        public IHttpActionResult DeleteGoscie(int id)
        {
            Goscie goscie = db.Goscies.Find(id);
            if (goscie == null)
            {
                return NotFound();
            }

            db.Goscies.Remove(goscie);
            db.SaveChanges();

            return Ok(goscie);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GoscieExists(int id)
        {
            return db.Goscies.Count(e => e.Id == id) > 0;
        }
    }
}