using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesBinairesV1
{
    class Bit
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private bool _enable;

        public bool Enable
        {
            get { return _enable; }
            set { _enable = value; }
        }

        public Bit(int ValueOfBit)
        {
            this.Value = ValueOfBit;
            this.Enable = false;
        }
    }
}
