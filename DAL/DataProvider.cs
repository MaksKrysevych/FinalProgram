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
        public void ReadDishes(List<Dishes> dishes)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Dishes>));
            using (var file = new FileStream("dishes.json", FileMode.OpenOrCreate))
            {
                var newDishes = jsonFormatter.ReadObject(file) as List<Dishes>;

                dishes = newDishes;
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
        public void ReadOrders(List<Orders> orders)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Orders>));
            using (var file = new FileStream("orders.json", FileMode.OpenOrCreate))
            {
                var newOrders = jsonFormatter.ReadObject(file) as List<Orders>;

                orders = newOrders;
            }
        }
    }
}
