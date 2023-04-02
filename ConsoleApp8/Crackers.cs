using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Crackers
    {
        #region PrivateFields
        private double _weight;
        private string _taste;
        private double _price;
        private string _title;
        private static int _counter;
        private int _id;
        #endregion
        #region Properties
        public string Title
        {
            get => _title;
            set
            {
                if (value.Trim() != String.Empty) _title = value;
            }
        }
        public string Taste
        {
            get => _taste;
            set
            {
                if (value.Trim() != String.Empty) _taste = value;
            }
        }
        public double Weight
        {
            get => _weight;
            set
            {
                if (value >= 50 && value < 300) _weight = value;
            }
        }
        public double Price
        {
            get => _price;
            set
            {
                if (value > 0 && value < 120) _price = value;
            }
        }
        public static int Counter => _counter;
        #endregion
        #region Methods
        public void Buy() => Console.WriteLine($"Я купил сухарики {Title}.");
        public void About() => Console.WriteLine($"Я купил сухарики за {Price}грн :\nВес: {Weight}гр\nВкус: {Taste}");
        public static void GetCount() => Console.WriteLine($"Создано {Counter} уп. сухариков");
        #endregion
        #region Constructors
        public Crackers() : this("Flint") { }
        public Crackers(string title) : this(title, 150) { }
        public Crackers(string title, double weight) : this(title, weight, 45) { }
        public Crackers(string title, double weight, double price) : this(title, weight, price, "Сметана и зелень") { }
        public Crackers(string title, double weight, double price, string taste)
        {
            Title = !String.IsNullOrWhiteSpace(title) ? title : "Flint";
            Weight = weight;
            Price = price;
            Taste = !String.IsNullOrWhiteSpace(taste) ? taste : "Сметана и зелень";
            _counter++;
        }


        #endregion
    }
   

}
