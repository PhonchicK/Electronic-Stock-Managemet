using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Utilites.Electronic.Resistor
{
    public partial class ResistorControl : UserControl
    {
        //public Settings
        public int BandCount { get; set; }
        public float Resistance { get; set; }
        public int Tolerance { get; set; }

        //Colors
        private Color ResistorPinColor = Color.FromArgb(255, 98, 97, 95);
        private Color ResisotorBackColor = Color.FromArgb(255, 234, 182, 118);


        //Settings Sizes
        private int resistorPinWidth = 511;
        private int resistorPinHeight = 20;
        private int resistorBaseWidth = 260;
        private int resistorBaseHeight = 150;
        private int StripWidth = 10;

        private int selectedStripIndex = -1;
        private ResistorStrip[] resistorStrips;
        private Bitmap resistorBitmap;

        //Resistor Strip Colors
        List<ResistorColor> resistorBaseColors = new List<ResistorColor>
        {
            ResistorColor.Black,
            ResistorColor.Brown,
            ResistorColor.Red,
            ResistorColor.Orange,
            ResistorColor.Yellow,
            ResistorColor.Green,
            ResistorColor.Blue,
            ResistorColor.Purple,
            ResistorColor.Grey,
            ResistorColor.White
        };
        List<ResistorColor> resistorToleranceColors = new List<ResistorColor>
        {
            ResistorColor.Gold,
            ResistorColor.Silver
        };

        public ResistorControl()
        {
            InitializeComponent();
            resistorBitmap = new Bitmap(512,256);
            this.DrawResistor();

            this.resistorStrips = new ResistorStrip[]
            {
                new ResistorStrip(ResistorColor.Black),
                new ResistorStrip(ResistorColor.Blue),
                new ResistorStrip(ResistorColor.Black),
                new ResistorStrip(ResistorColor.Gold)
            };

            this.DrawStrips();
        }
        private void resistorSetPixel(int x, int y, Color color)
        {
            this.resistorBitmap.SetPixel(x, y, color);
            this.resistorImage.Image = resistorBitmap;
        }

        private void DrawSquare(int startX, int startY, int width, int height, Color color)
        {
            for (int x = 0; x <= width; x++)
            {
                for (int y = 0; y <= height; y++)
                {
                    this.resistorSetPixel(x + startX, y + startY, color);
                }
            }
        }

        private void DrawResistor()
        {
            //Draw Pin
            this.DrawSquare(0, (resistorBitmap.Height / 2) - (this.resistorPinHeight / 2),
                           this.resistorPinWidth, this.resistorPinHeight,
                           this.ResistorPinColor);

            //Draw Base
            this.DrawSquare((this.resistorBitmap.Width / 2) - (this.resistorBaseWidth / 2), (this.resistorBitmap.Height / 2) - (this.resistorBaseHeight / 2),
                           this.resistorBaseWidth, this.resistorBaseHeight, 
                           this.ResisotorBackColor);
        }

        private void DrawStrips()
        {
            int startX = (resistorBitmap.Width / 2) - (this.resistorBaseWidth / 2);

            int value = (this.resistorBaseWidth - this.StripWidth * this.resistorStrips.Count()) / this.resistorStrips.Count();

            for (int i = 1; i <= this.resistorStrips.Length; i++)
            {
                this.DrawSquare(value * i + startX - this.StripWidth, (this.resistorBitmap.Height / 2) - (this.resistorBaseHeight / 2),
                                this.StripWidth, this.resistorBaseHeight, 
                                this.resistorStrips[i - 1].GetColor());
            }
        }
        private int GetStripIndexAtPos(Point point)
        {
            float valX = (float)resistorBitmap.Width / resistorImage.Width;
            float valY = (float)resistorBitmap.Height / resistorImage.Height;

            Point posInBitmap = new Point((int)(valX * point.X), (int)(valY * point.Y));

            int startX = (resistorBitmap.Width / 2) - (this.resistorBaseWidth / 2);

            int value = (this.resistorBaseWidth - this.StripWidth * this.resistorStrips.Count()) / this.resistorStrips.Count();

            for (int i = 1; i <= this.resistorStrips.Length; i++)
            {
                bool xIn = ((value * i + startX - this.StripWidth) < posInBitmap.X) &&
                           (((value * i + startX - this.StripWidth) + this.StripWidth) > posInBitmap.X);

                bool yIn = ((this.resistorBitmap.Height / 2) - (this.resistorBaseHeight / 2) < posInBitmap.Y) &&
                           (((this.resistorBitmap.Height / 2) - (this.resistorBaseHeight / 2) + this.resistorBaseHeight) > posInBitmap.Y);

                if (xIn && yIn)
                    return i - 1;
            }

            return -1;
        }

        private void resistorImage_MouseClick(object sender, MouseEventArgs e)
        {
            List<ResistorColor> resistorColors = new List<ResistorColor>();
            int stripIndex = GetStripIndexAtPos(e.Location);

            this.selectedStripIndex = stripIndex;

            if (stripIndex == -1)
            {
                this.colorsComboBox.DataSource = null;
                return;
            }


            if (this.resistorStrips.Length - 1 != stripIndex)
                resistorColors.AddRange(this.resistorBaseColors);
            resistorColors.AddRange(this.resistorToleranceColors);

            this.colorsComboBox.SelectedIndexChanged -= this.colorsComboBox_SelectedIndexChanged;
            this.colorsComboBox.DataSource = resistorColors;

            this.colorsComboBox.SelectedItem = this.resistorStrips[stripIndex].StripColor;
            this.colorsComboBox.SelectedIndexChanged += this.colorsComboBox_SelectedIndexChanged;
        }

        private void ResistorControl_Load(object sender, EventArgs e)
        {
        }


        private void colorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.selectedStripIndex != -1)
            {
                this.resistorStrips[this.selectedStripIndex].StripColor = (ResistorColor)this.colorsComboBox.SelectedItem;
                this.DrawStrips();
            }
        }

        private void resistanceTextBox_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(resistanceTextBox.Text))
            {
                return;
            }

            ResistorColor[] colors = CalculateResistor.ResistanceToColors(Convert.ToDouble(resistanceTextBox.Text), 5, 4);

            for (int i = 0; i < this.resistorStrips.Count(); i++)
            {
                this.resistorStrips[i].StripColor = colors[i];
            }

            if(selectedStripIndex != -1)
                this.colorsComboBox.SelectedItem = this.resistorStrips[selectedStripIndex].StripColor;

            this.DrawStrips();

        }
    }
}
