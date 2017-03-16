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

        public int NumberOfBits
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

        private Label _lblCalcul;

        public Label LblCalcul
        {
            get
            {
                return _lblCalcul;
            }

            set
            {
                _lblCalcul = value;
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
            this.NumberOfBits = paramNumberOfBits;
            int widthOfCard = (this.gbx_Bits.Width / 8) - SPACEBETWEENCARD;
            Model = new Model(NumberOfBits);
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
                lblEnable.Location = new Point(LeftLocation + 30, 25);
                lblEnable.Text = Convert.ToString(2);
                lblEnable.Width = 30;
                lblEnable.Height = 30;
                LblEnables.Add(lblEnable);
                lblEnable.Font = new Font("Arial", 20);

                lblEnable.Show();
                gbx_Nombre.Controls.Add(lblEnable);

                Label lblValue = new Label();
                lblValue.Location = new Point(LeftLocation + 35, 200);
                lblValue.Text = "1";
                lblValue.Show();
                LblValues.Add(lblValue);
                lblValue.Width = 30;
                gbx_Bits.Controls.Add(lblValue);

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
            if (LblCalcul != null)
            {
                LblCalcul.Hide();
                this.Controls.Remove(LblCalcul);
            }
            LblCalcul = new Label();
            LblCalcul.Text = " = ";
            for (int i = 0; i < NumberOfBits; i++)
            {
                if (Model.Bits[i].Enable == false)
                {
                    LblValues[i].Text = "0";
                    LblEnables[i].Text = "0";
                    if(Model.Bits[i].Value == 1)
                        LblCalcul.Text = "0 " + LblCalcul.Text;
                    else
                        LblCalcul.Text = "0 + " + LblCalcul.Text;
                }
                else
                {
                    LblValues[i].Text = Convert.ToString(Model.Bits[i].Value);
                    LblEnables[i].Text = "1";

                    if (Model.Bits[i].Value == 1)
                        LblCalcul.Text = Convert.ToString(Model.Bits[i].Value) + " " + LblCalcul.Text;
                    else
                        LblCalcul.Text = Convert.ToString(Model.Bits[i].Value) + " + " + LblCalcul.Text;

                }
            }
            LblCalcul.Show();
            LblCalcul.AutoSize = false;
            LblCalcul.Height = gbx_Calcul.Height;
            LblCalcul.Width = gbx_Calcul.Width;
            LblCalcul.TextAlign = ContentAlignment.MiddleCenter;
            gbx_Calcul.Controls.Add(LblCalcul);
            LblCalcul.Location = new Point(0, 0);
            LblCalcul.Font = new Font("Arial", 20);

            lblResult.Text = Convert.ToString(Model.ConvertToDecimalValue());

        }

        private void btn_Croissant_Click(object sender, EventArgs e)
        {
            numberAuto = Model.ConvertToDecimalValue();
            Croissant = true;
            tmrAutoDec.Enabled = true;
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
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            tmrAutoDec.Enabled = false;
        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void àProposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void tsiChronologic_Click(object sender, EventArgs e)
        {
            numberAuto = Model.ConvertToDecimalValue();
            Croissant = true;
            tmrAutoDec.Enabled = true;
            tsiChronologic.Checked = true;
            tsiChronologicInverse.Checked = false;
            tsiManual.Checked = false;
        }

        private void tsiChronologicInverse_Click(object sender, EventArgs e)
        {
            numberAuto = Model.ConvertToDecimalValue();
            Croissant = false;
            tmrAutoDec.Enabled = true;
            tsiChronologic.Checked = false;
            tsiChronologicInverse.Checked = true;
            tsiManual.Checked = false;
        }

        private void tsiManual_Click(object sender, EventArgs e)
        {
            tmrAutoDec.Enabled = false;
            tsiChronologic.Checked = false;
            tsiChronologicInverse.Checked = false;
            tsiManual.Checked = true;
        }

        private void tsiShowCard_Click(object sender, EventArgs e)
        {
            Model.SetAllTo(true);
            UpdateView();
        }

        private void tsmHideCarde_Click(object sender, EventArgs e)
        {
            Model.SetAllTo(false);
            UpdateView();
        }

        private void tsiOne_Click(object sender, EventArgs e)
        {
            newBits(Convert.ToInt32(1));
        }

        private void tsiTwo_Click(object sender, EventArgs e)
        {
            newBits(Convert.ToInt32(2));
        }

        private void tsiThree_Click(object sender, EventArgs e)
        {
            newBits(Convert.ToInt32(3));
        }

        private void tsiFour_Click(object sender, EventArgs e)
        {
            newBits(Convert.ToInt32(4));
        }

        private void tsiFive_Click(object sender, EventArgs e)
        {
            newBits(Convert.ToInt32(5));
        }

        private void tsiSix_Click(object sender, EventArgs e)
        {
            newBits(Convert.ToInt32(6));
        }

        private void tsiEight_Click(object sender, EventArgs e)
        {
            newBits(Convert.ToInt32(8));
        }

        private void tsiLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmFolder_Click(object sender, EventArgs e)
        {

        }
    }
}
