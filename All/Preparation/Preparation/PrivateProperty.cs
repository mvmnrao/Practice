using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Preparation
{
    class PrivateProperty
    {
        public PrivateProperty(int Integer)
        { 
        
        }

        private PrivateProperty()
        { 
        
        }

        private int Integer = 0;
        public int MyReadOnly
        {
            get
            {
                return Integer;
            }
        }

        public void SetValue()
        {
            
        }
    }
}
