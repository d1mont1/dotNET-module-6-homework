using System;

namespace dotNET_module_6_homework
{
    class Student
    {
        public static string GetInfo(Person person)
        {
            return $"Имя: {person.FirstName}, Фамилия: {person.LastName}, Возраст: {person.Age}";
        }
    }
}
