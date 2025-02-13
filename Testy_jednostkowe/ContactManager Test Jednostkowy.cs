using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aplikacja_kontakty.Tests
{
    [TestClass]
    public class ContactManagerTests
    {
        [TestMethod]
        public void AddContact_ShouldAddContactToList()
        {
            // Arrange
            var contactManager = new ContactManager();
            string firstName = "Jan";
            string lastName = "Kowalski";
            string phoneNumber = "123456789";
            string email = "jan.kowalski@example.com";

            // Act
            contactManager.AddContact(firstName, lastName, phoneNumber, email);

            // Assert
            var contacts = contactManager.GetContacts();
            Assert.AreEqual(1, contacts.Count); // Sprawdzamy, czy lista zawiera dok³adnie jeden kontakt
            var contact = contacts.First();
            Assert.AreEqual(firstName, contact.FirstName);
            Assert.AreEqual(lastName, contact.LastName);
            Assert.AreEqual(phoneNumber, contact.PhoneNumber);
            Assert.AreEqual(email, contact.Email);
        }

        [TestMethod]
        public void EditContact_ShouldUpdateExistingContact()
        {
            // Arrange
            var contactManager = new ContactManager();
            contactManager.AddContact("Jan", "Kowalski", "123456789", "jan.kowalski@example.com");
            var contact = contactManager.GetContacts().First();
            int id = contact.Id;

            string newFirstName = "Adam";
            string newLastName = "Nowak";
            string newPhoneNumber = "987654321";
            string newEmail = "adam.nowak@example.com";

            // Act
            contactManager.EditContact(id, newFirstName, newLastName, newPhoneNumber, newEmail);

            // Assert
            var updatedContact = contactManager.GetContacts().First();
            Assert.AreEqual(newFirstName, updatedContact.FirstName);
            Assert.AreEqual(newLastName, updatedContact.LastName);
            Assert.AreEqual(newPhoneNumber, updatedContact.PhoneNumber);
            Assert.AreEqual(newEmail, updatedContact.Email);
            Assert.IsTrue(updatedContact.UpdatedAt > contact.UpdatedAt); // Sprawdzamy, czy data aktualizacji zosta³a zmieniona
        }

        [TestMethod]
        public void DeleteContact_ShouldRemoveContactFromList()
        {
            // Arrange
            var contactManager = new ContactManager();
            contactManager.AddContact("Jan", "Kowalski", "123456789", "jan.kowalski@example.com");
            var contact = contactManager.GetContacts().First();
            int id = contact.Id;

            // Act
            contactManager.DeleteContact(id);

            // Assert
            var contacts = contactManager.GetContacts();
            Assert.AreEqual(0, contacts.Count); // Sprawdzamy, czy lista kontaktów jest pusta
        }

        [TestMethod]
        public void SearchContacts_ShouldReturnMatchingContacts()
        {
            // Arrange
            var contactManager = new ContactManager();
            contactManager.AddContact("Jan", "Kowalski", "123456789", "jan.kowalski@example.com");
            contactManager.AddContact("Adam", "Nowak", "987654321", "adam.nowak@example.com");

            // Act
            var results = contactManager.SearchContacts("Kowalski");

            // Assert
            Assert.AreEqual(1, results.Count); // Sprawdzamy, czy zwrócono dok³adnie jeden kontakt
            var contact = results.First();
            Assert.AreEqual("Jan", contact.FirstName);
            Assert.AreEqual("Kowalski", contact.LastName);
        }

        [TestMethod]
        public void DisplayAllContacts_ShouldPrintAllContacts()
        {
            // Arrange
            var contactManager = new ContactManager();
            contactManager.AddContact("Jan", "Kowalski", "123456789", "jan.kowalski@example.com");
            contactManager.AddContact("Adam", "Nowak", "987654321", "adam.nowak@example.com");

            // Act
            contactManager.DisplayAllContacts();

            // Assert
            var contacts = contactManager.GetContacts();
            Assert.AreEqual(2, contacts.Count); // Sprawdzamy, czy lista zawiera dwa kontakty
        }
    }
}