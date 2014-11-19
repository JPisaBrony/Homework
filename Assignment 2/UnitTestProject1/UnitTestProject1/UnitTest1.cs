//  Unit tests cases
//  by Josh Pohl and
//  Mathew Leet

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Test_InvoiceConstructor()
        {
            Address address = new Address("Bob", "17th street", "Fargo", "12345", "North Dakota", "USA");
            LineItem item = new LineItem(new Product(20.0M, "hammer"));

            Invoice invoice = new Invoice(item, address);

            string expected1 = "Bob";
            string expected2 = "17th street";
            string expected3 = "Fargo";
            string expected4 = "12345";
            string expected5 = "North Dakota";
            string expected6 = "USA";
            decimal expected7 = 20.0M;
            string expected8 = "hammer";

            Assert.AreEqual(expected1, address.Name);
            Assert.AreEqual(expected2, address.Street);
            Assert.AreEqual(expected3, address.City);
            Assert.AreEqual(expected4, address.ZipCode);
            Assert.AreEqual(expected5, address.State);
            Assert.AreEqual(expected6, address.Country);
            Assert.AreEqual(expected7, item.getProduct().Amount);
            Assert.AreEqual(expected8, item.getProduct().Description);
        }

        [TestMethod]
        public void Test_LineConstructor()
        {
            LineItem item = new LineItem(new Product(20.0M, "hammer"));

            decimal expected = 20.0M;
            string expected2 = "hammer";

            Assert.AreEqual(expected, item.getProduct().Amount);
            Assert.AreEqual(expected2, item.getProduct().Description);
        }

        [TestMethod]
        public void Test_AddressConstructor()
        {
            Address address = new Address("Bob", "17th street", "Fargo", "12345", "North Dakota", "USA");

            string expected1 = "Bob";
            string expected2 = "17th street";
            string expected3 = "Fargo";
            string expected4 = "12345";
            string expected5 = "North Dakota";
            string expected6 = "USA";

            Assert.AreEqual(expected1, address.Name);
            Assert.AreEqual(expected2, address.Street);
            Assert.AreEqual(expected3, address.City);
            Assert.AreEqual(expected4, address.ZipCode);
            Assert.AreEqual(expected5, address.State);
            Assert.AreEqual(expected6, address.Country);
        }

        [TestMethod]
        public void Test_ProductConstructor()
        {
            Product pro = new Product(20.0M, "hammer");

            decimal expected = 20.0M;
            string expected2 = "hammer";

            Assert.AreEqual(expected, pro.Amount);
            Assert.AreEqual(expected2, pro.Description);
        }

        [TestMethod]
        public void Test_FindQuantity()
        {
            LineItem item = new LineItem(new Product(20.0M, "hammer"));

            int expected = 1;

            Assert.AreEqual(expected, item.getQuantity());
        }

        [TestMethod]
        public void Test_LineItemTotal()
        {
            LineItem item = new LineItem(new Product(20.0M, "hammer"));

            int expected = 1;

            Assert.AreEqual(expected, item.getLineItemTotal());
        }

        [TestMethod]
        public void Test_GrandTotal()
        {
            Invoice item = new Invoice(new LineItem(new Product(20.0M, "hammer")), new Address("Bob", "17th street", "Fargo", "12345", "North Dakota", "USA"));

            decimal expected = 20.0M;

            Assert.AreEqual(expected, item.grandTotal());
        }


        [TestMethod]
        public void Test_AddressToString()
        {
            Address address = new Address("Bob", "17th street", "Fargo", "12345", "North Dakota", "USA");

            string expected = "name: Bob\nstreet: 17th street\ntown: Fargo\nzipCode: 12345\nstate: North Dakota\ncountry: USA";

            Assert.AreEqual(expected, address.ToString());
        }

    }
}
