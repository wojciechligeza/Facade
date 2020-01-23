using System;

namespace Facade
{
    class Loan
    {
        public bool HasNoBadLoans(Student student)
        {
            Console.WriteLine("Weryfikacja pożyczki dla : " + student.Name);
            return true;
        }
    }
}
