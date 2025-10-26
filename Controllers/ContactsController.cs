using Microsoft.AspNetCore.Mvc;
using AddressBookAPI.Data;
using AddressBookAPI.Models;

namespace AddressBookAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private static readonly ContactDatabase _db = new ContactDatabase();

        [HttpGet]
        public ActionResult<List<Contact>> GetAll()
        {
            return Ok(_db.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Contact> GetById(int id)
        {
            var contact = _db.GetById(id);
            if (contact == null)
                return NotFound(new { message = "Contact not found" });

            return Ok(contact);
        }

        [HttpPost]
        public ActionResult<Contact> Create(Contact contact)
        {
            var created = _db.Add(contact);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public ActionResult<Contact> Update(int id, Contact contact)
        {
            var updated = _db.Update(id, contact);
            if (updated == null)
                return NotFound(new { message = "Contact not found" });

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var deleted = _db.Delete(id);
            if (!deleted)
                return NotFound(new { message = "Contact not found" });

            return NoContent();
        }

        [HttpGet("search")]
        public ActionResult<List<Contact>> Search([FromQuery] string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return BadRequest(new { message = "Query parameter is required" });

            var results = _db.Search(query);
            return Ok(results);
        }
    }
}