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
        //Colors
        private Color ResistorPinColor = Color.FromArgb(255, 98, 97, 95);
        private Color ResisotorBackColor = Color.FromArgb(255, 234, 182, 118);


        //Settings Sizes
        private int resistorPinWidth = 511;
        private int resistorPinHeight = 20;
        private int resistorBaseWidth = 260;
        private int resistorBaseHeight = 150;
        private int StripWidth = 10;


        private ResistorStrip[] resistorStrips;
        private Bitmap resistorBitmap;

        public ResistorControl()
        {
            InitializeComponent();
            resistorBitmap = new Bitmap(512,256);
            this.DrawResistor();
            //this.DrawStrips();
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


        private void ResistorControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
