using PhoneBookConsole.DbContexts;
using PhoneBookConsole.Models;

namespace PhoneBookConsole.Data;

public class EfDbManager : IDbManager
{
    public void AddNewContact(Contact newContact)
    {
        using (var db = new ContactContext())
        {
            db.Add(newContact);
            db.SaveChanges();
        }
    }

    public void UpdateContact(Contact oldContact, Contact newContact)
    {
        using (var db = new ContactContext())
        {
            var old = db.Contacts.Where(x => x.Name == oldContact.Name).First();
            old.Name = newContact.Name;
            old.PhoneNumber = newContact.PhoneNumber;
            db.SaveChanges();
        }
    }

    public void DeleteContact(Contact contact)
    {
        using (var db = new ContactContext())
        {
            var toBeDeleted = db.Contacts.Where(x => x.Name == contact.Name).First();
            db.Remove(toBeDeleted);
            db.SaveChanges();
        }
    }

    public List<Contact> GetContacts()
    {
        using (var db = new ContactContext())
        {
            var contactList = db.Contacts.ToList();

            return contactList;
        }
    }
}