using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aplikacja_kontakty;
using System;
using System.Linq;

namespace AplikacjaKontaktyTests
{
    [TestClass]
    public class ContactManagerTests
    {
        private ContactManager contactManager;

        [TestInitialize]
        public void SetUp()
        {
            contactManager = new ContactManager();
        }

        [TestMethod]
        public void AddContact_ShouldAddContactToList()
        {
            contactManager.AddContact("Jan", "Kowalski", "123456789", "jan.kowalski@example.com");
            var contacts = contactManager.GetContacts();

            Assert.AreEqual(1, contacts.Count);
            Assert.AreEqual("Jan", contacts[0].FirstName);
        }

        [TestMethod]
        public void EditContact_ShouldUpdateContactDetails()
        {
            contactManager.AddContact("Jan", "Kowalski", "123456789", "jan.kowalski@example.com");
            var contact = contactManager.GetContacts().First();
            contactManager.EditContact(contact.Id, "Adam", "Nowak", "987654321", "adam.nowak@example.com");

            Assert.AreEqual("Adam", contact.FirstName);
            Assert.AreEqual("Nowak", contact.LastName);
            Assert.AreEqual("987654321", contact.PhoneNumber);
        }

        [TestMethod]
        public void DeleteContact_ShouldRemoveContactFromList()
        {
            contactManager.AddContact("Jan", "Kowalski", "123456789", "jan.kowalski@example.com");
            var contact = contactManager.GetContacts().First();
            contactManager.DeleteContact(contact.Id);

            Assert.AreEqual(0, contactManager.GetContacts().Count);
        }

        [TestMethod]
        public void SearchContacts_ShouldReturnMatchingContacts()
        {
            contactManager.AddContact("Jan", "Kowalski", "123456789", "jan.kowalski@example.com");
            var results = contactManager.GetContacts().Where(c => c.FirstName == "Jan").ToList();

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("Kowalski", results[0].LastName);
        }

        [TestMethod]
        public void SearchContacts_ShouldReturnEmptyListIfNoMatch()
        {
            contactManager.AddContact("Jan", "Kowalski", "123456789", "jan.kowalski@example.com");
            var results = contactManager.GetContacts().Where(c => c.FirstName == "Adam").ToList();

            Assert.AreEqual(0, results.Count);
        }
    }
}
