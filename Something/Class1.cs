using System;
using System.Collections.Generic;
using System.Text;

namespace Something
{
    class Class1
    {
        public int i;

        private string myPropVal;
        public string MyProp
        {
            get
            {
                return myPropVal;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new NotSupportedException();
                }
                myPropVal = value;
            }
        }

        public Class1(int i)
        {
            this.i = i;
        }
    }
}
