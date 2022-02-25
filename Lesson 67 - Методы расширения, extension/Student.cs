using System;

namespace Students
{
    //Не можем унаследоваться от этого класса - sealed
    sealed class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
