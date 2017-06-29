using MVC_APP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace MVC_APP.Controllers
{
    public class PhoneApiController : ApiController
    {
        private PhoneContext context = new PhoneContext();

        // GET: api/PhoneApi
        [HttpGet]
        public IEnumerable<Phone> Get() {
            return context.Phones;
        }

        // GET: api/PhoneApi/5
        [HttpGet]
        [ResponseType(typeof(Phone))]
        public IHttpActionResult Get(int id) {
            Phone phone = context.Phones.Find(id);
            if (phone == null) {
                return NotFound();
            }
            return Ok(phone);
        }

        // POST: api/PhoneApi
        [HttpPost]
        [ResponseType(typeof(Phone))]
        public IHttpActionResult Post(Phone phone) {
            if (!ModelState.IsValid) {
                return (BadRequest(ModelState));
            }

            context.Phones.Add(phone);
            context.SaveChanges();

            return (CreatedAtRoute("DefaultApi", new { id = phone.ID }, phone));
        }

        // PUT: api/PhoneApi/5
        [HttpPut]
        [ResponseType(typeof(Phone))]
        public IHttpActionResult Put(Phone ToUpdatePhone) {
            Phone phone = context.Phones.Find(ToUpdatePhone.ID);
            phone.Surname = ToUpdatePhone.Surname;
            phone.FirstName = ToUpdatePhone.FirstName;
            phone.MiddleName = ToUpdatePhone.MiddleName;
            phone.PhoneNumber = ToUpdatePhone.PhoneNumber;
            phone.BDay = ToUpdatePhone.BDay;

            if (!ModelState.IsValid) {
                return (BadRequest(ModelState));
            }

            if (ToUpdatePhone.ID != phone.ID) {
                return BadRequest();
            }

            context.Entry(phone).State = System.Data.Entity.EntityState.Modified;

            try {
                context.SaveChanges();
                return (Ok(phone));
            } catch (DbUpdateConcurrencyException) {
                if (!PhoneExists(ToUpdatePhone.ID)) {
                    return NotFound();
                } else {
                    throw;
                    return StatusCode(HttpStatusCode.NoContent);
                }
            }
        }

        // DELETE: api/PhoneApi/5
        [HttpDelete]
        [ResponseType(typeof(Phone))]
        public IHttpActionResult Delete(int id) {
            Phone phone = context.Phones.Find(id);
            if (phone == null) {
                return (NotFound());
            }

            context.Phones.Remove(phone);
            context.SaveChanges();

            return (Ok(phone));
        }

        private bool PhoneExists(int id) {
            return context.Phones.Count(e => e.ID == id) > 0;
        }
    }
}
