using AddressBookAPI.Models;

namespace AddressBookAPI.Data
{
    public class ContactDatabase
    {
        private static List<Contact> _contacts = new List<Contact>();
        private static int _nextId = 1;

        public List<Contact> GetAll() => _contacts;

        public Contact? GetById(int id) => _contacts.FirstOrDefault(c => c.Id == id);

        public Contact Add(Contact contact)
        {
            contact.Id = _nextId++;
            contact.CreatedAt = DateTime.UtcNow;
            _contacts.Add(contact);
            return contact;
        }

        public Contact? Update(int id, Contact updatedContact)
        {
            var contact = GetById(id);
            if (contact == null) return null;

            contact.FirstName = updatedContact.FirstName;
            contact.LastName = updatedContact.LastName;
            contact.Email = updatedContact.Email;
            contact.Phone = updatedContact.Phone;
            contact.Address = updatedContact.Address;
            contact.Category = updatedContact.Category;

            return contact;
        }

        public bool Delete(int id)
        {
            var contact = GetById(id);
            if (contact == null) return false;

            _contacts.Remove(contact);
            return true;
        }

        public List<Contact> Search(string query)
        {
            query = query.ToLower();
            return _contacts.Where(c =>
                c.FirstName.ToLower().Contains(query) ||
                c.LastName.ToLower().Contains(query) ||
                c.Email.ToLower().Contains(query) ||
                (c.Category?.ToLower().Contains(query) ?? false)
            ).ToList();
        }
    }
}