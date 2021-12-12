using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace DAL
{
    public class DataProvider
    {
        public void JSONSerializationOfDishes(List<Dishes> dishes)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Dishes>));
            using (var file = new FileStream("dishes.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(file, dishes);
            }

            
        }
        public void ReadDishes()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Dishes>));
            using (var file = new FileStream("dishes.json", FileMode.OpenOrCreate))
            {
                var newDishes = jsonFormatter.ReadObject(file) as List<Dishes>;

                if (newDishes != null)
                {
                    foreach (var dish in newDishes)
                    {
                        Console.WriteLine(dish);
                    }
                }
            }
        }

        public void JSONSerializationOfOrders(List<Orders> orders)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Orders>));
            using (var file = new FileStream("orders.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(file, orders);
            }

            
        }
        public void ReadOrders()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Orders>));
            using (var file = new FileStream("orders.json", FileMode.OpenOrCreate))
            {
                var newOrders = jsonFormatter.ReadObject(file) as List<Orders>;

                if (newOrders != null)
                {
                    foreach (var order in newOrders)
                    {
                        Console.WriteLine(order);
                    }
                }
            }
        }
    }
}
