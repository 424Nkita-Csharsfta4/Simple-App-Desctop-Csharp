using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1.Modal.User.Controller
{
    public class UserController
    {
        public User User { get; }

        public UserController(string userName, string genderName,DateTime birthday,double weight,double height)
        {
            

            var gender = new Gender(genderName);
            User = new User(userName, gender, birthday, weight, height);

           
        }

        #region Сохранение данных пользователя
        public void Save()
        {
            var formate = new BinaryFormatter();

            using(var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formate.Serialize(fs, User);
            }
        }
        #endregion


        #region Получение дынных пользователя
        public User Load()
        {
            var formate = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if(formate.Deserialize(fs) is User user)
                {
                    return user;
                }
                else
                {
                    throw new FileLoadException("Не удалось получить данные пользователя из файла","users.dat");

                }
            }
        }
        #endregion
    }
}
