using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilites.Electronic.Resistor
{
    public class ResistorStrip
    {
        public ResistorStrip(ResistorColor stripColor)
        {
            StripColor = stripColor;
        }

        public ResistorColor StripColor { get; set; }

        public Color GetColor()
        {
            switch(this.StripColor)
            {
                case ResistorColor.Black: return Color.Black; break;
                case ResistorColor.Brown: return Color.SaddleBrown; break;
                case ResistorColor.Red: return Color.Red; break;
                case ResistorColor.Orange: return Color.Orange; break;
                case ResistorColor.Yellow: return Color.Yellow; break;
                case ResistorColor.Green: return Color.Green; break;
                case ResistorColor.Blue: return Color.Blue; break;
                case ResistorColor.Purple: return Color.Purple; break;
                case ResistorColor.Grey: return Color.Yellow; break;
                case ResistorColor.White: return Color.Green; break;
                case ResistorColor.Gold: return Color.Gold; break;
                case ResistorColor.Silver: return Color.Silver; break;
                default: return Color.Transparent; break;
            }
        }
    }
}
