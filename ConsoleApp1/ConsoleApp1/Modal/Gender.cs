using System;

namespace ConsoleApp1.Modal
{
    [Serializable]
    internal class Gender
    {/// <summary>
    /// Gender Name in Class
    /// </summary>
        public string Name { get;}//Base
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым или null",nameof(name));

            }
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
