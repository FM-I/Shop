using System;

namespace Shop.Interfaces
{
    /// <summary>
    /// Интерфейс для описаниия реализации продукта.
    /// </summary>
    interface IProduct
    {
        /// <summary>
        /// Идентификатор продукта.
        /// </summary>
        int Id { get; }
        /// <summary>
        /// Название продукта.
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Занимаемый обём продуктом.
        /// </summary>
        double OccupiedVolume { get; }
        /// <summary>
        /// Цена продукта.
        /// </summary>
        decimal Price { get; }
    }
}
