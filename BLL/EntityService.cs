using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class EntityService
    {
        public void AddDish(List<Dishes> dishes)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter name of dish:");
                    string nameOfDish = Console.ReadLine();
                    Console.WriteLine("Enter price:");
                    double price = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter ingredients:");
                    string ingredients = Console.ReadLine();
                    Console.WriteLine("Enter time of coocking:");
                    double timeOfCoocking = Convert.ToDouble(Console.ReadLine());

                    dishes.Add(new Dishes(ingredients, nameOfDish, price, timeOfCoocking));
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void DeteteDish(List<Dishes> dishes)
        {
            Console.WriteLine("Name of dish:");
            string name = Console.ReadLine();
            if (dishes.Contains(dishes.Find(r => r.NameOfDish == name)))
            {
                dishes.Remove(dishes.Find(r => r.NameOfDish == name));
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
        public void ChangeNameOfDish(List<Dishes> dishes)
        {
            Console.WriteLine("Name of dish:");
            string name = Console.ReadLine();
            if (dishes.Contains(dishes.Find(r => r.NameOfDish == name)))
            {
                Console.WriteLine("New name:");
                var newName = Console.ReadLine();
                dishes[dishes.FindIndex(r => r.NameOfDish == name)].NameOfDish = newName;
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
        public void ChangePrice(List<Dishes> dishes)
        {
            Console.WriteLine("Name of dish:");
            string name = Console.ReadLine();
            if (dishes.Contains(dishes.Find(r => r.NameOfDish == name)))
            {
                Console.WriteLine("New price:");
                var newPrice = Convert.ToDouble(Console.ReadLine());
                dishes[dishes.FindIndex(r => r.NameOfDish == name)].Price = newPrice;
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
        public void ChangeTimeOfCoocking(List<Dishes> dishes)
        {
            Console.WriteLine("Name of dish:");
            string name = Console.ReadLine();
            if (dishes.Contains(dishes.Find(r => r.NameOfDish == name)))
            {
                Console.WriteLine("New time:");
                var newTime = Convert.ToDouble(Console.ReadLine());
                dishes[dishes.FindIndex(r => r.NameOfDish == name)].TimeOfCoocking = newTime;
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
        public void ShowAllDishes(List<Dishes> dishes)
        {
            foreach (Dishes d in dishes)
            {
                Console.WriteLine("Name of dish: " + d.NameOfDish);
                Console.WriteLine("Price: " + d.Price);
                Console.WriteLine("Ingredients: " + d.Ingredient.Replace(" ", ", "));
                Console.WriteLine("Time of coocking: " + d.TimeOfCoocking);
                Console.WriteLine();
            }
        }
        public void ShowInfoOfDish(List<Dishes> dishes)
        {
            Console.WriteLine("Name of dish:");
            string name = Console.ReadLine();
            if (dishes.Contains(dishes.Find(r => r.NameOfDish == name)))
            {
                Console.WriteLine("Name of the dish: " + dishes[dishes.FindIndex(r => r.NameOfDish == name)].NameOfDish);
                Console.WriteLine("Price: " + dishes[dishes.FindIndex(r => r.NameOfDish == name)].Price);
                Console.WriteLine("Time of coocking: " + dishes[dishes.FindIndex(r => r.NameOfDish == name)].TimeOfCoocking);
                dishes[dishes.FindIndex(r => r.NameOfDish == name)].Ingredient.Replace("  ", ", ");
                Console.WriteLine("Ingredients: " + dishes[dishes.FindIndex(r => r.NameOfDish == name)].Ingredient.Replace(" ", ", "));
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }

        public void AddIngredient(List<Dishes> dishes)
        {
            Console.WriteLine("Name of dish:");
            string name = Console.ReadLine();
            if (dishes.Contains(dishes.Find(r => r.NameOfDish == name)))
            {
                Console.WriteLine("New ingredient:");
                string newIngredient = Console.ReadLine();
                dishes[dishes.FindIndex(r => r.NameOfDish == name)].Ingredient.Replace(",", "");
                dishes[dishes.FindIndex(r => r.NameOfDish == name)].Ingredient += " " + newIngredient;
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
        public void DeleteIngredient(List<Dishes> dishes)
        {
            Console.WriteLine("Name of dish:");
            string name = Console.ReadLine();
            if (dishes.Contains(dishes.Find(r => r.NameOfDish == name)))
            {
                Console.WriteLine("Name of ingredient:");
                string nameOfIngredient = Console.ReadLine();
                dishes[dishes.FindIndex(r => r.NameOfDish == name)].Ingredient.Replace(",", "");
                dishes[dishes.FindIndex(r => r.NameOfDish == name)].Ingredient.Replace("  ", " ");
                string[] allIngredients = dishes[dishes.FindIndex(r => r.NameOfDish == name)].Ingredient.Split(' ');

                for (int i = 0; i < allIngredients.Length; i++)
                {
                    if (allIngredients[i] == nameOfIngredient)
                    {
                        string newIngridiens = dishes[dishes.FindIndex(r => r.NameOfDish == name)].Ingredient.Replace(nameOfIngredient, "");
                        dishes[dishes.FindIndex(r => r.NameOfDish == name)].Ingredient = newIngridiens;
                    }
                }
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
        public void ChangeIngredient(List<Dishes> dishes)
        {
            Console.WriteLine("Name of dish:");
            string name = Console.ReadLine();
            if (dishes.Contains(dishes.Find(r => r.NameOfDish == name)))
            {
                Console.WriteLine("Name of ingredient:");
                string nameOfIngredient = Console.ReadLine();

                string[] allIngredients = dishes[dishes.FindIndex(r => r.NameOfDish == name)].Ingredient.Split(' ');

                for (int i = 0; i < allIngredients.Length; i++)
                {
                    if (allIngredients[i] == nameOfIngredient)
                    {
                        Console.WriteLine("New ingredient:");
                        string newIngredient = Console.ReadLine();
                        string Ingridiens = dishes[dishes.FindIndex(r => r.NameOfDish == name)].Ingredient.Replace(nameOfIngredient, newIngredient);
                        dishes[dishes.FindIndex(r => r.NameOfDish == name)].Ingredient = Ingridiens;
                    }
                }
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
        public void ShowIngredientsOfDish(List<Dishes> dishes)
        {
            Console.WriteLine("Name of dish:");
            string name = Console.ReadLine();
            if (dishes.Contains(dishes.Find(r => r.NameOfDish == name)))
            {
                Console.WriteLine("It consist of " + dishes[dishes.FindIndex(r => r.NameOfDish == name)].Ingredient);
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }

        public void AddOrder(List<Orders> orders)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter number of table:");
                    int numberOfTable = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number of dishes:");
                    int numberOfDishes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter total amount:");
                    double totalAmount = Convert.ToDouble(Console.ReadLine());

                    orders.Add(new Orders(numberOfDishes, totalAmount, numberOfTable));
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void DeleteOrder(List<Orders> orders)
        {
            Console.WriteLine("Enter number of table:");
            int numberOfTable = Convert.ToInt32(Console.ReadLine());
            if (orders.Contains(orders.Find(r => r.NumberOfTable == numberOfTable)))
            {
                orders.Remove(orders.Find(r => r.NumberOfTable == numberOfTable));
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
        public void ChangeNumberOfDishesInOrder(List<Orders> orders)
        {
            Console.WriteLine("Enter number of table:");
            int numberOfTable = Convert.ToInt32(Console.ReadLine());
            if (orders.Contains(orders.Find(r => r.NumberOfTable == numberOfTable)))
            {
                Console.WriteLine("New number of dishes:");
                int newNumberOfDishes = Convert.ToInt32(Console.ReadLine());
                orders[orders.FindIndex(r => r.NumberOfTable == numberOfTable)].NumberOfDishes = newNumberOfDishes;
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
        public void ChangeTotalAmountInOrder(List<Orders> orders)
        {
            Console.WriteLine("Enter number of table:");
            int numberOfTable = Convert.ToInt32(Console.ReadLine());
            if (orders.Contains(orders.Find(r => r.NumberOfTable == numberOfTable)))
            {
                Console.WriteLine("New total amount:");
                double newTotalAmount = Convert.ToDouble(Console.ReadLine());
                orders[orders.FindIndex(r => r.NumberOfTable == numberOfTable)].TotalAmount = newTotalAmount;
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
        public void ChangeNumberOfTableInOrder(List<Orders> orders)
        {
            Console.WriteLine("Enter number of table:");
            int numberOfTable = Convert.ToInt32(Console.ReadLine());
            if (orders.Contains(orders.Find(r => r.NumberOfTable == numberOfTable)))
            {
                Console.WriteLine("New number of table:");
                int newNumberOfTable = Convert.ToInt32(Console.ReadLine());
                orders[orders.FindIndex(r => r.NumberOfTable == numberOfTable)].NumberOfDishes = numberOfTable;
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
        public void ShowInfoOfOrder(List<Orders> orders)
        {
            Console.WriteLine("Enter number of table:");
            int numberOfTable = Convert.ToInt32(Console.ReadLine());
            if (orders.Contains(orders.Find(r => r.NumberOfTable == numberOfTable)))
            {
                Console.WriteLine("Number of table: " + orders[orders.FindIndex(r => r.NumberOfTable == numberOfTable)].NumberOfTable);
                Console.WriteLine("Number of dish: " + orders[orders.FindIndex(r => r.NumberOfTable == numberOfTable)].NumberOfDishes);
                Console.WriteLine("Total amount: " + orders[orders.FindIndex(r => r.NumberOfTable == numberOfTable)].TotalAmount);
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
        public void ShowInfoOfAllOrders(List<Orders> orders)
        {
            foreach (Orders o in orders)
            {
                Console.WriteLine("Number of table: " + o.NumberOfTable);
                Console.WriteLine("Number of dish: " + o.NumberOfDishes);
                Console.WriteLine("Total amount: " + o.TotalAmount);
                Console.WriteLine();
            }
        }

        public void SerchingForIngredient(List<Dishes> dishes)
        {
            Console.WriteLine("Enter key word of ingredient:");
            string keyWord = Console.ReadLine();
            for (int i = 0; i < dishes.Count; i++)
            {
                if (dishes[i].Ingredient.Contains(keyWord))
                {
                    Console.WriteLine("Dishes that consist of this ingredient: ");
                    Console.WriteLine("Name of dish: " + dishes[i].NameOfDish);
                    Console.WriteLine("Ingredients: " + dishes[i].Ingredient);
                }
            }
        }
        public void SearchingForOrders(List<Orders> orders)
        {
            Console.WriteLine("Enter key number of table:");
            int keyNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].NumberOfTable == keyNumber)
                {
                    Console.WriteLine("Information of ordering of this table:");
                    Console.WriteLine("Number of table: " + orders[i].NumberOfTable);
                    Console.WriteLine("Number of dishes: " + orders[i].NumberOfDishes);
                    Console.WriteLine("Total amount: " + orders[i].TotalAmount);
                }
            }
        }
    }
}
