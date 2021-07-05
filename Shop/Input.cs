using System;

namespace Shop
{
    public static class Input
    {
        /// <summary>
        /// Делегат для универсальной проверки ввода.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        public delegate bool TryParse<TInput, TOutput>(TInput input, out TOutput output);

        /// <summary>
        /// Метод для проверки коректности ввода базовых типов.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="tryParse"></param>
        /// <param name="inputMessage"></param>
        /// <param name="errorMessage"></param>
        public static void InputValue<T>(out T value, TryParse<string, T> tryParse, string inputMessage, string errorMessage)
        {
            Console.Write(inputMessage);
            while (true)
            {
                if (tryParse(Console.ReadLine(), out value)) break;
                else Console.WriteLine(errorMessage);
            }
        }
    }
}
