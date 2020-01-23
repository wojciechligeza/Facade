using System;

namespace Facade
{
    /// <summary>
    /// FASADA
    /// </summary>
    class CollegeLoan
    {
        private Bank _bank = new Bank();
        private Loan _loan = new Loan();
        private Credit _credit = new Credit();

        public bool IsEligible(Student student, int amount)
        {
            Console.WriteLine("{0} ubiega się o {1:C} pożyczki. \n", student.Name, amount);

            bool eligible = true;

            // OCENA
            if (!_bank.HasSufficientSavings(student, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(student))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(student))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
