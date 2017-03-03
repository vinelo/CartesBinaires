using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartesBinairesV1
{
    public partial class View : Form
    {
        const int WIDTHOFCARD = 80;
        const int HEIGHTOFCARD = 142;
        const int SPACEBETWEENCARD = 10;
        
        private PictureBox[] _cards;

        public PictureBox[] Cards
        {
            get { return _cards; }
            set { _cards = value; }
        }
        public View()
        {
            InitializeComponent();
            Model = new Model();
            Cards = Model.Bits;
            int LeftLocation = 10;
            int Count = 1;
            foreach (PictureBox card in Cards)
            {
                //card.Image = CartesBinairesV1.Properties.Resources._1;
                //card.Left = 10;
                //card.Top = 10;
                //card.Height = 10;
                //card.Width = 10;
                
                card.Location = new Point(LeftLocation, 20);
                card.Name = "pic" + Convert.ToString(Count);
                card.Size = new Size(WIDTHOFCARD, HEIGHTOFCARD);
                card.SizeMode = PictureBoxSizeMode.StretchImage;
                card.Image = CartesBinairesV1.Properties.Resources._1;
                
                card.Show();
                gbx_Bits.Controls.Add(card);

                LeftLocation = LeftLocation + WIDTHOFCARD + SPACEBETWEENCARD;

            }
        }

        List<int> ListBinaryValue;

        private Model _model;

        internal Model Model
        {
            get { return _model; }
            set { _model = value; }
        }


        public void UpdateView()
        {
            //ListBinaryValue = Model.ReturnBits();

            //if(ListBinaryValue[0] != 0)
            //{
            //    pbx_bit1.Image = CartesBinairesV1.Properties.Resources._1;
            //}
            //else
            //{
            //    pbx_bit1.Image = CartesBinairesV1.Properties.Resources.DosDeCarte;
            //}

            //if (ListBinaryValue[1] != 0)
            //{
            //    pbx_bit2.Image = CartesBinairesV1.Properties.Resources._2;
            //}
            //else
            //{
            //    pbx_bit2.Image = CartesBinairesV1.Properties.Resources.DosDeCarte;
            //}

            //if (ListBinaryValue[2] != 0)
            //{
            //    pbx_bit3.Image = CartesBinairesV1.Properties.Resources._4;
            //}
            //else
            //{
            //    pbx_bit3.Image = CartesBinairesV1.Properties.Resources.DosDeCarte;
            //}

            //if (ListBinaryValue[3] != 0)
            //{
            //    pbx_bit4.Image = CartesBinairesV1.Properties.Resources._8;
            //}
            //else
            //{
            //    pbx_bit4.Image = CartesBinairesV1.Properties.Resources.DosDeCarte;
            //}

            //if (ListBinaryValue[4] != 0)
            //{
            //    pbx_bit5.Image = CartesBinairesV1.Properties.Resources._16;
            //}
            //else
            //{
            //    pbx_bit5.Image = CartesBinairesV1.Properties.Resources.DosDeCarte;
            //}

            //if (ListBinaryValue[5] != 0)
            //{
            //    pbx_bit6.Image = CartesBinairesV1.Properties.Resources._32;
            //}
            //else
            //{
            //    pbx_bit6.Image = CartesBinairesV1.Properties.Resources.DosDeCarte;
            //}

            //label1.Text = Convert.ToString(Model.ConvertToDecimalValue());

        }

        private void pbx_bit1_Click(object sender, EventArgs e)
        {
            Model.EnableDisable(0);
            UpdateView();
        }

        private void pbx_bit5_Click(object sender, EventArgs e)
        {
            Model.EnableDisable(4);
            UpdateView();
        }

        private void pbx_bit2_Click(object sender, EventArgs e)
        {
            Model.EnableDisable(1);
            UpdateView();
        }

        private void pbx_bit3_Click(object sender, EventArgs e)
        {
            Model.EnableDisable(2);
            UpdateView();
        }

        private void pbx_bit4_Click(object sender, EventArgs e)
        {
            Model.EnableDisable(3);
            UpdateView();
        }

        private void pbx_bit6_Click(object sender, EventArgs e)
        {
            Model.EnableDisable(5);
            UpdateView();
        }
    }
}
