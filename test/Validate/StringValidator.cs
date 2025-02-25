using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Validate
{
    /// <summary>
    /// Класс проверки строковых значений
    /// </summary>
    class StringValidators
    {
        /// <summary>
        /// Проверка, на наличие цифр и пустых строк
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns>true, если ошибок нет, в противном случае - false</returns>
        static public bool Validate(string value)
        {
            bool flag1 = true;

            if (String.IsNullOrWhiteSpace(value))
            {
                return true;
            }

            else
            {
                foreach (char cch in value)
                {
                    if (!char.IsLetter(cch))
                    {
                        flag1 = false;
                    }
                }
                return flag1;
            }


        }
    }
}
