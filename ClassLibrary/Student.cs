using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student
    {
        public static string GetInfo(Person person)
        {
            return $"Имя: {person.FirstName}, Фамилия: {person.LastName}, Возраст: {person.Age}";
        }
    }
}
