using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Validate
{
    /// <summary>
    /// Класс проверки целочисленных данных
    /// </summary>
    class IntValidator
    {
        /// <summary>
        /// Проверка числа, чтобы число не было < 0
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns>true, если значение > 0, в противном случае - false,если < 0</returns>
        static public bool Validate(int value)
        {
            return value > 0;
        }
    }
}
