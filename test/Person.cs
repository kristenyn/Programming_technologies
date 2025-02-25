using test.Validate;
using System;
using System.IO;
using test.Validate;
namespace test
{
    class Person
    {
        /// <summary>
        /// Констуктор, 4 параметра
        /// </summary>
        /// <param name="height">Рост человека</param>
        /// <param name="weight">Вес человека</param>
        /// <param name="BirthDay">Дата Рождения человека</param>
        /// <param name="FullName">Полное имя человека</param>
        public Person(int height, int weight, DateTime BirthDay, string FullName)
        {
            try
            {

                if (ChangeHeight(height) == false)
                    throw new Exception("Неправильно указаное значение");
                if (ChangeWeight(weight) == false)
                    throw new Exception("Неправильно указаное значение");
                this.Birthday = BirthDay;
                string fullName = FullName; 
                if (!fullName.Contains(' ') || fullName[0] == ' ' || fullName[fullName.Length - 1] == ' ')
                    throw new Exception("Указано только значение - имя или фамилия ");

                string firstNam = fullName.Substring(0, fullName.IndexOf(' ', 0)); 
                if (ChangeFirstName(firstNam) == false)
                    throw new Exception("Неправильно указаное значение");

                string lastNam = fullName.Substring(fullName.IndexOf(' ', 0) + 1, fullName.Length - fullName.IndexOf(' ', 0) - 1); 
                if (ChangeLastName(lastNam) == false)
                    throw new Exception("Неправильно указаное значение");


                Console.WriteLine("Рост " + this.Height);
                Console.WriteLine("Вес " + this.Weight);
                Console.WriteLine("Дата рождения " + this.Birthday);
                Console.WriteLine("Полное имя " + this.FullName);
                Console.WriteLine("Имя " + this.FirstName);
                Console.WriteLine("Фамилия " + this.LastName);

            }
            catch (IOException e)
            {
                Console.WriteLine($"Ошибка.{e.Message}");
            }

        }
        // Рост человека
        public int Height { get; private set; }
        // Вес человека
        public double Weight { get; private set; }
        // Дата рождения человека
        public DateTime Birthday { get; }
        // Имя человека
        public string FirstName { get; private set; }
        // Фамилия человека
        public string LastName { get; private set; }
        // Полное имя человека
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        /// <summary>
        /// Изменение роста человека
        /// </summary>
        /// <param name="Height">Рост</param>
        /// <returns>true или false</returns>
        public bool ChangeHeight(int Height)
        {
            bool flag = IntValidator.Validate(Height);
            if (flag)
                this.Height = Height;
            return flag;
        }
        /// <summary>
        /// Изменение веса человека
        /// </summary>
        /// <param name="weight">Вес</param>
        /// <returns>true или false</returns>
        public bool ChangeWeight(int weight)
        {
            bool flag = IntValidator.Validate(weight);
            if (flag)
                Weight = weight;
            return flag;
        }
        /// <summary>
        /// Изменение имени человека
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <returns>true или false</returns>
        public bool ChangeFirstName(string firstName)
        {
            bool flag = StringValidators.Validate(firstName);
            if (flag)
                FirstName = firstName;
            return flag;
        }
        /// <summary>
        /// Изменение фамилии человека
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns>true или false</returns>
        public bool ChangeLastName(string lastName)
        {
            bool flag = StringValidators.Validate(lastName);
            if (flag)
                this.LastName = lastName;
            return flag;
        }


    }
}
