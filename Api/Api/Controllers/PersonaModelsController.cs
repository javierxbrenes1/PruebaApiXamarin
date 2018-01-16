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
using Api.Models;

namespace Api.Controllers
{
    public class PersonaModelsController : ApiController
    {
        private ApiContext db = new ApiContext();

        // GET: api/PersonaModels
        public IQueryable<PersonaModel> GetPersonaModels()
        {
            return db.PersonaModels;
        }

        // GET: api/PersonaModels/5
        [ResponseType(typeof(PersonaModel))]
        public IHttpActionResult GetPersonaModel(string id)
        {
            PersonaModel personaModel = db.PersonaModels.Find(id);
            if (personaModel == null)
            {
                return NotFound();
            }

            return Ok(personaModel);
        }

        // PUT: api/PersonaModels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPersonaModel(string id, PersonaModel personaModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != personaModel.Id)
            {
                return BadRequest();
            }

            db.Entry(personaModel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonaModelExists(id))
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

        // POST: api/PersonaModels
        [ResponseType(typeof(PersonaModel))]
        public IHttpActionResult PostPersonaModel(PersonaModel personaModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PersonaModels.Add(personaModel);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (PersonaModelExists(personaModel.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = personaModel.Id }, personaModel);
        }

        // DELETE: api/PersonaModels/5
        [ResponseType(typeof(PersonaModel))]
        public IHttpActionResult DeletePersonaModel(string id)
        {
            PersonaModel personaModel = db.PersonaModels.Find(id);
            if (personaModel == null)
            {
                return NotFound();
            }

            db.PersonaModels.Remove(personaModel);
            db.SaveChanges();

            return Ok(personaModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PersonaModelExists(string id)
        {
            return db.PersonaModels.Count(e => e.Id == id) > 0;
        }
    }
}