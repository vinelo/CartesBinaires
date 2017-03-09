using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CartesBinairesV1
{
    public partial class View : Form
    {

        const int HEIGHTOFCARD = 142;
        const int SPACEBETWEENCARD = 10;
        int numberAuto = 0;
        bool Croissant;

        private PictureBox[] _cards;

        public PictureBox[] Cards
        {
            get { return _cards; }
            set { _cards = value; }
        }

        private Model _model;

        internal Model Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private List<Label> _lblValues;

        public List<Label> LblValues
        {
            get
            {
                return _lblValues;
            }

            set
            {
                _lblValues = value;
            }
        }

        private List<Label> _lblEnables;

        public List<Label> LblEnables
        {
            get
            {
                return _lblEnables;
            }

            set
            {
                _lblEnables = value;
            }
        }
        private int _numberToStart;

        public int NumberToStart
        {
            get
            {
                return _numberToStart;
            }

            set
            {
                _numberToStart = value;
            }
        }

        public View()
        {
            InitializeComponent();
            newBits(8);
        }

        public void newBits(int paramNumberOfBits)
        {
            if (LblValues != null)
            {
                foreach (Label LblValue in LblValues)
                {
                    LblValue.Hide();
                    this.Controls.Remove(LblValue);
                }
            }
            if (LblEnables != null)
            {
                foreach (Label LblEnable in LblEnables)
                {
                    LblEnable.Hide();
                    this.Controls.Remove(LblEnable);
                }
            }
            if (Model != null)
            {
                foreach (Bit bit in Model.Bits)
                {
                    bit.Hide();
                    this.Controls.Remove(bit);
                }
            }
            this.NumberToStart = paramNumberOfBits;
            int widthOfCard = (this.gbx_Bits.Width / NumberToStart) - SPACEBETWEENCARD;
            Model = new Model(NumberToStart);
            LblValues = new List<Label>();
            LblEnables = new List<Label>();

            int LeftLocation = gbx_Bits.Width - SPACEBETWEENCARD - widthOfCard;
            foreach (PictureBox card in Model.Bits)
            {
                gbx_Bits.Controls.Add(card);
                card.Location = new Point(LeftLocation, 20);
                card.Size = new Size(widthOfCard, HEIGHTOFCARD);
                card.SizeMode = PictureBoxSizeMode.StretchImage;
                card.Image = CartesBinairesV1.Properties.Resources.DosDeCarte;
                card.Show();
                card.Click += new EventHandler(this.card_Click);
                gbx_Bits.Controls.Add(card);

                Label lblEnable = new Label();
                lblEnable.Location = new Point(LeftLocation + 40, 40);
                lblEnable.Text = Convert.ToString(2);
                lblEnable.Width = 30;
                LblEnables.Add(lblEnable);
                lblEnable.Show();
                gbx_Nombre.Controls.Add(lblEnable);

                Label lblValue = new Label();
                lblValue.Location = new Point(LeftLocation + 40, 40);
                lblValue.Text = "1";
                lblValue.Show();
                LblValues.Add(lblValue);
                lblValue.Width = 30;
                gbx_Calcul.Controls.Add(lblValue);

                LeftLocation = LeftLocation - widthOfCard - SPACEBETWEENCARD;

            }

            UpdateView();
        }

        void card_Click(object sender, System.EventArgs e)
        {
            Bit bit = (Bit)sender;
            bit.EnableDisable();
            UpdateView();
        }

        public void UpdateView()
        {
            for (int i = 0; i < NumberToStart; i++)
            {
                if (Model.Bits[i].Enable == false)
                {
                    LblValues[i].Text = "0";
                    LblEnables[i].Text = "0";
                }
                else
                {
                    LblValues[i].Text = Convert.ToString(Model.Bits[i].Value);
                    LblEnables[i].Text = "1";
                }
            }

            lblResult.Text = Convert.ToString(Model.ConvertToDecimalValue());

        }

        private void btn_Croissant_Click(object sender, EventArgs e)
        {
            numberAuto = Model.ConvertToDecimalValue();
            Croissant = true;
            tmrAutoDec.Enabled = true;
            btn_Stop.Enabled = true;
        }

        private void tmrAutoDec_Tick(object sender, EventArgs e)
        {
            if (Croissant == true)
            {
                Model.ConvertToBinary(numberAuto);
                numberAuto++;
                if(Model.ConvertToDecimalValue() == 255)
                {
                    tmrAutoDec.Enabled = false;
                }
            }
            else
            {
                Model.ConvertToBinary(numberAuto);
                numberAuto--;
                if (Model.ConvertToDecimalValue() == 0)
                {
                    tmrAutoDec.Enabled = false;
                }
            }
            UpdateView();
        }

        private void btn_Decroissant_Click(object sender, EventArgs e)
        {
            numberAuto = Model.ConvertToDecimalValue();
            Croissant = false;
            tmrAutoDec.Enabled = true;
            btn_Stop.Enabled = true;
        }

        private void numNumberOfBits_ValueChanged(object sender, EventArgs e)
        {
            newBits(Convert.ToInt32(numNumberOfBits.Value));
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            tmrAutoDec.Enabled = false;
            btn_Stop.Enabled = false;
        }
    }
}
