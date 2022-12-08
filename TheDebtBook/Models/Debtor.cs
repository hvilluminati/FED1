using Prism.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace TheDebtBook.Models
{
    public class Debtor : BindableBase
    {
        string name;
        int debt;
        List<int> debits;

        public Debtor()
        {
        }

        public Debtor(string dName, int dDebt)
        {
            name = dName;
            debt = dDebt;
            debits = new List<int>();
            debits.Add(debt);

        }

        /// <summary>
        /// Performs only a shallow copy
        /// </summary>
        /// <returns></returns>
        public Debtor Clone()
        {
            return this.MemberwiseClone() as Debtor;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                SetProperty(ref name, value);
            }
        }

        public int Debt
        {
            get
            {
                return debt;
            }
            set
            {
                debits.Add(value);
                int sum = debits.Sum();
                SetProperty(ref debt, sum);

            }
        }
    }
}
