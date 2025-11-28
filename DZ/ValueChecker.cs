using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class ValueChecker
    {
        public void CheckType(object input)
        {
            if (input is int || input is double || input is bool || input is char || input is decimal || input is float || input is long || input is short || input is byte || input is sbyte || input is uint || input is ulong || input is ushort)
            {
                Console.WriteLine($"Значение: {input} - Значимый тип ({input.GetType().Name})");
            }
            else if (input is string || input.GetType().IsClass)
            {
                Console.WriteLine($"Значение: {input} - Ссылочный тип ({input.GetType().Name})");
            }
            else
            {
                Console.WriteLine($"Значение: {input} - Неизвестный тип ({input.GetType().Name})");
            }
        }

    }
}
