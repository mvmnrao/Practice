using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsSample
{
    public class Major : Minor
    {
        private int _age;

        public new int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value > 18)
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("Age should be greater than 18");
                }
            }
        }

        public bool Married { get; set; }

        public Major() : base()
        {
            Married = true;
        }

        public bool IsSingle()
        {
            return Married ? true : false;
        }
    }
}
