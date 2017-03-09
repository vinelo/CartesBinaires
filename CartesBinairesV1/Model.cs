using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesBinairesV1
{
    class Model
    {

        private List<Bit> _bits;

        internal List<Bit> Bits
        {
            get
            {
                return _bits;
            }

            set
            {
                _bits = value;
            }
        }
        public Model() : this(8) { }
        public Model(int NumberOfBit)
        {
            Bits = new List<Bit>();
            //new Bit[NUMBER_OF_BITS];
            int ValueOfBit = 1;

            for (int i = 0; i < NumberOfBit ; i++)
            {
                switch(i)
                {
                    case 0:
                        Bits.Add(new Bit(ValueOfBit, CartesBinairesV1.Properties.Resources._1));
                        break;
                    case 1:
                        Bits.Add(new Bit(ValueOfBit, CartesBinairesV1.Properties.Resources._2));
                        break;
                    case 2:
                        Bits.Add(new Bit(ValueOfBit, CartesBinairesV1.Properties.Resources._4));
                        break;
                    case 3:
                        Bits.Add(new Bit(ValueOfBit, CartesBinairesV1.Properties.Resources._8));
                        break;
                    case 4:
                        Bits.Add(new Bit(ValueOfBit, CartesBinairesV1.Properties.Resources._16));
                        break;
                    case 5:
                        Bits.Add(new Bit(ValueOfBit, CartesBinairesV1.Properties.Resources._32));
                        break;
                    case 6:
                        Bits.Add(new Bit(ValueOfBit, CartesBinairesV1.Properties.Resources._64));
                        break;
                    case 7:
                        Bits.Add(new Bit(ValueOfBit, CartesBinairesV1.Properties.Resources._128));
                        break;

                }

                ValueOfBit *= 2;
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

        public void ConvertToBinary(int DecimalNumber)
        {
            List<bool> isEnabled = new List<bool>();

            for (int i = 0; i < this.Bits.Count; i++)
            {
                int rest = DecimalNumber % 2;
                DecimalNumber = DecimalNumber / 2;

                if (rest == 0)
                {
                    isEnabled.Add(false);
                }
                else
                {
                    isEnabled.Add(true);
                }
            }

            //isEnabled.Reverse();

            for (int i = 0; i < this.Bits.Count; i++)
            {
                Bits[i].Enable = isEnabled[i];
            }
        }

    }
}
