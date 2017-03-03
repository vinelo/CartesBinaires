using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesBinairesV1
{
    class Controller
    {
        private Model _model;

        private Model Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private View _view;

        private View View
        {
            get { return _view; }
            set { _view = value; }
        }

        public Controller(View V)
        {
            this.View = V;
            this.Model = new Model();
        }

        public void EnableDisable(int positionOfBit)
        {
            if (Model.Bits[positionOfBit].Enable == true)
            {
                Model.Bits[positionOfBit].Enable = false;
            }
            else
            {
                Model.Bits[positionOfBit].Enable = true;
            }

            UpdateView();
        }

        public void UpdateView()
        {
            //View.UpdateView();
        }

        public List<int> ReturnBits()
        {
            List<int> ListBit = new List<int>();
            int PositionInTable = 0;

            foreach(Bit bit in this.Model.Bits)
            {
                if (bit.Enable == true)
                {
                    ListBit[PositionInTable] = bit.Value;
                }
                else
                {
                    ListBit[PositionInTable] = 0;
                }
            }

            return ListBit;
        }
    }
}
