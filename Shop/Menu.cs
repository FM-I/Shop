using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{

    enum Started
    {
        exit,
        addShowCase,
        printShowCases,
        getShowCase
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
                Input.InputValue(out int item, int.TryParse, "Зделайте выбор : ", "Error.");

                Console.Clear();


                switch ((Started)item)
                {
                    case Started.addShowCase:
                        _showCaseController.AddShowCase();
                        break;
                    case Started.printShowCases:
                        _showCaseController.PrintShowCases();
                        break;
                    case Started.getShowCase:
                        _showCaseController.PrintShowCases();
                        
                        Input.InputValue(out int number, int.TryParse, "Номер лавки : ", "Error.");
                        var showCase = _showCaseController.GetShowCase(number);

                        if (showCase == null)
                            ShowCaseMenu(showCase);

                        break;
                    case Started.exit:
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
            return;
        }

    }
}
