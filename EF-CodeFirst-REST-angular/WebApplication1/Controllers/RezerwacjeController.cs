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
    public class RezerwacjeController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Rezerwacje
        public IQueryable<Rezerwacje> GetRezerwacjes()
        {
            return db.Rezerwacjes;
        }

        // GET: api/Rezerwacje/5
        [ResponseType(typeof(Rezerwacje))]
        public IHttpActionResult GetRezerwacje(int id)
        {
            Rezerwacje rezerwacje = db.Rezerwacjes.Find(id);
            if (rezerwacje == null)
            {
                return NotFound();
            }

            return Ok(rezerwacje);
        }

        // PUT: api/Rezerwacje/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRezerwacje(int id, Rezerwacje rezerwacje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rezerwacje.Id)
            {
                return BadRequest();
            }

            db.Entry(rezerwacje).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RezerwacjeExists(id))
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

        // POST: api/Rezerwacje
        [ResponseType(typeof(Rezerwacje))]
        public IHttpActionResult PostRezerwacje(Rezerwacje rezerwacje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rezerwacjes.Add(rezerwacje);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rezerwacje.Id }, rezerwacje);
        }

        // DELETE: api/Rezerwacje/5
        [ResponseType(typeof(Rezerwacje))]
        public IHttpActionResult DeleteRezerwacje(int id)
        {
            Rezerwacje rezerwacje = db.Rezerwacjes.Find(id);
            if (rezerwacje == null)
            {
                return NotFound();
            }

            db.Rezerwacjes.Remove(rezerwacje);
            db.SaveChanges();

            return Ok(rezerwacje);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RezerwacjeExists(int id)
        {
            return db.Rezerwacjes.Count(e => e.Id == id) > 0;
        }
    }
}