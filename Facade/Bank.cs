using System;

namespace Facade
{
    class Bank
    {
        public bool HasSufficientSavings(Student student, int amount)
        {
            Console.WriteLine("Weryfikacja banku dla :  " + student.Name);
            return true;
        }
    }
}
