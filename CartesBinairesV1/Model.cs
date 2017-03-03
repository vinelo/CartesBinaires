using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesBinairesV1
{
    class Model
    {
        public const int NUMBER_OF_BITS = 6;

        private Bit[] _bits;

        internal Bit[] Bits
        {
            get { return _bits; }
            set { _bits = value; }
        }

        public Model()
        {
            Bits = new Bit[NUMBER_OF_BITS];
            int ValueOfBit = 1;

            for (int i = 0; i < NUMBER_OF_BITS; i++)
            {
                Bits[i] = new Bit(ValueOfBit);
                ValueOfBit *= 2;
                switch(i)
                {
                    case 1:
                        Bits[i].Image = CartesBinairesV1.Properties.Resources._1;
                        break;
                    case 2:
                        Bits[i].Image = CartesBinairesV1.Properties.Resources._2;
                        break;
                    case 3:
                        Bits[i].Image = CartesBinairesV1.Properties.Resources._4;
                        break;
                    case 4:
                        Bits[i].Image = CartesBinairesV1.Properties.Resources._8;
                        break;
                    case 5:
                        Bits[i].Image = CartesBinairesV1.Properties.Resources._16;
                        break;
                    case 6:
                        Bits[i].Image = CartesBinairesV1.Properties.Resources._32;
                        break;
                }
            }
        }

        public void SetAllToFalse()
        {
            foreach(Bit bit in Bits)
            {
                bit.Enable = false;
            }
        }

        public int ConvertToDecimalValue()
        {
            int TotalSum = 0;

            foreach (Bit bit in Bits)
            {
                if(bit.Enable == true)
                {
                    TotalSum += bit.Value;
                }
            }

            return TotalSum;
        }

        public void EnableDisable(int positionOfBit)
        {
            if (this.Bits[positionOfBit].Enable == true)
            {
                this.Bits[positionOfBit].Enable = false;
            }
            else
            {
                this.Bits[positionOfBit].Enable = true;
            }
        }

        public List<int> ReturnBits()
        {
            List<int> ListBit = new List<int>();

            foreach (Bit bit in this.Bits)
            {
                if (bit.Enable == true)
                {
                    ListBit.Add(bit.Value);
                }
                else
                {
                    ListBit.Add(0);
                }
            }

            return ListBit;
        }
    }
}
