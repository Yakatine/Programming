using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"Значение {propertyName} должно быть положительным. Текущее значение: {value}");
            }
        }
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"Значение {propertyName} должно быть положительным. Текущее значение: {value}");
            }
        }
        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"Значение {propertyName} должно быть в диапазоне от {min} до {max}. Текущее значение: {value}");
            }
        }
    }
}
