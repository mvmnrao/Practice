using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsSample
{
    public class Minor
    {
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 18)
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("Age should be lesser than 19");
                }
            }
        }

        public string Name { get; set; }

        private string Gender { get; set; }

        public Minor()
        {
            Gender = "M";
        }

        public string GetGender()
        {
            return Gender == "M" ? "Male" : "Female";
        }
    }
}
