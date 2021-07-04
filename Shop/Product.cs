using Shop.Interfaces;
using System;

namespace Shop
{
    /// <summary>
    /// Класс представляющий продукт.
    /// </summary>
    public class Product : IProduct
    {
        /// <summary>
        /// Идентификатор продукта.
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// Название продукта.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Занимаемый обём продуктом.
        /// </summary>
        public double OccupiedVolume { get; }
        /// <summary>
        /// Цена продукта.
        /// </summary>
        public decimal Price { get; }

        public Product(int id, string name, double occupiedVolume, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException($"{nameof(name)} не может быть пустим или null.",nameof(name));

            if (id < 0)
                throw new ArgumentException(nameof(id));

            if (occupiedVolume < 1)
                throw new ArgumentException(nameof(occupiedVolume));

            if (price < 0)
                throw new ArgumentException(nameof(price));


            Id = id;
            Name = name;
            OccupiedVolume = occupiedVolume;
            Price = price;
        }
    }
}
