using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    public class ShowCaseController
    {
        private List<ShowCase> _showCases;


        public ShowCaseController()
        {
            _showCases = new List<ShowCase>();
        }

        public ShowCaseController(List<ShowCase> showCases)
        {
            _showCases = showCases ?? throw new ArgumentNullException(nameof(showCases));
        }

        public ShowCase GetShowCase(int number)
        {
            if(number < 1 || number > _showCases.Count)
            {
                Console.WriteLine("Выбрано неверный номер.");
                return null;
            }

            return _showCases[--number];
        }

        /// <summary>
        /// Добвление новой лавки.
        /// </summary>
        public void AddShowCase()
        {
            try
            {
                int id;
                do
                {
                    Input.InputValue(out id, int.TryParse, "Id лавки : ", "Ошибка ввода.");

                    if (_showCases.Where(s => s.Id == id).FirstOrDefault() == null) break;
                    Console.WriteLine("Лавка с таким id уже существует.");

                } while (true);

                Console.Write("Название лавки : ");

                string name = Console.ReadLine();
                Input.InputValue(out double maxCapacity, double.TryParse, "Вместимость лавки : ", "Ошибка ввода.");
                Input.InputValue(out DateTime dateTime, DateTime.TryParse, "Дата открытия лавки (dd.mm.yyyy) : ", "Ошибка ввода.");

                _showCases.Add(new ShowCase(id, name, maxCapacity, dateTime));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Вывод списка лавок.
        /// </summary>
        public void PrintShowCases()
        {
            if(_showCases.Count == 0)
            {
                Console.WriteLine("Лавки отсутствуют.");
                return;
            }

            Console.WriteLine("№\tId\tName");
            int counter = 1;
            foreach (var showCase in _showCases)
            {
                Console.WriteLine($"{counter}\t{showCase}");
                ++counter;
            }
        }

    }
}
