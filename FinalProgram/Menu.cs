using BLL;
using DAL;
using System;
using System.Collections.Generic;

namespace FinalProgram
{
    public class Menu
    {
        List<Dishes> dishes = new List<Dishes>();
        List<Orders> orders = new List<Orders>();
        EntityService entityService = new EntityService();
        DataProvider dataProvider = new DataProvider();
        

        public void MainMenu()
        {
            bool workingOfMenu = true;
            while (workingOfMenu)
            {
                MenuOfMainMenu();
                Console.WriteLine("Choice:");
                int option;
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.WriteLine("Action is't exist");
                        Console.WriteLine("Try again!");
                    }
                    break;
                }

                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();
                            FoodManagement();
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            OrderingManagement();

                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Searching();

                            break;
                        }

                    case 4:
                        {
                            workingOfMenu = false;
                            break;
                        }

                    default:
                        break;
                }
            }
        }

        void FoodManagement()
        {
            bool workingOfMenu = true;
            while (workingOfMenu)
            {
                MenuOfFoodManagement();
                Console.WriteLine("Choice:");
                int option;
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.WriteLine("Action is't exist");
                        Console.WriteLine("Try again!");
                    }
                    break;
                }

                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();
                            IngredientManagement();
                            dataProvider.JSONSerializationOfDishes(dishes);
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            entityService.AddDish(dishes);
                            dataProvider.JSONSerializationOfDishes(dishes);
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            entityService.DeteteDish(dishes);
                            dataProvider.JSONSerializationOfDishes(dishes);
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            ChangingInfoOfDish();
                            dataProvider.JSONSerializationOfDishes(dishes);
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();
                            entityService.ShowInfoOfDish(dishes);

                            while (true)
                            {
                                Console.WriteLine("Enter x - to exit");
                                string exit = Console.ReadLine();

                                if (exit == "x")
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Try again!");
                                }
                            }
                            break;
                        }

                    case 6:
                        {
                            Console.Clear();
                            entityService.ShowAllDishes(dishes);

                            while (true)
                            {
                                Console.WriteLine("Enter x - to exit");
                                string exit = Console.ReadLine();

                                if (exit == "x")
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Try again!");
                                }
                            }
                            break;
                        }

                    case 7:
                        {
                            Console.Clear();
                            workingOfMenu = false;
                            break;
                        }

                    default:
                        break;
                }
            }

        }
        void IngredientManagement()
        {
            bool workingOfMenu = true;
            while (workingOfMenu)
            {
                MenuOfIngredientManagement();
                Console.WriteLine("Choice:");
                int option;
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.WriteLine("Action is't exist");
                        Console.WriteLine("Try again!");
                    }
                    break;
                }

                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();
                            entityService.AddIngredient(dishes);
                            dataProvider.JSONSerializationOfDishes(dishes);
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            entityService.DeleteIngredient(dishes);
                            dataProvider.JSONSerializationOfDishes(dishes);

                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            entityService.ChangeIngredient(dishes);
                            dataProvider.JSONSerializationOfDishes(dishes);
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            entityService.ShowInfoOfDish(dishes);
                            while (true)
                            {
                                Console.WriteLine("Enter x - to exit");
                                string exit = Console.ReadLine();

                                if (exit == "x")
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Try again!");
                                }
                            }
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();
                            workingOfMenu = false;
                            break;
                        }

                    default:
                        break;
                }
            }

        }
        void ChangingInfoOfDish()
        {
            bool workingOfMenu = true;
            while (workingOfMenu)
            {
                MenuOfChangingInfoOfDish();
                Console.WriteLine("Choice:");
                int option;
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.WriteLine("Action is't exist");
                        Console.WriteLine("Try again!");
                    }
                    break;
                }

                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();
                            entityService.ChangeNameOfDish(dishes);
                            dataProvider.JSONSerializationOfDishes(dishes);
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            entityService.ChangePrice(dishes);
                            dataProvider.JSONSerializationOfDishes(dishes);

                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            entityService.ChangeTimeOfCoocking(dishes);
                            dataProvider.JSONSerializationOfDishes(dishes);
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            entityService.ShowInfoOfDish(dishes);
                            while (true)
                            {
                                Console.WriteLine("Enter x - to exit");
                                string exit = Console.ReadLine();

                                if (exit == "x")
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Try again!");
                                }
                            }
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();
                            workingOfMenu = false;
                            break;
                        }

                    default:
                        break;
                }
            }
        }

        void OrderingManagement()
        {
            bool workingOfMenu = true;
            while (workingOfMenu)
            {
                MenuOfOrderingManagement();
                Console.WriteLine("Choice:");
                int option;
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.WriteLine("Action is't exist");
                        Console.WriteLine("Try again!");
                    }
                    break;
                }

                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();
                            entityService.AddOrder(orders);
                            dataProvider.JSONSerializationOfOrders(orders);
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            entityService.DeleteOrder(orders);
                            dataProvider.JSONSerializationOfOrders(orders);
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            ChangingInfoOfOrdering();
                            dataProvider.JSONSerializationOfOrders(orders);
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            entityService.ShowInfoOfOrder(orders);
                            while (true)
                            {
                                Console.WriteLine("Enter x - to exit");
                                string exit = Console.ReadLine();

                                if (exit == "x")
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Try again!");
                                }
                            }
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();
                            entityService.ShowInfoOfAllOrders(orders);
                            while (true)
                            {
                                Console.WriteLine("Enter x - to exit");
                                string exit = Console.ReadLine();

                                if (exit == "x")
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Try again!");
                                }
                            }
                            break;
                        }

                    case 6:
                        {
                            Console.Clear();
                            workingOfMenu = false;
                            break;
                        }

                    default:
                        break;
                }
            }
        }
        void ChangingInfoOfOrdering()
        {
            bool workingOfMenu = true;
            while (workingOfMenu)
            {
                MenuOfChangingInfoOfOrdering();
                Console.WriteLine("Choice:");
                int option;
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.WriteLine("Action is't exist");
                        Console.WriteLine("Try again!");
                    }
                    break;
                }

                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();
                            entityService.ChangeNumberOfDishesInOrder(orders);
                            dataProvider.JSONSerializationOfOrders(orders);
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            entityService.ChangeTotalAmountInOrder(orders);
                            dataProvider.JSONSerializationOfOrders(orders);
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            entityService.ChangeNumberOfTableInOrder(orders);
                            dataProvider.JSONSerializationOfOrders(orders);
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            entityService.ShowInfoOfOrder(orders);
                            while (true)
                            {
                                Console.WriteLine("Enter x - to exit");
                                string exit = Console.ReadLine();

                                if (exit == "x")
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Try again!");
                                }
                            }
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();
                            workingOfMenu = false;
                            break;
                        }

                    default:
                        break;
                }
            }
        }

        void Searching()
        {
            bool workingOfMenu = true;
            while (workingOfMenu)
            {
                MenuOfSearching();
                Console.WriteLine("Choice:");
                int option;
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.WriteLine("Action is't exist");
                        Console.WriteLine("Try again!");
                    }
                    break;
                }

                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();
                            entityService.SerchingForIngredient(dishes);
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            entityService.SearchingForOrders(orders);
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            workingOfMenu = false;
                            break;
                        }

                    default:
                        break;
                }
            }
        }

        void MenuOfMainMenu()
        {
            Console.WriteLine("\t\tWelcome to main menu!");
            Console.WriteLine("Options:");
            Console.WriteLine("1. Food management");
            Console.WriteLine("2. Ordering management");
            Console.WriteLine("3. Searching");
            Console.WriteLine("4. Exit\n\n");
        }
        void MenuOfFoodManagement()
        {
            Console.WriteLine("\t\tFood management");
            Console.WriteLine("Options:");
            Console.WriteLine("1. Ingredient management");
            Console.WriteLine("2. Add dish");
            Console.WriteLine("3. Delete dish");
            Console.WriteLine("4. Change dish");
            Console.WriteLine("5. Show dish");
            Console.WriteLine("6. Show all dishes");
            Console.WriteLine("7. Close menu\n\n");
        }
        void MenuOfIngredientManagement()
        {
            Console.WriteLine("\t\tIngredient management");
            Console.WriteLine("Options:");
            Console.WriteLine("1. Add ingredient to the dish");
            Console.WriteLine("2. Delete ingredient from the dish");
            Console.WriteLine("3. Change ingredient in the dish");
            Console.WriteLine("4. Show ingredients in the dish");
            Console.WriteLine("5. Exit\n\n");
        }
        void MenuOfChangingInfoOfDish()
        {
            Console.WriteLine("\t\tChanging info of dish");
            Console.WriteLine("Options:");
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change price");
            Console.WriteLine("3. Change time of coocking");
            Console.WriteLine("4. Show info of the dish");
            Console.WriteLine("5. Exit\n\n");
        }
        void MenuOfOrderingManagement()
        {
            Console.WriteLine("\t\tOrdering management");
            Console.WriteLine("Options:");
            Console.WriteLine("1. Add order");
            Console.WriteLine("2. Delete order");
            Console.WriteLine("3. Change order");
            Console.WriteLine("4. Show order");
            Console.WriteLine("5. Show all orders");
            Console.WriteLine("6. Close menu\n\n");
        }
        void MenuOfChangingInfoOfOrdering()
        {
            Console.WriteLine("\t\tOrdering management");
            Console.WriteLine("Options:");
            Console.WriteLine("1. Change number of dishes");
            Console.WriteLine("2. Change total amount");
            Console.WriteLine("3. Change number of table");
            Console.WriteLine("4. Show order");
            Console.WriteLine("5. Close menu\n\n");
        }
        void MenuOfSearching()
        {
            Console.WriteLine("\t\tSearching menu");
            Console.WriteLine("1. Search for ingredient");
            Console.WriteLine("2. Search for orders");
            Console.WriteLine("3. Close menu\n\n");
        }
    }
}
