using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{

    enum Started
    {
        Exit,
        AddShowCase,
        PrintShowCases,
        GetShowCase
    }

    enum ShowCaseItem
    {
        Exit,
        AddProduct,
        RemoveProduct,
        ShowProduct
    }

    public class Menu
    {
        private ShowCaseController _showCaseController;

        public Menu()
        {
            _showCaseController = new ShowCaseController();
        }


        public void StartedMenu()
        {

            while (true)
            {
                Console.WriteLine("1.Добавление лавки.");
                Console.WriteLine("2.Вывод всех лавок.");
                Console.WriteLine("3.Просмотр лавки.");
                Console.WriteLine("0.Выход.");
                Input.InputValue(out int item, int.TryParse, "Сделайте выбор : ", "Error.");

                Console.Clear();


                switch ((Started)item)
                {
                    case Started.AddShowCase:
                        _showCaseController.AddShowCase();
                        break;
                    case Started.PrintShowCases:
                        _showCaseController.PrintShowCases();
                        break;
                    case Started.GetShowCase:
                        _showCaseController.PrintShowCases();
                        
                        Input.InputValue(out int number, int.TryParse, "Номер лавки : ", "Error.");
                        var showCase = _showCaseController.GetShowCase(number);

                        if (showCase != null)
                            ShowCaseMenu(showCase);

                        break;
                    case Started.Exit:
                        return;
                    default:
                        break;
                }

                Console.WriteLine();

            }
        }

        private void ShowCaseMenu(ShowCase showCase)
        {
            Console.Clear();


            while (true)
            {
                Console.WriteLine("1.Добавление продукта.");
                Console.WriteLine("2.Удаление продукта.");
                Console.WriteLine("3.Вывод продуктов.");
                Console.WriteLine("0.Выход.");
                Input.InputValue(out int item, int.TryParse, "Сделайте выбор : ", "Error.");

                Console.Clear();
                Console.WriteLine($"Id лавки : {showCase.Id}");
                switch ((ShowCaseItem)item)
                {
                    case ShowCaseItem.AddProduct:
                        showCase.AddProduct();
                        break;
                    case ShowCaseItem.RemoveProduct:
                        showCase.RemoveProduct();
                        break;
                    case ShowCaseItem.ShowProduct:
                        showCase.ShowProducts();
                        break;
                    case ShowCaseItem.Exit:
                        return;
                    default:
                        break;
                }

                Console.WriteLine();

            }


        }

    }
}
