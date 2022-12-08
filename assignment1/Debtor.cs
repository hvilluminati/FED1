using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Debt
{
    public class Debtor
    {

        public Debtor()
        {
        }

        public Debtor(string name, int debt)
        {
            _name = name;
            _debt = debt;
        }



        public string _name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int _debt
        {
            get
            {
                return _debt;
            }
            set
            {
                _debt = value;
            }
        }
    }
}
