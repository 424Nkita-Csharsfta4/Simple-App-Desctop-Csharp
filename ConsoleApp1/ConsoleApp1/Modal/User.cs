using System;

namespace ConsoleApp1.Modal
{

    [Serializable]
    internal class User
    {

        public string Name { get; }//Name User

        public Gender Gender { get; }

        public DateTime BirthDate { get; }

        public double Weight
        {
            get;
            set;
        }
        public double Height { get; set; }

        public User(string name,
            Gender gender,
            DateTime birthDate,
            double weight, 
            double height)
        {
            #region Проверка условий на ошибки заполнения поля пользователем

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть пустым", nameof(name));
            }
            if(gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null",nameof(gender));
            }
            if(birthDate < DateTime.Parse("01.01.1900") && birthDate >=DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата др", nameof(birthDate));
            }
            if(weight <= 0)
            {
                throw new ArgumentException("Вес не возможен быть равен:0",nameof(weight));
            }
            if (height <= 0)
            {
                throw new ArgumentException("Рост не может быть равен :0",nameof(height));
            }
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }
        #endregion

        public override string ToString()
        {
            return Name;
        }
    }
}
