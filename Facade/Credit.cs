using System;

namespace Facade
{
    class Credit
    {
        public bool HasGoodCredit(Student student)
        {
            Console.WriteLine("Weryfikacja zdolności kredytowej dla : " + student.Name);
            return true;
        }
    }
}
