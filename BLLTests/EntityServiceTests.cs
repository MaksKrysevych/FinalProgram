using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DAL;

namespace BLL.Tests
{
    [TestClass()]
    public class EntityServiceTests
    {
        [TestMethod()]
        public void AddDishTest()
        {
            List<Dishes> dishes = new List<Dishes>();
            dishes.Add(new Dishes("potato carrot egg mayonez onion", "Olivye", 30, 40));

            Assert.AreEqual(1, dishes.Count);
        }


        [TestMethod]
        public void TestDeleteStudent()
        {
            List<Dishes> dishes = new List<Dishes>();
            dishes.Add(new Dishes("potato carrot egg mayonez onion", "Olivye", 30, 40));
            dishes.Remove(dishes.Find(r => r.NameOfDish == "Olivye"));

            Assert.AreEqual(0, dishes.Count);
        }

        [TestMethod]
        public void TestUpdateData()
        {
            List<Dishes> dishes = new List<Dishes>();
            dishes.Add(new Dishes("potato carrot egg mayonez onion", "Olivye", 30, 40));
            dishes[dishes.FindIndex(r => r.NameOfDish == "Olivye")].Price = 45;

            Assert.AreEqual(45, dishes[dishes.FindIndex(r => r.NameOfDish == "Olivye")].Price);
        }
        [TestMethod]
        public void TestSerchingForIngredient()
        {
            List<Dishes> dishes = new List<Dishes>();
            dishes.Add(new Dishes("potato carrot egg mayonez onion", "Olivye", 30, 40));
            dishes.Add(new Dishes("potato", "Potato free", 30, 10));

            int count = 0;
            for (int i = 0; i < dishes.Count; i++)
            {
                if (dishes[i].Ingredient.Contains("potato"))
                {
                    count++;
                }
            }

            Assert.AreEqual(2, count);
        }


    }
}