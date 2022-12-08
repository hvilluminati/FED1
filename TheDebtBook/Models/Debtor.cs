using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TheDebtBook.Models
{
    public class Debtor : BindableBase
    {
        private string name;
        private int debt;
        private List<int> debits = new List<int>();

        public Debtor()
        {
        }

        public Debtor(string dName, int dDebt)
        {
            name = dName;
            //Debt = dDebt;
            debits.Add(dDebt);
        }

        public int Debt
        {
            get
            {
                int totalDebt = 0;
                foreach (int d in DebtList)
                {
                    totalDebt += d;
                };

                return totalDebt;
            }
            set
            {
                //debits.Add(value);
                SetProperty(ref debt, Debt);
            }
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


        public List<int> DebtList
        {
            get { return debits; }

            set { debits = value; }
        }
    }
}
