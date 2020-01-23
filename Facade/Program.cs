using System;

namespace Facade
{
    /// <summary>
    /// ENTRYPOINT APLIKACJI
    /// </summary>
    class Client
    {
        static void Main()
        {
            // Fasada
            CollegeLoan collegeLoan = new CollegeLoan();

            // Ocena
            Student student = new Student("Zdzichu");
            bool eligible = collegeLoan.IsEligible(student, 75000);

            Console.WriteLine("\n" + student.Name +
                              " został " + (eligible ? "przyjęty." : "odrzucony."));

            Console.ReadKey();
        }
    }
}
