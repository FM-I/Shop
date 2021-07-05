using Shop.Interfaces;
using System;
using System.Collections.Generic;

namespace Shop
{
    public class ShowCase : IShowCase
    {
        public int Id { get; }
        public string Name { get; }
        public double MaxCapacity { get; }
        public double CurrentCapacity { get; private set; }
        public DateTime CreationTime { get; }
        public DateTime RemoveTime { get; }

        /// <summary>
        /// Список продуктов которые находяться на лавке.
        /// </summary>
        private List<Product> _products;

        public ShowCase(int id, string name, double maxCapacity,  DateTime creationTime)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            if(id < 1)
                throw new ArgumentNullException(nameof(id));

            Id = id;
            Name = name;
            MaxCapacity = maxCapacity;
            CurrentCapacity = 0;
            CreationTime = creationTime;
            _products = new List<Product>();
        }

        /// <summary>
        /// Добавление продукта на витрину.
        /// </summary>
        public void AddProduct()
        {
            var product = Product.CreateProduct();

            if((CurrentCapacity + product.OccupiedVolume) > MaxCapacity)
                Console.WriteLine("На витрине недостаточно места для этого товара.");
            else
            {
                CurrentCapacity += product.OccupiedVolume;
                _products.Add(product);
            }
        }
        /// <summary>
        /// Удаление продукта с витрины.
        /// </summary>
        public void RemoveProduct()
        {
            if (_products.Count == 0)
            {
                Console.WriteLine("Витрина пуста.");
                return;
            }

            Console.Clear();
            ShowProducts();

            Input.InputValue(out int number, int.TryParse, "Выберите номер продукта: ", "Ошибка ввода");

            if(number < 1 || number > _products.Count)
                Console.WriteLine("Выбрано неверный номер.");
            else
            {
                CurrentCapacity -= _products[--number].OccupiedVolume;
                _products.RemoveAt(--number);

            }
        }
        /// <summary>
        /// Вывод всех продуктов которые находятся на витрине.
        /// </summary>
        public void ShowProducts()
        {

            if(_products.Count == 0)
            {
                Console.WriteLine("Витрина пуста.");
                return;
            }

            Console.WriteLine("№\tId\tНазва\tОбъём\tЦена");

            int counter = 1;
            foreach (var product in _products)
            {
                Console.WriteLine($"{counter}.\t{product}");
                counter++;
            }
            Console.WriteLine($"Обём товара на витрине {CurrentCapacity}");
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}";
        }

    }
}
