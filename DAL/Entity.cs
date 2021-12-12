using System.Runtime.Serialization;

namespace DAL
{
    [DataContract]
    public class Ingredients
    {
        [DataMember]
        public string Ingredient { get; set; }

        public Ingredients(string ingredient)
        {
            Ingredient = ingredient;
        }
    }
    [DataContract]
    public class Dishes : Ingredients
    {
        [DataMember]
        public string NameOfDish { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public double TimeOfCoocking { get; set; }


        public Dishes(string ingredient, string nameOfDish, double price, double timeOfCoocking) : base(ingredient)
        {
            NameOfDish = nameOfDish;
            Price = price;
            TimeOfCoocking = timeOfCoocking;
        }
    }

    [DataContract]
    public class Orders
    {
        [DataMember]
        public int NumberOfDishes { get; set; }
        [DataMember]
        public double TotalAmount { get; set; }
        [DataMember]
        public int NumberOfTable { get; set; }

        public Orders(int numberOfDishes, double totalAmount, int numberOfTable)
        {
            NumberOfDishes = numberOfDishes;
            TotalAmount = totalAmount;
            NumberOfTable = numberOfTable;
        }
    }
}
