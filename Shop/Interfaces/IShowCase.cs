using System;

namespace Shop.Interfaces
{
    interface IShowCase
    {
        /// <summary>
        /// Идентификатор лавки.
        /// </summary>
        int Id { get; }
        /// <summary>
        /// Название лавки.
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Максимальная вместительность лавки.
        /// </summary>
        double MaxCapacity { get; }
        /// <summary>
        /// Текущая заплоненость лавки.
        /// </summary>
        public double CurrentCapacity { get; }
        /// <summary>
        /// Дата создание лавки.
        /// </summary>
        DateTime CreationTime { get; }
        /// <summary>
        /// Дата закрытия лавки.
        /// </summary>
        DateTime RemoveTime { get; }


        /// <summary>
        /// Добавлление продукта на лавку.
        /// </summary>
        void AddProduct();
        /// <summary>
        /// Удаление продукта с лавки.
        /// </summary>
        void RemoveProduct();
        /// <summary>
        /// Вывод информации всех продуктов на лавке.
        /// </summary>
        void ShowProducts();

    }
}
