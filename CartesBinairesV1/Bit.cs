using System.Windows.Forms;
using System.Drawing;

namespace CartesBinairesV1
{
    class Bit : PictureBox
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
            set {
                if (value == true)
                    this.Image = ImageBit;
                else
                    this.Image = Backimage;
                _enable = value; }
        }

        private Bitmap _backimage;

        public Bitmap Backimage
        {
            get
            {
                return _backimage;
            }

            set
            {
                _backimage = value;
            }
        }

        private Bitmap _imagebit;

        public Bitmap ImageBit
        {
            get
            {
                return _imagebit;
            }

            set
            {
                _imagebit = value;
            }
        }

        public void EnableDisable()
        {
            if (this.Enable == false)
                this.Enable = true;
            else
                this.Enable = false;
        }

        public Bit(int ValueOfBit, Bitmap Image)
        {
            this.Value = ValueOfBit;
            this.Enable = false;
            this.ImageBit = Image;
            this.Backimage = CartesBinairesV1.Properties.Resources.DosDeCarte;
            this.Image = Backimage;
        }

        
    }
}
